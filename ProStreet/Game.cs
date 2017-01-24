using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.ProStreetAddresses;
using Funcs = NFSScript.ProStreetFunctions;
using NFSScript.Math;


namespace NFSScript.ProStreet
{
    /// <summary>
    /// A struct that represents the main game manager.
    /// </summary>
    public static class Game
    {
        private const int SOUND_ID = 0x1;
        private const int AUDIO_STREAMING_ID = 0x2;
        private const int SPEECH_ID = 0x3;
        private const int NIS_AUDIO_ID = 0x4;

        /// <summary>
        /// Returns the currently playing song ID.
        /// </summary>
        public static int CurrentlyPlayingSongID
        {
            get { return memory.ReadInt32((IntPtr)Addrs.GameAddrs.STATIC_SONG_ID); }
        }

        /// <summary>
        /// Returns the current game state.
        /// </summary>
        /// <returns></returns>
        public static GameState GetGameState()
        {
            return (GameState)Enum.Parse(typeof(GameState), memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_GAME_STATE).ToString());
        }

        /// <summary>
        /// Returns the save game directory path.
        /// </summary>
        public static string saveDirectory { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NFS ProStreet"); } }

        /// <summary>
        /// Returns true is the gameplay is active.
        /// </summary>
        public static bool isGameplayActive
        {
            get
            {         
                if (memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_GAMEPLAY_ACTIVE) == 1)
                    return true;
                else return false;
            }
        }

