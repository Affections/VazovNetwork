﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VazovNetwork
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());

            Login fLogin = new Login();

            if(fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new VazovNetwork());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
