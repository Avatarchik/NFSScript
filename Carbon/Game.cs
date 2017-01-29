using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.CarbonAddresses;
using static NFSScript.CarbonFunctions;
using NFSScript.Math;

namespace NFSScript.Carbon
{
    /// <summary>
    /// A class that represents the main game manager.
    /// </summary>
    public static class Game
    {
        #region Constant Variables
        private const int SOUND_ID = 0x1;
        private const int AUDIO_STREAMING_ID = 0x2;
        private const int SPEECH_ID = 0x3;
        private const int NIS_AUDIO_ID = 0x4;

        private const int DRAW_RACE_CAR_ADDR = 0x1;
        private const int DRAW_HELI_ADDR = 0x2;
        private const int DRAW_COP_CAR_ADDR = 0x3;
        private const int DRAW_TRAFFIC_ADDR = 0x4;
        private const int DRAW_NIS_CAR_ADDR = 0x5;

        /// <summary>
        /// The ID for the DrawRaceCar constructor pointer.
        /// </summary>
        public const int DRAW_RACE_CAR_POINTER_ID = 0x1;

        /// <summary>
        /// The ID for DrawHeli constructor pointer.
        /// </summary>
        public const int DRAW_HELI_POINTER_ID = 0x2;

        /// <summary>
        /// The ID for DrawCopCar constructor pointer.
        /// </summary>
        public const int DRAW_COP_CAR_POINTER_ID = 0x3;

        /// <summary>
        /// The ID for DrawTraffic constructor pointer.
        /// </summary>
        public const int DRAW_TRAFFIC_POINTER_ID = 0x4;

        /// <summary>
        /// The ID for DrawNISCar constructor pointer.
        /// </summary>
        public const int DRAW_NIS_CAR_POINTER_ID = 0x5;
        #endregion

        private static float sirensIntensityR = 1, sirensIntensityB = 1, sirensIntensityW = 1;

        /// <summary>
        /// Returns the save game directory path.
        /// </summary>
        public static string saveDirectory { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NFS Carbon"); } }

        /// <summary>
        /// Returns a value that indicates whether the sirens are enabled in or not.
        /// </summary>
        public static bool sirensEnabled { get; private set; }

        /// <summary>
        /// Returns the game's run time in seconds.
        /// </summary>
        public static float runTime
        {
            get
            {
                return memory.ReadFloat((IntPtr)Addrs.GenericAddrs.STATIC_RUN_TIME);
            }
        }

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
        /// Returns the amount of seconds it takes to render a frame. (Might be inaccurate)
        /// </summary>
        public static float lastFrameTime
        {
            get
            {
                return memory.ReadFloat((IntPtr)Addrs.GenericAddrs.STATIC_LAST_FRAME_TIME);
            }
        }

        /// <summary>
        /// Returns true if the gameplay is currently active.
        /// </summary>
        public static bool isGameplayActive
        {
            get
            {               
                return memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_GAMEPLAY_ACTIVE) == 1;
            }
        }        

