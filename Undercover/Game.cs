﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.UndercoverAddresses;
using static NFSScript.UndercoverFunctions;
using NFSScript.Math;

namespace NFSScript.Undercover
{
    /// <summary>
    ///  A struct that represents the main game manager.
    /// </summary>
    public static class Game
    {
        private const int SOUND_ID = 0x1;
        private const int AUDIO_STREAMING_ID = 0x2;
        private const int SPEECH_ID = 0x3;
        private const int NIS_AUDIO_ID = 0x4;

        /// <summary>
        /// Returns the save game directory path.
        /// </summary>
        public static string saveDirectory { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NFS Undercover"); } }

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
        /// Returns a boolean that indicates whether the game is paused or not.
        /// </summary>
        public static bool isGamePaused
        {
            get
            {
                byte b = memory.ReadByte((IntPtr)Addrs.GameAddrs.STATIC_IS_GAME_NOT_PAUSED);
                if (b == 0)
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
        /// Skips the frontend values with a custom set of values. Keep in mind that on every gameplay change (Entering the car lot) the SkipFE gets disabled and must be recalled again.
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
        /// Skips the frontend and set the values from the defined SkipFEValues class to the game's SkipFE values. Keep in mind that on every gameplay change (Entering the car lot) the SkipFE gets disabled and must be recalled again.
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
        /// Forces the current pursuit to end.
        /// </summary>
        public static void ForceEndPursuit()
        {
            Function.Call(FORCE_PURSUIT_END);
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
        /// Restarts the current mission.
        /// </summary>
        public static void RestartMission()
        {
            Function.Call(E_RESTART_MISSION);
        }

        /// <summary>
        /// Ends the current mission.
        /// </summary>
        public static void EndMission()
        {
            Function.Call(END_MISSION);
        }

        /// <summary>
        /// Calls the spotted helicopter cam event.
        /// </summary>
        public static void HeliCopCam()
        {
            Function.Call(CAMERA_HELI_COP_CAM);
        }

        /// <summary>
        /// Shakes the camera.
        /// </summary>
        public static void CameraShake()
        {
            Function.Call(CAMERA_SHAKE);
        }

        /// <summary>
        /// Start a race from in-game.
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
            byte bDisableCops = 0, bHelicopter = 0, bPoint2Point = 0, bPracticeMode = 0;

            if (skipFEValues.disableCops)
                bDisableCops = 1;
            if (skipFEValues.helicopter)
                bHelicopter = 1;
            if (skipFEValues.point2Point)
                bPoint2Point = 1;
            if (skipFEValues.practiceMode)
                bPracticeMode = 1;

            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_DISABLE_COPS, bDisableCops);
            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_HELICOPTER, bHelicopter);
            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_POINT_2_POINT, bPoint2Point);
            memory.WriteByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_PRACTICE_MODE, bPracticeMode);

            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_NUM_AI_CARS, skipFEValues.aiCars);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_MAX_COPS, skipFEValues.maxCops);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_TRACK_NUMBER, skipFEValues.trackNumber);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_NUM_PLAYER_CARS, skipFEValues.numberPlayerCars);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_NUM_LAPS, skipFEValues.numLaps);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_CONTROLLER_CONFIG2, skipFEValues.controllerConfig2);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_BRAKE_ASSIST_LEVEL, skipFEValues.brakeAssistLevel);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_TRACTION_CONTROL_LEVEL, skipFEValues.tractionControlLevel);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_STABILITY_CONTROL_LEVEL, skipFEValues.stabilityControlLevel);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_ANTI_LOCK_BRAKES_LEVEL, skipFEValues.antiLockBrakesLevel);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_DRIFT_ASSIST_LEVEL, skipFEValues.driftAssistLevel);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_RACELINE_ASSIST_LEVEL, skipFEValues.racelineAssistLevel);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_RACE_ID, skipFEValues.raceID);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_MISSION_ID, skipFEValues.missionID);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_PLAYER2_CAR, skipFEValues.player2Car);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_TURBO_SFX, skipFEValues.turboSFX);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_AI_CARS, skipFEValues.aiCars);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_PARKING_LOT_CARS, skipFEValues.parkingLotCars);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_PARKING_LOT_DRIVER_CLASSES, skipFEValues.parkingLotDriverClasses);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_RENDER_TEST_CARS, skipFEValues.renderTestCars);
            memory.WriteInt32((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_PLAYER_CAR, skipFEValues.playerCar);

            memory.WriteFloat((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_RENDER_TEST_SPACING, skipFEValues.renderTestSpacing);
            memory.WriteFloat((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_PLAYER_PERFORMANCE, skipFEValues.playerPerformance);            
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

        /// <summary>
        /// Returns a string with a length of 27 which contains the latest entered code (If the player has entered any).
        /// </summary>
        /// <returns></returns>
        public static string GetSecretCodeField()
        {
            return memory.ReadStringASCII((IntPtr)Addrs.GameAddrs.STATIC_GET_SECRET_CODE_FIELD, 27);
        }
    }
}
