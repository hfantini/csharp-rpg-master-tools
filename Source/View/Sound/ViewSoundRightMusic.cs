﻿
/*

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
    |	Name: [ViewSoundRightMusic.cs]
    |	Type: [VIEW
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
using RPGMasterTools.Source.Controller;
using RPGMasterTools.Source.Controller.Sound;
using RPGMasterTools.Source.Model.Sound;
using RPGMasterTools.Source.Util;

// == NAMESPACE
// ==================================================================

namespace RPGMasterTools.Source.View.Sound
{
    // == CLASS
    // ==============================================================

    public partial class ViewSoundRightMusic : UserControl, RPGMasterTools.Source.Interface.IComponent<EnumStateSoundRightMusic>
    {
        // -- CONST -----------------------------------------------------

        // -- VAR -------------------------------------------------------

        private ViewSoundRightMusicPlayer _viewMusicPlayer;
        private SoundRightMusicController _controller = null;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public ViewSoundRightMusic()
        {
            InitializeComponent();
        }

        public ViewSoundRightMusic(GenericController parentController)
        {
            InitializeComponent();
            Disposed += onDispose;

            // CONFIGURE CONTROLLER

            this._controller = new SoundRightMusicController(this, parentController);

            // CREATE COMPONENTS
            this._viewMusicPlayer = new ViewSoundRightMusicPlayer(this._controller);

            // CONFIGURE COMPONENTS
            this._viewMusicPlayer.Dock = DockStyle.Fill;
            pnlBottom.Controls.Add(this._viewMusicPlayer);
        }

        // == METHODS
        // ==============================================================

        public void update(EnumStateSoundRightMusic lastState, EnumStateSoundRightMusic currentState)
        {
            if (currentState == EnumStateSoundRightMusic.STATE_UPDATE_LIST_ADD)
            {
                updateMusicList();
            }
            else if (currentState == EnumStateSoundRightMusic.STATE_UPDATE_LIST_RECREATE)
            {
                recreateMusicList();
            }
            else if (currentState == EnumStateSoundRightMusic.STATE_PRESET_LOADED)
            {
                recreateMusicList();
            }
            else if (currentState == EnumStateSoundRightMusic.STATE_PLAY)
            {
                // UPDATE LAST NAMEPLATE
                if (this._controller.lastMusicIndex != -1)
                {
                    ViewSoundRightMusicPlate lastNamePlate = (ViewSoundRightMusicPlate) fLayItems.Controls[this._controller.lastMusicIndex];
                    lastNamePlate.setState(EnumStateSoundRightMusicPlate.STATE_STOPPED);
                }
            }
            else if (currentState == EnumStateSoundRightMusic.STATE_PLAYING)
            {
                if (this._controller.currentMusicIndex != -1)
                {
                    // UPDATE CURRRENT NAMEPLATE
                    ViewSoundRightMusicPlate currentNamePlate = (ViewSoundRightMusicPlate)fLayItems.Controls[this._controller.currentMusicIndex];
                    currentNamePlate.setState(EnumStateSoundRightMusicPlate.STATE_PLAYING);
                }
            }
            else if (currentState == EnumStateSoundRightMusic.STATE_STOP)
            {
                if (this._controller.currentMusicIndex != -1)
                {
                    // UPDATE CURRRENT NAMEPLATE
                    ViewSoundRightMusicPlate currentNamePlate = (ViewSoundRightMusicPlate)fLayItems.Controls[this._controller.currentMusicIndex];
                    currentNamePlate.setState(EnumStateSoundRightMusicPlate.STATE_STOPPED);
                }
            }
            else if (currentState == EnumStateSoundRightMusic.STATE_PAUSED)
            {
                if (this._controller.currentMusicIndex != -1)
                {
                    // UPDATE CURRRENT NAMEPLATE
                    ViewSoundRightMusicPlate currentNamePlate = (ViewSoundRightMusicPlate)fLayItems.Controls[this._controller.currentMusicIndex];
                    currentNamePlate.setState(EnumStateSoundRightMusicPlate.STATE_PAUSED);
                }
            }
        }

        private void updateMusicList()
        {
            SoundController controller = ( (SoundController) this._controller.parentController.parentController);
            List<Music> lastChangeList = controller.musicLastChange;

            for(int count = 0; count < lastChangeList.Count; count++)
            {
                Music music = lastChangeList[count];

                ViewSoundRightMusicPlate mPlate = new ViewSoundRightMusicPlate(this._controller, music);
                mPlate.Width = fLayItems.Width;

                fLayItems.Controls.Add(mPlate);
            }

            lastChangeList.Clear();
        }

        private void recreateMusicList()
        {
            UComponent.removeAllChildren(fLayItems);

            SoundController controller = ((SoundController)this._controller.parentController.parentController);
            List<Music> musicList = controller.musicPlaylist;

            for (int count = 0; count < musicList.Count; count++)
            {
                Music music = musicList[count];

                ViewSoundRightMusicPlate mPlate = new ViewSoundRightMusicPlate(this._controller, music);
                mPlate.Width = fLayItems.Width;

                fLayItems.Controls.Add(mPlate);
            }
        }

        private void ViewSoundRightMusic_Load(object sender, EventArgs e)
        {
            this._controller.currentState = EnumStateSoundRightMusic.STATE_IDLE;
        }

        // == EVENTS
        // ==============================================================

        public void onDispose(object sender, EventArgs args)
        {
            this._controller.Dispose();
            this._controller = null;
        }

        // == GETTERS AND SETTERS
        // ==============================================================
    }
}
