using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Core;
using UC = NFSScript.Core.GameInit.Undercover;
namespace NFSScript.Undercover
{
    /// <summary>
    /// A class for the game's "Skip Frontend" functions and values.
    /// </summary>
    public class SkipFEValues
    {
        /// <summary>
        /// Race type.
        /// </summary>
        public Any raceType;

        /// <summary>
        /// Track direction.
        /// </summary>
        public Any trackDirection;

        /// <summary>
        /// Language.
        /// </summary>
        public Any language;

        /// <summary>
        /// 
        /// </summary>
        public Any povType1;

        /// <summary>
        /// Difficulty
        /// </summary>
        public Any difficulty;

        /// <summary>
        /// Number of AI cars.
        /// </summary>
        public int numAICars;

        /// <summary>
        /// Max amount of cops.
        /// </summary>
        public int maxCops;

        /// <summary>
        /// Track number.
        /// </summary>
        public int trackNumber;

        /// <summary>
        /// 
        /// </summary>
        public int numberPlayerCars;

        /// <summary>
        /// Number of laps.
        /// </summary>
        public int numLaps;

        /// <summary>
        /// 
        /// </summary>
        public int controllerConfig2;

        /// <summary>
        /// 
        /// </summary>
        public int brakeAssistLevel;

        /// <summary>
        /// 
        /// </summary>
        public int tractionControlLevel;

        /// <summary>
        /// 
        /// </summary>
        public int stabilityControlLevel;

        /// <summary>
        /// 
        /// </summary>
        public int antiLockBrakesLevel;

        /// <summary>
        /// 
        /// </summary>
        public int driftAssistLevel;

        /// <summary>
        /// 
        /// </summary>
        public int racelineAssistLevel;

        /// <summary>
        /// Race ID.
        /// </summary>
        public int raceID;

        /// <summary>
        /// Mission ID.
        /// </summary>
        public int missionID;

        /// <summary>
        /// 
        /// </summary>
        public int player2Car;

        /// <summary>
        /// 
        /// </summary>
        public int turboSFX;

        /// <summary>
        /// 
        /// </summary>
        public int aiCars;

        /// <summary>
        /// 
        /// </summary>
        public int parkingLotCars;

        /// <summary>
        /// 
        /// </summary>
        public int parkingLotDriverClasses;

        /// <summary>
        /// 
        /// </summary>
        public int renderTestCars;

        /// <summary>
        /// 
        /// </summary>
        public int playerCar;

        /// <summary>
        /// 
        /// </summary>
        public float renderTestSpacing;

        /// <summary>
        /// 
        /// </summary>
        public float playerPerformance;

        /// <summary>
        /// 
        /// </summary>
        public bool disableCops;

        /// <summary>
        /// 
        /// </summary>
        public bool helicopter;

        /// <summary>
        /// 
        /// </summary>
        public bool point2Point;

        /// <summary>
        /// 
        /// </summary>
        public bool practiceMode;

        /// <summary>
        /// Returns the SkipFE player's car handle.
        /// </summary>
        /// <returns></returns>
        public IntPtr PlayerCarHandle
        {
            get
            {
                return new IntPtr(playerCar);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetDefaults()
        {
            raceType = UC.raceType;
            trackDirection = UC.trackDirection;
            language = UC.language;
            povType1 = UC.povType1;
            difficulty = UC.difficulty;
            numAICars = UC.numAICars;
            maxCops = UC.maxCops;
            trackNumber = UC.trackNumber;
            numberPlayerCars = UC.numberPlayerCars;
            numLaps = UC.numLaps;
            controllerConfig2 = UC.controllerConfig2;
            brakeAssistLevel = UC.brakeAssistLevel;
            tractionControlLevel = UC.tractionControlLevel;
            stabilityControlLevel = UC.stabilityControlLevel;
            antiLockBrakesLevel = UC.antiLockBrakesLevel;
            driftAssistLevel = UC.driftAssistLevel;
            racelineAssistLevel = UC.racelineAssistLevel;
            raceID = UC.raceID;
            missionID = UC.missionID;
            player2Car = UC.player2Car;
            turboSFX = UC.turboSFX;
            aiCars = UC.aiCars;
            parkingLotCars = UC.parkingLotCars;
            parkingLotDriverClasses = UC.parkingLotDriverClasses;
            renderTestCars = UC.renderTestCars;
            playerCar = UC.playerCar;
            disableCops = UC.disableCops;
            helicopter = UC.helicopter;
            point2Point = UC.point2Point;
            practiceMode = UC.practiceMode;
        }

        /// <summary>
        /// Instantiate a new SkipFEValues class.
        /// </summary>
        public SkipFEValues()
        {
            SetDefaults();
        }

        /// <summary>
        /// Set the player's car.
        /// </summary>
        /// <param name="carAddress"></param>
        public void SetPlayerCar(int carAddress)
        {
            playerCar = carAddress;
        }
    }
}
