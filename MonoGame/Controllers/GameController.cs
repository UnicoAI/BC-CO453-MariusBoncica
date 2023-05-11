using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace App05MonoGame.Sprites
{
    /// <summary>
    /// The Game Controller holds all of the neccesary variables and controller information for spawning Asteroids, timing the game, etc.
    /// </summary>
    /// <author>
    /// Leighton Burgoyne
    /// </author>
    public class GameController
    {
        public List<Asteroid> asteroids = new List<Asteroid>(); // List of Asteroid Instances
        public double timer = 2D; // Timer Variable
        public double maxTime = 2D; // Maximum Time Variable
        public int nextSpeed = 240; // Next Speed Variable
        public float totalTime = 0f; // Total Time Variable

        public bool inGame = true; // In Game Status Variable

        public void conUpdate(GameTime gameTime)
        {
            if (inGame) // Run Timer
            {
                timer -= gameTime.ElapsedGameTime.TotalSeconds;
                totalTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else // Reset all Properties
            {
                inGame = true;
                totalTime = 0f;
                timer = 2D;
                maxTime = 2D;
                nextSpeed = 240;
            }

            if (timer <= 0) // Add new Asteroids and increment the speed accordingly
            {
                asteroids.Add(new Asteroid(nextSpeed));
                timer = maxTime;
                if (maxTime > 0.5)
                {
                    maxTime -= 0.1D;
                }

                if (nextSpeed < 720)
                {
                    nextSpeed += 4;
                }
            }
        }
    }
} 