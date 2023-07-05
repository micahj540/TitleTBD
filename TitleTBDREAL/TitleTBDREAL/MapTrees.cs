using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoGame.Extended;

namespace TitleTBDREAL
{
    internal class MapTrees
    {
        public MapTrees()
        {
           

        }
        public void draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            spriteBatch.Draw(texture, new Vector2(50, 50), null, Color.White);
            spriteBatch.Draw(texture, new Vector2(200, 5), null, Color.White);
            spriteBatch.Draw(texture, new Vector2(500, 4), null, Color.White);
        }
    }
}
