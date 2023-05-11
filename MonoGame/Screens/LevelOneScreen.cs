using App05MonoGame.Controllers;
using App05MonoGame.Sprites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace App05MonoGame.Screens
{
    public class LevelOneScreen : IUpdateableInterface, IDrawableInterface
    {
        #region Attributes

        // Game Fields
        private App05Game game;
        private Texture2D backgroundImage;
        private Button pauseButton;
        private Button musicButton;
        private Button time;
        private Button logo;
        private Button livesBox;

        // Font Fields
        private SpriteFont saranaiFont; // Decorative Font
        private SpriteFont arialFont; // Large Font
        private SpriteFont calibriFont; // Small Font

        // Local Variables
        public int livesLevel = 3;

        // Texture Fields
        Texture2D spaceship_Sprite;
        Texture2D asteroid_Sprite;

        GameController gameController = new GameController();

        Spaceship player = new Spaceship();

        #endregion
        public LevelOneScreen(App05Game game)
        {
            this.game = game;
            LoadContent();
        }

        /// <summary>
        /// Load all required Game Content
        /// </summary>
        public void LoadContent()
        {
            backgroundImage = game.Content.Load<Texture2D>("Backgrounds/LevelOneBackground");
            saranaiFont = game.Content.Load<SpriteFont>("Fonts/saranai");
            arialFont = game.Content.Load<SpriteFont>("Fonts/arial");
            calibriFont = game.Content.Load<SpriteFont>("Fonts/calibri");
            asteroid_Sprite = game.Content.Load<Texture2D>("Actors/asteroid-1");
            spaceship_Sprite = game.Content.Load<Texture2D>("Actors/Ship");
            SetupPauseButton();
            SetupMusicButton();
            SetupHUD();
        }

        /// <summary>
        /// Create and Setup the Pause Button
        /// </summary>
        private void SetupPauseButton()
        {
            pauseButton = new Button(saranaiFont,
                game.Content.Load<Texture2D>("Controls/Pause_Normal_Btn"), Color.White)
            {
                Position = new Vector2(1198, 100),
                Text = "",
                Scale = 0.15f,
            };

            pauseButton.Click += PauseGame;
        }

        /// <summary>
        /// Handles the Pausing of the Game
        /// </summary>
        private void PauseGame(object sender, System.EventArgs e)
        {
            game.Paused = !(game.Paused);

            if (game.Paused) // Pause Song if Muted
            {
                SoundController.PauseSong();
            }
            else // Resume Song when Unmuted
            {
                SoundController.ResumeSong();
            }
        }

        /// <summary>
        /// Create and Setup the Music Button
        /// </summary
        private void SetupMusicButton()
        {
            musicButton = new Button(saranaiFont,
                game.Content.Load<Texture2D>("Controls/Music_Normal_Btn"), Color.White)
            {
                Position = new Vector2(1198, 180),
                Text = "",
                Scale = 0.15f
            };

            musicButton.Click += MuteAudio;
        }

        /// <summary>
        /// Create and Setup the HUD Elements
        /// </summary>
        private void SetupHUD()
        {
            logo = new Button(saranaiFont, game.Content.Load<Texture2D>("backgrounds/SpaceWarfareLogo"), Color.White)
            {
                Position = new Vector2(528, 10),
                Text = "",
                Scale = 0.4f,
            };
        }

        /// <summary>
        /// Handles the Muting of Game Music
        /// </summary>
        private void MuteAudio(object sender, System.EventArgs e)
        {
            game.Muted = !(game.Muted);

            if (game.Muted) // Pause Song if Muted
            {
                SoundController.PauseSong();
            }
            else // Resume Song when Unmuted
            {
                SoundController.ResumeSong();
            }
        }

        /// <summary>
        /// Updates the required elements
        /// </summary>
        public void Update(GameTime gameTime)
        {
            pauseButton.Update(gameTime);
            musicButton.Update(gameTime);
            logo.Update(gameTime);

            if (!game.Paused)
            {
                player.shipUpdate(gameTime, gameController);
                gameController.conUpdate(gameTime);
            }

            if (game.Paused)
            {
                gameController.asteroids.RemoveAll(asteroid => !asteroid.offScreen);
            }

            for (int i = 0; i < gameController.asteroids.Count; i++)
            {
                gameController.asteroids[i].asteroidUpdate(gameTime);
                
                if (gameController.asteroids[i].position.X < (0 - gameController.asteroids[i].radius))
                {
                    gameController.asteroids[i].offScreen = true;
                }

                int sum = gameController.asteroids[i].radius + 60;
                if (Vector2.Distance(gameController.asteroids[i].position, player.position) < sum)
                {
                    gameController.asteroids.Remove(gameController.asteroids[i]);
                    SoundController.PlaySoundEffect(Sounds.Collisions);
                    livesLevel -= 1;
                }
            }

            gameController.asteroids.RemoveAll(asteroid => asteroid.offScreen);

            if(livesLevel <= 0) // Lose the Game
            {
                SoundController.PlaySoundEffect(Sounds.Lose);
                game.GameState = GameStates.GameLost;
            }

            if (gameController.totalTime >= 100) // Win the Game
            {
                SoundController.PlaySoundEffect(Sounds.Win);
                game.GameState = GameStates.GameWon;
            }
        }

        /// <summary>
        /// Draws the required spriteBatches
        /// </summary>
        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(backgroundImage, Vector2.Zero, Color.White);

            DrawGameStatus(spriteBatch);

            time.Draw(spriteBatch, gameTime);
            logo.Draw(spriteBatch, gameTime);
            livesBox.Draw(spriteBatch, gameTime);


            pauseButton.Draw(spriteBatch, gameTime);
            musicButton.Draw(spriteBatch, gameTime);

            DrawGameFooter(spriteBatch);

            spriteBatch.Draw(spaceship_Sprite, new Vector2(player.position.X - 56, player.position.Y - 60), Color.White);
            
            if (game.Paused)
            {
                spriteBatch.DrawString(arialFont, "Game is Paused.", new Vector2(528, 360), Color.White);
            }

            for (int i = 0; i < gameController.asteroids.Count; i++)
            {
                Vector2 tempPos = gameController.asteroids[i].position;
                int tempRadius = gameController.asteroids[i].radius;
                spriteBatch.Draw(asteroid_Sprite, new Vector2(tempPos.X - tempRadius, tempPos.Y - tempRadius), Color.White);
            }
        }

        /// <summary>
        /// Display game statuses such as the Time Elapsed and Lives Remaining to the Player
        /// </summary>
        public void DrawGameStatus(SpriteBatch spriteBatch)
        {
            // TODO: Use the Sprite's score and energy

            int lives = livesLevel;

            // Time Box
            time = new Button(arialFont, game.Content.Load<Texture2D>("Controls/TimeBox"), Color.White)
            {
                Position = new Vector2(20, 20),
                Text = "Time: " + Math.Floor(gameController.totalTime).ToString(),
                Scale = 0.15f,
            };

            // Lives Box
            livesBox = new Button(arialFont, game.Content.Load<Texture2D>("Controls/LivesBar"), Color.White)
            {
                Position = new Vector2(978, 20),
                Text = "Lives: " + lives.ToString(),
                Scale = 0.15f,
            };
        }

        /// <summary>
        /// Display identifying information such as the the App, the Module, the authors at the bottom of the screen
        /// </summary>
        public void DrawGameFooter(SpriteBatch spriteBatch)
        {
            int bottomMargin = 30;

            Vector2 namesSize = calibriFont.MeasureString(App05Game.AuthorNames);
            Vector2 appSize = calibriFont.MeasureString(App05Game.AppName);

            Vector2 bottomCentre = new Vector2(
                (App05Game.Game_Width - namesSize.X) / 2,
                App05Game.Game_Height - bottomMargin);

            Vector2 bottomLeft = new Vector2(
                bottomMargin, App05Game.Game_Height - bottomMargin);

            Vector2 bottomRight = new Vector2(
                App05Game.Game_Width - appSize.X - bottomMargin,
                App05Game.Game_Height - bottomMargin);

            spriteBatch.DrawString(calibriFont,
                App05Game.AuthorNames, bottomCentre, Color.White);
            spriteBatch.DrawString(calibriFont,
                App05Game.ModuleName, bottomLeft, Color.White);
            spriteBatch.DrawString(calibriFont,
                App05Game.AppName, bottomRight, Color.White);
        }
    
    }
}