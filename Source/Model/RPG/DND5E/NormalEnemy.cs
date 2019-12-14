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
    |	Name: [NormalEnemy.cs]
    |	Type: [MODEL]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines a normal enemy class.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Model.RPG.DND5E
{
    // == CLASS
    // ==============================================================

    public abstract class NormalEnemy : Enemy
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        public NormalEnemy(string name) : base(name)
        {
            
        }

        // == METHODS
        // ==============================================================

        public override Bitmap getIcon()
        {
            return RPGMasterTools.Properties.Resources.ico_class_enemy;
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}