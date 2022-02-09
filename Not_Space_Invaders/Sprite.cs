using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Space_Invaders
{
    class Sprite
    {
        protected Texture2D spriteTexture;
        protected Rectangle spritePosition;
        protected Color spriteColour;
        
        
        

        public Sprite(Texture2D inTexture, Rectangle inPosition, Color inColour)
        {
            spriteTexture = inTexture;
            spritePosition = inPosition;
            spriteColour = inColour;
        }

        public void DrawSprite(SpriteBatch inSpriteBatch)
        {
            inSpriteBatch.Draw(spriteTexture, spritePosition, spriteColour);
        }
        
        public Rectangle Position
        { get; set; }


        public Texture2D Texture
        { get; set; }
        
        

        

    }
}
