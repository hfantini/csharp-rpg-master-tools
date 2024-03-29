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
    |	Name: [FILENAME]
    |	Type: [TYPE]
    |	Author: Henrique Fantini
    |	
    |	Description:
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
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Controller.Char;
using RPGMasterTools.Source.Model.RPG.DND5E;
using RPGMasterTools.Source.Util;
using RPGMasterTools.Source.Enumeration.RPG.DND5E;
using System.Threading;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Combat
{
    // == CLASS
    // ==============================================================

    public partial class ViewCombatPanelCharacter : UserControl, IComponent<EnumStateCombatPanelCharacter>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private CombatPanelCharacterController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewCombatPanelCharacter()
        {
            InitializeComponent();
        }

        public ViewCombatPanelCharacter(GenericController parentController, Model.RPG.CombatCharacter combatCharacter)
        {
            InitializeComponent();

            // INIT VALUES

            // CONFIG CONTROLER
            this._controller = new CombatPanelCharacterController(this, parentController, combatCharacter);

            // CONFIG COMPONENTS

            lblName.Text = combatCharacter.character.name;
            lblStatus.Text = URPG.getCharacterStateString(combatCharacter.character);

            if(combatCharacter.character is Player)
            {
                pBoxIcon.Image = URPG.getClassIcon( ( (Player) combatCharacter.character ).pClass);
            }
            else
            {
                pBoxIcon.Image = RPGMasterTools.Properties.Resources.ico_class_boss;
            }
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateCombatPanelCharacter lastState, EnumStateCombatPanelCharacter currentState)
        {
            Model.RPG.Combat combat = ((CombatController)this._controller.parentController.parentController).selectedCombat;

            if (currentState == EnumStateCombatPanelCharacter.STATE_UPDATE)
            {
                lblStatus.Text = URPG.getCharacterStateString(this._controller.combatCharacter.character);

                if (combat.combatState == Enumeration.RPG.CombatState.PREPARATION)
                {
                    if (this._controller.combatCharacter.initiative != -1)
                    {
                        txtInitiative.Text = this._controller.combatCharacter.initiative.ToString();
                    }

                    txtInitiative.Enabled = true;
                    txtLife.Enabled = true;
                    txtLifeMax.Enabled = true;
                    btnDamage.Enabled = false;
                    btnHeal.Enabled = false;
                    btnCharEffect.Enabled = false;
                    btnDeath.Enabled = false;
                }
                else if (combat.combatState == Enumeration.RPG.CombatState.FIGHT)
                {
                    txtInitiative.Enabled = false;
                    txtLife.Enabled = false;
                    txtLifeMax.Enabled = false;

                    txtInitiative.Text = this._controller.combatCharacter.initiative.ToString();
                    txtLife.Text = this._controller.combatCharacter.character.lifePoints.ToString();
                    txtLifeMax.Text = this._controller.combatCharacter.character.maxLifePoints.ToString();

                    if (combat.getCurrentPlay() == this._controller.combatCharacter)
                    {
                        pBoxIndicator.Image = RPGMasterTools.Properties.Resources.ico_play;
                        tblMain.BackColor = Color.OrangeRed;
                    }
                    else
                    {
                        pBoxIndicator.Image = RPGMasterTools.Properties.Resources.ico_stop;
                        tblMain.BackColor = SystemColors.ScrollBar;
                    }

                    // BASED ON CURRENT CHARACTER STATE

                    if (controller.combatCharacter.character.currentState == EnumCharacterState.STATE_COMBAT || controller.combatCharacter.character.currentState == EnumCharacterState.STATE_FALLEN)
                    {
                        // CHANGE STYLE OF DEATH BUTTON

                        if (controller.combatCharacter.character.currentState == EnumCharacterState.STATE_COMBAT)
                        {
                            btnDamage.Enabled = true;
                            btnHeal.Enabled = true;
                            btnCharEffect.Enabled = false;
                            btnDeath.Enabled = false;
                        }
                        else if (controller.combatCharacter.character.currentState == EnumCharacterState.STATE_FALLEN)
                        {
                            btnDamage.Enabled = false;
                            btnHeal.Enabled = true;
                            btnCharEffect.Enabled = false;
                            btnDeath.Enabled = true;
                        }
                    }
                    else if (controller.combatCharacter.character.currentState == EnumCharacterState.STATE_DEAD)
                    {
                        // CONVERT DEATH BUTTON TO RESURRECTION BUTTON

                        btnDamage.Enabled = false;
                        btnHeal.Enabled = false;
                        btnCharEffect.Enabled = false;
                        btnDeath.Enabled = true;
                    }

                }
            }
            else if(currentState == EnumStateCombatPanelCharacter.STATE_ROLL_RANDOM_INITIATIVE)
            {
                int value = URPG.roll(EnumDice.D20);
                txtInitiative.Text = value.ToString();

                Thread.Sleep(30);
            }
        }

        // == EVENTS
        // ==============================================================

        private void ViewCombatPanelCharacter_Load(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatPanelCharacter.STATE_UPDATE;
        }

        private void txtInitiative_TextChanged(object sender, EventArgs e)
        {
            String text = txtInitiative.Text;

            if (text != "")
            {
                if (!text.All(Char.IsDigit))
                {
                    txtInitiative.Text = "";
                }
                else
                {
                    int value = Convert.ToInt32(text);

                    if (value < 1 || value > 20)
                    {
                        txtInitiative.Text = "";
                    }
                }
            }
        }

        private void txtLife_TextChanged(object sender, EventArgs e)
        {
            String text = txtLife.Text;

            if (text != "")
            {
                if (!text.All(Char.IsDigit))
                {
                    txtLife.Text = "";
                }
            }
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatPanelCharacter.STATE_APPLY_DAMAGE;
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateCombatPanelCharacter.STATE_APPLY_HEAL;
        }

        private void btnDeath_Click(object sender, EventArgs e)
        {
            if (this._controller.combatCharacter.character.currentState == EnumCharacterState.STATE_FALLEN)
            {
                this._controller.currentState = EnumStateCombatPanelCharacter.STATE_APPLY_DEATH;
            }
            else if (this._controller.combatCharacter.character.currentState == EnumCharacterState.STATE_DEAD)
            {
                this._controller.currentState = EnumStateCombatPanelCharacter.STATE_APPLY_RESS;
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public CombatPanelCharacterController controller
        {
            get { return this._controller; }
        }

        public int initiative
        {
            get { return Convert.ToInt32(this.txtInitiative.Text); }
        }

        public int life
        {
            get
            {
                int retValue = -1;

                if(this.txtLife.Text != "" && this.txtLife.Text.All(Char.IsDigit) )
                {
                    retValue = Convert.ToInt32(this.txtLife.Text);
                }

                return retValue;
            }
        }

        public int maxLife
        {
            get
            {
                int retValue = -1;

                if (this.txtLifeMax.Text != "" && this.txtLifeMax.Text.All(Char.IsDigit))
                {
                    retValue = Convert.ToInt32(this.txtLifeMax.Text);
                }

                return retValue;
            }
        }
    }
}
