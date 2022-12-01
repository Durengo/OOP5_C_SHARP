using System;
using System.Diagnostics;
using OOP5.source.GUI.Forms;

namespace OOP5
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainScreen());
        }
    }
}
