using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Core;
using PS = NFSScript.Core.GameInit.ProStreet;
namespace NFSScript.ProStreet
{
    /// <summary>
    /// A class for the game's "Skip Frontend" functions and values.
    /// </summary>
    public class SkipFEValues
    {
        /// <summary>
        /// Player's blueprint type.
        /// </summary>
        public Any playerBlueprintType;

        /// <summary>
        /// 
        /// </summary>
        public Any trackDirection;

        /// <summary>
        /// 
        /// </summary>
        public int numAICars;

        /// <summary>
        /// 
        /// </summary>
        public Any raceType;

        /// <summary>
        /// 
        /// </summary>
        public bool enableDebugActivity;

        /// <summary>
        /// 
        /// </summary>
        public bool autoRaceTest;

        /// <summary>
        /// 
        /// </summary>
        public bool practiceMode;

        /// <summary>
        /// 
        /// </summary>
        public Any controllerConfig;

        /// <summary>
        /// 
        /// </summary>
        public bool disableSmoke;

        /// <summary>
        /// 
        /// </summary>
        public int numPlayerCars;

        /// <summary>
        /// 
        /// </summary>
        public int numLaps;

        /// <summary>
        /// 
        /// </summary>
        public int controllerConfig1, controllerConfig2;

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
        public int raceLineAssistLevel;

        /// <summary>
        /// 
        /// </summary>
        public int brakingAssistLevel;

        /// <summary>
        /// 
        /// </summary>
        public int numPlayerScreens;

        /// <summary>
        /// 
        /// </summary>
        public Any transmissionSetup;

        /// <summary>
        /// 
        /// </summary>
        public Any bootFlow;

        /// <summary>
        /// 
        /// </summary>
        public int trackNumber;

        /// <summary>
        /// 
        /// </summary>
        public int raceID;

        /// <summary>
        /// 
        /// </summary>
        public int playerCar;

        /// <summary>
        /// 
        /// </summary>
        public int turboSFX;

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

        private void SetDefaults()
        {
            numAICars = PS.numAICars;
            numPlayerCars = PS.numPlayerCars;
            numLaps = PS.numLaps;
            numPlayerScreens = PS.numPlayerScreens;
            playerCar = PS.playerCar;
            enableDebugActivity = PS.enableDebugActivity;
            autoRaceTest = PS.autoRaceTest;
            practiceMode = PS.practiceMode;
            disableSmoke = PS.disableSmoke;
            playerBlueprintType = PS.playerBlueprintType;
            trackDirection = PS.trackDirection;
            raceType = PS.raceType;
            controllerConfig = PS.controllerConfig;
            controllerConfig1 = PS.controllerConfig1;
            controllerConfig2 = PS.controllerConfig2;
            tractionControlLevel = PS.tractionControlLevel;
            stabilityControlLevel = PS.stabilityControlLevel;
            antiLockBrakesLevel = PS.antiLockBrakesLevel;
            driftAssistLevel = PS.driftAssistLevel;
            raceLineAssistLevel = PS.raceLineAssistLevel;
            brakingAssistLevel = PS.brakingAssistLevel;
            transmissionSetup = PS.transmissionSetup;
            bootFlow = PS.bootFlow;
            trackNumber = PS.trackNumber;
            raceID = PS.raceID;
            turboSFX = PS.turboSFX;
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
