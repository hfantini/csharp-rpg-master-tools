﻿/*

    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +
    |
    |	RPGMasterTools
    |
    |	A multitool software for D&D game masters.
    |	
    |	== INFO ==
    |
    |	By Henrique Fantini @ 2019
    |	www.henriquefantini.com
    |	contact@henriquefantini.com
    |
    |	== FILE DETAILS 
    |
    |	Name: [FrmMain.cs]
    |	Type: [Form]
    |	Author: Henrique Fantini
    |	
    |	Description: Main form of the program.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.View.Sound;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View
{
    // == CLASS
    // ==============================================================

    public partial class ViewMain : Form, IView<EnumStateMain>
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private MainController _controller;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewMain()
        {
            InitializeComponent();

            // == FORM CONFIGURATION

            this.WindowState = FormWindowState.Maximized;

            this._controller = new MainController(this);
            UFormUtil.applyLanguageToForm(this);
            UFormUtil.applyLanguageToMenu(mnuMain);
            UFormUtil.applyLanguageToTabPanel(tpnlMain);

            // == ADDING ANOTHER COMPONENTS
            tabSound.Controls.Add( new ViewSound(this._controller) );
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateMain lastState, EnumStateMain currentState)
        {

        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public void getController()
        {
            throw new NotImplementedException();
        }
    }
}
