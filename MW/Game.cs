using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.MWAddresses;
using Funcs = NFSScript.MWFunctions;
using NFSScript.Math;

namespace NFSScript.MW
{
    /// <summary>
    /// A struct that represents the main game manager.
    /// </summary>
    public static class Game
    {
        #region Constant Variables
        private const int SOUND_ID = 0x1;
        private const int AUDIO_STREAMING_ID = 0x2;
        private const int SPEECH_ID = 0x3;
        private const int NIS_AUDIO_ID = 0x4;
        #endregion

        private static float sirensIntensityR = 1, sirensIntensityB = 1, sirensIntensityW = 1;

        /// <summary>
        /// Returns a value that indicates whether the sirens are enabled or not.
        /// </summary>
        public static bool sirensEnabled { get; private set; }

        /// <summary>
        /// Returns the save game directory path.
        /// </summary>
        public static string saveDirectory { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NFS Most Wanted"); } }

        /// <summary>
        /// The scale at which the gameplay's time is passing. (Not the global time scale)
        /// </summary>
        public static float gameSpeed
        {
            get
            {
                return memory.ReadFloat((IntPtr)Addrs.GameAddrs.STATIC_GAME_SPEED);
            }
            set
            {
                memory.WriteFloat((IntPtr)Addrs.GameAddrs.STATIC_GAME_SPEED, value);
            }
        }

        /// <summary>
        /// Returns the amount of seconds it takes to render a frame
        /// </summary>
        public static float lastFrameTime
        {
            get
            {
                return memory.ReadFloat((IntPtr)Addrs.GenericAddrs.STATIC_LAST_FRAME_TIME);
            }
        }

        /// <summary>
        /// Returns true is the gameplay is active.
        /// </summary>
        public static bool isGameplayActive
        {
            get
            {
                byte b = memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_GAMEPLAY_ACTIVE);
                if (b == 1)
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
        /// Saves a number of defined frames as StreamAnim(framenumber).tga.
        /// </summary>
        /// <param name="frames"></param>
        public static void StreamAnim(int frames)
        {
            memory.WriteInteger((IntPtr)Addrs.GenericAddrs.STATIC_NUMBER_OF_STREAM_ANIM, frames);
            memory.WriteByte((IntPtr)Addrs.GenericAddrs.STATIC_SAVE_STREAM_ANIM_FRAMES, 1);
        }

        /// <summary>
        /// Saves 30 screenshots a second when enabled.
        /// </summary>
        /// <param name="value"></param>
        public static void UseRecordable(bool value)
        {
            byte b = 0;
            if (value) b = 1;
            memory.WriteByte((IntPtr)Addrs.GenericAddrs.STATIC_USE_RECORDABLE, b);
        }

        /// <summary>
        /// Turn the loading screen on.
        /// </summary>
        public static void LoadingScreenOn()
        {
            if(isGameplayActive)
                Function.Call(Funcs.LOADING_SCREEN_ON);
        }

        /// <summary>
        /// Turn the loading screen off.
        /// </summary>
        public static void LoadingScreenOff()
        {
            Function.Call(Funcs.LOADING_SCREEN_OFF);
        }

        /// <summary>
        /// Turn the fade screen on.
        /// </summary>
        public static void FadeScreenOn()
        {
            Function.Call(Funcs.FADE_SCREEN_ON);
        }

        /// <summary>
        /// Turn the fade screen off.
        /// </summary>
        public static void FadeScreenOff()
        {
            Function.Call(Funcs.FADE_SCREEN_OFF);
        }

        /// <summary>
        /// Bail the current pursuit.
        /// </summary>
        public static void PursuitBail()
        {
            Function.Call(Funcs.PURSUIT_BAIL);
        }

        /// <summary>
        /// Un-pauses the game.
        /// </summary>
        public static void Unpause()
        {
            Function.Call(Funcs.UNPAUSE);
        }

        /// <summary>
        /// Pauses the game.
        /// </summary>
        public static void Pause()
        {
            Function.Call(Funcs.PAUSE);
        }

        /// <summary>
        /// Forces the car to stop.
        /// </summary>
        public static void ForceCarStop()
        {
            Function.Call(Funcs.FORCE_CAR_STOP);
        }

        /// <summary>
        /// Restarts the race.
        /// </summary>
        public static void RestartRace()
        {
            Function.Call(Funcs.RESTART_RACE);
        }

        /// <summary>
        /// Starts a race.
        /// </summary>
        /// <param name="raceID">The race ID to start.</param>
        public static void StartRace(string raceID)
        {
            Function.Call(Funcs.START_RACE, raceID);
        }

        /// <summary>
        /// Reloads the HUD.
        /// </summary>
        public static void ReloadHUD()
        {
            Function.Call(Funcs.RELOAD_HUD);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ReloadGame()
        {
            Function.Call(Funcs.RELOAD_GAME);
        }

        /// <summary>
        /// Shows the SMS screen.
        /// </summary>
        public static void ShowSMS()
        {
            Function.Call(Funcs.SHOW_SMS);
        }

        /// <summary>
        /// Starts a pursuit.
        /// </summary>
        public static void ForcePursuitStart()
        {
            Function.Call(Funcs.FORCE_PURSUIT_START);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static void DoScreenPrintf(bool value)
        {
            byte b = 0;
            if (value) b = 1;
            memory.WriteByte((IntPtr)Addrs.GenericAddrs.STATIC_DO_SCREEN_PRINTF, b);
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

            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_ENABLED, value);
        }

        /// <summary>
        /// Enable the police sirens for the cars present in the world.
        /// </summary>
        public static void EnablePoliceSirens()
        {
            _setPoliceSirensIntensity(sirensIntensityR, sirensIntensityB, sirensIntensityW);
            sirensEnabled = true;
        }

        /// <summary>
        /// Enable the police sirens for the cars present in the world.
        /// </summary>
        public static void DisablePoliceSirens()
        {
            _setPoliceSirensIntensity(0, 0, 0);
            sirensEnabled = false;
        }

        /// <summary>
        /// Set the police lights intensity on the cars present in the world.
        /// </summary>
        /// <param name="red"></param>
        /// <param name="blue"></param>
        /// <param name="white"></param>
        public static void SetPoliceLightsIntensity(float red, float blue, float white)
        {
            sirensIntensityR = red;
            sirensIntensityB = blue;
            sirensIntensityW = white;

            if (sirensEnabled)
            {
                _setPoliceSirensIntensity(red, blue, white);
            }
        }

        /// <summary>
        /// Returns the police lights intensity value.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, float> GetCurrentPoliceLightsIntensity()
        {
            Dictionary<string, float> dic = new Dictionary<string, float>();

            dic.Add("Redlights", memory.ReadFloat((IntPtr)Addrs.GameAddrs.STATIC_GLOBAL_COP_LIGHTS_RED));
            dic.Add("Bluelights", memory.ReadFloat((IntPtr)Addrs.GameAddrs.STATIC_GLOBAL_COP_LIGHTS_BLUE));
            dic.Add("Whitelights", memory.ReadFloat((IntPtr)Addrs.GameAddrs.STATIC_GLOBAL_COP_LIGHTS_WHITE));

            return dic;
        }

        internal static void _setPoliceSirensIntensity(float r, float b, float w)
        {
            memory.WriteFloat((IntPtr)Addrs.GameAddrs.STATIC_GLOBAL_COP_LIGHTS_RED, r);
            memory.WriteFloat((IntPtr)Addrs.GameAddrs.STATIC_GLOBAL_COP_LIGHTS_BLUE, b);
            memory.WriteFloat((IntPtr)Addrs.GameAddrs.STATIC_GLOBAL_COP_LIGHTS_WHITE, w);
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
                    address = (IntPtr)Addrs.GenericAddrs.STATIC_IS_NIS_AUDIO_ENABLED;
                    break;

                default:
                    return;
            }

            memory.WriteByte(address, b);
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
                    b = memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_NIS_AUDIO_ENABLED);
                    break;

                default:
                    b = 0;
                    break;
            }

            return (b == 1);
        }

