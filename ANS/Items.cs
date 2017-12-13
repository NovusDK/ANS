using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace ANS
{
	class Items
	{
		Texture2D sprite;
		Vector2 position;
		Rectangle rectangle;
		string spriteName;
		float layerDepth;
		bool walkable;
		Random random;


		float rotation;
		float scale; 
		Vector2 origin; 

		public Items ( Vector2 position, string spriteName,float layerDepth, bool walkable, Random random )
		{
			this.position = position;
			this.spriteName = spriteName;
			this.layerDepth = layerDepth;
			this.walkable = walkable;
			this.random = random; 
		}

		public void LoadItems()
		{
			sprite = GameWorld.Instance.Content.Load<Texture2D>(spriteName);
			rectangle = new Rectangle(0, 0, sprite.Width, sprite.Height); 
		}

		public void DrawItems()
		{
			GameWorld.Instance.spriteBatch.Draw(sprite,position, null, Color.White, rotation,origin ,scale ,SpriteEffects.None, layerDepth); 

		}
	}
}
