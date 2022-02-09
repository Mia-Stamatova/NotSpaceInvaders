using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Space_Invaders
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private PlayerShip player1;
        private Texture2D player1Texture;
        private Bullet bullet;
        private Texture2D bulletTexture;
        private EnemyShips enemyShips;
        private Texture2D enemyTexture;
        
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            player1Texture = Content.Load<Texture2D>("Brick");
            bulletTexture = Content.Load<Texture2D>("Brick");

            // TODO: use this.Content to load your game content here
            player1 = new PlayerShip(player1Texture, new Rectangle(GraphicsDeviceManager.DefaultBackBufferWidth/2 - player1Texture.Width/2, GraphicsDeviceManager.DefaultBackBufferHeight - player1Texture.Height, player1Texture.Width, player1Texture.Height), Color.White);
            bullet = new Bullet(bulletTexture, new Rectangle(GraphicsDeviceManager.DefaultBackBufferWidth/2 - player1Texture.Width/2, GraphicsDeviceManager.DefaultBackBufferHeight - player1Texture.Height, 20, 20), Color.Red);
            

        }


        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            player1.Movement();
            bullet.BulletMovement();
            bullet.BulletFired(player1);
            enemyShips.InitialiseEnemyShips();
            enemyShips.EnemyShipsMovement(_graphics);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            GraphicsDevice.Clear(Color.BlueViolet);

            // TODO: Add your drawing code here
            player1.DrawSprite(_spriteBatch);
            bullet.DrawSprite(_spriteBatch);
            enemyShips.DrawSprite(_spriteBatch);
            _spriteBatch.End();
            base.Draw(gameTime);

        }

    }
}