        /// <summary>
        /// Returns true if there is an ongoing activity/race.
        /// </summary>
        public static bool isActivityActive
        {
            get
            {
                return memory.ReadByte((IntPtr)Addrs.GameAddrs.STATIC_IS_ACTIVITY_MODE) == 1;
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
        /// Is memcard versioning enabled?
        /// </summary>
        public static bool isMemcardVersioningEnabled
        {
            get
            {
                return memory.ReadBoolean((IntPtr)Addrs.GenericAddrs.STATIC_IS_MEMCARD_VERSIONING_ENABLED);
            }
        }

        /// <summary>
        /// Returns a boolean that indicates whether it's the collectors edition of the game or not.
        /// </summary>
        public static bool isCollectorsEdition
        {
            get
            {
                return memory.ReadBoolean((IntPtr)Addrs.GenericAddrs.STATIC_IS_COLLECTORS_EDITION);
            }
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
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static void EnableRightStickInFrontend(bool value)
        {
            memory.WriteBoolean((IntPtr)Addrs.GenericAddrs.STATIC_ENABLE_RIGHT_STICK_IN_FRONTEND, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static void gDebugEventStrings(bool value)
        {
            memory.WriteBoolean((IntPtr)Addrs.GenericAddrs.STATIC_GDEBUG_EVENT_STRINGS, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static void bRumbleEnabled(bool value)
        {
            memory.WriteBoolean((IntPtr)Addrs.GenericAddrs.STATIC_B_RUMBLE_ENABLED, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static void PrecipitationEnable(bool value)
        {
            memory.WriteBoolean((IntPtr)Addrs.GenericAddrs.STATIC_PRECIPITATION_ENABLE, value);
        }

        /// <summary>
        /// Enable debug car customize.
        /// </summary>
        /// <param name="value"></param>
        public static void EnableDebugCarCustomize(bool value)
        {
            memory.WriteBoolean((IntPtr)Addrs.GameAddrs.STATIC_ENABLE_DEBUG_CAR_CUSTOMIZE, value);
        }

        /// <summary>
        /// Changes to the next untuned preset in a specific order on debug car customize.
        /// </summary>
        public static void DebugVehicleSelection()
        {
            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_DEBUG_VEHICLE_SELECTION, 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static void DoScreenPrintf(bool value)
        {
            memory.WriteBoolean((IntPtr)Addrs.GenericAddrs.STATIC_DO_SCREEN_PRINTF, value);
        }

        /// <summary>
        /// Calls the DrawHeli constructor for every set ID present in the game's world.
        /// </summary>
        /// <param name="id">The constructor ID.</param>
        public static void DrawHeli(int id)
        {
            _setConstructorRaceCarPointerValue(id, DRAW_HELI_POINTER_ID);
        }

        /// <summary>
        /// Calls the DrawRaceCar constructor for every set ID present in the world.
        /// </summary>
        /// <param name="id">The constructor ID.</param>
        public static void DrawRaceCar(int id)
        {
            _setConstructorRaceCarPointerValue(id, DRAW_RACE_CAR_POINTER_ID);
        }

        /// <summary>
        /// Calls the DrawCopCar constructor for every set ID present in the world.
        /// </summary>
        /// <param name="id">The constructor ID.</param>
        public static void DrawCopCar(int id)
        {
            _setConstructorRaceCarPointerValue(id, DRAW_COP_CAR_POINTER_ID);
        }

        /// <summary>
        /// Calls the DrawNISCar constructor for every set ID present in the world.
        /// </summary>
        /// <param name="id">The constructor ID.</param>
        public static void DrawNISCar(int id)
        {
            _setConstructorRaceCarPointerValue(id, DRAW_NIS_CAR_POINTER_ID);
        }

        /// <summary>
        /// Calls the DrawTraffic constructor for every set ID present in the world.
        /// </summary>
        /// <param name="id">The constructor ID.</param>
        public static void DrawTraffic(int id)
        {
            _setConstructorRaceCarPointerValue(id, DRAW_TRAFFIC_POINTER_ID);

        }

        /// <summary>
        /// Should the game skip movies?
        /// </summary>
        /// <param name="value"></param>
        public static void SkipMovies(bool value)
        {
            memory.WriteBoolean((IntPtr)Addrs.GenericAddrs.STATIC_SKIP_MOVIES, value);
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
        /// Sets a value for the game world's heat
        /// </summary>
        /// <param name="heat"></param>
        public static void SetWorldHeat(float heat)
        {
            uint addr = memory.ReadUInteger((IntPtr)Addrs.PlayerAddrs.PSTATIC_PLAYER_HEAT_LEVEL);
            memory.WriteFloat((IntPtr)addr + Addrs.PlayerAddrs.POINTER_PLAYER_HEAT_LEVEL, heat - 0.001f);
        }

        /// <summary>
        /// Returns the game world's heat
        /// </summary>
        /// <returns></returns>
        public static float GetWorldHeat()
        {
            uint addr = memory.ReadUInteger((IntPtr)Addrs.PlayerAddrs.PSTATIC_PLAYER_HEAT_LEVEL);
            return memory.ReadFloat((IntPtr)addr + Addrs.PlayerAddrs.POINTER_PLAYER_HEAT_LEVEL);
        }

        /// <summary>
        /// Set a value that decides whether cops are enabled in the game or not.
        /// </summary>
        /// <param name="isEnabled"></param>
        public static void SetCopsEnabled(bool isEnabled)
        {
            Function.Call(SET_COPS_ENABLED, isEnabled);
        }

        /// <summary>
        /// Bails the current pursuit.
        /// </summary>
        public static void BailPursuit()
        {
            Function.Call(BAIL_PURSUIT);
        }

        /// <summary>
        /// Forces a pursuit to start.
        /// </summary>
        public static void ForcePursuitStart()
        {
            Function.Call(FORCE_PURSUIT_START);
        }

        /// <summary>
        /// No more new pursuits or cops.
        /// </summary>
        public static void NoNewPursuitsOrCops()
        {
            Function.Call(NO_NEW_PURSUITS_OR_COPS);
        }

        /// <summary>
        /// Abandons the race.
        /// </summary>
        public static void AbandonRace()
        {
            Function.Call(ABANDON_RACE);
        }

        /// <summary>
        /// Shakes the camera.
        /// </summary>
        public static void CameraShake()
        {
            Function.Call(CAMERA_SHAKE);
        }

        /// <summary>
        /// Starts a race from in-game.
        /// </summary>
        /// <param name="raceID">The race ID to start.</param>
        public static void StartRaceFromInGame(string raceID)
        {
            Function.Call(START_RACE_FROM_IN_GAME, raceID);
        }

        /// <summary>
        /// Jumps to a safehouse.
        /// </summary>
        public static void JumpToSafeHouse()
        {
            Function.Call(JUMP_TO_SAFE_HOUSE);
        }

        /// <summary>
        /// Jumps to a car lot.
        /// </summary>
        public static void JumpToCarLot()
        {
            Function.Call(JUMP_TO_CAR_LOT);
        }

        /// <summary>
        /// Jumps to a new wingman.
        /// </summary>
        public static void JumpToNewWingman()
        {
            Function.Call(JUMP_TO_NEW_WING_MAN);
        }

        /// <summary>
        /// Activates drift mode.
        /// </summary>
        public static void ActivateDriftMode()
        {
            Function.Call(ACTIVATE_DRIFT_MODE);
        }

        /// <summary>
        /// Deactivates drift mode.
        /// </summary>
        public static void DeactivateDriftMode()
        {
            Function.Call(DEACTIVATE_DRIFT_MODE);
        }

        /// <summary>
        /// Set the police lights intensity for the cars present in the world.
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
        /// Skips the frontend values with a custom set of values. Keep in mind that on every gameplay change (Going to the safehouse) the SkipFE gets disabled and must be recalled again.
        /// </summary>
        /// <param name="enabled"></param>
        public static void SkipFE(bool enabled)
        {
            memory.WriteBoolean((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_ENABLED, enabled);
        }

        /// <summary>
        /// Returns the current activity ID.
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentActivityID()
        {
            return Encoding.Default.GetString(memory.ReadByteArray((IntPtr)Addrs.GameAddrs.STATIC_ACTIVITY_ID, 106).Where(b => b != 0x00).ToArray());
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
            if(value) b = 1;
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

        internal static void _setConstructorRaceCarPointerValue(int id, int pointer)
        {
            int p = 0;
            switch (pointer)
            {
                case DRAW_RACE_CAR_POINTER_ID:
                    p = Addrs.GameAddrs.STATIC_CONSTRUCTOR_DRAW_RACE_CAR;
                    break;

                case DRAW_HELI_POINTER_ID:
                    p = Addrs.GameAddrs.STATIC_CONSTRUCTOR_DRAW_HELI;
                    break;

                case DRAW_COP_CAR_POINTER_ID:
                    p = Addrs.GameAddrs.STATIC_CONSTRUCTOR_DRAW_COP_CAR;
                    break;

                case DRAW_TRAFFIC_POINTER_ID:
                    p = Addrs.GameAddrs.STATIC_CONSTRUCTOR_DRAW_TRAFFIC;
                    break;

                case DRAW_NIS_CAR_POINTER_ID:
                    p = Addrs.GameAddrs.STATIC_CONSTRUCTOR_DRAW_NIS_CAR;
                    break;
            }

            IntPtr addr = IntPtr.Zero;
            switch (id)
            {
                case DRAW_RACE_CAR_ADDR:
                    addr = (IntPtr)Addrs.GameAddrs.STATIC_CONSTRUCTOR_POINTER_CALL_DRAW_RACER_CAR;
                    break;

                case DRAW_HELI_ADDR:
                    addr = (IntPtr)Addrs.GameAddrs.STATIC_CONSTRUCTOR_POINTER_CALL_DRAW_HELI;
                    break;

                case DRAW_COP_CAR_ADDR:
                    addr = (IntPtr)Addrs.GameAddrs.STATIC_CONSTRUCTOR_POINTER_CALL_DRAW_COP_CAR;
                    break;

                case DRAW_TRAFFIC_ADDR:
                    addr = (IntPtr)Addrs.GameAddrs.STATIC_CONSTRUCTOR_POINTER_CALL_DRAW_TRAFFIC;
                    break;

                case DRAW_NIS_CAR_ADDR:
                    addr = (IntPtr)Addrs.GameAddrs.STATIC_CONSTRUCTOR_DRAW_NIS_CAR;
                    break;
            }

            memory.WriteInt32(addr, p);
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
        /// A class that represents the game's world
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
            /// Sets a value that indicates whether it should always rain.
            /// </summary>
            public static bool alwaysRain
            {
                get
                {
                    byte b = memory.ReadByte((IntPtr)Addrs.WorldAddrs.STATIC_ALWAYS_RAIN);
                    if (b == 1)
                        return true;
                    else return false;
                }
                set
                {
                    if (value)
                        memory.WriteByte((IntPtr)Addrs.WorldAddrs.STATIC_ALWAYS_RAIN, 1);
                    else memory.WriteByte((IntPtr)Addrs.WorldAddrs.STATIC_ALWAYS_RAIN, 0);
                }
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
            /// Enable fog.
            /// </summary>
            public static void EnableFog()
            {
                memory.WriteByte((IntPtr)Addrs.WorldAddrs.STATIC_FOG, 1);
            }

            /// <summary>
            /// Disable fog.
            /// </summary>
            public static void DisableFog()
            {
                memory.WriteByte((IntPtr)Addrs.WorldAddrs.STATIC_FOG, 0);
            }

            /// <summary>
            /// Sets a value that indicates whether rainy road reflections are enabled.
            /// </summary>
            public static bool rainyRoadReflections
            {
                get
                {
                    byte b = memory.ReadByte((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_ROAD_REFLECTION);
                    if (b == 1)
                        return true;
                    else return false;
                }
                set
                {
                    if (value)
                        memory.WriteByte((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_ROAD_REFLECTION, 1);
                    else memory.WriteByte((IntPtr)Addrs.WorldAddrs.STATIC_RAIN_ROAD_REFLECTION, 0);
                }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static void TimeOfDaySwapEnable(bool value)
            {
                byte b = 0;
                if(value) b = 1;

                memory.WriteByte((IntPtr)Addrs.WorldAddrs.STATIC_TIME_OF_DAY_SWAP_ENABLE, b);
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
        /// A class that represents the game's race manager
        /// </summary>
        public static class RacesManager
        {
            /// <summary>
            /// Maximum Drift Multiplier for Track (Circuit) Drifts. (Default value is 10)
            /// </summary>
            public static byte MaximumTrackDriftMultiplier
            {
                get
                {
                    return memory.ReadByte((IntPtr)Addrs.RaceAddrs.STATIC_MAX_DRIFT_MULTIPLIER_TRACK);
                }
                set
                {
                    memory.WriteByte((IntPtr)Addrs.RaceAddrs.STATIC_MAX_DRIFT_MULTIPLIER_TRACK, value);
                }
            }

            /// <summary>
            /// Maximum Drift Multiplier for Canyon (Sprint) Drifts. (Default value is 20)
            /// </summary>
            public static byte MaximumCanyonDriftMultiplier
            {
                get
                {
                    return memory.ReadByte((IntPtr)Addrs.RaceAddrs.STATIC_MAX_DRIFT_MULTIPLIER_CANYON);
                }
                set
                {
                    memory.WriteByte((IntPtr)Addrs.RaceAddrs.STATIC_MAX_DRIFT_MULTIPLIER_CANYON, value);
                    memory.WriteByte((IntPtr)Addrs.RaceAddrs.STATIC_MAX_DRIFT_MULTIPLIER_CANYON2, value);
                }
            }

            /// <summary>
            /// Set if the player should win the race regardless of the player's or his wingman finishing position.
            /// </summary>
            /// <param name="enabled"></param>
            public static void SetPlayerAlwaysWin(bool enabled)
            {
                if (enabled)
                {
                    memory.WriteUInteger((IntPtr)Addrs.RaceAddrs.STATIC_PLAYER_ALWAYS_WIN_ADDR_1, 0x90900134);
                    memory.WriteInteger((IntPtr)Addrs.RaceAddrs.STATIC_PLAYER_ALWAYS_WIN_ADDR_2, 0x13EBC084);
                    memory.WriteUInteger((IntPtr)Addrs.RaceAddrs.STATIC_PLAYER_ALWAYS_WIN_ADDR_3, 0x9001347F);
                    memory.WriteUInteger((IntPtr)Addrs.RaceAddrs.STATIC_PLAYER_ALWAYS_WIN_ADDR_4, 0x90909090);
                    memory.WriteUInteger((IntPtr)Addrs.RaceAddrs.STATIC_PLAYER_ALWAYS_WIN_ADDR_5, 0xC8878A90);
                }
                else if (!enabled)
                {
                    memory.WriteInteger((IntPtr)Addrs.RaceAddrs.STATIC_PLAYER_ALWAYS_WIN_ADDR_1, 0x40750134);
                    memory.WriteInteger((IntPtr)Addrs.RaceAddrs.STATIC_PLAYER_ALWAYS_WIN_ADDR_2, 0x1374C084);
                    memory.WriteInteger((IntPtr)Addrs.RaceAddrs.STATIC_PLAYER_ALWAYS_WIN_ADDR_3, 0xF01347F);
                    memory.WriteInteger((IntPtr)Addrs.RaceAddrs.STATIC_PLAYER_ALWAYS_WIN_ADDR_4, 0x24BB5);
                    memory.WriteUInteger((IntPtr)Addrs.RaceAddrs.STATIC_PLAYER_ALWAYS_WIN_ADDR_5, 0xC8878A00);
                }
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
