using System;
using System.Diagnostics;

public class Class1
{
	static void Main()
	{
        ProcessStartInfo proc = new ProcessStartInfo("ExitAppcom");
        proc.WindowStyle =  ProcessWindowStyle.Hidden;
        Process.Start(proc);
       
	}
}
