using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zhashenii
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /*Prihlaseni P;
        registrace.Show();*/
        public static Prihlaseni prihlaseni;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Prihlaseni());//Application.Run(new Form1());
            prihlaseni = new Prihlaseni();
            Application.Run(prihlaseni);
        }
    }
}
