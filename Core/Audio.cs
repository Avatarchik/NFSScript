using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using NFSScript.Math;
using NFSScript.Core;
using NFSScript.Types;

using MDPlayer = MediaPlayer.MediaPlayer;

namespace NFSScript
{
    /// <summary>
    /// 
    /// </summary>
    public class Audio
    {
        private const string WAVE_EXTENSION = ".wav";
        private const string MP3_EXTENSION = ".mp3";
        /// <summary>
        /// 
        /// </summary>
        public class AudioClip
        {
            #region Private Variables
            private MDPlayer mediaPlayer;
            private string soundLocation;
            private AudioType audioType;
            private bool isLooping, isPlaying;
            private int volume;
            #endregion

            #region Public Variables
            /// <summary>
            /// Returns the location of the sound file.
            /// </summary>
            public string SoundFileLocation { get { return soundLocation; } }

            /// <summary>
            /// Returns a value that indicates whether this <see cref="AudioClip"/> loops or not.
            /// </summary>
            public bool IsLoop { get { return isLooping; } }

            /// <summary>
            /// Returns a value that indicates whether this <see cref="AudioClip"/> is currently playing or not.
            /// </summary>
            public bool IsPlaying { get { return isPlaying; } }

            /// <summary>
            /// The volume of this <see cref="AudioClip"/>.
            /// </summary>
            public int Volume
            {
                get
                {
                    return volume;
                }
                set
                {
                    volume = value;
                    if (mediaPlayer != null)
                        mediaPlayer.Volume = value;
                }
            }
            #endregion

            /// <summary>
            /// Instantiate an <see cref="AudioClip"/>.
            /// </summary>
            /// <param name="fileLocation">The file location of the sound file.</param>
            public AudioClip(string fileLocation)
            {
                soundLocation = fileLocation;
                isLooping = false;
                ApplyAudioSettings();
            }

            /// <summary>
            /// Instantiate an <see cref="AudioClip"/>.
            /// </summary>
            /// <param name="fileLocation">The file location of the sound file.</param>
            /// <param name="isLoop">Should the sound loop?</param>
            public AudioClip(string fileLocation, bool isLoop)
            {
                soundLocation = fileLocation;
                isLooping = isLoop;
                ApplyAudioSettings();
            }

            /// <summary>
            /// Plays this <see cref="AudioClip"/>.
            /// </summary>
            public void Play()
            {
                if (audioType == AudioType.WAV || audioType == AudioType.MP3)
                {
                    mediaPlayer.Play();
                    isPlaying = true;
                }
                else Log.Print("AUDIOERROR", string.Format("Could not play sound at {0}, AudioClip is {1}.", soundLocation, audioType));
            }

            /// <summary>
            /// Stops this <see cref="AudioClip"/>.
            /// </summary>
            public void Stop()
            {
                if (isPlaying)
                {
                    mediaPlayer.Stop();
                    isPlaying = false;
                }
            }

            /// <summary>
            /// Pauses this <see cref="AudioClip"/>.
            /// </summary>
            public void Pause()
            {
                if (isPlaying)
                {
                    mediaPlayer.Pause();
                    isPlaying = false;
                }
            }

            /// <summary>
            /// Returns the <see cref="AudioType"/> for this <see cref="AudioClip"/>.
            /// </summary>
            /// <returns></returns>
            private void ApplyAudioSettings()
            {
                mediaPlayer = new MDPlayer();
                mediaPlayer.FileName = soundLocation;

                mediaPlayer.AutoStart = false;
                mediaPlayer.CurrentPosition = 0;
                mediaPlayer.EndOfStream += MediaPlayer_EndOfStream;

                if (!string.IsNullOrEmpty(soundLocation))
                {
                    if (soundLocation.EndsWith(WAVE_EXTENSION, StringComparison.OrdinalIgnoreCase))
                    {
                        audioType = AudioType.WAV;
                    }
                    else if (soundLocation.EndsWith(MP3_EXTENSION, StringComparison.OrdinalIgnoreCase))
                    {
                        audioType = AudioType.MP3;
                    }
                    else audioType = AudioType.Undefined;
                }
                else audioType = AudioType.None;
            }

            private void MediaPlayer_EndOfStream(int Result)
            {
                if (isLooping)
                {                    
                    mediaPlayer.CurrentPosition = 0;
                    mediaPlayer.Play();
                }
            }

        }

        /// <summary>
        /// Audio type enum.
        /// </summary>
        public enum AudioType : byte
        {
            /// <summary>
            /// 
            /// </summary>
            None = 0,
            /// <summary>
            /// Undefined audio type.
            /// </summary>
            Undefined = 1,
            /// <summary>
            /// Wave audio type.
            /// </summary>
            WAV = 2,
            /// <summary>
            /// MP3 audio type.
            /// </summary>
            MP3 = 3
        }
    }
}
