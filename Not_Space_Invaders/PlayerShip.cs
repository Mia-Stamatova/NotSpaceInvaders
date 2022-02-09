using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Space_Invaders
{
    class PlayerShip : Sprite
    {
        private int lives = 3;
        
        public PlayerShip(Texture2D inTexture, Rectangle inPosition, Color inColour): base(inTexture, inPosition, inColour)
        {
            //empty apart from anything that a player needs that a sprite doesn't

        }

        
        public void Movement()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right) && spritePosition.X + spriteTexture.Width < GraphicsDeviceManager.DefaultBackBufferWidth)
            {
                spritePosition.X += 3;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left) && spritePosition.X > 0)
            {
                spritePosition.X -= 3;
            }
            
        }

        //variables
        //constructor
        //lives
        //movement (inc bounds)
        //fire/shoot
        //collision

        
        
        
    }
}
