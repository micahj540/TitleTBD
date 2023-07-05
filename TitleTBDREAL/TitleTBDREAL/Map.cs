using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoGame.Extended;
using System.Reflection.Metadata;

namespace TitleTBDREAL
{
    internal class Map
    {
        private int tileWidth;
        private int tileHeight;
        private int width;
        private int height;
        //private MapTrees mapTrees;

        public Map(int pTileWidth, int pTileHeight, int pWidth, int pHeight)
        {

            tileHeight = pHeight;
            width = pWidth;
            height = pHeight;
            tileWidth = pWidth;

        }
        public void drawGrass(SpriteBatch spriteBatch, Texture2D texture)
        {
            Vector2 tilePosition = new Vector2(0, 0);


            for (int i = 0; i < width; i++)
            {

                for (int j = 0; j < height; j++)
                {
                    spriteBatch.Draw(texture, new Vector2(tilePosition.X, tilePosition.Y), null, Color.White);
                    tilePosition.Y += tileHeight;
                }
                tilePosition.Y = 0;
                tilePosition.X += tileWidth;
            }

        }
        public void drawPath(SpriteBatch spriteBatch, Texture2D pathTexture, Texture2D halfTexture)
        {
            Vector2 tilePosition = new Vector2(10 * tileWidth, 10 * tileHeight);

            for (int i = 0; i < 11; i++)
            {
                
                spriteBatch.Draw(pathTexture, new Vector2(tilePosition.X, tilePosition.Y), null, Color.White);
                tilePosition.X += tileWidth;
                spriteBatch.Draw(halfTexture, new Vector2(tilePosition.X, tilePosition.Y), null, Color.White);
                tilePosition.X -= tileWidth;
                tilePosition.Y -= tileHeight;
                
            }


        }
        public void drawHouse(SpriteBatch spriteBatch, Texture2D texture)
        {
            spriteBatch.Draw(texture, new Vector2(600, 350), null, Color.White);
        }
    }
}


