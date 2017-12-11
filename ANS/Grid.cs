using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ANS
{
	public class Grid
	{
		GameWorld gameworld;
		Texture2D gridTexture;
		Rectangle gridRectangle;
		Rectangle[,] gridArray;
   
        public Grid(GameWorld gameworld)
        {
            this.gameworld = gameworld;
        }

		public void LoadGrid()
		{
			gridTexture = gameworld.Content.Load<Texture2D>("green3");
			gridRectangle = new Rectangle(10, 10, gridTexture.Width, gridTexture.Height);

			gridArray = new Rectangle[10, 10];
			int gridSize =  gameworld.graphics.PreferredBackBufferHeight / 20 + gameworld.graphics.PreferredBackBufferWidth / 20;

			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					gridArray[x, y] = new Rectangle(x * gridSize, y * gridSize, gridSize, gridSize);
				}

			}
		}

		public void DrawGrid()
		{

			Texture2D T = new Texture2D(gameworld.GraphicsDevice, 1, 1);
			T.SetData<Color>(new[] { Color.White });

			foreach (Rectangle item in gridArray)
			{
				gameworld.spriteBatch.Draw(gridTexture, item, Color.White);
			}
		}
	}
}
