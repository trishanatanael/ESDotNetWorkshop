﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESDotNetWorkshop
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
            //Application.Run(new Ex1_1());
            //Application.Run(new Ex1_2());
            Application.Run(new Ex1_3());
            //Application.Run(new Ex1_3Difficult());
            //Application.Run(new DafestyEDMWinform());
            //Application.Run(new EFPractice1Winform());
            //Application.Run(new EFOPDafestyEDMWinform ());
        }
    }
}
