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
    |	Name: [SoundRightAmbienceController]
    |	Type: [CONTROLLER]
    |	Author: Henrique Fantini
    |	
    |	Description:
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/


// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.State;
using RPGMasterTools.Source.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.Controller.Sound
{
    // == CLASS
    // ==============================================================

    public class SoundRightAmbienceController : ComponentController<EnumStateSoundRightAmbience>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private int _masterVolume = 100;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public SoundRightAmbienceController(IComponent<EnumStateSoundRightAmbience> component, GenericController parentController) : base(component, parentController)
        {

        }

        // == METHODS
        // ==============================================================

        protected override void update()
        {
            base.update();

            this.currentState = EnumStateSoundRightAmbience.STATE_IDLE;
        }

        // == EVENTS
        // ==============================================================

        protected override void onParentStateChange(GenericController parentController)
        {
            if (parentController is SoundController)
            {
                SoundController controller = (SoundController)parentController;

                if(controller.currentState == EnumStateSound.STATE_AMBIENCE_LIST_ADDED)
                {
                    this.currentState = EnumStateSoundRightAmbience.STATE_UPDATE_LIST_ADD;
                }
                if (controller.currentState == EnumStateSound.STATE_AMBIENCE_LIST_REMOVED)
                {
                    this.currentState = EnumStateSoundRightAmbience.STATE_UPDATE_LIST_RECREATE;
                }
                else
                {
                    base.onParentStateChange(parentController);
                }
            }
            else
            {
                base.onParentStateChange(parentController);
            }
        }

        // == GETTERS AND SETTERS
        // ==============================================================

        public int masterVolume
        {
            get { return this._masterVolume; }
            set { this._masterVolume = value; }
        }
    }
}