using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Space_Invaders
{
    class Enemy : Sprite
    {
        private bool isDrawn;
        public Sprite otherSprite;
        
        public Enemy(Rectangle inPosition, Texture2D inTexture, Color inColour, bool inIsDrawn, Sprite inOtherSprite ) : base(inTexture, inPosition, inColour)
        {
            isDrawn = inIsDrawn;
            otherSprite = inOtherSprite; 
        }

        public bool IsDrawn
        {
            get { return isDrawn; }
            set { isDrawn = value; }
        }

    }
}
