using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiTutor.Util
{
	public class DebugPrinter
	{
		public static void BeginMessage()
		{
			System.Diagnostics.Debug.WriteLine("\n/********** BEGIN **********/\n");
		}

		public static void Print(string message)
		{
			System.Diagnostics.Debug.WriteLine(message);
		}

		public static void EndMessage()
		{
			System.Diagnostics.Debug.WriteLine("\n/********** END **********/\n");
		}
	}
}
