using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace ExitApp
{
    class Program
    {
     
    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    const int SW_HIDE = 5;
    static void Main()
      {
       const int SW_HIDE = 5;
       int n = 0;
       while (true)
         {

          try
            {
             foreach (Process proc in Process.GetProcessesByName("AdobeGCClient"))
             {
                        proc.Kill();
             }
            }

          catch (Exception exception)
          {
                    

          }
       }

    }

       
    
    }
}