        /// <summary>
        /// A struct that represents the game's world
        /// </summary>
        public static class World
        {
            /// <summary>
            /// World's speed modifier for animations (like waving trees) on the game's world. (Default value is 45.0)
            /// </summary>
            public static float animationSpeed
            {
                get { return memory.ReadFloat((IntPtr)Addrs.WorldAddrs.STATIC_ANIMATION_SPEED); }
                set { memory.WriteFloat((IntPtr)Addrs.WorldAddrs.STATIC_ANIMATION_SPEED, value); }
            }

            /// <summary>
            /// Game world cars current scale
            /// </summary>
            public static Vector3 CarsScale
            {
                get
                {
                    float x = memory.ReadFloat((IntPtr)Addrs.WorldAddrs.STATIC_GLOBAL_CAR_SCALE_X);
                    float y = memory.ReadFloat((IntPtr)Addrs.WorldAddrs.STATIC_GLOBAL_CAR_SCALE_Y);
                    float z = memory.ReadFloat((IntPtr)Addrs.WorldAddrs.STATIC_GLOBAL_CAR_SCALE_Z);

                    return new Vector3(x, y, z);
                }
                set
                {
                    memory.WriteFloat((IntPtr)Addrs.WorldAddrs.STATIC_GLOBAL_CAR_SCALE_X, value.x);
                    memory.WriteFloat((IntPtr)Addrs.WorldAddrs.STATIC_GLOBAL_CAR_SCALE_Y, value.y);
                    memory.WriteFloat((IntPtr)Addrs.WorldAddrs.STATIC_GLOBAL_CAR_SCALE_Z, value.z);
                }
            }

