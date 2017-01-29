namespace NFSScript.Core
{
    /// <summary>
    /// 
    /// </summary>
    public static class UGAddresses
    {
        /// <summary>
        /// 
        /// </summary>
        public struct GenericAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ONLINE_ENABLED = 0x7346C4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GAME_STATE = 0x77A920;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAME_LOADED = 0x700E80;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAME_WORLD_LOADED = 0x73131C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_LAST_FRAME_TIME = 0x730B48;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAMEPLAY_ACTIVE = 0x734534;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GAMEPLAY_ACTIVE_TIMER = 0x6F0898;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CHEAT_INPUT_FIELD = 0x737670;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_THROTTLE_MAIN_INPUT = 0x7187F1;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_REVERSE_MAIN_INPUT = 0x718841;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_STEERING_RIGHT_MAIN_INPUT = 0x7188E1;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_STEERING_LEFT_MAIN_INPUT = 0x718891;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_EBRAKE_MAIN_INPUT = 0x7189D1;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_NITROUS_BOOST_MAIN_INPUT = 0x718A21;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SHIFT_UP_MAIN_INPUT = 0x718931;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SHIFT_DOWN_MAIN_INPUT = 0x718981;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_LOOK_BACK_MAIN_INPUT = 0x718B11;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CAMERA_CHANGE_MAIN_INPUT = 0x718AC1;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_RESET_CAR_MAIN_INPUT = 0x718BB1;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_SOUND_ENABLED = 0x700EBC;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct PlayerAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_CASH = 0x76026C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_SPEED_MPH = 0x705858;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_TOTAL_MONEY_EARNED = 0x760270;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_STYLE_POINTS = 0x71DC60;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct UIAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CURSOR_POS_X = 0x7357A0; // ushort

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CURSOR_POS_Y = 0x7357A4; // ushort
        }

        /// <summary>
        /// 
        /// </summary>
        public struct NetworkAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_SERVER = 0x7346C8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SERVER_PORT = 0x6F1F3C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_NETWORK_LOBBY_IP = 0x6F1F40;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_NETWORK_LOBBY_PORT = 0x6F1F60;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_NETWORK_USE_LOBBIES = 0x6F1F64;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class UG2Addresses
    {
        /// <summary>
        /// 
        /// </summary>
        public struct GenericAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAME_LOADED = 0x83152C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GAME_STATE = 0x8654A4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CHEAT_INPUT_FIELD = 0x865945;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAMEPLAY_ACTIVE = 0x82BA74;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_REPLAY_MODE = 0x8363E8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_REPLAY_MODE2 = 0x8650C0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_LAST_FRAME_TIME = 0x865144;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct GameAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_ACTIVITY_MODE = 0x88F2BE;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct WorldAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_WORLD_CARS_NEON_BRIGHTNESS = 0x60D8D0; // float
        }

        /// <summary>
        /// 
        /// </summary>xxxxx
        public struct PlayerAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_CASH = 0x861E74;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_CAR_SPEED_MPH = 0x7F0A04;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_CURRENT_CAR_STAR_RATING = 0x8638F8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_POSITION_READONLY_X = 0x8A2070;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_POSITION_READONLY_Y = 0x8A2078;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_POSITION_READONLY_Z = 0x8A2074;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct UIAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CURSOR_POS_X = 0x838498;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CURSOR_POS_Y = 0x83849C;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct OnlineAddrs
        {

        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class MWAddresses
    {
        /// <summary>
        /// 
        /// </summary>
        public struct GenericAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAME_LOADED = 0x91CD38;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_LAST_FRAME_TIME = 0x983E90;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAMEPLAY_ACTIVE = 0x8F40C4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_SOUND_ENABLED = 0x008F86F8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_AUDIO_STREAMING_ENABLED = 0x008F86FC;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_SPEECH_ENABLED = 0x008F8700;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_NIS_AUDIO_ENABLED = 0x008F8704;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GAME_STATE = 0x00925E90;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SOUND_ENABLED = 0x8F86F8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_FORCE_CLIENT_SHUTDOWN = 0x9B4224;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_USE_RECORDABLE = 0x926118;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_DO_SCREEN_PRINTF = 0x926140;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ENABLE_BRELEASE_PRINTF = 0x90E630;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SAVE_STREAM_ANIM_FRAMES = 0x982BC0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_NUMBER_OF_STREAM_ANIM = 0x8F93FC;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_CAR_OFFSET = 0x160;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct GameAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_PLAYER_ACTIVE = 0x905820;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GAME_SPEED = 0x901B1C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_ENABLED = 0x926064;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_PLAYER_CAR = 0x8F86A8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_AI_CARS = 0x926080;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_LAPS = 0x8F86BC;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_TRACK_NUMBER = 0x8F86A4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_MOVIES = 0x926144;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_NEW_CAR_SMOOHTING = 0x905D50;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GLOBAL_COP_LIGHTS_RED = 0x742af9; // float

            /// <summary>
            /// 
            /// </summary>
            /// 
            public const int STATIC_GLOBAL_COP_LIGHTS_BLUE = 0x742b01; // float

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GLOBAL_COP_LIGHTS_WHITE = 0x742b09; // float
        }
            
        /// <summary>
        /// 
        /// </summary>
        public struct WorldAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GLOBAL_CAR_SCALE_X = 0x737870;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GLOBAL_CAR_SCALE_Y = 0x7378D4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GLOBAL_CAR_SCALE_Z = 0x7378A2;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ROAD_REFLECTION_FIX = 0x758293;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ALWAYS_RAIN = 0x9B0A30;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_RAIN_ROAD_REFLECTION = 0x904B38;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_RAIN_AMOUNT = 0x904A14;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_RAIN_INTENSITY = 0x904A94;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_RAIN_SIZE = 0x904A90;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_RAIN_XING = 0x904A24;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_RAIN_FALL_SPEED = 0x904A28;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_RAIN_GRAVITY = 0x904A2C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ANIMATION_SPEED = 0x904AEC;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct PlayerAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int PSTATIC_HEAT_LEVEL = 0x91CF90;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_HEAT_LEVEL = 0x14;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_POS_X = 0x9386D8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_POS_Y = 0x9386DC;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_POS_Z = 0x9386E0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_X_ROT = 0x9386CC;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_Y_ROT = 0x9386D0;
            
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_Z_ROT = 0x9386D4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_W_ROT = 0x9386C8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_SPEED = 0x914654;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_HEADLIGHTS_LEFT = 0x742b94; // float

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_HEADLIGHTS_RIGHT = 0x742bb3; // float

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_AI_CONTROL = 0x90D5FA;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_HOT_SAVE_POSITION = 0x9B0908;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_HOT_WARP_TO_SAVED_POSITION = 0x9B090C;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct UIAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CURSOR_POS_X = 0x91CFB0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CURSOR_POS_Y = 0x91CFB4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_TRIGGER_EA_TRAX_NOTIFICATION = 0x91CB08;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_STRING_HELLO_WORLD_ADDRESS = 0x8C7470;

            /// <summary>
            /// Length of 31
            /// </summary>
            public const int STATIC_DEBUG_ERROR_MSG_ADDRESS = 0x8A42F4;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct CameraAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int PNONSTATIC_VISUAL_TREATMENT_ADDR = 0x982af0;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_VISUAL_TREAT = 0x18C;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct NetworkAddrs
        {
            /// <summary>
            /// Length of 32
            /// </summary>
            public const int STATIC_NETWORK_LOBBY_IP = 0x8F42C8;

            /// <summary>
            /// ushort
            /// </summary>
            public const int STATIC_NETWORK_LOBBY_PORT = 0x8F42E8;

            /// <summary>
            /// boolean (byte = 0 || 1)
            /// </summary>
            public const int STATIC_NETWORK_DEBUG = 0x9B4170;

            /// <summary>
            /// byte, obsolete.
            /// </summary>
            public const int STATIC_ONLINE_ENABLED = 0x926110;

            /// <summary>
            /// boolean (byte = 0 || 1)
            /// </summary>
            public const int STATIC_IS_SERVER = 0x9B416C;

            /// <summary>
            /// string address of an unknown length.
            /// </summary>
            public const int STATIC_SERVER_IP = 0x9B3E98;

            /// <summary>
            /// string address of an unknown length.
            /// </summary>
            public const int STATIC_NETWORK_USER_NAME = 0x91CF90;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_NETWORK_USE_LOBBIES = 0x9B4174;

            /// <summary>
            /// string address of an unknown length.
            /// </summary>
            public const int STATIC_NETWORK_GAME_NAME = 0x9B4180;

            /// <summary>
            /// Length of 12.
            /// </summary>
            public const int STATIC_NETWORK_GAME_ROOM_PLAYER = 0x009B98B0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_OFFSET_GAME_ROOM_PLAYER = 0x8C;

            /// <summary>
            /// Length of 9
            /// </summary>
            public const int STATIC_OFFSET_GAME_ROOM_PLAYER_UID = 0x18;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_NETWORK_HOST_MAX_LAPS_1 = 0x556bb5;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_NETWORK_HOST_MAX_LAPS_2 = 0x556bde;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_NETWORK_HOST_MIN_LAPS_1 = 0x556bc4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_NETWORK_HOST_MIN_LAPS_2 = 0x556bcf;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class CarbonAddresses
    {
        /// <summary>
        /// 
        /// </summary>
        public struct GenericAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_WIN_10_ADDRESS_FIX = 0x59606D; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_WIN_10_ADDRESS_FIX_2 = 0x59606E; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_WIN_10_ADDRESS_FIX_3 = 0x5960A9; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_WIN_10_ADDRESS_FIX_4 = 0x5960AA; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_FIX_ROAD_REFLECTION = 0x7D83C9; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GAME_STATE = 0xA99BBC;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_RUN_TIME = 0xA62EFC;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_FIX_INVISIBLE_WHEELS = 0x7BDDBC; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAME_LOADED = 0x00BBA405; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAMEPLAY_ACTIVE = 0x00A7AB84; // byte;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_SOUND_ENABLED = 0xA631B8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_AUDIO_STREAMING_ENABLED = 0xA631BC;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_SPEECH_ENABLED = 0xA63AC0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_NIS_AUDIO_ENABLED = 0xA631C4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_MEMCARD_ENABLED = 0xA631C8;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_CAR_OFFSET = 0x160;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_COLLECTORS_EDITION = 0xA631E8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_LAST_FRAME_TIME = 0x84D7EC;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_B_RUMBLE_ENABLED = 0xA631A8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PRECIPITATION_ENABLE = 0xA631B0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ENABLE_RIGHT_STICK_IN_FRONTEND = 0xA9E6C8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GDEBUG_EVENT_STRINGS = 0xA9E679;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_MEMCARD_VERSIONING_ENABLED = 0xA9E684;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_DO_SCREEN_PRINTF = 0xA9E6D4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_MOVIES = 0xA9E6D8;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct GameAddrs
        {            
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GAME_SPEED = 0xA712AC; // float

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ENABLE_MUSIC = 0xA631BC; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ENABLE_VOICES = 0xA631C0; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SHOW_CAR_DEBUG_CUSTOMIZE = 0xA9E680; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_ACTIVITY_MODE = 0xB77E39;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ACTIVITY_ID = 0xA98180;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GLOBAL_COP_LIGHTS_RED = 0x7cbed9; // float

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GLOBAL_COP_LIGHTS_BLUE = 0x7cbee1; // float

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GLOBAL_COP_LIGHTS_WHITE = 0x7cbee9; // float

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_ENABLED = 0xA9E620;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_SPLIT_SCREEN = 0xA9E62C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_PLAYER_PERFORMANCE = 0xA9E628;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_AI_CARS = 0xA9E630;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_COPS_DISABLED = 0xA63158;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_OF_COPS = 0xA9E638;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_TRAFFIC_DISABLED = 0xA9E644;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_POINT_2_POINT = 0xA9E64C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_RACE_TYPE = 0xA9E648;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_NO_WINGMAN = 0xA9E655;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_AI_CONTROL_PLAYER = 0xA9E656;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_TRACK_NUMBER = 0xA6313C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_RACE_ID = 0xA63140;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_PLAYER_CARS = 0xA63150;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_OF_LAPS = 0xA63154;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_TRAFFIC_ONCOMING = 0xA63160;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_DAMAGE_ENABLED = 0xA63164;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_PLAYER_CAR = 0xA63144;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_TRAFFIC_DENSITY = 0xA9E640;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_BOOT_FLOW = 0xA9E664;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_EMERGENCY_SAVE_MEMORY = 0xA9E668;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_FORCE_FAKE_BOSS = 0xA9E66C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ENABLE_DEBUG_CAR_CUSTOMIZE = 0xA9E680;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_DEBUG_VEHICLE_SELECTION = 0xB74BED;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CAR_GUYS_FORCE_LODS = 0xA9E68C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ANIM_CFG_DISABLE_ANIMATIONS = 0xA9E6A4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ANIM_CFG_DEBUG_OUTPUT = 0xA9E6B4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ANIM_CFG_DISABLE_WORLD_ANIMATION = 0xA9E6BC;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_UNLOCK_ALL_THINGS = 0xA9E6C0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CONSTRUCTOR_DRAW_HELI = 0x70A780;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CONSTRUCTOR_DRAW_RACE_CAR = 0x70AAF0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CONSTRUCTOR_DRAW_COP_CAR = 0x70AA20;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CONSTRUCTOR_DRAW_TRAFFIC = 0x70A850;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CONSTRUCTOR_DRAW_NIS_CAR = 0x70A950;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CONSTRUCTOR_POINTER_CALL_DRAW_RACER_CAR = 0xAAA2C8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CONSTRUCTOR_POINTER_CALL_DRAW_NIS_CAR = 0xAAA2E8;


            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CONSTRUCTOR_POINTER_CALL_DRAW_COP_CAR = 0xAAAC44;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CONSTRUCTOR_POINTER_CALL_DRAW_HELI = 0xAAACAC;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CONSTRUCTOR_POINTER_CALL_DRAW_TRAFFIC = 0xAAAD60;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_CAREER_INTRO = 0xA9E6C1;

            /// <summary>
            /// 
            /// </summary>
            public const int NONSTATIC_CURRENT_AMOUNT_OF_COPS_IN_PURSUIT = 0x69F384; // int
        }

        /// <summary>
        /// 
        /// </summary>
        public struct WorldAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_TIME_OF_DAY_SWAP_ENABLE = 0xA631B4;

            /// <summary>
            /// byte
            /// </summary>
            public const int STATIC_ALWAYS_RAIN = 0xB74D20; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_FOG = 0xB74D64;

            /// <summary>
            /// byte
            /// </summary>
            public const int STATIC_RAIN_ROAD_REFLECTION = 0xA798D4; // byte

            /// <summary>
            /// float
            /// </summary>
            public const int STATIC_RAIN_AMOUNT = 0xA797D0; // float

            /// <summary>
            /// float
            /// </summary>
            public const int STATIC_RAIN_INTENSITY = 0xA79850; // float

            /// <summary>
            /// float
            /// </summary>
            public const int STATIC_RAIN_SIZE = 0xA7984C; // float

            /// <summary>
            /// float
            /// </summary>
            public const int STATIC_RAIN_XING = 0xA797E0; // float

            /// <summary>
            /// float
            /// </summary>
            public const int STATIC_RAIN_FALL_SPEED = 0xA797E4; // float

            /// <summary>
            /// float
            /// </summary>
            public const int STATIC_RAIN_GRAVITY = 0xA797E8; // float

            /// <summary>
            /// float
            /// </summary>
            public const int STATIC_ANIMATION_SPEED = 0xA798B4; // float (Default value is 45f)
            
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GLOBAL_CAR_SCALE_X = 0x7AD540;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GLOBAL_CAR_SCALE_Y = 0x7AD5A4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GLOBAL_CAR_SCALE_Z = 0x7AD572;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_BARRIER_SPLINE_4501_TRANSFORM = 0x9d85c8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_BARRIER_SPLINE_4500_TRANSFORM = 0x9d85dc;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_BARRIER_SPLINE_4091_TRANSFORM = 0x9d85f0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_BARRIER_SPLINE_4090_TRANSFORM = 0x9d8604;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_BARRIER_SPLINE_306_TRANSFORM = 0x9d8618;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_BARRIER_SPLINE_305_TRANSFORM = 0x9d862c;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_BARRIER_SPLINE_precentd_TRANSFORM = 0x9d8b34;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct RaceAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_MAX_DRIFT_MULTIPLIER_TRACK = 0x6BE947; // byte
            /// <summary>
            /// 
            /// </summary>

            public const int STATIC_MAX_DRIFT_MULTIPLIER_CANYON = 0x6AB943; // byte
            
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_MAX_DRIFT_MULTIPLIER_CANYON2 = 0x6AB945; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_ALWAYS_WIN_ADDR_1 = 0x641164; // T: 0x90900134 || F: 0x40750134

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_ALWAYS_WIN_ADDR_2 = 0x6412C0; // T: 0x13EBC084 || F: 0x1374C084

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_ALWAYS_WIN_ADDR_3 = 0x660F60; // T: 0x9001347F || F: 0xF01347F

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_ALWAYS_WIN_ADDR_4 = 0x660F64; // T: 0x90909090 || F: 0x24B85

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_ALWAYS_WIN_ADDR_5 = 0x660F68; // T: 0xC8878A90 || F: 0xC8878A00

            /// <summary>
            /// 
            /// </summary>
            public const int NONSTATIC_PLAYER_OPPONENT = 0x68E774;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_PLAYER_OPPONENT_1 = 0x7FC;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_PLAYER_OPPONENT_2 = 0x3C8;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_PLAYER_OPPONENT_3 = 0x60;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_PLAYER_OPPONENT_4 = 0x6A4;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_PLAYER_OPPONENT_5 = 0x34;

            /// <summary>
            /// 
            /// </summary>
            public const int PSTATIC_RACE_OPPONENT_POINTER = 0x384;

            /// <summary>
            /// 
            /// </summary>
            public const int PSTATIC_RACE_OPPONENT_DISTACNE_FOR_NEXT_CHECKPOINT = 0xE8;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct PlayerAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_POLICE_IGNORE_PLAYER = 0x44A7E4; // ulong (Enabled: 3943023862U || Disabled: 2047198454U)
            
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_AI_CONTROL = 0x00A9FFF8; // byte (Disabled: 0 || Enabled: 1)

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_HOT_SAVE_POSITION = 0xB74BF8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_HOT_WARP_TO_SAVED_POSITION = 0xB7FBFC;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_PLAYER_AI_CONTROL_POINTER = 0x8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_LAST_KNOWN_POSITION_X = 0xB7F458;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_LAST_KNOWN_POSITION_Y = 0xB7F45C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_LAST_KNOWN_POSITION_Z = 0xB7F460;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_AUGMENTED_DRIFT_WITH_EBRAKE = 0xA9E65B; // byte (Disabled: 0 || Enabled: 1)
            
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_HEADLIGHTS_LEFT = 0x7cbf96; // float

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_HEADLIGHTS_RIGHT = 0x7cbf77; // float
            
            /// <summary>
            /// 
            /// </summary>
            public const int NONSTATIC_PLAYER_X_POS = 0x6AB140; // float

            /// <summary>
            /// 
            /// </summary>
            public const int NONSTATIC_PLAYER_Y_POS = 0x6AB144; // float

            /// <summary>
            /// 
            /// </summary>
            public const int NONSTATIC_PLAYER_Z_POS = 0x6AB148; // float

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_X_ROT = 0xAAB130;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_Y_ROT = 0xAAB134;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_Z_ROT = 0xAAB138;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_W_ROT = 0xAAB13C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_EVADE_PURSUIT_ADDR = 0x44A7D4; // T: 0xA0E9BA75 || F: 0x86D9BA75 (Offset: +0x2 = T: 0x9000615D || F: 0x180)

            /// <summary>
            /// 
            /// </summary>
            public const int NONSTATIC_PLAYER_SPEED = 0x68E59C; // float

            /// <summary>
            /// An int32 address
            /// </summary>
            public const int PNONSTATIC_PLAYER_CASH = 0x697CFC;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_PLAYER_CASH_1 = 0x340;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_PLAYER_CASH_2 = 0xA0;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_PLAYER_CASH_3 = 0x6B0;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_PLAYER_CASH_4 = 0xFC;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_PLAYER_CASH_5 = 0x6C;

            /// <summary>
            /// A uint (DWORD) address
            /// </summary>
            public const int PSTATIC_PLAYER_HEAT_LEVEL = 0xAA7724; // float

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_PLAYER_HEAT_LEVEL = 0x14;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct CameraAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CAMERA_SMART_LOOK_AHEAD = 0x485399; // byte

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_DEBUG_CAMERA_POS_X = 0xA57BF0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_DEBUG_CAMERA_POS_Y = 0xA57BF8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_DEBUG_CAMERA_POS_Z = 0xA57BF4;

            /// <summary>
            /// 
            /// </summary>
            public const int NONSTATIC_CAMERA_LOD_VALUE_1 = 0x673070;

            /// <summary>
            /// 
            /// </summary>
            public const int NONSTATIC_CAMERA_LOD_VALUE_2 = 0x67306C;

            /// <summary>
            /// 
            /// </summary>
            public const int NONSTATIC_CAMERA_LOD_VALUE_3 = 0x673074;

            /// <summary>
            /// 
            /// </summary>
            public const int NONSTATIC_CAMERA_LOD_VALUE_4 = 0x673078;

        }

        /// <summary>
        /// 
        /// </summary>
        public struct UIAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CURSOR_POS_X = 0x00A97B30;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CURSOR_POS_Y = 0x00A97B34;

            /// <summary>
            /// Recommended length of 44.
            /// </summary>
            public const int STATIC_ERROR_ALLOCATED_MSG = 0x9D99E2;

            /// <summary>
            /// 
            /// </summary>
            public const int PNONSTATIC_MINIMAP_ROUTE_COLOR_EDGE_X = 0x68499C;

            /// <summary>
            /// 
            /// </summary>
            public const int PNONSTATIC_MINIMAP_ROUTE_COLOR_CENTER_X = 0x6849A0;

            /// <summary>
            /// 
            /// </summary>
            public const int PNONSTATIC_MINIMAP_ROUTE_WIDTH = 0x6849A8;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_1 = 0x8;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_2 = 0x1C0;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_3 = 0xF4;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_4 = 0x24;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_5 = 0x640;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_1 = 0x88;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_2 = 0x1E4;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_3 = 0x1CC;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_4 = 0x78;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_5 = 0x70;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_WIDTH_1 = 0x4E4;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_WIDTH_2 = 0x110;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_WIDTH_3 = 0xDC;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_WIDTH_4 = 0xE8;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_MINIMAP_ROUTE_WIDTH_5 = 0x48;


            /// <summary>
            /// 
            /// </summary>
            public const int OFFSET_MINIMAP_ROUTE_COLOR_CENTER = 0x4;
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    public static class ProStreetAddresses
    {
        /// <summary>
        /// 
        /// </summary>
        public struct GenericAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GAME_STATE = 0xABB510;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAME_PAUSED = 0xBFFC34;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAME_LOADED = 0xA4F708;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_CAREER_LOADED = 0xAB0F40;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAMEPLAY_ACTIVE = 0xA54EBC;

            /// <summary>
            ///
            /// </summary>
            public const int STATIC_IS_SOUND_ENABLED = 0x00A9DA00;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_IS_AUDIO_STREAMING_ENABLED = 0x00A9DA04;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_IS_SPEECH_ENABLED = 0x00A9DA08;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_IS_NISAUDIO_ENABLED = 0x00A9DA0C;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct GameAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_ENTERED_CODE = 0xA55384;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_ACTIVITY_MODE = 0xC003BE;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SONG_ID = 0xA4F6F8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE = 0x00BFBC08;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_PLAYER_BLUEPRINT_TYPE = 0x00BFBC10;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_TRACK_DIRECTION = 0x00BFBC14;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_AI_CARS = 0x00BFBC18;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_RACE_TYPE = 0x00BFBC23;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_ENABLE_DEBUG_ACTIVITY = 0x00BFBC2C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_AUTO_RACE_TEST = 0x00BFBC2E;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_PRACTICE_MODE = 0x00BFBC30;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_CONTROLLER_CONFIG = 0x00BFBC34;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_DISABLE_SMOKE = 0x00BFBC38;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_BOOT_FLOW = 0x00BFBC41;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_TRACK_NUMBER = 0x00A9D974;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_RACE_ID = 0x00A9D978;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_PLAYER_CAR = 0x00A9D97C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_SKIP_FE_TURBO_SFX = 0x00A9D980;

            /// <summary>
            ///
            /// </summary>
            public const int STATIC_EMERGENCY_SAVE_MEMORY = 0x00BFBC42;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_B_FORCE_RUMBLE_ON = 0x00BFBC43;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC44 = 0x00BFBC44;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC48 = 0x00BFBC48;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC4_C = 0x00BFBC4C;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_PRECIPITATION_ENABLE = 0x00BFBC50;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC54 = 0x00BFBC54;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_BYTE__BFBC5_A = 0x00BFBC5A;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_UNLOCK_ALL_THINGS = 0x00BFBC5B;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC5_C = 0x00BFBC5C;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC60 = 0x00BFBC60;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC64 = 0x00BFBC64;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC68 = 0x00BFBC68;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_CAREER_INTRO = 0x00BFBC6C;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SHOW_ALL_CARS_IN_FE = 0x00BFBC6E;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_B_ENABLE_RIGHT_STICK_IN_FRONTEND = 0x00BFBC6F;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC70 = 0x00BFBC70;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_MOVIES = 0x00BFBC74;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_BYTE__BFBC78 = 0x00BFBC78;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_BYTE__BFBC79 = 0x00BFBC79;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_BYTE__BFBC7_A = 0x00BFBC7A;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC7_C = 0x00BFBC7C;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_FLT__BFBC80 = 0x00BFBC80;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC84 = 0x00BFBC84;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_FLT__BFBC88 = 0x00BFBC88;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_FLT__BFBC8_C = 0x00BFBC8C;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC90 = 0x00BFBC90;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBC94 = 0x00BFBC94;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_FRAME_RATE_DIV = 0x00BFBC98;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_FLT__BFBC9_C = 0x00BFBC9C;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__BFBCA0 = 0x00BFBCA0;



            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_POV_TYPE1 = 0x00A9D9A8;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_PLAYER_CARS = 0x00A9D9AC;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_LAPS = 0x00A9D9B0;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_TRAFFIC_ONCOMING = 0x00A9D9B4;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__A9_D9_B8 = 0x00A9D9B8;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_CONTROLLER_CONFIG1 = 0x00A9D9C0;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_CONTROLLER_CONFIG2 = 0x00A9D9C4;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__A9_D9_C8 = 0x00A9D9C8;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_TRACTION_CONTROL_LEVEL = 0x00A9D9CC;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_STABILITY_CONTROL_LEVEL = 0x00A9D9D0;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_ANTI_LOCK_BRAKES_LEVEL = 0x00A9D9D4;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_DRIFT_ASSIST_LEVEL = 0x00A9D9D8;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_RACELINE_ASSIST_LEVEL = 0x00A9D9DC;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_BRAKING_ASSIST_LEVEL = 0x00A9D9E0;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_PLAYER_SCREENS = 0x00A9D9E4;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SKIP_FE_TRANSMISSION_SETUP = 0x00A9D9E8;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_SUN_AND_SKY_ATTRIB = 0x00A9D9EC;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_G__ATTACHMENT_IN_PHYSICS = 0x00A9D9F0;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_G__FIX_CAR_COLLISION_VOLUMES = 0x00A9D9F4;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_B_RUMBLE_ENABLED = 0x00A9D9F5;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_TIME_OF_DAY_SWAP_ENABLE = 0x00A9D9F6;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_DWORD__A9_D9_FC = 0x00A9D9FC;

            /// <summary>
            ///
            /// </summary>
            public const int STATIC_IS_MEMCARD_ENABLED = 0x00A9DA10;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_OFF__A9_DA14 = 0x00A9DA14;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_OFF__A9_DA18 = 0x00A9DA18;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_G_STARTING_CASH = 0x00A9DA1C;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_FLT__A9_DA20 = 0x00A9DA20;


            /// <summary>
            ///
            /// </summary>
            public const int STATIC_FLT__A9_DA24 = 0x00A9DA24;

        }

        /// <summary>
        /// 
        /// </summary>
        public struct PlayerAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_SPEED = 0xAB0D5C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_POS_X = 0xFFF910;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_POS_Y = 0xFFF914;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_POS_Z = 0xFFF918;

            /// <summary>
            /// 
            /// </summary>
            public const int NON_STATIC_PLAYER_CASH = 0x006B0EA8;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_NON_STATIC_PLAYER_CASH = 0x1E0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_AI_CONTROL_PLAYER_CAR = 0x00BFBC2D;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct UIAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CURSOR_POS_X = 0xAC73F0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CURSOR_POS_Y = 0xAC73F4;

            /// <summary>
            /// 
            /// </summary>
            public const int PNONSTATIC_UI_INVALID_CODE_ENTRY_TEXT = 0x736F78;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_UI_INVALID_CODE_ENTRY_TEXT_1 = 0x1DC;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_UI_INVALID_CODE_ENTRY_TEXT_2 = 0x178;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_UI_INVALID_CODE_ENTRY_TEXT_3 = 0x794;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_UI_INVALID_CODE_ENTRY_TEXT_4 = 0x7BC;

            /// <summary>
            /// 
            /// </summary>
            public const int POINTER_UI_INVALID_CODE_ENTRY_TEXT_5 = 0x0;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class UndercoverAddresses
    {
        /// <summary>
        /// 
        /// </summary>
        public struct GenericAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GAME_STATE = 0xDA57B8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAME_LOADED = 0xD893E8;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_LAST_FRAME_TIME = 0xDA52A4;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAMEPLAY_ACTIVE = 0xD891F2;

            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_IS_SOUND_ENABLED = 0x00D3CEC0;

            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_IS_AUDIO_STREAMING_ENABLED = 0x00D3CEC4;

            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_IS_SPEECH_ENABLED = 0x00D3CEC8;

            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_IS_NISAUDIO_ENABLED = 0x00D3CECC;

            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_IS_MEMCARD_ENABLED = 0x00D3CED0;

            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_IS_MEMCARD_VERSIONING_ENABLED = 0x00D3CED4;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct GameAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_GAME_NOT_PAUSED = 0xD893F3;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_GET_SECRET_CODE_FIELD = 0xD9A76E;

            /// <summary>
            /// 
            /// </summary>
            public static int STATIC_IS_ACTIVITY_MODE = 0xD952DD;

            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_TIME_OF_DAY_SWAP_ENABLE = 0x00D3CEB0;


            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_ENABLE_PATHFINDER_MUSIC = 0x00D3CEB4;


            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_FORCE_PURSUIT_SONG_ID = 0x00D3CEB8;


            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_FORCE_CHASEDOWN_SONG_ID = 0x00D3CEBC;


            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_G_STARTING_CASH = 0x00D3CEF8;


            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE = 0x00DAA0A4;


            /// <summary>
            /// Generated: enum GRace::Context
            /// </summary>
            public const int STATIC_SKIP_FE_RACE_TYPE = 0x00DAA0A8;


            /// <summary>
            /// Generated: enum eTrackDirection
            /// </summary>
            public const int STATIC_SKIP_FE_TRACK_DIRECTION = 0x00DAA0AC;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_AI_CARS = 0x00DAA0B0;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_MAX_COPS = 0x00DAA0B4;
            
            /// <summary>
            /// Generated: bool
            /// </summary>
            public const int STATIC_SKIP_FE_DISABLE_COPS = 0x00DAA0B8;
            
            /// <summary>
            /// Generated: bool
            /// </summary>
            public const int STATIC_SKIP_FE_HELICOPTER = 0x00DAA0B9;
            
            /// <summary>
            /// Generated: bool
            /// </summary>
            public const int STATIC_SKIP_FE_POINT_2_POINT = 0x00DAA0BA;
            
            /// <summary>
            /// Generated: bool
            /// </summary>
            public const int STATIC_SKIP_FE_PRACTICE_MODE = 0x00DAA0BB;
            
            /// <summary>
            /// Generated: enum eLanguages
            /// </summary>
            public const int STATIC_SKIP_FE_LANGUAGE = 0x00DAA0BC;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_START_FRAME_RATE_MAPPER = 0x00DAA0C0;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_START_CAR_FRAME_RATE_MAPPER = 0x00DAA0C4;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_FOREVER = 0x00D3CDF0;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_TRACK_NUMBER = 0x00D3CDF4;
            
            /// <summary>
            /// Generated: char const *
            /// </summary>
            public const int STATIC_SKIP_FE_RACE_ID = 0x00D3CDF8;
            
            /// <summary>
            /// Generated: char const *
            /// </summary>
            public const int STATIC_SKIP_FE_MISSION_ID = 0x00D3CDFC;
            
            /// <summary>
            /// Generated: char *
            /// </summary>
            public const int STATIC_SKIP_FE_PLAYER_CAR = 0x00D3CE00;
            
            /// <summary>
            /// Generated: char const *
            /// </summary>
            public const int STATIC_SKIP_FE_PLAYER2_CAR = 0x00D3CE04;
            
            /// <summary>
            /// Generated: char const *
            /// </summary>
            public const int STATIC_SKIP_FE_TURBO_SFX = 0x00D3CE08;
            
            /// <summary>
            /// Generated: char const *
            /// </summary>
            public const int STATIC_SKIP_FE_AI_CARS = 0x00D3CE0C;
            
            /// <summary>
            /// Generated: char const *
            /// </summary>
            public const int STATIC_SKIP_FE_PARKING_LOT_CARS = 0x00D3CE10;
            
            /// <summary>
            /// Generated: char const *
            /// </summary>
            public const int STATIC_SKIP_FE_PARKING_LOT_DRIVER_CLASSES = 0x00D3CE14;
            
            /// <summary>
            /// Generated: char const *
            /// </summary>
            public const int STATIC_SKIP_FE_RENDER_TEST_CARS = 0x00D3CE18;
            
            /// <summary>
            /// Generated: float
            /// </summary>
            public const int STATIC_SKIP_FE_RENDER_TEST_SPACING = 0x00D3CE1C;
            
            /// <summary>
            /// Generated: float
            /// </summary>
            public const int STATIC_SKIP_FE_PLAYER_PERFORMANCE = 0x00D3CE20;
            
            /// <summary>
            /// Generated: enumPOVTypes
            /// </summary>
            public const int STATIC_SKIP_FE_POV_TYPE1 = 0x00D3CE24;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_PLAYER_CARS = 0x00D3CE28;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_NUM_LAPS = 0x00D3CE2C;
            
            /// <summary>
            /// Generated: enum eOpponentStrength
            /// </summary>
            public const int STATIC_SKIP_FE_DIFFICULTY = 0x00D3CE34;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_CONTROLLER_CONFIG2 = 0x00D3CE3C;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_BRAKE_ASSIST_LEVEL = 0x00D3CE40;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_TRACTION_CONTROL_LEVEL = 0x00D3CE44;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_STABILITY_CONTROL_LEVEL = 0x00D3CE48;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_ANTI_LOCK_BRAKES_LEVEL = 0x00D3CE4C;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_DRIFT_ASSIST_LEVEL = 0x00D3CE50;
            
            /// <summary>
            /// Generated: int
            /// </summary>
            public const int STATIC_SKIP_FE_RACELINE_ASSIST_LEVEL = 0x00D3CE54;

        }

        /// <summary>
        /// 
        /// </summary>
        public struct PlayerAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_IS_IN_PURSUIT = 0xD20DA0;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_PLAYER_SPEED = 0xD83AE4;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct UIAddrs
        {
            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CURSOR_POS_X = 0xDFAD7C;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_CURSOR_POS_Y = 0xDFAD80;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_UI_WORLD_MAP_CUSROR_POS_X = 0x135D210;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_UI_WORLD_MAP_CUSROR_POS_Y = 0x135D214;

            /// <summary>
            /// 
            /// </summary>
            public const int STATIC_MINIMAP_SHOW_NON_PURSUIT_COPS = 0x00D31368;

            /// <summary>
            /// Length of 87.
            /// </summary>
            public const int STATIC_UI_INVALID_SECRET_CODE_ENTRY_TEXT = 0x21102358;

            /// <summary>
            /// Length of 10.
            /// </summary>
            public const int STATIC_UI_VIDEO_ITEM_TITLE = 0x2110C3EA;

            /// <summary>
            /// Length of 65.
            /// </summary>
            public const int STATIC_UI_VIDEO_CONTENT_TITLE = 0x2069CB6B;

            /// <summary>
            /// Lenght of 31.
            /// </summary>
            public const int STATIC_UI_VIDEO_CONTENT_ITEM_1 = 0x2069CBAE;

            /// <summary>
            /// Length of 32.
            /// </summary>
            public const int STATIC_UI_VIDEO_CONTENT_ITEM_2 = 0x2069CBCE;

            /// <summary>
            /// Length of 19.
            /// </summary>
            public const int STATIC_UI_VIDEO_CONTENT_ITEM_3 = 0x2069CBEF;
        }
    }
}
