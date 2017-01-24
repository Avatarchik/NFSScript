using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFSScript.Undercover
{
    /// <summary>
    /// A class for secret codes in the game.
    /// </summary>
    public static class SecretCodes
    {
        /// <summary>
        /// The cheat code string for $10,000.
        /// </summary>
        public const string TEN_THOUSAND_DOLLARS = "%%$3/\"";

        /// <summary>
        /// The cheat code string for Die-Cast Lexus IS F bonus car.
        /// </summary>
        public const string DIECAST_LEXUS_IS_F_BONUS_CAR = "0;6,2;";

        /// <summary>
        /// The cheat code string for Die-Cast Nissan 240SX (S13) bonus car.
        /// </summary>
        public const string DIECAST_NISSAN_240SX_BONUS_CAR = "@/;#/+";

        /// <summary>
        /// The cheat code string for Die-Cast Volkwagen R32 bonus car.
        /// </summary>
        public const string DIECAST_VOLKWAGEN_R32_BONUS_CAR = "!3/$\"):";

        /// <summary>
        /// The cheat code string for NeedforSpeed.com Lotus Elise bonus car.
        /// </summary>
        public const string NEED_FOR_SPEED_DOT_COM_LOTUS_ELISE_BONUS_CAR = "-KJ3=E";

        /// <summary>
        /// The cheat code string for $15,000 money from T-Mobile.
        /// </summary>
        public const string FIFTEEN_THOSAND_DOLLARS_FROM_T_MOBILE = "S1D3K1CK";

        /// <summary>
        /// The cheat code string for Die-Cast Audi R8 Bonus Car.
        /// </summary>
        public const string UNLOCK_DIECAST_AUDI_R8_BONUS_CAR = ")B7@B=";

        /// <summary>
        /// The cheat code string for Die-Cast Camaro Concept Bonus Car.
        /// </summary>
        public const string UNLOCK_DIECAST_CAMARO_CONCEPT_BONUS_CAR = "!K?MMF0";

        /// <summary>
        /// The cheat code string for Die-Cast Dodge Charger Bonus Car.
        /// </summary>
        public const string UNLOCK_DIECAST_DODGE_CHARGET_BONUS_CAR = "qlcukc4bqm";

        /// <summary>
        /// The cheat code string for Die-Cast Dodge Viper SRT10 Bonus Car.
        /// </summary>
        public const string UNLOCK_DIECAST_DODGE_VIPER_SRT10_BONUS_CAR = "!C6;C>E";

        /// <summary>
        /// The cheat code string for Die-Cast GT-R Police Bonus Car.
        /// </summary>
        public const string UNLOCK_DIECAST_GTR_POLICE_BONUS_CAR = "\"90=*6@";

        /// <summary>
        /// The cheat code string for Die-Cast Mitsubishi Lancer Bonus Car.
        /// </summary>
        public const string UNLOCK_DIECAST_MITSUBISHI_LANCER_BONUS_CAR = "2<?P;G";

        /// <summary>
        /// The cheat code string for Die-Cast Pontiac GTO Bonus Car.
        /// </summary>
        public const string UNLOCK_DIECAST_PONTIAC_GTO_BONUS_CAR = "d5dviyrlgn";

        /// <summary>
        /// The cheat code string for Die-Cast Posche 911 Turbo Bonus Car.
        /// </summary>
        public const string UNLOCK_DIECAST_PORSCHE_911_TURBO_BONUS_CAR = ">8P:I;";

        /// <summary>
        /// The cheat code string for Shelby Terlingua Bonus Car.
        /// </summary>
        public const string UNLOCK_NEED_FOR_SPEED_TERLINGUA_BONUS_CAR = "NeedForSpeedShelbyTerlingua";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string[] cheatsArray = {
        TEN_THOUSAND_DOLLARS, DIECAST_LEXUS_IS_F_BONUS_CAR, DIECAST_NISSAN_240SX_BONUS_CAR, DIECAST_VOLKWAGEN_R32_BONUS_CAR, NEED_FOR_SPEED_DOT_COM_LOTUS_ELISE_BONUS_CAR,
        FIFTEEN_THOSAND_DOLLARS_FROM_T_MOBILE, UNLOCK_DIECAST_AUDI_R8_BONUS_CAR, UNLOCK_DIECAST_CAMARO_CONCEPT_BONUS_CAR, UNLOCK_DIECAST_DODGE_CHARGET_BONUS_CAR,
        UNLOCK_DIECAST_DODGE_VIPER_SRT10_BONUS_CAR, UNLOCK_DIECAST_GTR_POLICE_BONUS_CAR, UNLOCK_DIECAST_MITSUBISHI_LANCER_BONUS_CAR, UNLOCK_DIECAST_PONTIAC_GTO_BONUS_CAR,
        UNLOCK_DIECAST_PORSCHE_911_TURBO_BONUS_CAR, UNLOCK_NEED_FOR_SPEED_TERLINGUA_BONUS_CAR};

        /// <summary>
        /// Checks if the set secret code is valid.
        /// </summary>
        /// <param name="secretCode"></param>
        /// <returns></returns>
        public static bool IsSecretCodeValid(string secretCode)
        {
            int count = cheatsArray.Select((s, i) => new { i, s }).Count(t => t.s == secretCode);
            return (count != 0);
        }
    }
}
