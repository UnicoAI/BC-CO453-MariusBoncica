using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;


namespace App05MonoGame.Controllers
{
    /// <summary>
    /// Add one value for each sound effect
    /// </summary>
    public enum Sounds
    {
        Collisions,
        Shooting,
        Lose,
        Win
    }
    
    /// <summary>
    /// Sound Controller will manage any sound effects or music in the game.
    /// </summary>
    /// <author>
    /// Created by Andrei Cruceru & Derek Peacock. Modified by Leighton Burgoyne
    /// </author>
    public static class SoundController
    {
        #region constants

        // Dictionary Keys

        public const string SongName = "NightLurker"; // Background Music
        public const string CollisionEffect = "CollisionEffect"; // Asteroid Collision Sound Effect
        public const string ProjectileEffect = "ProjectileEffect";
        public const string LoseEffect = "LoseEffect"; // Lose Game Sound Effect
        public const string WinEffect = "WinEffect"; // Win Game Sound Effect

        #endregion

        // Dictionaries

        private static readonly Dictionary<string, Song> Songs =
            new Dictionary<string, Song>();

        private static readonly Dictionary<string, SoundEffect> SoundEffects = 
            new Dictionary<string, SoundEffect>();
        
        /// <summary>
        /// Load songs and sound effects.
        /// </summary>
        public static void LoadContent(ContentManager content)
        {
            Songs.Add(SongName,content.Load<Song>("Sounds/NightLurker"));            

            SoundEffects.Add(CollisionEffect, content.Load<SoundEffect>("Sounds/flame"));
            SoundEffects.Add(ProjectileEffect, content.Load<SoundEffect>("Sounds/shooting"));
            SoundEffects.Add(LoseEffect, content.Load<SoundEffect>("Sounds/lose"));
            SoundEffects.Add(WinEffect, content.Load<SoundEffect>("Sounds/win"));
        }
        

        /// <summary>
        /// Play the selected sound effect if it exists in the
        /// dictionary of sound effects
        /// </summary>
        public static void PlaySoundEffect(Sounds sound)
        {
            switch (sound)
            {
                // Collisions Sound
                case Sounds.Collisions:
                    SoundEffects[CollisionEffect].Play(); break;

                // Shooting Sound (reserved for future use)
                case Sounds.Shooting:
                    SoundEffects[ProjectileEffect].Play(); break;

                // Lose Sound
                case Sounds.Lose:
                    SoundEffects[LoseEffect].Play(); break;

                // Win Sound
                case Sounds.Win:
                    SoundEffects[WinEffect].Play(); break;

                // Default Action
                default:
                    break;
            }
        }


        /// <summary>
        /// Play a song
        /// </summary>
        /// <param name="song">A string type key assigned to a song.</param>
        public static void PlaySong(string song)
        {
            MediaPlayer.IsRepeating = true;

            MediaPlayer.Play(Songs[song]);
        }

        public static void PauseSong()
        {
            MediaPlayer.Pause();
        }

        public static void ResumeSong()
        {
            MediaPlayer.Resume();
        }
    }
}
