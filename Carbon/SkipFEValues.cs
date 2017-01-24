using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;

namespace NFSScript.Carbon
{
    /// <summary>
    /// A class for the game's "Skip Frontend" functions and values.
    /// </summary>
    public class SkipFEValues
    {
        /// <summary>
        /// The max amount of cops.
        /// </summary>
        public int maxCops;

        /// <summary>
        /// A boolean that indicates whether traffic is disabled or not.
        /// </summary>
        public bool disableTraffic;

        /// <summary>
        /// Number of AI cars.
        /// </summary>
        public int numberOfAICars;

        /// <summary>
        /// A boolean that indicates whether AI controls the player or not.
        /// </summary>
        public bool aiControlPlayer;

         /// <summary>
        /// A boolean that indicates whether a wingman is present or not.
        /// </summary>
        public bool noWingMan;

        /// <summary>
        /// Player Performance.
        /// </summary>
        public float playerPerformance;

        /// <summary>
        /// A boolean that indicates whether the cops are disabled or not.
        /// </summary>
        public bool copsDisabled;

        /// <summary>
        /// Track number.
        /// </summary>
        public int trackNumber;

        /// <summary>
        /// A boolean thatindicates whether the traffic is disabled or not.
        /// </summary>
        public bool trafficDisabled;

        /// <summary>
        /// The number of cops.
        /// </summary>
        public int numberOfCops;

        /// <summary>
        /// Point 2 Point.
        /// </summary>
        public byte point2Point;

        /// <summary>
        /// The race type.
        /// </summary>
        public int raceType;

        /// <summary>
        /// The race ID.
        /// </summary>
        public int raceID;

        /// <summary>
        /// The number of player cars.
        /// </summary>
        public int numberPlayerCars;

        /// <summary>
        /// The number of laps.
        /// </summary>
        public int numberOfLaps;

        /// <summary>
        /// Traffic oncoming.
        /// </summary>
        public int trafficOncoming;

        /// <summary>
        /// A boolean that indicates whether damage is enabled or not.
        /// </summary>
        public bool damageEnabled;

        /// <summary>
        /// Traffic density.
        /// </summary>
        public float trafficDensity;

        /// <summary>
        /// An unsafe value.
        /// </summary>
        public bool _unsafeHelicopter;

        /// <summary>
        /// An unsafe value.
        /// </summary>
        public byte _unsafeSplitScreen;

        /// <summary>
        /// Player's car address as an integer.
        /// </summary>
        public int playerCar;

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
        /// Instantiate a new SkipFEValues class.
        /// </summary>
        public SkipFEValues()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {  
            _unsafeSplitScreen = 0;
            playerPerformance = 0;
            numberOfAICars = 0;
            copsDisabled = true;
            numberOfCops = 0;
            trafficDisabled = false;
            point2Point = 0;
            raceType = 0;
            noWingMan = false;
            aiControlPlayer = false;
            trackNumber = 5000;
            raceID = 10232980;
            numberPlayerCars = 1;
            numberOfLaps = 2;
            trafficOncoming = 1056964608;
            damageEnabled = true;
            trafficDensity = 0;
            playerCar = 10232980;
        }

        /// <summary>
        /// Set the player's car.
        /// </summary>
        /// <param name="carAddress"></param>
        public void SetPlayerCar(CarAddress carAddress)
        {
            playerCar = (int)carAddress;
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
