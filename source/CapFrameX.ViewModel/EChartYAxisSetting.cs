using System.ComponentModel;

namespace CapFrameX.ViewModel
{
	public enum EChartYAxisSetting
	{
		[Description("占满")]
		FullFit = 1,
		[Description("四分位距")]
		IQR = 2,
		[Description("0-10ms")]
		Zero_Ten = 3,
		[Description("0-20ms")]
		Zero_Twenty = 4,
		[Description("0-30ms")]
		Zero_Thirty = 5,
		[Description("0-40ms")]
		Zero_Forty = 6,
		[Description("0-60ms")]
		Zero_Sixty = 7,
		[Description("0-80ms")]
		Zero_Eighty = 8,
		[Description("0-100ms")]
		Zero_Hundred = 9
	}
}
