using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TitleTBDREAL
{
    public class mapDraw
    {
        public override void drawMap()
        {
            _spriteBatch.Draw(pineTree, new Vector2(300, 300), null, Color.White, 0f, new Vector2(pineTree.Width / 2, pineTree.Height / 2), Vector2.One, SpriteEffects.None, 0f);

        }
    }
}

