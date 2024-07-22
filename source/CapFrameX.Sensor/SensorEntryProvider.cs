using CapFrameX.Contracts.Sensor;
using CapFrameX.Extensions;
using CapFrameX.Monitoring.Contracts;
using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapFrameX.Sensor
{
    public class SensorEntryProvider : ISensorEntryProvider
    {
        private readonly ISensorService _sensorService;
        private readonly ISensorConfig _sensorConfig;

        public Action ConfigChanged { get; set; }

        public SensorEntryProvider(ISensorService sensorService,
            ISensorConfig sensorConfig)
        {
            _sensorService = sensorService;
            _sensorConfig = sensorConfig;
        }

        public async Task<IEnumerable<ISensorEntry>> GetWrappedSensorEntries()
        {
            var sensorEntries = await _sensorService.GetSensorEntries();
            var wrappedEntries = sensorEntries.Select(WrapSensorEntry);

            if (!_sensorConfig.HasConfigFile
              // reset config when hardware has changed
              || _sensorConfig.SensorEntryCount != sensorEntries.Count())
            {
                var backupSensorConfig = _sensorConfig.GetSensorConfigCopy();
                _sensorConfig.ResetConfig();
                wrappedEntries.ForEach(entry => SetIsActiveDefault(entry, backupSensorConfig));
                await SaveSensorConfig();
            }

            return wrappedEntries;
        }

        public async Task SaveSensorConfig()
        {
            await _sensorConfig.Save();
        }

        private SensorEntryWrapper WrapSensorEntry(ISensorEntry entry)
        {
            return new SensorEntryWrapper()
            {
                Identifier = entry.Identifier,
                Name = entry.Name,
                SensorType = entry.SensorType,
                HardwareType = entry.HardwareType,
                UseForLogging = _sensorConfig.GetSensorIsActive(entry.Identifier),
                UpdateLogState = UpdateLogState
            };
        }

        private void UpdateLogState(string identifier, bool useForLogging)
        {
            ConfigChanged?.Invoke();
            _sensorConfig.SetSensorIsActive(identifier, useForLogging);
        }

        private void SetIsActiveDefault(ISensorEntry sensor, Dictionary<string, bool> configCopy)
        {
            var oldConfigStatus = configCopy.ContainsKey(sensor.Identifier) && configCopy[sensor.Identifier];
            _sensorConfig.SetSensorIsActive(sensor.Identifier, oldConfigStatus || GetIsDefaultActiveSensor(sensor));
        }

        public bool GetIsDefaultActiveSensor(ISensorEntry sensor)
        {
            Enum.TryParse(sensor.HardwareType, out HardwareType hardwareType);
            Enum.TryParse(sensor.SensorType, out SensorType sensorType);

            bool isDefault = false;

            switch (sensor.Name)
            {
                case "CPU占用" when hardwareType == HardwareType.CPU:
                case "CPU最高占用" when hardwareType == HardwareType.CPU:
                case "CPU最高频率" when sensorType == SensorType.Clock:
                case "CPU功耗" when sensorType == SensorType.Power:
                case "CPU温度" when sensorType == SensorType.Temperature:
                case "显卡占用" when sensorType == SensorType.Load:
                case "显卡频率" when sensorType == SensorType.Temperature:
                case "显卡频率" when sensorType == SensorType.Clock:
                case "显卡功耗" when hardwareType == HardwareType.GpuNvidia:
                case "显卡功耗限制" when hardwareType == HardwareType.GpuNvidia:
                case "显卡Total" when hardwareType == HardwareType.GpuAti:
                case "显卡TBP" when hardwareType == HardwareType.GpuAti:
                case "显卡TDP" when hardwareType == HardwareType.GpuIntel:
                case "游戏内存占用" when hardwareType == HardwareType.RAM:
                    isDefault = true;
                    break;
            }

            return isDefault;
        }
    }
}
