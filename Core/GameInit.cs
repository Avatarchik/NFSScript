using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static NFSScript.Core.GameMemory;

namespace NFSScript.Core
{
    /// <summary>
    /// 
    /// </summary>
    public static class GameInit
    {
        /// <summary>
        /// 
        /// </summary>
        public struct ProStreet
        {
            /// <summary>
            /// 
            /// </summary>
            public static int numAICars, numPlayerCars, numLaps, numPlayerScreens, playerCar, trackNumber, raceID, turboSFX, controllerConfig, controllerConfig1, controllerConfig2,
                tractionControlLevel, stabilityControlLevel, antiLockBrakesLevel, driftAssistLevel, raceLineAssistLevel, brakingAssistLevel;

            /// <summary>
            /// 
            /// </summary>
            public static bool enableDebugActivity, autoRaceTest, practiceMode, disableSmoke;

            /// <summary>
            /// 
            /// </summary>
            public static Any playerBlueprintType, trackDirection, raceType,
                transmissionSetup, bootFlow;

            /// <summary>
            /// 
            /// </summary>
            public static void Init()
            {
                numAICars = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_NUM_AI_CARS);
                numPlayerCars = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_NUM_PLAYER_CARS);
                numLaps = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_NUM_LAPS);
                numPlayerScreens = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_NUM_PLAYER_SCREENS);
                playerCar = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_PLAYER_CAR);

                enableDebugActivity = memory.ReadBoolean((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_ENABLE_DEBUG_ACTIVITY);
                autoRaceTest = memory.ReadBoolean((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_AUTO_RACE_TEST);
                practiceMode = memory.ReadBoolean((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_PRACTICE_MODE);
                disableSmoke = memory.ReadBoolean((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_DISABLE_SMOKE);

                playerBlueprintType = memory.ReadByteArray((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_PLAYER_BLUEPRINT_TYPE, 4);
                trackDirection = memory.ReadByteArray((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_TRACK_DIRECTION, 4);
                raceType = memory.ReadByteArray((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_RACE_TYPE, 4);
                controllerConfig = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_CONTROLLER_CONFIG);
                controllerConfig = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_CONTROLLER_CONFIG);
                controllerConfig1 = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_CONTROLLER_CONFIG1);
                controllerConfig2 = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_CONTROLLER_CONFIG2);
                tractionControlLevel = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_TRACTION_CONTROL_LEVEL);
                stabilityControlLevel = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_STABILITY_CONTROL_LEVEL);
                antiLockBrakesLevel = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_ANTI_LOCK_BRAKES_LEVEL);
                driftAssistLevel = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_DRIFT_ASSIST_LEVEL);
                raceLineAssistLevel = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_RACELINE_ASSIST_LEVEL);
                brakingAssistLevel = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_BRAKING_ASSIST_LEVEL);
                transmissionSetup = memory.ReadByteArray((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_TRANSMISSION_SETUP, 4);
                bootFlow = memory.ReadByteArray((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_BOOT_FLOW, 4);
                trackNumber = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_TRACK_NUMBER);
                raceID = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_RACE_ID);
                turboSFX = memory.ReadInt32((IntPtr)ProStreetAddresses.GameAddrs.STATIC_SKIP_FE_TURBO_SFX);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public struct Undercover
        {
            /// <summary>
            /// 
            /// </summary>
            public static Any raceType, trackDirection, language, povType1, difficulty;

            /// <summary>
            /// 
            /// </summary>
            public static int numAICars, maxCops, trackNumber, numberPlayerCars, numLaps, controllerConfig2, brakeAssistLevel, tractionControlLevel, stabilityControlLevel,
                antiLockBrakesLevel, driftAssistLevel, racelineAssistLevel, raceID, missionID, player2Car, turboSFX, aiCars, parkingLotCars, parkingLotDriverClasses,
                renderTestCars, playerCar;

            /// <summary>
            /// 
            /// </summary>
            public static float renderTestSpacing, playerPerformance;

            /// <summary>
            /// 
            /// </summary>
            public static bool disableCops, helicopter, point2Point, practiceMode;

            /// <summary>
            /// 
            /// </summary>
            public static void Init()
            {
                numAICars = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_AI_CARS);
                numLaps = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_NUM_LAPS);
                playerCar = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_PLAYER_CAR);
                numberPlayerCars = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_NUM_PLAYER_CARS);
                missionID = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_MISSION_ID);
                player2Car = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_PLAYER2_CAR);
                aiCars = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_AI_CARS);
                parkingLotCars = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_PARKING_LOT_CARS);
                parkingLotDriverClasses = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_PARKING_LOT_DRIVER_CLASSES);
                renderTestCars = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_RENDER_TEST_CARS);
                maxCops = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_MAX_COPS);

                disableCops = memory.ReadBoolean((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_DISABLE_COPS);
                helicopter = memory.ReadBoolean((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_HELICOPTER);
                point2Point = memory.ReadBoolean((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_POINT_2_POINT);
                practiceMode = memory.ReadBoolean((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_PRACTICE_MODE);

                trackDirection = memory.ReadByteArray((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_TRACK_DIRECTION, 4);
                raceType = memory.ReadByteArray((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_RACE_TYPE, 4);
                controllerConfig2 = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_CONTROLLER_CONFIG2);
                tractionControlLevel = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_TRACTION_CONTROL_LEVEL);
                stabilityControlLevel = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_STABILITY_CONTROL_LEVEL);
                antiLockBrakesLevel = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_ANTI_LOCK_BRAKES_LEVEL);
                driftAssistLevel = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_DRIFT_ASSIST_LEVEL);
                trackNumber = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_TRACK_NUMBER);
                raceID = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_RACE_ID);
                turboSFX = memory.ReadInt32((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_TURBO_SFX);

                renderTestSpacing = memory.ReadFloat((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_RENDER_TEST_SPACING);
                playerPerformance = memory.ReadFloat((IntPtr)UndercoverAddresses.GameAddrs.STATIC_SKIP_FE_PLAYER_PERFORMANCE);
            }
        }
    }
}