            /// <summary>
            /// Sets a value for the game world's heat
            /// </summary>
            /// <param name="heat"></param>
            public static void SetWorldHeat(float heat)
            {
                uint addr = memory.ReadUInteger((IntPtr)Addrs.PlayerAddrs.PSTATIC_HEAT_LEVEL);
                memory.WriteFloat((IntPtr)addr + Addrs.PlayerAddrs.POINTER_HEAT_LEVEL, heat);
            }

            /// <summary>
            /// Sets the world's current rain properties
            /// </summary>
            /// <param name="rainSize"></param>
            /// <param name="intensity"></param>
            /// <param name="crossing"></param>
            /// <param name="fallSpeed"></param>
            /// <param name="gravity"></param>
            public static void SetRainProperties(float rainSize, float intensity, float crossing, float fallSpeed, float gravity)
            {
                memory.WriteFloat((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_SIZE, rainSize);
                memory.WriteFloat((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_INTENSITY, intensity);
                memory.WriteFloat((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_XING, crossing);
                memory.WriteFloat((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_FALL_SPEED, fallSpeed);
                memory.WriteFloat((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_GRAVITY, gravity);
            }

            /// <summary>
            /// Returns the world's current rain properties.
            /// </summary>
            /// <returns></returns>
            public static Dictionary<string, float> GetRainProperties()
            {
                Dictionary<string, float> dic = new Dictionary<string, float>();

                dic.Add("RainSize", memory.ReadFloat((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_SIZE));
                dic.Add("Intensity", memory.ReadFloat((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_INTENSITY));
                dic.Add("Crossing", memory.ReadFloat((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_XING));
                dic.Add("FallSpeed", memory.ReadFloat((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_FALL_SPEED));
                dic.Add("Gravity", memory.ReadFloat((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_GRAVITY));

                return dic;
            }
        }

        /// <summary>
        /// A class for the main camera in-game.
        /// </summary>
        public static class MainCamera
        {
            /// <summary>
            /// Shake the main camera.
            /// </summary>
            public static void Shake()
            {
                Function.Call(Funcs.CAMERA_SHAKE);
            }

            /// <summary>
            /// Set the visual treatment RGB values.
            /// </summary>
            /// <param name="color"></param>
            public static void SetVisualTreatmentColor(Color color)
            {
                _setVisualTreatmentRGB(color.r, color.g, color.b);
            }

            /// <summary>
            /// Set the visual treatment's amount of bloom.
            /// </summary>
            /// <param name="value"></param>
            public static void SetVisualTreatmentBloomAmount(float value)
            {
                _setVisualTreatmentBloomAmount(value);
            }

            /// <summary>
            /// Set the visual treatment's saturation.
            /// </summary>
            /// <param name="value"></param>
            public static void SetVisualTreatmentBlackBloomAmount(float value)
            {
                _setVisualTreatmentBlackBloomAmount(value);
            }

            /// <summary>
            /// Set the visual treatment's amount of black bloom.
            /// </summary>
            /// <param name="value"></param>
            public static void SetVisualTreatmentSaturation(float value)
            {
                _setVisualTreatmentSaturation(value);
            }

            internal static void _setVisualTreatmentBlackBloomAmount(float value)
            {
                int address = memory.ReadInt32((IntPtr)Addrs.CameraAddrs.PNONSTATIC_VISUAL_TREATMENT_ADDR);
                address = memory.ReadInt32((IntPtr)address + Addrs.CameraAddrs.POINTER_VISUAL_TREAT);

                memory.WriteFloat((IntPtr)address + 0xD8, value);
            }

            internal static void _setVisualTreatmentBloomAmount(float value)
            {
                int address = memory.ReadInt32((IntPtr)Addrs.CameraAddrs.PNONSTATIC_VISUAL_TREATMENT_ADDR);
                address = memory.ReadInt32((IntPtr)address + Addrs.CameraAddrs.POINTER_VISUAL_TREAT);

                memory.WriteFloat((IntPtr)address + 0xD0, value);
            }

            internal static void _setVisualTreatmentSaturation(float value)
            {
                int address = memory.ReadInt32((IntPtr)Addrs.CameraAddrs.PNONSTATIC_VISUAL_TREATMENT_ADDR);
                address = memory.ReadInt32((IntPtr)address + Addrs.CameraAddrs.POINTER_VISUAL_TREAT);

                memory.WriteFloat((IntPtr)address + 0xD4, value);
            }

            internal static void _setVisualTreatmentRGB(float r, float g, float b)
            {
                int address = memory.ReadInt32((IntPtr)Addrs.CameraAddrs.PNONSTATIC_VISUAL_TREATMENT_ADDR);
                address = memory.ReadInt32((IntPtr)address + Addrs.CameraAddrs.POINTER_VISUAL_TREAT);

                memory.WriteFloat((IntPtr)address + 0xC0, r);
                memory.WriteFloat((IntPtr)address + 0xC4, g);
                memory.WriteFloat((IntPtr)address + 0xC8, b);
            }
        }
    }

    /// <summary>
    /// The game's flow manager class.
    /// </summary>
    public class GameFlowManager
    {
        /// <summary>
        /// The address where the main GameFlowManager is located at.
        /// </summary>
        public static IntPtr address { get { return (IntPtr)Addrs.GenericAddrs.STATIC_GAME_STATE; } }

        private int gameStateValue;

        /// <summary>
        /// The main GameFlowManager.
        /// </summary>
        public static GameFlowManager TheGameFlowManager { get { return new GameFlowManager(memory.ReadInt32(address)); } }

        /// <summary>
        /// Instantiate a GameFlowManager class.
        /// </summary>
        /// <param name="gameStateValue"></param>
        private GameFlowManager(int gameStateValue)
        {
            this.gameStateValue = gameStateValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        public static implicit operator int(GameFlowManager instance)
        {
            if (instance == null)
            {
                return -1;
            }
            return instance.gameStateValue;
        }

        /// <summary>
        /// Returns the game state value string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return gameStateValue.ToString();
        }
    }
}
