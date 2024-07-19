using CapFrameX.Contracts.Overlay;
using System.Collections.Generic;

namespace CapFrameX.Overlay
{
    public static class OverlayUtils
    {
        public static List<OverlayEntryWrapper> GetOverlayEntryDefaults()
        {
            return new List<OverlayEntryWrapper>
                {
					// CX 
					// CaptureServiceStatus
					new OverlayEntryWrapper("CaptureServiceStatus")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = true,
                        ShowOnOverlayIsEnabled = true,
                        Description = "捕获服务状态",
                        GroupName = "Status:",
                        Value = "捕获服务就绪...",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

					// CaptureTimer
					new OverlayEntryWrapper("CaptureTimer")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = true,
                        ShowOnOverlayIsEnabled = true,
                        Description = "捕获计时器",
                        GroupName = "Status:",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

					// System time
                    new OverlayEntryWrapper("SystemTime")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "系统时间",
                        GroupName = "Time",
                        Value = "Time",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

					// RunHistory
					new OverlayEntryWrapper("RunHistory")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "运行历史",
                        GroupName = string.Empty,
                        Value = default,
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

                    // CX CPU usage
					new OverlayEntryWrapper("CxAppCpuUsage")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "CapFrameX CPU占用 (%)",
                        GroupName = "CX CPU",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

					// RTSS
					// Framerate
					new OverlayEntryWrapper("Framerate")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = true,
                        ShowOnOverlayIsEnabled = true,
                        Description = "帧率",
                        GroupName = "<APP>",
                        Value = 0d,
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = true,
                        Color = string.Empty
                    },

					// Frametime
					new OverlayEntryWrapper("Frametime")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = true,
                        ShowOnOverlayIsEnabled = true,
                        Description = "帧生成时间",
                        GroupName = "<APP>",
                        Value = 0d,
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = true,
                        Color = string.Empty
                    },

                    // Custom CPU
					new OverlayEntryWrapper("CustomCPU")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "自定义CPU名称",
                        GroupName = "CPU Info",
                        Value = "CPU",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

                    // Custom GPU
					new OverlayEntryWrapper("CustomGPU")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "自定义显卡名称",
                        GroupName = "GPU Info",
                        Value = "GPU",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

                    // Custom Mainboard
					new OverlayEntryWrapper("Mainboard")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "主板名称",
                        GroupName = "MB Info",
                        Value = "Mainboard",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

                    // Custom RAM
					new OverlayEntryWrapper("CustomRAM")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "自定义内存描述",
                        GroupName = "RAM Info",
                        Value = "RAM",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

                    // OS
					new OverlayEntryWrapper("OS")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "系统版本",
                        GroupName = "OS",
                        Value = "OS",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

                    new OverlayEntryWrapper("GPUDriver")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "显卡软件驱动",
                        GroupName = "GPU Driver",
                        Value = "Not available",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

