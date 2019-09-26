namespace MiTutor.Util
{
	public class ConsolePrinter
	{
		public string Message { get; set; }

		public ConsolePrinter()
		{
			Message = "";
		}

		public void PrintMessage()
		{
			Message = $"\n/********** BEGIN **********/\n" + Message + $"\n\n/********** END **********/\n";
			System.Console.WriteLine(Message);
			Message = "";
		}

		public void AddLine(object line)
		{
			Message += $"\n{line}";
		}
	}
}