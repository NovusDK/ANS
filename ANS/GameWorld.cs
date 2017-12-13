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
		#region singleton
		private static GameWorld instance;

		internal static GameWorld Instance
		{
			get
			{
				//tjek om "instance" eksistere, hvis den ikke eksistere, instansiere den sig selv 
				if (instance == null)
				{
					instance = new GameWorld();
				}
				return instance;
			}
		}
		#endregion

		#region fields 
		Texture2D wizTexture, portalTexture;
		Rectangle wizRectangle, portalRectangle;
		Grid grid = new Grid();
		List<Items> items = new List<Items>(); 
		#endregion


		public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;

        private GameWorld()
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
			items.Add(new Items(new Vector2(50, 50), "bigW2", 1, true, null));


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

			portalTexture = Content.Load<Texture2D>("portalA2");
			portalRectangle = new Rectangle(0, 800, portalTexture.Width, portalTexture.Height);
			wizTexture = Content.Load<Texture2D>("bigW2");
			wizRectangle = new Rectangle(portalRectangle.X + 100, portalRectangle.Y, wizTexture.Width, wizTexture.Height);


			grid.LoadGrid();

			foreach (Items item in items)
			{
				item.LoadItems();
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

			grid.DrawGrid(); 

			spriteBatch.Draw(wizTexture, wizRectangle, Color.White);
			spriteBatch.Draw(portalTexture, portalRectangle, Color.White);

			foreach (Items item in items)
			{
				item.DrawItems();
			}

			spriteBatch.End(); 

            base.Draw(gameTime);
        }
    }
}
