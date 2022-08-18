2022-06-13T21:01:36.5681920+08:00[ThreadId:0000000001]		Debug		SetSelfStartingHelper.SetSelfStartByRegistryKey(False, "PRemoteM")

2022-06-13T21:01:37.0844933+08:00[ThreadId:0000000001]		Debug		Launcher resize:  w = 400, h = 46

2022-06-13T21:01:37.2325081+08:00[ThreadId:0000000001]		Debug		Call HideMe()

2022-06-13T21:01:37.4893983+08:00[ThreadId:0000000001]		Debug		Call HideMe()

2022-06-13T21:01:37.5371875+08:00[ThreadId:0000000001]		Debug		Launcher resize:  w = 400, h = 86

2022-06-13T21:01:47.0582807+08:00[ThreadId:0000000004]		Debug		Check update.

2022-06-13T21:01:52.1565242+08:00[ThreadId:0000000004]		Warning		System.Net.WebException: 操作超时
   在 System.Net.HttpWebRequest.GetResponse()
   在 Shawn.Utils.HttpHelper.Get(String url, Encoding encoding) 位置 D:\DemoProject\PRemoteM\PRM.Core\Utils\HttpHelper.cs:行号 106
   在 Shawn.Utils.VersionHelper.CheckUpdateFromUrl(String url, Version ignoreVersion, String urlContent) 位置 D:\DemoProject\PRemoteM\PRM.Core\Utils\VersionHelper.cs:行号 227
   在 System.Net.HttpWebRequest.GetResponse()
   在 Shawn.Utils.HttpHelper.Get(String url, Encoding encoding) 位置 D:\DemoProject\PRemoteM\PRM.Core\Utils\HttpHelper.cs:行号 106
   在 Shawn.Utils.VersionHelper.CheckUpdateFromUrl(String url, Version ignoreVersion, String urlContent) 位置 D:\DemoProject\PRemoteM\PRM.Core\Utils\VersionHelper.cs:行号 227