                    // Online metrics
                    // Average
                    new OverlayEntryWrapper("OnlineAverage")
                    {
                        OverlayEntryType = EOverlayEntryType.OnlineMetric,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "实时平均FPS",
                        GroupName = "Average",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

                    // P1
                    new OverlayEntryWrapper("OnlineP1")
                    {
                        OverlayEntryType = EOverlayEntryType.OnlineMetric,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "实时 P1 FPS",
                        GroupName = "P1%",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

                    // P0.2
                    new OverlayEntryWrapper("OnlineP0dot2")
                    {
                        OverlayEntryType = EOverlayEntryType.OnlineMetric,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "实时 P0.2 FPS",
                        GroupName = "P0.2%",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

                    // 1% Low
                    new OverlayEntryWrapper("Online1PercentLow")
					{
						OverlayEntryType = EOverlayEntryType.OnlineMetric,
						ShowOnOverlay = false,
						ShowOnOverlayIsEnabled = true,
						Description = "实时 1% Low FPS",
						GroupName = "1% Low",
						Value = "0",
						ValueFormat = default,
						ShowGraph = false,
						ShowGraphIsEnabled = false,
						Color = string.Empty
					},

                    // 0.2% Low
                    new OverlayEntryWrapper("Online0dot2PercentLow")
					{
						OverlayEntryType = EOverlayEntryType.OnlineMetric,
						ShowOnOverlay = false,
						ShowOnOverlayIsEnabled = true,
						Description = "实时 0.2% Low FPS",
						GroupName = "0.2% Low",
						Value = "0",
						ValueFormat = default,
						ShowGraph = false,
						ShowGraphIsEnabled = false,
						Color = string.Empty
					},

                    // GPU Active Time Average
                    new OverlayEntryWrapper("OnlineGpuActiveTimeAverage")
					{
						OverlayEntryType = EOverlayEntryType.OnlineMetric,
						ShowOnOverlay = false,
						ShowOnOverlayIsEnabled = true,
						Description = "显卡平均忙碌时间 (ms)",
						GroupName = "GPUBusy Avg",
						Value = "0",
						ValueFormat = default,
						ShowGraph = false,
						ShowGraphIsEnabled = false,
						Color = string.Empty
					},

                    // Frame Time Average
                    new OverlayEntryWrapper("OnlineFrameTimeAverage")
					{
						OverlayEntryType = EOverlayEntryType.OnlineMetric,
						ShowOnOverlay = false,
						ShowOnOverlayIsEnabled = true,
						Description = "平均帧生成时间 (ms)",
						GroupName = "Frametime Avg",
						Value = "0",
						ValueFormat = default,
						ShowGraph = false,
						ShowGraphIsEnabled = false,
						Color = string.Empty
					},

                    // GPU Active Time Deviation
                    new OverlayEntryWrapper("OnlineGpuActiveTimePercentageDeviation")
					{
						OverlayEntryType = EOverlayEntryType.OnlineMetric,
						ShowOnOverlay = false,
						ShowOnOverlayIsEnabled = true,
						Description = "GPU Active Time Deviation (%)",
						GroupName = "GPUBusy Deviation",
						Value = "0",
						ValueFormat = default,
						ShowGraph = false,
						ShowGraphIsEnabled = false,
						Color = string.Empty
					},

                    // Render lag
                    new OverlayEntryWrapper("OnlineApplicationLatency")
                    {
                        OverlayEntryType = EOverlayEntryType.OnlineMetric,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "应用延迟 (ms)",
                        GroupName = "App Latency",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

                    // Stuttering percentage
                    new OverlayEntryWrapper("OnlineStutteringPercentage")
                    {
                        OverlayEntryType = EOverlayEntryType.OnlineMetric,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "卡顿时间 (%)",
                        GroupName = "Stuttering",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },

                    // PMD
                    new OverlayEntryWrapper("PmdGpuPowerCurrent")
                    {
                        OverlayEntryType = EOverlayEntryType.OnlineMetric,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "PMD 显卡功耗 (W)",
                        GroupName = "PMD GPU Power",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },
                    new OverlayEntryWrapper("PmdCpuPowerCurrent")
                    {
                        OverlayEntryType = EOverlayEntryType.OnlineMetric,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "PMD CPU功耗 (W)",
                        GroupName = "PMD CPU Power",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },
                    new OverlayEntryWrapper("PmdSystemPowerCurrent")
                    {
                        OverlayEntryType = EOverlayEntryType.OnlineMetric,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "PMD 系统功耗 (W)",
                        GroupName = "PMD Sys Power",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },
                     new OverlayEntryWrapper("BatteryLifePercent")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "电池 (%)",
                        GroupName = "Battery Life",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },
                    new OverlayEntryWrapper("BatteryLifeRemaining")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "电池剩余时间 (min)",
                        GroupName = "Battery Life",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },
                    new OverlayEntryWrapper("Ping")
                    {
                        OverlayEntryType = EOverlayEntryType.CX,
                        ShowOnOverlay = false,
                        ShowOnOverlayIsEnabled = true,
                        Description = "网络延迟",
                        GroupName = "Ping",
                        Value = "0",
                        ValueFormat = default,
                        ShowGraph = false,
                        ShowGraphIsEnabled = false,
                        Color = string.Empty
                    },
					new OverlayEntryWrapper("ThreadAffinityState")
					{
						OverlayEntryType = EOverlayEntryType.CX,
						ShowOnOverlay = false,
						ShowOnOverlayIsEnabled = true,
						Description = "Thread Affinity State",
						GroupName = "Thread Affinity",
						Value = "Default",
						ValueFormat = default,
						ShowGraph = false,
						ShowGraphIsEnabled = false,
						Color = string.Empty
					},
                    //new OverlayEntryWrapper("PCLatency")
                    //{
                    //    OverlayEntryType = EOverlayEntryType.CX,
                    //    ShowOnOverlay = false,
                    //    ShowOnOverlayIsEnabled = true,
                    //    Description = "FrameView PC Latency",
                    //    GroupName = "PC Latency",
                    //    Value = "0",
                    //    ValueFormat = default,
                    //    ShowGraph = false,
                    //    ShowGraphIsEnabled = false,
                    //    Color = string.Empty
                    //}
            };
        }
    }
}