        /// <summary>
        /// Returns true if the career is loaded.
        /// </summary>
        public static bool isCareerLoaded
        {
            get
            {
                if (memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_CAREER_LOADED) == 1)
                    return true;
                else return false;
            }
        }

        /// <summary>
        /// Is sound enabled?
        /// </summary>
        public static bool isSoundEnabled
        {
            get { return _readAudioIDValue(SOUND_ID); }
            set { _setAudioIDValue(SOUND_ID, value); }
        }

        /// <summary>
        /// Is audio stream enabled?
        /// </summary>
        public static bool isAudioStreamingEnabled
        {
            get { return _readAudioIDValue(AUDIO_STREAMING_ID); }
            set { _setAudioIDValue(AUDIO_STREAMING_ID, value); }
        }

        /// <summary>
        /// Is speech enabled?
        /// </summary>
        public static bool isSpeechEnabled
        {
            get { return _readAudioIDValue(SPEECH_ID); }
            set { _setAudioIDValue(SPEECH_ID, value); }
        }

        /// <summary>
        /// Is NIS audio enabled?
        /// </summary>
        public static bool isNISAudioEnabled
        {
            get { return _readAudioIDValue(NIS_AUDIO_ID); }
            set { _setAudioIDValue(NIS_AUDIO_ID, value); }
        }

        /// <summary>
        /// Sets or gets a value that indicates whether the movies should be skipped or not.
        /// </summary>
        public static bool SkipMovies
        {
            get
            {
                return (memory.ReadByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_MOVIES) == 1);
            }
            set
            {
                byte b = 0;
                if (value)
                    b = 1;

                memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_MOVIES, b);
            }
        }

        /// <summary>
        /// Shows a loading screen.
        /// </summary>
        public static void ShowLoadingScreen()
        {
            Function.Call(Funcs.SHOW_LOADING_SCREEN);
        }

        /// <summary>
        /// Hides a loading screen.
        /// </summary>
        public static void HideLoadingScreen()
        {
            Function.Call(Funcs.HIDE_LOADING_SCREEN);
        }

        /// <summary>
        /// Unlock everything.
        /// </summary>
        public static void UnlockAllThings()
        {
            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_UNLOCK_ALL_THINGS, 1);
        }

        /// <summary>
        /// Skip the career intro.
        /// </summary>
        public static void SkipCareerIntro()
        {
            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_CAREER_INTRO, 1);
        }

        /// <summary>
        /// Skips the frontend values with a custom set of values. Keep in mind that on every gameplay change (Going to the safehouse) the SkipFE gets disabled and must be recalled again.
        /// </summary>
        /// <param name="enabled"></param>
        public static void SkipFE(bool enabled)
        {
            byte value = 0;
            if (enabled)
                value = 1;

            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE, value);
        }

        /// <summary>
        /// Skips the frontend and set the values from the defined SkipFEValues class to the game's SkipFE values. Keep in mind that on every gameplay change (Going to the safehouse) the SkipFE gets disabled and must be recalled again.
        /// </summary>
        /// <param name="skipFEValues"></param>
        public static void StartSkipFE(SkipFEValues skipFEValues)
        {
            SkipFE(true);
            _setSkipFEValues(skipFEValues);
        }

        /// <summary>
        /// Sets the values from the defined SkipFEValues class to the game's SkipFE values without skipping frontend.
        /// </summary>
        /// <param name="skipFEValues"></param>
        public static void SetSkipFE(SkipFEValues skipFEValues)
        {
            _setSkipFEValues(skipFEValues);
        }

        /// <summary>
        /// Returns a string with a length of 26 which contains the latest entered code (If the player has entered any).
        /// </summary>
        /// <returns></returns>
        public static string GetEnteredCode()
        {
            return memory.ReadStringASCII((IntPtr)Addrs.GameAddrs.STATIC_ENTERED_CODE, 26);
        }

        internal static void _setAudioIDValue(int id, bool value)
        {
            byte b = 0;
            if (value) b = 1;
            IntPtr address = IntPtr.Zero;
            switch (id)
            {
                case SOUND_ID:
                    address = (IntPtr)Addrs.GenericAddrs.STATIC_IS_SOUND_ENABLED;
                    break;

                case AUDIO_STREAMING_ID:
                    address = (IntPtr)Addrs.GenericAddrs.STATIC_IS_AUDIO_STREAMING_ENABLED;
                    break;

                case SPEECH_ID:
                    address = (IntPtr)Addrs.GenericAddrs.STATIC_IS_SPEECH_ENABLED;
                    break;

                case NIS_AUDIO_ID:
                    address = (IntPtr)Addrs.GenericAddrs.STATIC_IS_NISAUDIO_ENABLED;
                    break;

                default:
                    return;
            }

            memory.WriteByte(address, b);
        }

        internal static void _setSkipFEValues(SkipFEValues skipFEValues)
        {
            byte bEnableDebugActivity = 0, bAutoRaceTest = 0, bPracticeMode = 0, bDisableSmoke = 0;

            if (skipFEValues.enableDebugActivity)
                bEnableDebugActivity = 1;
            if (skipFEValues.autoRaceTest)
                bAutoRaceTest = 1;
            if (skipFEValues.practiceMode)
                bPracticeMode = 1;
            if (skipFEValues.disableSmoke)
                bDisableSmoke = 1;

            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_ENABLE_DEBUG_ACTIVITY, bEnableDebugActivity);
            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_AUTO_RACE_TEST, bAutoRaceTest);
            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_PRACTICE_MODE, bPracticeMode);
            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_DISABLE_SMOKE, bDisableSmoke);

            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_NUM_AI_CARS, skipFEValues.numAICars);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_NUM_PLAYER_CARS, skipFEValues.numPlayerCars);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_NUM_LAPS, skipFEValues.numLaps);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_NUM_PLAYER_SCREENS, skipFEValues.numPlayerScreens);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_PLAYER_CAR, skipFEValues.playerCar);

            memory.WriteByteArray((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_PLAYER_BLUEPRINT_TYPE, skipFEValues.playerBlueprintType);
            memory.WriteByteArray((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_TRACK_DIRECTION, skipFEValues.trackDirection);
            memory.WriteByteArray((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_RACE_TYPE, skipFEValues.raceType);
            memory.WriteByteArray((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_CONTROLLER_CONFIG, skipFEValues.controllerConfig);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_CONTROLLER_CONFIG1, skipFEValues.controllerConfig1);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_CONTROLLER_CONFIG2, skipFEValues.controllerConfig2);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_TRACTION_CONTROL_LEVEL, skipFEValues.tractionControlLevel);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_STABILITY_CONTROL_LEVEL, skipFEValues.stabilityControlLevel);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_ANTI_LOCK_BRAKES_LEVEL, skipFEValues.antiLockBrakesLevel);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_DRIFT_ASSIST_LEVEL, skipFEValues.driftAssistLevel);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_RACELINE_ASSIST_LEVEL, skipFEValues.raceLineAssistLevel);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_BRAKING_ASSIST_LEVEL, skipFEValues.brakingAssistLevel);
            memory.WriteByteArray((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_TRANSMISSION_SETUP, skipFEValues.transmissionSetup);
            memory.WriteByteArray((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_BOOT_FLOW, skipFEValues.bootFlow);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_TRACK_NUMBER, skipFEValues.trackNumber);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_RACE_ID, skipFEValues.raceID);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_TURBO_SFX, skipFEValues.turboSFX);
        }

        internal static bool _readAudioIDValue(int id)
        {
            byte b = 0;
            switch (id)
            {
                case SOUND_ID:
                    b = memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_SOUND_ENABLED);
                    break;

                case AUDIO_STREAMING_ID:
                    b = memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_AUDIO_STREAMING_ENABLED);
                    break;

                case SPEECH_ID:
                    b = memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_SPEECH_ENABLED);
                    break;

                case NIS_AUDIO_ID:
                    b = memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_NISAUDIO_ENABLED);
                    break;

                default:
                    b = 0;
                    break;
            }

            return (b == 1);
        }
    }

    /// <summary>
    /// An enum that represents the game state in NFS: ProStreet.
    /// </summary>
    public enum GameState : byte
    {
        /// <summary>
        /// No game state.
        /// </summary>
        None = 0,
        /// <summary>
        /// Loading before going into the FE game state.
        /// </summary>
        LoadingFE = 1,
        /// <summary>
        /// FE game state.
        /// </summary>
        FE = 3,
        /// <summary>
        /// Preloading game state.
        /// </summary>
        PreLoading = 4,
        /// <summary>
        /// Loading game state. (Inconsistent)
        /// </summary>
        Loading = 5,
        /// <summary>
        /// InGame game state.
        /// </summary>
        InGame = 6
    }
}
