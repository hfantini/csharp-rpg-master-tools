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
    |	Name: [Rogue.cs]
    |	Type: [MODEL]
    |	Author: Henrique Fantini
    |	
    |	Description: Rogue class definition.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/

// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.RPG.DND5E;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Model.RPG.DND5E
{
    public class Rogue : PClass
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        // == CONSTRUCTOR(S)
        // ==============================================================

        public Rogue() : base()
        {
            this._clazz = EnumCharacterClass.ROGUE;
            this._lifeDice = EnumDice.D8;
            this._mainStat = EnumCharacterStat.DEXTERITY;
            this._saveStats = new List<EnumCharacterStat>() { EnumCharacterStat.DEXTERITY, EnumCharacterStat.INTELLIGENCE };
        }

        // == METHODS
        // ==============================================================

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
