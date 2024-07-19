using System;

namespace CapFrameX.Data.Session.Contracts
{
	public interface ISessionSensorData
	{
		[SensorDataExport("时间(s)")]
		double[] MeasureTime { get; set; }
		[SensorDataExport("CPU负载(%)")]
		int[] CpuUsage { get; set; }
		[SensorDataExport("CPU最大线程负载(%)")]
		int[] CpuMaxThreadUsage { get; set; }
		[SensorDataExport("CPU最大频率(MHz)")]
		int[] CpuMaxClock { get; set; }
		[SensorDataExport("CPU功耗(W)")]
		int[] CpuPower { get; set; }
		[SensorDataExport("CPU温度(°C)")]
		int[] CpuTemp { get; set; }
		[SensorDataExport("显卡负载(%)")]
		int[] GpuUsage { get; set; }
		[SensorDataExport("显卡频率 (MHz)")]
		int[] GpuClock { get; set; }
		[SensorDataExport("显卡功耗 (W)")]
		int[] GpuPower { get; set; }
		[SensorDataExport("GPU TBP Sim (W)")]
		int[] GpuTBPSim { get; set; }
		[SensorDataExport("显卡温度(°C)")]
		int[] GpuTemp { get; set; }
		[SensorDataExport("内存占用(GB)")]
		double[] RamUsage { get; set; }
		[SensorDataExport("显存占用(MB)")]
		int[] VRamUsage { get; set; }
		[SensorDataExport("显存占用(GB)")]
		double[] VRamUsageGB { get; set; }
		[SensorDataExport("显卡功耗限制")]
		int[] GPUPowerLimit { get; set; }
		double[] BetweenMeasureTimes { get; set; }
	}

	public class SensorDataExportAttribute: Attribute {
		public string Description;
		public SensorDataExportAttribute(string desc)
		{
			Description = desc;
		}
	}
}