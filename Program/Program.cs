using System;
using System.Windows.Forms;
using UI;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new AmpUI());
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }
    }
}
