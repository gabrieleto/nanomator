using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Nanomator
{
    public class Nanomator
    {
        public float currentFrame = 0;

        public void Draw(Game1 game, Texture2D texture, Vector2 position, int frameWidth, int frameHeight, int frames, Color color)
        {
            currentFrame += 0.1f;
            if (currentFrame >= frames)
            {
                currentFrame = 0;
            }

            game._spriteBatch.Draw(texture, position, new Rectangle(new Point(frameWidth * (int)currentFrame, 0), new Point(frameWidth, frameHeight)), color);
        }
    }
}
