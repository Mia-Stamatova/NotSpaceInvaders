using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Space_Invaders
{
    class Bullet : Sprite
    {
        private bool moveUp = false;
        public Bullet(Texture2D inTexture, Rectangle inPosition, Color inColour) : base(inTexture, inPosition, inColour)
        {
            //empty apart from anything that a player needs that a sprite doesn't

        }

        public void InitialPosition(Sprite inSprite)
        {
            int xPosition = inSprite.Position.X;
                //+ inSprite.Texture.Width / 2 - Texture.Width / 2;
            spritePosition = new Rectangle(xPosition, inSprite.Position.Y, Texture.Width, Texture.Height);
            int yPosition = spritePosition.Y;

        }

        public void BulletMovement()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right) && spritePosition.X + spriteTexture.Width < GraphicsDeviceManager.DefaultBackBufferWidth && moveUp == false)
            {
                spritePosition.X += 3;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left) && spritePosition.X > 0 && moveUp == false)
            {
                spritePosition.X -= 3;
            }
            
        }

        public void BulletFired(Sprite inSprite)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                moveUp = true;
            }
            if (moveUp == true && spritePosition.Y > 0)
            {
                spritePosition.Y -= 2;
            }
            if (spritePosition.Y <= 0)
            {
                
                InitialPosition(inSprite);
                moveUp = false;
                spritePosition.Y = GraphicsDeviceManager.DefaultBackBufferHeight - spriteTexture.Height;
                spritePosition.X = inSprite.Position.X;



            }
        }

    }


   /* public void MovementBullet()
    {
        
    } */
}
