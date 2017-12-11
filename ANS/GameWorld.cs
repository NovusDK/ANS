using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic; 

namespace ANS
{
	//test
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {
		#region fields 
		Texture2D gridTexture, wizTexture;
		Rectangle gridRectangle, wizRectangle;


		Rectangle[,] gridArray;
		
		#endregion



		GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1000;
            graphics.PreferredBackBufferHeight =1000;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO: use this.Content to load your game content here
			gridTexture = Content.Load<Texture2D>("green3");
			gridRectangle = new Rectangle(10, 10, gridTexture.Width, gridTexture.Height);
			wizTexture = Content.Load<Texture2D>("bigW2");
			wizRectangle = new Rectangle(1, 1, wizTexture.Width, wizTexture.Height);



			gridArray = new Rectangle[10, 10];
			int gridSize = graphics.PreferredBackBufferHeight / 20 + graphics.PreferredBackBufferWidth / 20;

			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					gridArray[x, y] = new Rectangle(x *gridSize , y * gridSize, gridSize, gridSize);
				}
				
			}
		}

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

			// TODO: Add your drawing code here
			spriteBatch.Begin();

			

			Texture2D T = new Texture2D(GraphicsDevice,1,1);
			T.SetData<Color>(new[] { Color.White });  

			foreach (Rectangle item in gridArray)
			{
				spriteBatch.Draw(gridTexture, item, Color.White); 
			}

			spriteBatch.Draw(wizTexture, wizRectangle, Color.White);

			spriteBatch.End(); 

            base.Draw(gameTime);
        }
    }
}
