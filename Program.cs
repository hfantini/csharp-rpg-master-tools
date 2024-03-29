﻿using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMasterTools
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            #if (!DEBUG)

                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run( new ViewMain() );
                }
                catch( Exception e )
                {
                    // THROW EXCEPTION TO GLOBAL EXCEPTION HANDLER

                    UExceptionHandler.handleWithException(e);
                }

            #endif

            #if (DEBUG)

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ViewMain());

            #endif
        }
    }
}
