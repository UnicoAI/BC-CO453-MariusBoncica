using App05MonoGame.Controllers;
using App05MonoGame.Screens;
using App05MonoGame.Sprites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace App05MonoGame
{
    public enum GameStates
    {
        Starting,
        HowToPlay,
        LevelOne,
        GameLost,
        GameWon
    }

    /// <summary>
    /// This game creates a variety of sprites as an example.  
    /// There is no game to play yet. The spaceShip and the 
    /// asteroid can be used for a space shooting game, the player, 
    /// the coin and the enemy could be used for a pacman
    /// style game where the player moves around collecting
    /// random coins and the enemy tries to catch the player.
    /// 
    /// Version: 1.0
    /// Date: 01/05/2022
    /// 
    /// </summary>
    /// <authors>
    /// Leighton Burgoyne
    /// </authors>
    public class App05Game : Game
    {
        #region Constants

        public const int Game_Height = 720;
        public const int Game_Width = 1280;

        public const string GameName = "";
        public const string ModuleName = "BNU CO453 2022";
        public const string AuthorNames = "Leighton Burgoyne";
        public const string AppName = "App05 MonoGame";

        #endregion

        #region Properties

        // Which state the game is in, starting, playing etc.

        public GameStates GameState { get; set; }

        public string GameStateTitle { get; set; }
        
        public GraphicsDevice Graphics { get; set; }

        // Records whether the game is Paused
        public bool Paused { get; set; }

        // Records whether the Game is Muted
        public bool Muted { get; set; }

        #endregion

        #region: Attributes

        // Essential XNA objects for Graphics manipulation
        private readonly GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        // Screens
        private StartScreen startScreen;
        private HowToPlayScreen howToPlayScreen;
        private LevelOneScreen levelOneScreen;
        private GameLostScreen gameLostScreen;
        private GameWonScreen gameWonScreen;

        #endregion

        /// <summary>
        /// Create a graphics manager and the root for
        /// all the game assets or content
        /// </summary>
        public App05Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        /// <summary>
        /// Setup the game window size to HD_Height x HD_Width pixels
        /// Simple fixed playing area with no camera or scrolling
        /// </summary>
        protected override void Initialize()
        {
            Window.Title = "Space Warfare";

            GameState = GameStates.Starting;
            GameStateTitle = GameName + ": Start Screen";

            graphics.PreferredBackBufferWidth = Game_Width;
            graphics.PreferredBackBufferHeight = Game_Height;

            graphics.ApplyChanges();

            Graphics = graphics.GraphicsDevice;
            Paused = false;

            base.Initialize();
        }

        /// <summary>
        /// use Content to load your game images, fonts,
        /// music and sound effects
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load Music and SoundEffects

            SoundController.LoadContent(Content);
            SoundController.PlaySong("NightLurker");

            startScreen = new StartScreen(this);
        }


        /// <summary>
        /// Called 60 frames/per second and updates the positions
        /// of all the drawable objects
        /// </summary>
        /// <param name="gameTime">
        /// Can work out the elapsed time since last call if
        /// you want to compensate for different frame rates
        /// </param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || 
                Keyboard.GetState().IsKeyDown(Keys.Escape)) Exit();

            switch (GameState)
            {
                // Start Screen
                case GameStates.Starting:
                    startScreen.Update(gameTime); 
                    break;

                // How To Play Screen
                case GameStates.HowToPlay:
                    if (howToPlayScreen == null)
                        howToPlayScreen = new HowToPlayScreen(this);
                    howToPlayScreen.Update(gameTime);
                    break;
                
                // Level One Screen
                case GameStates.LevelOne:
                    if (levelOneScreen == null)
                        levelOneScreen = new LevelOneScreen(this);
                    levelOneScreen.Update(gameTime);
                    break;

                // Game Lost Screen
                case GameStates.GameLost:
                    if (gameLostScreen == null)
                        gameLostScreen = new GameLostScreen(this);
                    gameLostScreen.Update(gameTime);
                    break;

                // Game Won Screen
                case GameStates.GameWon:
                    if (gameWonScreen == null)
                        gameWonScreen = new GameWonScreen(this);
                    gameWonScreen.Update(gameTime);
                    break;

                default:
                    break;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// Called 60 frames/per second and Draw all the 
        /// sprites and other drawable images here
        /// </summary>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LawnGreen);

            spriteBatch.Begin();

            switch (GameState)
            {
                // Start Screen
                case GameStates.Starting:
                    startScreen.Draw(spriteBatch, gameTime);
                    break;

                // How To Play Screen
                case GameStates.HowToPlay:
                    if (howToPlayScreen != null)
                        howToPlayScreen.Draw(spriteBatch, gameTime);
                    break;

                // Level One Screen
                case GameStates.LevelOne:
                    if (levelOneScreen != null)
                        levelOneScreen.Draw(spriteBatch, gameTime);
                    break;

                // Game Lost Screen
                case GameStates.GameLost:
                    if (gameLostScreen != null)
                        gameLostScreen.Draw(spriteBatch, gameTime);
                    break;

                // Game Won Screen
                case GameStates.GameWon:
                    if (gameWonScreen != null)
                        gameWonScreen.Draw(spriteBatch, gameTime);
                    break;

                default:
                    break;
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }

    }
}
