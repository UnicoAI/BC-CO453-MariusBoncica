using App05MonoGame.Controllers;
using App05MonoGame.Sprites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace App05MonoGame.Screens
{
    public class StartScreen : IUpdateableInterface, IDrawableInterface
    {
        #region fields

        private App05Game game;
        private Texture2D backgroundImage;

        private SpriteFont saranaiFont;
        private SpriteFont arialFont;
        private SpriteFont calibriFont;

        private Button playButton;
        private Button helpButton;
        private Button musicButton;

        #endregion

        public StartScreen(App05Game game)
        {
            this.game = game;
            LoadContent();
        }

        /// <summary>
        /// Load all required Game Content
        /// </summary>
        public void LoadContent()
        {
            backgroundImage = game.Content.Load<Texture2D>("Backgrounds/StartBackground");

            saranaiFont = game.Content.Load<SpriteFont>("Fonts/saranai");
            arialFont = game.Content.Load<SpriteFont>("Fonts/arial");
            calibriFont = game.Content.Load<SpriteFont>("Fonts/calibri");
            
            SetupStartButton();
            SetupHelpButton();
            SetupMusicButton();
                
        }

        /// <summary>
        /// Create and Setup the Start Button
        /// </summary>
        private void SetupStartButton()
        {
            playButton = new Button(saranaiFont,
                game.Content.Load<Texture2D>("Controls/Normal_Btn"), Color.Cyan)
            {
                Position = new Vector2(510, 420),
                Text = "Start Game",
                Scale = 0.2f
            };

            playButton.Click += StartGame;
        }

        /// <summary>
        /// Create and Setup the Help Button
        /// </summary>
        private void SetupHelpButton()
        {
            helpButton = new Button(saranaiFont,
                game.Content.Load<Texture2D>("Controls/Normal_Btn"), Color.Cyan)
            {
                Position = new Vector2(510, 520),
                Text = "How to Play",
                Scale = 0.2f
            };

            helpButton.Click += OpenHelp;
        }

        /// <summary>
        /// Create and Setup the Music Button
        /// </summary>
        private void SetupMusicButton()
        {
            musicButton = new Button(saranaiFont,
                game.Content.Load<Texture2D>("Controls/Music_Normal_Btn"), Color.White)
            {
                Position = new Vector2(1175, 20),
                Text = "",
                Scale = 0.2f
            };

            musicButton.Click += MuteAudio;
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
        /// Handles the Starting of the Game
        /// </summary>
        private void StartGame(object sender, System.EventArgs e)
        {
            game.GameState = GameStates.LevelOne;
        }

        /// <summary>
        /// Handles the Opening of the Help Screen
        /// </summary>
        private void OpenHelp(object sender, System.EventArgs e)
        {
            game.GameState = GameStates.HowToPlay;
        }

        /// <summary>
        /// Draws the required spriteBatches
        /// </summary>
        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(backgroundImage, Vector2.Zero, Color.White);

            DrawGameFooter(spriteBatch);
            playButton.Draw(spriteBatch, gameTime);
            helpButton.Draw(spriteBatch, gameTime);
            musicButton.Draw(spriteBatch, gameTime);
        }

        /// <summary>
        /// Updates the required elements
        /// </summary>
        public void Update(GameTime gameTime)
        {
            playButton.Update(gameTime);
            helpButton.Update(gameTime);
            musicButton.Update(gameTime);
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
