﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PacMan.GameGL
{
    public class Game
    {
        public static GameObject getBlankGameObject(){
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, PacManGUI.Properties.Resources.simplebox);
            return blankGameObject;
        }
        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = PacManGUI.Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = PacManGUI.Properties.Resources.vertical;
            }

            if (displayCharacter == '#')
            {
                img = PacManGUI.Properties.Resources.horizontal;
            }

            if (displayCharacter == '.')
            {
                img = PacManGUI.Properties.Resources.pallet;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p') {
                img = PacManGUI.Properties.Resources.pacman_open;
            }
            if (displayCharacter == 'H' || displayCharacter == 'h')
            {
                img = PacManGUI.Properties.Resources.ghost_orange;
            }
            if (displayCharacter == 'V' || displayCharacter == 'v')
            {
                img = PacManGUI.Properties.Resources.ghost_pink;
            }
            if (displayCharacter == 'R' || displayCharacter == 'r')
            {
                img = PacManGUI.Properties.Resources.ghost_fright;
            }
            if (displayCharacter == 'C' || displayCharacter == 'c')
            {
                img = PacManGUI.Properties.Resources.ghost_red;
            }
            return img;
        }
    }
}
