using System.ComponentModel;

namespace CapFrameX.Sensor.Reporting
{
	public enum EReportSensorName
	{
		[Description("CPU负载 (%)")]
		CpuUsage,
		[Description("CPU最大线程负载 (%)")]
		CpuMaxThreadUsage,
		[Description("CPU最大频率 (MHz)")]
		CpuMaxClock,
		[Description("CPU功耗 (W)")]
		CpuPower,
		[Description("CPU温度 (°C)")]
		CpuTemp,
		[Description("显卡占用 (%)")]
		GpuUsage,
		[Description("显卡满载时间 (%)")]
		GpuLoadLimit,
		[Description("显卡频率 (MHz)")]
		GpuClock,
		[Description("显卡功耗 (W)")]
		GpuPower,
		[Description("GPU TBP Sim (W)")]
		GpuTBPSim,
		[Description("显卡温度 (°C)")]
		GpuTemp,
		[Description("显存占用 (MB)")]
		VRamUsage,
		[Description("显存占用 (GB)")]
		VRamUsageGB,
		[Description("内存占用 (GB)")]
		RamUsage,
	}
}
