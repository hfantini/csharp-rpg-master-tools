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
    |	Name: [ViewSound.cs]
    |	Type: [COMPONENT]
    |	Author: Henrique Fantini
    |	
    |	Description: Sound component.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Controller.Sound;
using RPGMasterTools.Source.Controller;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSound : UserControl, IComponent<EnumStateSound>
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------
        private SoundController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSound( GenericController parentController )
        {
            InitializeComponent();

            this._controller = new SoundController(this, parentController);
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateSound lastState, EnumStateSound currentState)
        {
            if(currentState == EnumStateSound.STATE_START)
            {
                label1.Text = "IHIHIHIHI";
            }
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

    }
}