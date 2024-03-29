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
    |	Name: [CombatController.cs]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description: -
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/


// == IMPORTS
// ==================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RPGMasterTools.Source.Enumeration.Exception;
using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using RPGMasterTools.Source.Model.Exception;
using RPGMasterTools.Source.Model.RPG;
using RPGMasterTools.Source.Model.RPG.DND5E;
using RPGMasterTools.Source.Model.Sound;
using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.View;
using RPGMasterTools.Source.View.Combat;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Char
{
    // == CLASS
    // ==============================================================

    public class CombatController : ComponentController<EnumStateCombat>
    {

        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private List<Combat> _combatList = null;
        private Combat _selectedCombat = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public CombatController(IComponent<EnumStateCombat> component, GenericController controller) : base(component, controller)
        {
            this._combatList = new List<Combat>();
        }

        // == METHODS
        // ==============================================================

        protected override bool allowStateChange(EnumStateCombat currentState, EnumStateCombat nextState)
        {
            bool retValue = true;

            return retValue;
        }

        protected override void update()
        {
            if(currentState == EnumStateCombat.STATE_NEW)
            {
                String title = "COMBAT.CRUD.TITLE_NEW";
                ViewCombatCrud cCrud = new ViewCombatCrud(title, this, null);

                ViewDialog dlgNewCombat = new ViewDialog(title, cCrud);
                dlgNewCombat.Size = new Size(750, 500);
                dlgNewCombat.ShowDialog();

                // ON DIALOG CLOSED

                if (cCrud.currentState == EnumStateCombatCrud.STATE_OK)
                {
                    Combat combat = cCrud.currentModel;
                    this._combatList.Add(combat);
                    this.currentState = EnumStateCombat.STATE_UPDATE_LIST;
                }
            }

            base.update();

            if (this.currentState != EnumStateCombat.STATE_IDLE)
            {
                this.currentState = EnumStateCombat.STATE_IDLE;
            }
        }

        // == EVENTS
        // ==============================================================

        // == GETTERS AND SETTERS
        // ==============================================================

        public List<Combat> combatList
        {
            get { return this._combatList; }
        }

        public Combat selectedCombat
        {
            get { return this._selectedCombat; }
            set
            {
                this.currentState = EnumStateCombat.STATE_COMBAT_UNSELECT;
                this._selectedCombat = value;
                this.currentState = EnumStateCombat.STATE_COMBAT_SELECT;
            }
        }
    }
}
