using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Math;
using NFSScript.Core;

namespace NFSScript
{
    /// <summary>
    /// A class for Most Wanted functions.
    /// </summary>
    public static class MWFunctions
    {
        /// <summary>
        /// 
        /// </summary>
        public const int FORCE_CAR_STOP = 0x0062CDD0;

        /// <summary>
        /// 
        /// </summary>
        public const int BECOME_AI_CAR = 0x0062AD90;

        /// <summary>
        /// 
        /// </summary>
        public const int RESTART_RACE = 0x00630990;
        /// <summary>
        /// 
        /// </summary>
        public const int RELOAD_HUD = 0x00630310;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_WORLD_GEOMETRY = 0x0062EFD0;
        /// <summary>
        /// 
        /// </summary>
        public const int RELOAD_GAME = 0x00630230;
        /// <summary>
        /// 
        /// </summary>
        public const int SHOW_SMS = 0x00631580;
        /// <summary>
        /// 
        /// </summary>
        public const int ADD_SMS = 0x0062A6D0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_SCREEN_FLASH = 0x0062EAC0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_NUKE_SMACK = 0x0062E3F0;
        /// <summary>
        /// 
        /// </summary>
        public const int BECOME_PLAYER_CAR = 0x0062AE00;
        /// <summary>
        /// 
        /// </summary>
        public const int DISP_INTRO_RACE = 0x0062BD00;
        /// <summary>
        /// 
        /// </summary>
        public const int FADE_SCREEN_NO_LOADING_BAR_ON = 0x0062C760;
        /// <summary>
        /// 
        /// </summary>
        public const int FADE_SCREEN_NO_LOADING_BAR_OFF = 0x0062C680;
        /// <summary>
        /// 
        /// </summary>
        public const int SHOW_MESSAGE_SCREEN = 0x00631020;
        /// <summary>
        /// 
        /// </summary>
        public const int DESTROY_VEHILCE = 0x0062BB40;
        /// <summary>
        /// 
        /// </summary>
        public const int BECOME_PURSUIT_CAR = 0x0062AE70;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_VISUAL_LOOK = 0x0062EDB0;
        /// <summary>
        /// 
        /// </summary>
        public const int KNOCKOUT_RACER = 0x0062D420;
        /// <summary>
        /// 
        /// </summary>
        public const int SIMULATE = 0x006317B0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_LIGHTS = 0x00639E20;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_STOP_EFFECTS = 0x0062EBD0;
        /// <summary>
        /// 
        /// </summary>
        public const int AUTO_SAVE = 0x0062AA20;
        /// <summary>
        /// 
        /// </summary>
        public const int PROCESS_AREA_STIMULUS = 0x0062FB90;
        /// <summary>
        /// 
        /// </summary>
        public const int RESET_SEQUENCER = 0x00630620;
        /// <summary>
        /// 
        /// </summary>
        public const int TIRE_BLOWN = 0x00632000;
        /// <summary>
        /// 
        /// </summary>
        public const int RESET_PLAYER_CAR = 0x00630510;
        /// <summary>
        /// 
        /// </summary>
        public const int GPS_LOST = 0x0062CED0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_BURNOUT = 0x00639260;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_FREEZE = 0x0062DFF0;
        /// <summary>
        /// 
        /// </summary>
        public const int WORLD_MAP_ON = 0x00632370;
        /// <summary>
        /// 
        /// </summary>
        public const int RACE_SHEET_ON = 0x0062FFE0;
        /// <summary>
        /// 
        /// </summary>
        public const int SHOW_TIME_EXTENSION = 0x006316D0;
        /// <summary>
        /// 
        /// </summary>
        public const int PLAY_RACE_MOVIE = 0x0062F970;
        /// <summary>
        /// 
        /// </summary>
        public const int DISABLE_PURSUIT_VEHICLE = 0x0062BBB0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_DETACH = 0x0062DD40;
        /// <summary>
        /// 
        /// </summary>
        public const int KILL_JOINT = 0x0062D320;
        /// <summary>
        /// 
        /// </summary>
        public const int PLAY_END_NIS = 0x0062F480;
        /// <summary>
        /// 
        /// </summary>
        public const int ENABLE_TRIGGER = 0x0062C100;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_STEERING = 0x0063A4D0;
        /// <summary>
        /// 
        /// </summary>
        public const int END_CAR_STOP = 0x0062C180;
        /// <summary>
        /// 
        /// </summary>
        public const int JOINT_DETACHED = 0x0062D260;
        /// <summary>
        /// 
        /// </summary>
        public const int JUMP_TO_STRATEGY_FLOW = 0x0062D2B0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_CAR_DAMAGE_RESET = 0x00639410;
        /// <summary>
        /// 
        /// </summary>
        public const int D_DAY_SPEECH = 0x0062B6B0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_ROAD_NOISE = 0x0062E9F0;
        /// <summary>
        /// 
        /// </summary>
        public const int STOP_OBJECT_EFFECTS = 0x00631D90;
        /// <summary>
        /// 
        /// </summary>
        public const int MOMENT_STRM = 0x0062D8A0;
        /// <summary>
        /// 
        /// </summary>
        public const int EXIT_ENGAGABLE_TRIGGER = 0x0062C5D0;
        /// <summary>
        /// 
        /// </summary>
        public const int SET_PLAYER_CAR_RESET = 0x00630C10;
        /// <summary>
        /// 
        /// </summary>
        public const int CAMERA_PHOTO_FINISH = 0x0062B0A0;
        /// <summary>
        /// 
        /// </summary>
        public const int SPAWN_EXPLOSION = 0x006318C0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_COP_CAR_DOORS = 0x0062DB20;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_FAKE_FAR = 0x0062DEC0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_HIDE_CHARACTER = 0x0062E1F0;
        /// <summary>
        /// 
        /// </summary>
        public const int SHOW_MILESTONES = 0x006420F0;
        /// <summary>
        /// 
        /// </summary>
        public const int GPS_FINISHED = 0x0062CEA0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_DETAIL = 0x0062DE10;
        /// <summary>
        /// 
        /// </summary>
        public const int ENABLE_COLLISION_ELEMENT = 0x0062BF80;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_COP_LIGHTS = 0x0062DC70;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_PIXELATE = 0x0062E610;
        /// <summary>
        /// 
        /// </summary>
        public const int E911_CALL = 0x0062A490;
        /// <summary>
        /// 
        /// </summary>
        public const int AUDIO_SMACKABLE_TEST = 0x0062A8A0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_BRAKELOCK = 0x00639090;
        /// <summary>
        /// 
        /// </summary>
        public const int HIDE_RACE_OVER_MESSAGE = 0x0062D100;
        /// <summary>
        /// 
        /// </summary>
        public const int DYNAMIC_REGION = 0x0062BDA0;
        /// <summary>
        /// 
        /// </summary>
        public const int RANDOM_EVENT_LIST = 0x00630030;
        /// <summary>
        /// 
        /// </summary>
        public const int GTRIGGER_INTERNAL = 0x006389F0;
        /// <summary>
        /// 
        /// </summary>
        public const int FORCE_PURSUIT_START = 0x0060AAC0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_REATTACH = 0x0062E920;
        /// <summary>
        /// 
        /// </summary>
        public const int BREAKER_STOP_COPS = 0x0062AF90;
        /// <summary>
        /// 
        /// </summary>
        public const int REQUEST_EVENT_INFO_DIALOG = 0x00630460;
        /// <summary>
        /// 
        /// </summary>
        public const int SPAWN_SMACKABLE = 0x0063B940;
        /// <summary>
        /// 
        /// </summary>
        public const int FIRE_RANDOM_TRIGGER = 0x0062CB90;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_TIME_OF_DAY = 0x0062ECB0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_CAR_SHAKE = 0x00639980;
        /// <summary>
        /// 
        /// </summary>
        public const int TUNE_VEHICLE = 0x00632120;
        /// <summary>
        /// 
        /// </summary>
        public const int ACCELERATE = 0x0062A520;
        /// <summary>
        /// 
        /// </summary>
        public const int SHOW_RACE_OVER_MESSAGE = 0x006312A0;
        /// <summary>
        /// 
        /// </summary>
        public const int TIRE_PUNCTURED = 0x00632040;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_CONSTRAINT = 0x00639B80;
        /// <summary>
        /// 
        /// </summary>
        public const int QUIT_DEMO_0 = 0x0063AE30;
        /// <summary>
        /// 
        /// </summary>
        public const int ENABLE_MODELING = 0x0062C030;
        /// <summary>
        /// 
        /// </summary>
        public const int STOP_OBJECT_EFFECT = 0x00631CC0;
        /// <summary>
        /// 
        /// </summary>
        public const int PURSUIT_BREAKER = 0x006417C0;
        /// <summary>
        /// 
        /// </summary>
        public const int RESET_SYSTEM = 0x00630690;
        /// <summary>
        /// 
        /// </summary>
        public const int SET_SIM_RATE = 0x00630D90;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_PLAY_EFFECT = 0x0062E6E0;
        /// <summary>
        /// 
        /// </summary>
        public const int PLAY_RACE_NIS = 0x00641520;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_RAIN = 0x0062E840;
        /// <summary>
        /// 
        /// </summary>
        public const int AI_ENGINE_REV = 0x00637BD0;
        /// <summary>
        /// 
        /// </summary>
        public const int PERFECT_LAUNCH = 0x0062F3A0;
        /// <summary>
        /// 
        /// </summary>
        public const int SND_GAME_STATE = 0x00631810;
        /// <summary>
        /// 
        /// </summary>
        public const int PERFECT_SHIFT = 0x0062F3E0;
        /// <summary>
        /// 
        /// </summary>
        public const int CINEMATIC_MOMENT = 0x0062B430;
        /// <summary>
        /// 
        /// </summary>
        public const int TRIGGER_MOMENT_NIS = 0x00632080;
        /// <summary>
        /// 
        /// </summary>
        public const int SET_COP_AUTO_SPAWN_MODE = 0x00630B90;
        /// <summary>
        /// 
        /// </summary>
        public const int AWARD_UPGRADE = 0x0062ABE0;
        /// <summary>
        /// 
        /// </summary>
        public const int CHANGE_STATE = 0x0062B3F0;
        /// <summary>
        /// 
        /// </summary>
        public const int CELL_CALL = 0x0062B2F0;
        /// <summary>
        /// 
        /// </summary>
        public const int RESET_PROPS = 0x006305B0;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_AERO_DYNAMICS = 0x0062DA50;
        /// <summary>
        /// 
        /// </summary>
        public const int WAKE_OBJECT = 0x00632270;
        /// <summary>
        /// 
        /// </summary>
        public const int ENABLE_AI_PHYSICS = 0x0062BF10;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_CAR_PITCH = 0x006395B0;
        /// <summary>
        /// 
        /// </summary>
        public const int FIRE_EVENT_LIST = 0x00638640;
        /// <summary>
        /// 
        /// </summary>
        public const int LOAD_LOST = 0x0062D740;
        /// <summary>
        /// 
        /// </summary>
        public const int TERMINATE_MUSIC = 0x00631EB0;
        /// <summary>
        /// 
        /// </summary>
        public const int ENGINE_BLOWN = 0x0062C2A0;
        /// <summary>
        /// 
        /// </summary>
        public const int KILL_OBJECT = 0x0062D390;
        /// <summary>
        /// 
        /// </summary>
        public const int PLAY_OBJECT_EFFECT = 0x0062F610;
        /// <summary>
        /// 
        /// </summary>
        public const int SCHEDULE_EVENT_UPDATE = 0x00630A90;
        /// <summary>
        /// 
        /// </summary>
        public const int SHOCK_OBJECT = 0x00630E40;
        /// <summary>
        /// 
        /// </summary>
        public const int REPORT_INFRACTION = 0x00630400;
        /// <summary>
        /// 
        /// </summary>
        public const int PROCESS_STIMULUS = 0x0062FD20;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_NITRO = 0x0063A230;
        /// <summary>
        /// 
        /// </summary>
        public const int HIDE_PART = 0x0062CF90;
        /// <summary>
        /// 
        /// </summary>
        public const int NIS_CAR_ROLL = 0x00639790;
        /// <summary>
        /// 
        /// </summary>
        public const int TIPS = 0x00631F50;
        /// <summary>
        /// 
        /// </summary>
        public const int PLAYER_AIRBORNE = 0x0062F560;

        /// <summary>
        /// 
        /// </summary>
        public const int SHOW_RESULTS = 0x00642300;

        /// <summary>
        /// 
        /// </summary>
        public const int REQ_HELI_JOIN = 0x00708180;

        /// <summary>
        /// 
        /// </summary>
        public const int FADE_SCREEN_ON = 0x62cb00;

        /// <summary>
        /// 
        /// </summary>
        public const int FADE_SCREEN_OFF = 0x62c950;

        /// <summary>
        /// 
        /// </summary>
        public const int CAMERA_SHAKE = 0x62b110;

        /// <summary>
        /// 
        /// </summary>
        public const int PURSUIT_BAIL = 0x62ace0;


        /// <summary>
        /// 
        /// </summary>
        public const int SHOW_RACE_COUNTDOWN = 0x631190;

        /// <summary>
        /// 
        /// </summary>
        public static readonly byte[] DIALOG_BOX_SHOW_WARNING = {
            0x56,                                                                                       // push   esi
            0x57,                                                                                       // push   edi
            0x68, 0x70, 0x74, 0x8C, 0x00,                                                               // push   0x8c7470
            0x6A, 0xFF,                                                                                 // push   0xffffffff
            0x6A, 0xFF,                                                                                 // push   0xffffffff
            0x68, 0x01, 0x26, 0x7B, 0x41,                                                               // push   0x417b2601
            0x6A, 0x01,                                                                                 // push   0x1
            0x68, 0x78, 0x09, 0x89, 0x00,                                                               // push   0x890978
            0x52,                                                                                       // push   edx
            0xB8, 0x70, 0x89, 0x59, 0x00,                                                               // mov    eax,0x598970
            0xFF, 0xD0,                                                                                 // call   eax
            0x83, 0xC4, 0x1C,                                                                           // add    esp,0x1c
            0x5F,                                                                                       // pop    edi
            0x5E,                                                                                       // pop    esi
            0xC3                                                                                        // ret
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly byte[] DIALOG_BOX_SHOW_INFO = {
            0x56,                                                                                       // push   esi
            0x57,                                                                                       // push   edi
            0x68, 0x70, 0x74, 0x8C, 0x00,                                                               // push   0x8c7470
            0x6A, 0xFF,                                                                                 // push   0xffffffff
            0x6A, 0xFF,                                                                                 // push   0xffffffff
            0x68, 0x01, 0x26, 0x7B, 0x41,                                                               // push   0x417b2601
            0x6A, 0x00,                                                                                 // push   0x0
            0x68, 0x78, 0x09, 0x89, 0x00,                                                               // push   0x890978
            0x52,                                                                                       // push   edx
            0xB8, 0x70, 0x89, 0x59, 0x00,                                                               // mov    eax,0x598970
            0xFF, 0xD0,                                                                                 // call   eax
            0x83, 0xC4, 0x1C,                                                                           // add    esp,0x1c
            0x5F,                                                                                       // pop    edi
            0x5E,                                                                                       // pop    esi
            0xC3                                                                                        // ret
        };

        /// <summary>
        /// 
        /// </summary>
        public const int LOADING_SCREEN_ON = 0x62D6F0;

        /// <summary>
        /// 
        /// </summary>
        public const int LOADING_SCREEN_OFF = 0x62D520;

        /// <summary>
        /// 
        /// </summary>
        public const int SHOW_SCREEN_MESSAGE = 0x6121c9;

        /// <summary>
        /// 
        /// </summary>
        public const int SHOW_DIALOG_BOX = 0x598970;

        /// <summary>
        /// 
        /// </summary>
        public const int UI_SHOW_RACE_COUTNDOWN = 0x631190;

        /// <summary>
        /// 
        /// </summary>
        public const int UNPAUSE = 0x632190;

        /// <summary>
        /// 
        /// </summary>
        public const int PAUSE = 0x0062F360;



        /// <summary>
        ///
        /// </summary>
        public const int TABLE__RANDOMIZE = 0x618AC0;


        /// <summary>
        ///
        /// </summary>
        public const int AUDIO__SET_FLAG = 0x6048E0;


        /// <summary>
        ///
        /// </summary>
        public const int MINI_MAP__ADD_ENGAGED_RACE = 0x604B50;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA__SET_GENERIC_CAMERA = 0x604A50;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY = 0x604B80;


        /// <summary>
        ///
        /// </summary>
        public const int DEBUG__PRINT = 0x604C70;


        /// <summary>
        ///
        /// </summary>
        public const int DEBUG__PRINT_INSTANCE = 0x604C80;


        /// <summary>
        ///
        /// </summary>
        public const int DEBUG__SHOW_SCREEN_MESSAGE = 0x6121C0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_MESSAGE = 0x611320;

        /// <summary>
        ///
        /// </summary>
        public const int SABOTAGE_ENGINE = 0x60AB60;


        /// <summary>
        ///
        /// </summary>
        public const int BLOW_ENGINE = 0x60AB30;


        /// <summary>
        ///
        /// </summary>
        public const int DETACH_CAMERA_FROM_RACER = 0x611540;


        /// <summary>
        ///
        /// </summary>
        public const int CHALLENGE_COMPLETE = 0x60E200;


        /// <summary>
        ///
        /// </summary>
        public const int CLEAR_AICONTROL = 0x612420;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_AICONTROL = 0x6123B0;


        /// <summary>
        ///
        /// </summary>
        public const int INIT_RACERS = 0x61DBE0;


        /// <summary>
        ///
        /// </summary>
        public const int WARP_PLAYER_TO_TRIGGER = 0x611570;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_TRIGGER = 0x604D10;


        /// <summary>
        ///
        /// </summary>
        public const int SET_PLAYER_START_POSITION = 0x611670;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACER_GOAL = 0x611700;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACER_LAPS_LEFT = 0x604DB0;

        /// <summary>
        ///
        /// </summary>
        public const int TOTAL_RACER = 0x611440;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_RACE_PLACEMENT = 0x60AA00;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_SPEED_TRAP_TRIGGERED = 0x60A7B0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_CHECKPOINT_REACHED = 0x6117F0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_LAP_FINISHED = 0x611850;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_RACE_FINISHED = 0x6119F0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACE_ACTIVITY = 0x604ED0;


        /// <summary>
        ///
        /// </summary>
        public const int START_RACE = 0x60DBD0;


        /// <summary>
        ///
        /// </summary>
        public const int START_RACE_TIMERS = 0x604EF0;


        /// <summary>
        ///
        /// </summary>
        public const int SAVE_START_POSITIONS = 0x604E90;


        /// <summary>
        ///
        /// </summary>
        public const int RESTORE_START_POSITIONS = 0x60AA50;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_POST_RACE_FLOW = 0x611F20;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_ONLINE_POST_RACE_SCREEN = 0x605690;


        /// <summary>
        ///
        /// </summary>
        public const int SET_COPS_ENABLED = 0x604F40;


        /// <summary>
        ///
        /// </summary>
        public const int NO_NEW_PURSUITS_OR_COPS = 0x60AAB0;
        
        /// <summary>
        ///
        /// </summary>
        public const int ENTER_ENGAGABLE_TRIGGER = 0x604F80;

        /// <summary>
        ///
        /// </summary>
        public const int ENTER_GATE_ZONE = 0x611FB0;


        /// <summary>
        ///
        /// </summary>
        public const int EXIT_GATE_ZONE = 0x611FF0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_RACE_OVER_SUMMARY = 0x6120C0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_TRAFFIC_SPEED = 0x605090;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_COP = 0x60A670;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_CHARACTER = 0x604D40;


        /// <summary>
        ///
        /// </summary>
        public const int UNSPAWN_CHARACTER = 0x604DA0;


        /// <summary>
        ///
        /// </summary>
        public const int SEND_CHARACTER_STIMULUS = 0x60A6E0;


        /// <summary>
        ///
        /// </summary>
        public const int JACK_KNIFE = 0x605030;


        /// <summary>
        ///
        /// </summary>
        public const int SET_ALL_STAGING = 0x60DF70;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_PAUSE_MENU = 0x6050F0;


        /// <summary>
        ///
        /// </summary>
        public const int AWARD_CASH = 0x612130;


        /// <summary>
        ///
        /// </summary>
        public const int AWARD_POINTS = 0x60E030;


        /// <summary>
        ///
        /// </summary>
        public const int CHALLENGE_COMPLETED = 0x605140;


        /// <summary>
        ///
        /// </summary>
        public const int UNLOCK_RACE = 0x612140;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_COUNTDOWN_DONE = 0x60E160;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_COPS_FOR_RESTART = 0x60AB10;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_TRIGGER_ICON = 0x604D20;


        /// <summary>
        ///
        /// </summary>
        public const int HIDE_TRIGGER_ICON = 0x604D30;


        /// <summary>
        ///
        /// </summary>
        public const int WARP_TO_MARKER_WHEN_ROAMING = 0x605930;


        /// <summary>
        ///
        /// </summary>
        public const int DO_SPECIAL_FINALIZATION = 0x605890;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_ENGAGE_EVENTS = 0x605640;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_MENU_GATES = 0x605650;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_ENGAGE_SAFEHOUSE = 0x605660;


        /// <summary>
        ///
        /// </summary>
        public const int DO_SPECIAL_SETUP = 0x605830;


        /// <summary>
        ///
        /// </summary>
        public const int CLEAR_RACERS = 0x5E30A0;


        /// <summary>
        ///
        /// </summary>
        public const int ADD_RACER = 0x601F90;


        /// <summary>
        ///
        /// </summary>
        public const int ADD_CHECKPOINT = 0x5F5C20;


        /// <summary>
        ///
        /// </summary>
        public const int SET_NEXT_CHECKPOINT_POS = 0x5FE660;


        /// <summary>
        ///
        /// </summary>
        public const int SET_ROAMING = 0x5FE3E0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_IS_LOADING = 0x5DB3E0;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_SUDDEN_DEATH = 0x604030;


        /// <summary>
        ///
        /// </summary>
        public const int AWARD_BONUS_TIME = 0x5FE600;


        /// <summary>
        ///
        /// </summary>
        public const int SET_ACTIVELY_RACING = 0x604050;


        /// <summary>
        ///
        /// </summary>
        public const int SET_TASK_TIME = 0x604040;


        /// <summary>
        ///
        /// </summary>
        public const int DISABLE_BARRIERS = 0x5DBF00;


        /// <summary>
        ///
        /// </summary>
        public const int ENABLE_BIN_BARRIERS = 0x5E3020;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_SCRIPT_WHEN_LOADED = 0x5EEA60;


        /// <summary>
        ///
        /// </summary>
        public const int SET_HAS_BEEN_WON = 0x604080;


        /// <summary>
        ///
        /// </summary>
        public const int AWARD_PLAYER_BOUNTY = 0x612220;


        /// <summary>
        ///
        /// </summary>
        public const int JUMP_TO_CAR_LOT = 0x605250;


        /// <summary>
        ///
        /// </summary>
        public const int ABANDON_RACE = 0x60DEB0;


        /// <summary>
        ///
        /// </summary>
        public const int JUMP_TO_SAFE_HOUSE = 0x6052B0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_TIMER = 0x605300;


        /// <summary>
        ///
        /// </summary>
        public const int KILL_TIMER = 0x605320;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_GPS = 0x605340;


        /// <summary>
        ///
        /// </summary>
        public const int NAVIGATE_PLAYER_TO = 0x605360;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_ACTIVITY_FINSIHED = 0x605420;


        /// <summary>
        ///
        /// </summary>
        public const int SKIP_CAREER_INTRO = 0x612490;


        /// <summary>
        ///
        /// </summary>
        public const int SET_CHANCE_OF_RAIN = 0x6054A0;


        /// <summary>
        ///
        /// </summary>
        public const int FADE = 0x605500;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_TUTORIAL = 0x6124E0;


        /// <summary>
        ///
        /// </summary>
        public const int DO_SAFE_HOUSE_INTRO = 0x605560;


        /// <summary>
        ///
        /// </summary>
        public const int DO_ZONE_MENU_ACTION = 0x612030;


        /// <summary>
        ///
        /// </summary>
        public const int SET_CURRENT_TIME_OF_DAY = 0x605780;


        /// <summary>
        ///
        /// </summary>
        public const int RELOAD_WORLD = 0x6057E0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_HAS_RAP_SHEET = 0x605670;


        /// <summary>
        ///
        /// </summary>
        public const int SET_WORLD_HEAT = 0x612660;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_WINNING_POST_RACE_SCREEN = 0x60E240;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_LOSING_POST_RACE_SCREEN = 0x60E230;


        /// <summary>
        ///
        /// </summary>
        public const int PREVENT_PLAYER_BEING_BUSTED = 0x60AE00;

    }

    /// <summary>
    /// A class for Carbon functions.
    /// </summary>
    public static class CarbonFunctions
    {
        /// <summary>
        /// CameraAI::SetAction((EVIEW_ID, char const *))
        /// </summary>
        public const int CAMERA_AI__SET_ACTION = 0x48D620;

        /// <summary>
        ///
        /// </summary>
        public const int CAMERA_SHAKE = 0x0066C240;


        /// <summary>
        ///
        /// </summary>
        public const int ACCELERATE = 0x66B6C0;


        /// <summary>
        ///
        /// </summary>
        public const int ADD_SMS = 0x0066B7C0;


        /// <summary>
        ///
        /// </summary>
        public const int AUTO_SAVE = 0x0066BB30;


        /// <summary>
        ///
        /// </summary>
        public const int BAIL_PURSUIT = 0x66BBF0;


        /// <summary>
        ///
        /// </summary>
        public const int BECOME_AI_CAR = 0x0066BC80;


        /// <summary>
        ///
        /// </summary>
        public const int BECOME_PLAYER_CAR = 0x0066BCE0;


        /// <summary>
        ///
        /// </summary>
        public const int BECOME_PURSUIT_CAR = 0x0066BF60;


        /// <summary>
        ///
        /// </summary>
        public const int BREAKER_STOP_COPS = 0x0066C090;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA_KILL_ICE = 0x0066C140;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA_PHOTO_FINISH = 0x0066C1D0;


        /// <summary>
        ///
        /// </summary>
        public const int CELL_CALL = 0x0066C370;


        /// <summary>
        ///
        /// </summary>
        public const int CHANGE_WINGMAN_ROLE = 0x0066C610;


        /// <summary>
        ///
        /// </summary>
        public const int CINEMATIC_MOMENT = 0x0066C680;


        /// <summary>
        ///
        /// </summary>
        public const int DAMAGE_LIGHTS = 0x0066C860;


        /// <summary>
        ///
        /// </summary>
        public const int DEBUG_PRINT = 0x0066C950;


        /// <summary>
        ///
        /// </summary>
        public const int DEBUG_SCREEN_MESSAGE = 0x0066CA70;


        /// <summary>
        ///
        /// </summary>
        public const int DESTROY_VEHICLE = 0x0066CBC0;


        /// <summary>
        ///
        /// </summary>
        public const int DISABLE_PURSUIT_VEHICLE = 0x0066CC40;


        /// <summary>
        ///
        /// </summary>
        public const int DISMISS_AIFROM_RACE = 0x0066CD30;


        /// <summary>
        ///
        /// </summary>
        public const int DYNAMIC_REGION = 0x0066CED0;


        /// <summary>
        ///
        /// </summary>
        public const int ENABLE_COLLISION_GEOMETRY = 0x0066D010;


        /// <summary>
        ///
        /// </summary>
        public const int ENABLE_MODELING = 0x0066D0A0;


        /// <summary>
        ///
        /// </summary>
        public const int END_CAR_STOP = 0x0066D190;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_BIN = 0x0067BF00;


        /// <summary>
        ///
        /// </summary>
        public const int EXAMPLE_EVENT = 0x0066D570;


        /// <summary>
        ///
        /// </summary>
        public const int FIRE_EVENT_TAG = 0x0067C1C0;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_CAR_STOP = 0x0066DAA0;


        /// <summary>
        ///
        /// </summary>
        public const int GTRIGGER_INTERNAL = 0x006842E0;


        /// <summary>
        ///
        /// </summary>
        public const int HIDE_PART = 0x0066DCC0;


        /// <summary>
        ///
        /// </summary>
        public const int HUD_FADE_TO_BLACK_OFF = 0x0066DE10;


        /// <summary>
        ///
        /// </summary>
        public const int HUD_FADE_TO_BLACK_ON = 0x0066DE90;


        /// <summary>
        ///
        /// </summary>
        public const int ICE_CAR_ATTACH = 0x0066DF50;


        /// <summary>
        ///
        /// </summary>
        public const int JUMP_TO_STRATEGY_FLOW = 0x0066E000;


        /// <summary>
        ///
        /// </summary>
        public const int KILL_JOINT = 0x0066E090;


        /// <summary>
        ///
        /// </summary>
        public const int KILL_OBJECT = 0x0066E110;


        /// <summary>
        ///
        /// </summary>
        public const int LOAD_LOST = 0x0066E510;


        /// <summary>
        ///
        /// </summary>
        public const int LOAD_MINIMAP_RESOURCES = 0x0066E5D0;


        /// <summary>
        ///
        /// </summary>
        public const int MOMENT_STRM = 0x0066E6F0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_AERO_DYNAMICS = 0x0066E800;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_BLOOM_SCALE = 0x0066E8B0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_BRAKELOCK = 0x006849E0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_BURNOUT = 0x00684B00;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CAR_DAMAGE = 0x00684C10;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CAR_DAMAGE_RESET = 0x00684D10;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CAR_FULLY_ANIMATED = 0x00684E20;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CAR_HIDE_PART = 0x0066EA80;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CAR_PITCH = 0x00685000;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CAR_ROLL = 0x00685130;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CAR_SHAKE = 0x00685270;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CONSTRAINT = 0x006853A0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_COP_CAR_DOORS = 0x0066EC90;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_COP_LIGHTS = 0x0066EDB0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_DETACH = 0x0066EE40;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_DETAIL = 0x0066EF50;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_FAKE_FAR = 0x0066EFE0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_FREEZE = 0x0067CC00;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_HIDE_CHARACTER = 0x0067CD40;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_LIGHT_MATERIAL = 0x0066F210;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_LIGHT_RIGS = 0x0066F390;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_LIGHTS = 0x006855A0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_MOTION_BLUR = 0x0066F4A0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_NEUTRAL_REV = 0x00685700;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_NITRO = 0x00685840;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_NUKE_SMACK = 0x0066F630;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_OVERLAY_MESSAGE = 0x0066F770;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_PIXELATE = 0x0066F8C0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_PLAY_EFFECT = 0x0066FAD0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_RAIN = 0x0066FBE0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_REATTACH = 0x0066FC90;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_RELEASE_CAR_CONTROL = 0x0066FD10;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_ROAD_NOISE = 0x0066FDA0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_SCREEN_FLASH = 0x0066FE90;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_SHOW_HUD = 0x0066FF40;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_SPOT_LIGHT = 0x0066FFE0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_START_COUNTDOWN = 0x00670070;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_STEERING = 0x00685A70;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_STOP_EFFECTS = 0x00670180;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_TIME_OF_DAY = 0x00670250;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_UCAP_BLEND = 0x00670340;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_UCAP_PAUSE = 0x00670420;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_UCAP_SELECT = 0x00670500;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_VISUAL_LOOK = 0x00670720;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_WORLD_ANIM_TRIGGER = 0x00670840;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_WORLD_GEOMETRY = 0x006709A0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_END_NIS = 0x00670D20;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_OBJECT_EFFECT = 0x00670F00;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_RACE_MOVIE = 0x00671050;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_RACE_NIS = 0x00693BC0;


        /// <summary>
        ///
        /// </summary>
        public const int PROCESS_AREA_STIMULUS = 0x00671170;


        /// <summary>
        ///
        /// </summary>
        public const int PROCESS_STIMULUS = 0x006713B0;


        /// <summary>
        ///
        /// </summary>
        public const int PUDDLE = 0x006714A0;


        /// <summary>
        ///
        /// </summary>
        public const int PULSE_WINGMAN_METER = 0x0067D880;


        /// <summary>
        ///
        /// </summary>
        public const int REFRESH_HUD = 0x00671960;


        /// <summary>
        ///
        /// </summary>
        public const int RELOAD_HUD = 0x00671AC0;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_PLAYER_CAR = 0x00671C80;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_PROPS = 0x00671D30;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_SEQUENCER = 0x00671E50;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_SYSTEM = 0x00671FC0;


        /// <summary>
        ///
        /// </summary>
        public const int ROLLING_CHECK = 0x006721A0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_AI_AVOIDABLE = 0x00672270;


        /// <summary>
        ///
        /// </summary>
        public const int SET_AI_PLAYER_OFFSET = 0x00672310;


        /// <summary>
        ///
        /// </summary>
        public const int SET_COP_AUTO_SPAWN_MODE = 0x00672410;


        /// <summary>
        ///
        /// </summary>
        public const int SET_PLAYER_COLLISION_CACHE = 0x006724E0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_WINGMAN_CHARGE_LEVEL = 0x00672590;


        /// <summary>
        ///
        /// </summary>
        public const int SHOCK_OBJECT = 0x00672610;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_CANYON_INSTRUCTION_FLASHERS = 0x00672680;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_MARKETING_SCREEN = 0x006727E0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_MESSAGE_SCREEN = 0x006728A0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_RACE_COUNTDOWN = 0x006729B0;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_EXPLOSION = 0x00673170;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_FRAGMENT = 0x006732E0;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_SMACKABLE = 0x00686CE0;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_WORLD_EXPLOSION = 0x00673470;


        /// <summary>
        ///
        /// </summary>
        public const int STOP_OBJECT_EFFECT = 0x00673530;


        /// <summary>
        ///
        /// </summary>
        public const int STOP_OBJECT_EFFECTS = 0x006735C0;


        /// <summary>
        ///
        /// </summary>
        public const int TERMINATE_MUSIC = 0x00673660;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_PUSH_BUTTON_OVERLAY = 0x00673800;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_WINGMAN_ACTIVATION_ALLOWED = 0x006738C0;


        /// <summary>
        ///
        /// </summary>
        public const int TRIGGER_MOMENT_DYNAMIC_NIS = 0x00673970;


        /// <summary>
        ///
        /// </summary>
        public const int TRIGGER_MOMENT_NIS = 0x00673A10;


        /// <summary>
        ///
        /// </summary>
        public const int WINGMAN_TRIGGER = 0x00687AF0;


        /// <summary>
        ///
        /// </summary>
        public const int WORLD_MAP_ON = 0x00673FF0;


        /// <summary>
        ///
        /// </summary>
        public const int WORLD_MAP_ON_ACQUISITION = 0x006740B0;


        /// <summary>
        ///
        /// </summary>
        public const int WORLD_MAP_ON_ENCOUNTER = 0x006947D0;


        /// <summary>
        ///
        /// </summary>
        public const int WORLD_MAP_ON_IN_TRIGGER = 0x006949C0;


        /// <summary>
        /// 
        /// </summary>
        public const int SHOW_SCREEN_TEXT_MESSAGE = 0x65C090;
        
        /// <summary>
        ///
        /// </summary>
        public const int TABLE__RANDOMIZE = 0x00663F90;


        /// <summary>
        ///
        /// </summary>
        public const int DEBUG__EXECUTE_DEBUG_SCRIPT = 0x0064A800;


        /// <summary>
        ///
        /// </summary>
        public const int LUA_DEBUG__EXECUTE_LINE = 0x0064A4F0;


        /// <summary>
        ///
        /// </summary>
        public const int ACTIVITY__RUN = 0x0064ADE0;


        /// <summary>
        ///
        /// </summary>
        public const int SUSPEND = 0x0064AE10;


        /// <summary>
        ///
        /// </summary>
        public const int FREEZE_CAMERA = 0x650D70;


        /// <summary>
        /// MiniMap_AddEngagedRace(GRuntimeInstance *)
        /// </summary>
        public const int MINIMAP__ADD_ENGAGED_RACE = 0x64AFB0;


        /// <summary>
        /// Camera_SetGenericCamera(char const *,int)
        /// </summary>
        public const int CAMERA__SET_GENERIC_CAMERA = 0x650C50;


        /// <summary>
        /// Camera_SetSmoothExit(bool)
        /// </summary>
        public const int SET_SMOOTH_EXIT = 0x64AFA0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS__PLAY = 0x650DB0;


        /// <summary>
        ///
        /// </summary>
        public const int WAIT_FOR_PIP = 0x650D50;


        /// <summary>
        ///
        /// </summary>
        public const int LAUNCH_PIP = 0x655670;


        /// <summary>
        ///
        /// </summary>
        public const int DISABLE_PIP = 0x650D40;


        /// <summary>
        /// HUD_ShowMessage(char const *)
        /// </summary>
        public const int HUD__SHOW_MESSAGE = 0x65B1B0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_TIME_EXTENSION = 0x65B460;


        /// <summary>
        /// HUD_ShowLoopingMessage(char const *,float)
        /// </summary>
        public const int SHOW_LOOPING_MESSAGE = 0x65B2A0;


        /// <summary>
        /// Game_SabotageEngine(ISimable *,float)
        /// </summary>
        public const int GAME__SABOTAGE_ENGINE = 0x6515D0;


        /// <summary>
        /// Game_BlowEngine(ISimable *)
        /// </summary>
        public const int BLOW_ENGINE = 0x6515A0;


        /// <summary>
        ///
        /// </summary>
        public const int DETACH_CAMERA_FROM_RACER = 0x65B5E0;


        /// <summary>
        ///
        /// </summary>
        public const int CHALLENGE_COMPLETE = 0x6568B0;


        /// <summary>
        ///
        /// </summary>
        public const int CLEAR_AICONTROL = 0x65C330;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_AICONTROL = 0x65C2C0;


        /// <summary>
        ///
        /// </summary>
        public const int RACE_OVER_CAR_BEHAVIOUR = 0x65BA40;


        /// <summary>
        ///
        /// </summary>
        public const int INIT_RACERS = 0x668A10;


        /// <summary>
        ///
        /// </summary>
        public const int WARP_PLAYER_TO_TRIGGER = 0x65DFF0;


        /// <summary>
        ///
        /// </summary>
        public const int WARP_PLAYER_AND_WINGMAN_TO_MARKER = 0x664E90;


        /// <summary>
        ///
        /// </summary>
        public const int SET_PLAYER_START_POSITION = 0x65B800;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACER_GOAL = 0x65B8F0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACER_LAPS_LEFT = 0x64B190;


        /// <summary>
        ///
        /// </summary>
        public const int KNOCKOUT_RACER = 0x65B4E0;


        /// <summary>
        ///
        /// </summary>
        public const int TOTAL_RACER = 0x65B4E0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_RACE_PLACEMENT = 0x6512E0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_SPEED_TRAP_TRIGGERED = 0x655960;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_CHECKPOINT_REACHED = 0x65B9E0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_LAP_FINISHED = 0x65E010;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_RACE_FINISHED = 0x660D20;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACE_ACTIVITY = 0x64B4C0;


        /// <summary>
        ///
        /// </summary>
        public const int START_RACE = 0x655F70;


        /// <summary>
        ///
        /// </summary>
        public const int START_RACE_TIMERS = 0x65BC50;


        /// <summary>
        ///
        /// </summary>
        public const int SAVE_START_POSITIONS = 0x64B480;


        /// <summary>
        ///
        /// </summary>
        public const int RESTORE_START_POSITIONS = 0x651320;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_FINISH_CAMERA = 0x6513A0;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_POST_RACE_FLOW = 0x65EF00;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_ONLINE_POST_RACE_SCREEN = 0x64BBB0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_COPS_ENABLED = 0x6513E0;


        /// <summary>
        ///
        /// </summary>
        public const int NO_NEW_PURSUITS_OR_COPS = 0x651420;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_PURSUIT_START = 0x651430;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_ENGAGEABLE_TRIGGER = 0x64B560;


        /// <summary>
        ///
        /// </summary>
        public const int EXIT_ENGAGABLE_TRIGGER = 0x65BDC0;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_GATE_ZONE = 0x65BE10;


        /// <summary>
        ///
        /// </summary>
        public const int EXIT_GATE_ZONE = 0x665910;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_RACE_OVER_SUMMARY = 0x65BF90;


        /// <summary>
        /// Game_SetTrafficSpeed(GRuntimeInstance *,float,float)
        /// </summary>
        public const int SET_TRAFFIC_SPEED = 0x6514E0;


        /// <summary>
        /// Game_SpawnCop(GRuntimeInstance *,char const *,bool,bool)
        /// </summary>
        public const int SPAWN_COP = 0x651180;


        /// <summary>
        /// Game_SpawnCharacter(GRuntimeInstance *,GRuntimeInstance *,GRuntimeInstance *,float)
        /// </summary>
        public const int SPAWN_CHARACTER = 0x64B120;


        /// <summary>
        /// Game_UnspawnCharacter(GRuntimeInstance *)
        /// </summary>
        public const int UNSPAWN_CHARACTER = 0x64B180;


        /// <summary>
        ///
        /// </summary>
        public const int SEND_CHARACTER_STIMULUS = 0x6511F0;


        /// <summary>
        ///
        /// </summary>
        public const int JACK_KNIFE = 0x651480;


        /// <summary>
        ///
        /// </summary>
        public const int SET_ALL_STAGING = 0x656430;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_PAUSE_MENU = 0x64B620;


        /// <summary>
        /// Game_AwardCash(ISimable *,float)
        /// </summary>
        public const int AWARD_CASH = 0x65C000;


        /// <summary>
        /// Game_AwardPoints(ISimable *,float)
        /// </summary>
        public const int AWARD_POINTS = 0x6565B0;


        /// <summary>
        ///
        /// </summary>
        public const int CHALLENGE_COMPLETED = 0x651550;


        /// <summary>
        ///
        /// </summary>
        public const int UNLOCK_RACE = 0x65C010;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_COUNTDOWN_DONE = 0x6567B0;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_COPS_FOR_RESTART = 0x651580;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_TRIGGER_ICON = 0x64B100;


        /// <summary>
        ///
        /// </summary>
        public const int HIDE_TRIGGER_ICON = 0x64B110;


        /// <summary>
        ///
        /// </summary>
        public const int WARP_TO_MARKER_WHEN_ROAMING = 0x64BF80;


        /// <summary>
        ///
        /// </summary>
        public const int DO_SPECIAL_FINALIZATION = 0x64BE50;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_ENGAGE_EVENTS = 0x64BB20;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_MENU_GATES = 0x64BB30;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_ENGAGE_SAFEHOUSE = 0x64BB40;


        /// <summary>
        ///
        /// </summary>
        public const int DO_SPECIAL_SETUP = 0x64BDF0;


        /// <summary>
        ///
        /// </summary>
        public const int JUMP_TO_CAR_LOT = 0x64B7A0;


        /// <summary>
        ///
        /// </summary>
        public const int ABANDON_RACE = 0x656300;


        /// <summary>
        ///
        /// </summary>
        public const int JUMP_TO_SAFE_HOUSE = 0x64B800;


        /// <summary>
        ///
        /// </summary>
        public const int JUMP_TO_NEW_WING_MAN = 0x64B850;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_GPS = 0x64B8A0;


        /// <summary>
        ///
        /// </summary>
        public const int NAVIGATE_PLAYER_TO = 0x64B8C0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_ACTIVITY_FINISHED = 0x651690;


        /// <summary>
        ///
        /// </summary>
        public const int CAREER_POST_RACE_FLOW = 0x64B1F0;


        /// <summary>
        ///
        /// </summary>
        public const int RACE_DONE = 0x656970;


        /// <summary>
        ///
        /// </summary>
        public const int SET_CHANCE_OF_RAIN = 0x64B9D0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_TUTORIAL = 0x65C3A0;


        /// <summary>
        ///
        /// </summary>
        public const int DO_SAFE_HOUSE_INTRO = 0x64BA50;


        /// <summary>
        ///
        /// </summary>
        public const int DO_ZONE_MENU_ACTION = 0x65BE90;


        /// <summary>
        ///
        /// </summary>
        public const int SET_CURRENT_TIME_OF_DAY = 0x64BD40;


        /// <summary>
        ///
        /// </summary>
        public const int RELOAD_WORLD = 0x64BDA0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_WORLD_HEAT = 0x65C550;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_WINNING_POST_RACE_SCREEN = 0x65E270;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_LOSING_POST_RACE_SCREEN = 0x65E240;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_ACQUISITION_SCREEN = 0x64BC50;


        /// <summary>
        ///
        /// </summary>
        public const int PREVENT_PLAYER_BEING_BUSTED = 0x6516D0;


        /// <summary>
        ///
        /// </summary>
        public const int CALCULATE_RANKING = 0x64BE70;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_STEER = 0x65C730;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_GAS = 0x65C770;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_BRAKE = 0x65C7B0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_HAND_BRAKE = 0x65C7F0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_NOS = 0x65C830;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_GET_SPEED = 0x65C880;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_WON = 0x64BFA0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_VEHICLE_ON_GROUND = 0x6516F0;


        /// <summary>
        ///
        /// </summary>
        public const int ACTIVATE_DRIFT_MODE = 0x65C8B0;


        /// <summary>
        ///
        /// </summary>
        public const int DEACTIVATE_DRIFT_MODE = 0x65C910;


        /// <summary>
        ///
        /// </summary>
        public const int DRIFT_SECTION_ENTERED = 0x64C000;


        /// <summary>
        ///
        /// </summary>
        public const int DRIFT_SECTION_ENTRY_ENDED = 0x64C020;


        /// <summary>
        ///
        /// </summary>
        public const int DRIFT_SECTION_EXITED = 0x64C040;


        /// <summary>
        ///
        /// </summary>
        public const int DRIFT_FINALIZE_SCORE = 0x64C060;


        /// <summary>
        ///
        /// </summary>
        public const int DRIFT_RESET_SCORE = 0x64C080;


        /// <summary>
        ///
        /// </summary>
        public const int USE_SECTIONS_IN_DRIFT = 0x64BFE0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_MAX_SCORE_FOR_SECTION = 0x64C0A0;


        /// <summary>
        ///
        /// </summary>
        public const int PRECALCULATE_DRIFT_OPPONENT_SCORES = 0x64C0C0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_WAS_TOO_SLOW_IN_DRIFT_RACE = 0x64C2B0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_WENT_OVERBOARD_IN_DRIFT_RACE = 0x64C2D0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_WENT_OVERBOARD_IN_CHECK_POINT_RACE = 0x64C330;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_WENT_OVERBOARD_IN_CANYON_DUEL = 0x64C2F0;


        /// <summary>
        ///
        /// </summary>
        public const int ACTIVATE_DRIFT_CAMERA = 0x64C0E0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_AIGOAL = 0x651750;


        /// <summary>
        ///
        /// </summary>
        public const int GET_WINGMAN = 0x6517E0;


        /// <summary>
        /// Game_SetPursuitTarget(ISimable *,ISimable *)
        /// </summary>
        public const int SET_PURSUIT_TARGET = 0x6517A0;


        /// <summary>
        /// Game_SetPursuitOffset(ISimable *,float,float)
        /// </summary>
        public const int SET_PURSUIT_OFFSET = 0x651810;


        /// <summary>
        ///
        /// </summary>
        public const int TIME_PLAYER_FACING_WRONG_WAY = 0x65C970;


        /// <summary>
        /// Game_TriggerCrewIndication(int, char const *, char const *)
        /// </summary>
        public const int TRIGGER_CREW_INDICATION = 0x65C9A0;


        /// <summary>
        ///
        /// </summary>
        public const int FINALIZE_SCORES = 0x64C140;


        /// <summary>
        ///
        /// </summary>
        public const int CANYON_RACE_CLEAR = 0x64C170;


        /// <summary>
        ///
        /// </summary>
        public const int CANYON_RACE_SETUP = 0x656980;


        /// <summary>
        ///
        /// </summary>
        public const int CANYON_RACE_UPDATE = 0x64C1D0;


        /// <summary>
        ///
        /// </summary>
        public const int CANYON_RACE_STATE = 0x64C1F0;


        /// <summary>
        ///
        /// </summary>
        public const int KNOCKOUT_RACE_SETUP = 0x64C190;


        /// <summary>
        /// 
        /// </summary>
        public const int KNOCKOUT_RACE_UPDATE = 0x64C1B0;


        /// <summary>
        ///
        /// </summary>
        public const int GET_STORY_LINE_PROGRESSION = 0x64C380;


        /// <summary>
        ///
        /// </summary>
        public const int ADVANCE_STORY_LINE_PROGRESSION = 0x64C390;


        /// <summary>
        /// Game_StartRaceFromInGame(char const *)
        /// </summary>
        public const int START_RACE_FROM_IN_GAME = 0x64C3B0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_STORY_RACE_FLAG = 0x64C4A0;


        /// <summary>
        ///
        /// </summary>
        public const int GET_OVER_ALL_WON_ATTACK_RACES = 0x64C3F0;


        /// <summary>
        ///
        /// </summary>
        public const int GET_WON_ATTACK_RACESIN_AREA = 0x64C3D0;


        /// <summary>
        ///
        /// </summary>
        public const int QUIT_TO_CAR_CLASS_SELECT_SCREEN = 0x64C450;


        /// <summary>
        ///
        /// </summary>
        public const int QUIT_TO_LOGO_SCREEN = 0x64C400;


        /// <summary>
        ///
        /// </summary>
        public const int SKIP_CAREER_INTRO = 0x64C560;


        /// <summary>
        /// Game_SetCareerEventContext(int)
        /// </summary>
        public const int SET_CAREER_EVENT_CONTEXT = 0x64C570;


        /// <summary>
        ///
        /// </summary>
        public const int SETUP_CREW_TUTORIAL = 0x65CAF0;


        /// <summary>
        ///
        /// </summary>
        public const int DISMISS_TUTORIAL_AI = 0x656C30;


        /// <summary>
        ///
        /// </summary>
        public const int FINISH_TUTORIAL = 0x65CBC0;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_DRAFTING = 0x651C30;


        /// <summary>
        ///
        /// </summary>
        public const int DO_POST_BOSS_FLOW = 0x656C80;


        /// <summary>
        ///
        /// </summary>
        public const int FINISH_CREW_DEFECTION_FLOW = 0x667DF0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOULD_DO_SPECIAL_DEFECTION_FLOW = 0x64C5B0;


        /// <summary>
        ///
        /// </summary>
        public const int UNLOCK_NIKKI = 0x667FF0;


        /// <summary>
        ///
        /// </summary>
        public const int UPATE_BOSS_STATE = 0x64C600;


        /// <summary>
        ///
        /// </summary>
        public const int CREATE_DEFECTOR_CAR = 0x65E280;


        /// <summary>
        ///
        /// </summary>
        public const int PLACE_CREW_VEHICLE = 0x651DC0;


        /// <summary>
        ///
        /// </summary>
        public const int IS_CREW_VEHICLE_LOADED = 0x651FB0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_FREE_ROAM_START_MARKER = 0x64C590;


        /// <summary>
        ///
        /// </summary>
        public const int YOU_WON = 0x64C670;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACE_EXPIRED = 0x652000;


        /// <summary>
        ///
        /// </summary>
        public const int MUSIC__REQUEST_TRANSITION = 0x652080;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_CANYON_MUSIC = 0x0064C770;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_PURSUIT_MUSIC = 0x0064C7A0;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_LICENSED_MUSIC = 0x0064C7D0;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_CREW_MUSIC = 0x0064C740;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_KILL_MUSIC = 0x0064C800;


        /// <summary>
        ///
        /// </summary>
        public const int SPEECH__RACE_OVER = 0x65CC80;


        /// <summary>
        ///
        /// </summary>
        public const int RENDER__ENABLE_CRASH_VISUAL_TREATMENT = 0x64CA00;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA__ACTIVATE_DEFECTOR_CAMERA = 0x65CD50;


        /// <summary>
        ///
        /// </summary>
        public const int GAME__PLAYER_HUD_EXIST = 0x6522F0;


        /// <summary>
        ///
        /// </summary>
        public const int ACTIVATE_DEFAULT_CAMERA_OVERRIDE = 0x0064C830;


        /// <summary>
        ///
        /// </summary>
        public const int DEACTIVATE_DEFAULT_CAMERA_OVERRIDE = 0x64C960;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_FINISH_LINE = 0x64B0A0;


        /// <summary>
        ///
        /// </summary>
        public const int SETUP_CREW_DEFECTION_TRIGGER = 0x651D50;


        /// <summary>
        ///
        /// </summary>
        public const int CLEAR_CAREER_VEHICLE = 0x64CA20;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_ICONS = 0x652330;


        /// <summary>
        /// Racer_ForceCoast(int)
        /// </summary>
        public const int RACER__FORCE_COAST = 0x64CA30;


        /// <summary>
        ///
        /// </summary>
        public const int END_FORCE_STOP = 0x64CA50;


        /// <summary>
        /// Game_HideLoadingScreen(int)
        /// </summary>
        public const int GAME__HIDE_LOADING_SCREEN = 0x64CA70;


        /// <summary>
        ///
        /// </summary>
        public const int ENABLE_TRIGGER = 0x64C5D0;


        /// <summary>
        ///
        /// </summary>
        public const int GAME__SET_TIMER = 0x64A8C0;


        /// <summary>
        ///
        /// </summary>
        public const int GAME__KILL_TIMER = 0x64A8E0;


        /// <summary>
        ///
        /// </summary>
        public const int DIALOG_BOX__GENERATE = 0x5CDEA0;


        /// <summary>
        ///
        /// </summary>
        public const int DIALOG_BOX__OK = 0x5CF440;


        /// <summary>
        ///
        /// </summary>
        public const int DIALOG_BOX__OKCANCEL = 0x5CF460;


        /// <summary>
        ///
        /// </summary>
        public const int DIALOG_BOX__YES_NO = 0x5CF4B0;


        /// <summary>
        ///
        /// </summary>
        public const int DIALOG_BOX__CANCEL = 0x5CF490;


    }

    /// <summary>
    /// A class for ProStreet functions.
    /// </summary>
    public static class ProStreetFunctions
    {
        /// <summary>
        /// LUA function: FEDialogScreen::ShowCancel((char const *))
        /// </summary>
        public const int FEDIALOGSCREEN_SHOW_CANCEL = 0x0060C6C0;

        /// <summary>
        /// LUA function: FEDialogScreen::ShowDialog((char const *, char const *, char const *, char const *, bool))
        /// </summary>
        public const int FEDIALOGSCREEN_SHOW_DIALOG = 0x0060B130;

        /// <summary>
        /// LUA function: FEDialogScreen::ShowOk((char const *))
        /// </summary>
        public const int FEDIALOGSCREEN_SHOW_OK = 0x0060C5E0;

        /// <summary>
        /// LUA function: FEDialogScreen::ShowOkCancel((char const *))
        /// </summary>
        public const int FEDIALOGSCREEN_SHOW_OK_CANCEL = 0x0060C630;

        /// <summary>
        /// LUA function: FEDialogScreen::ShowYesNo((char const *))
        /// </summary>
        public const int FEDIALOGSCREEN_SHOW_YES_NO = 0x0060C710;

        /// <summary>
        ///
        /// </summary>
        public const int TABLE__RANDOMIZE = 0x6EF100;


        /// <summary>
        ///
        /// </summary>
        public const int DEBUG__EXECUTE_DEBUG_SCRIPT = 0x4DF1E0;


        /// <summary>
        ///
        /// </summary>
        public const int LUA_DEBUG__EXECUTE_LINE = 0x4DF1E0;


        /// <summary>
        ///
        /// </summary>
        public const int ACTIVITY__SUSPEND = 0x6DE1F0;


        /// <summary>
        ///
        /// </summary>
        public const int AUDIO__SET_FLAG = 0x6DE200;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA__SET_GENERIC_CAMERA = 0x6E1F40;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA__SET_SMOOTH_EXIT = 0x6DE350;


        /// <summary>
        ///
        /// </summary>
        public const int NIS__PLAY = 0x6E9370;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_REEZE_CAMERA = 0x6E2070;


        /// <summary>
        ///
        /// </summary>
        public const int NIS__WAIT_FOR_PIP = 0x466AB0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS__LAUNCH_PIP = 0x6E2030;


        /// <summary>
        ///
        /// </summary>
        public const int DEBUG__SHOW_SCREEN_MESSAGE = 0x6EA4D0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_MESSAGE = 0x6E9630;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_TIME_EXTENSION = 0x6E9920;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_LOOPING_MESSAGE = 0x6E9730;


        /// <summary>
        ///
        /// </summary>
        public const int HIDE_LOOPING_MESSAGE = 0x6E98A0;


        /// <summary>
        ///
        /// </summary>
        public const int SABOTAGE_ENGINE = 0x6E5760;


        /// <summary>
        ///
        /// </summary>
        public const int BLOW_ENGINE = 0x6E5730;


        /// <summary>
        ///
        /// </summary>
        public const int DETACH_CAMERA_FROM_RACER = 0x6E2130;


        /// <summary>
        ///
        /// </summary>
        public const int CHALLENGE_COMPLETE = 0x6DEF00;


        /// <summary>
        ///
        /// </summary>
        public const int CLEAR_AI_CONTROL = 0x6EA760;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_AI_CONTROL = 0x6EA6F0;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_PLAYER_TRIGGER_ENTERED = 0x6E99A0;


        /// <summary>
        ///
        /// </summary>
        public const int WARP_PLAYER_TO_TRIGGER = 0x6EB220;


        /// <summary>
        ///
        /// </summary>
        public const int WARP_PLAYER_AND_WINGMAN_TO_MARKER = 0x6E9AC0;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_TRIGGER = 0x6DE3D0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_PLAYER_START_POSITION = 0x6E9C30;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACER_LAPS_LEFT = 0x6DE4B0;


        /// <summary>
        ///
        /// </summary>
        public const int KNOCKOUT_RACER = 0x6E99B0;


        /// <summary>
        ///
        /// </summary>
        public const int TOTAL_RACER = 0x6E99B0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_RACER_FINISHED = 0x6E2560;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_SPEED_TRAP_TRIGGERED = 0x6E4CA0;


        /// <summary>
        ///
        /// </summary>
        public const int STORE_CHECKPOINT_SPEED = 0x6E2290;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_SECTOR_TRIGGER_ENTER = 0x6E2160;


        /// <summary>
        ///
        /// </summary>
        public const int CALCULATE_SECTOR_POINTS = 0x6DE4D0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_FAILED_TO_POST_SECTOR_RECORD = 0x6DE560;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_SECTOR_RECORD_POSTED = 0x6DE620;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_SECTOR_RECORD_BROKEN = 0x6DE720;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_SECTOR_DOMINATION = 0x6DE780;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_SECTOR_OWNERSHIP_CHANGED = 0x6DE7A0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_SECTOR_COMPLETED = 0x6E21F0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_LAP_FINISHED = 0x6E2440;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_RACE_FINISHED = 0x6E9D00;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACE_ACTIVITY = 0x6DEAB0;


        /// <summary>
        ///
        /// </summary>
        public const int START_RACE = 0x6E5310;


        /// <summary>
        ///
        /// </summary>
        public const int SAVE_START_POSITIONS = 0x6DEA30;


        /// <summary>
        ///
        /// </summary>
        public const int RESTORE_START_POSITIONS = 0x6DEA70;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_GRID_PLACEMENT = 0x6E4F40;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_FINISH_CAMERA = 0x6E9E60;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_POST_RACE_FLOW = 0x6E9EA0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_ONLINE_POST_RACE_SCREEN = 0x6DF1C0;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_ENGAGABLE_TRIGGER = 0x6DEAF0;


        /// <summary>
        ///
        /// </summary>
        public const int EXIT_ENGAGABLE_TRIGGER = 0x6EA130;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_GATE_ZONE = 0x6EA180;


        /// <summary>
        ///
        /// </summary>
        public const int EXIT_GATE_ZONE = 0x6EA1D0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_RACE_OVER_SUMMARY = 0x6EA320;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_CHARACTER = 0x6DE440;


        /// <summary>
        ///
        /// </summary>
        public const int UNSPAWN_CHARACTER = 0x6DE4A0;


        /// <summary>
        ///
        /// </summary>
        public const int SEND_CHARACTER_STIMULUS = 0x6E4BD0;


        /// <summary>
        ///
        /// </summary>
        public const int JACK_KNIFE = 0x6E2650;


        /// <summary>
        ///
        /// </summary>
        public const int SET_ALL_STAGING = 0x6EA3A0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_PAUSE_MENU = 0x6DEBA0;


        /// <summary>
        ///
        /// </summary>
        public const int AWARD_CASH = 0x6E2750;


        /// <summary>
        ///
        /// </summary>
        public const int AWARD_POINTS = 0x6DEC00;


        /// <summary>
        ///
        /// </summary>
        public const int CHALLENGE_COMPLETED = 0x6E2770;


        /// <summary>
        ///
        /// </summary>
        public const int UNLOCK_RACE = 0x6EA470;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_TRIGGER_ICON = 0x6DE3E0;


        /// <summary>
        ///
        /// </summary>
        public const int HIDE_TRIGGER_ICON = 0x6DE3F0;


        /// <summary>
        ///
        /// </summary>
        public const int WARP_TO_MARKER_WHEN_ROAMING = 0x6DF300;


        /// <summary>
        ///
        /// </summary>
        public const int DO_SPECIAL_FINALIZATION = 0x6DF2E0;


        /// <summary>
        ///
        /// </summary>
        public const int IS_ACTIVE_SPEED_TRAP = 0x466AB0;


        /// <summary>
        ///
        /// </summary>
        public const int IS_ACTIVE_MENU_GATE = 0x6DE8C0;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_ENGAGE_EVENTS = 0x6DF0F0;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_MENU_GATES = 0x6DF100;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_ENGAGE_SAFEHOUSE = 0x6DF110;


        /// <summary>
        ///
        /// </summary>
        public const int DO_SPECIAL_SETUP = 0x6DF2C0;


        /// <summary>
        ///
        /// </summary>
        public const int CLEAR_RACERS = 0x65DE70;


        /// <summary>
        ///
        /// </summary>
        public const int CLEAR_CHECKPOINTS = 0x6797A0;


        /// <summary>
        ///
        /// </summary>
        public const int ADD_CHECKPOINT = 0x67AD70;


        /// <summary>
        ///
        /// </summary>
        public const int SET_NEXT_CHECKPOINT_POS = 0x68F340;


        /// <summary>
        ///
        /// </summary>
        public const int SET_ROAMING = 0x68F020;


        /// <summary>
        ///
        /// </summary>
        public const int SET_IS_LOADING = 0x656130;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_LOADING_SCREEN = 0x6DFA20;


        /// <summary>
        ///
        /// </summary>
        public const int HIDE_LOADING_SCREEN = 0x6DF9C0;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_SUDDEN_DEATH = 0x6DE090;


        /// <summary>
        ///
        /// </summary>
        public const int AWARD_BONUS_TIME = 0x68F2D0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_ACTIVELY_RACING = 0x6DE0C0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_TASK_TIME = 0x6DE0A0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_SCRIPT_WHEN_LOADED = 0x6572C0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_HAS_BEEN_WON = 0x6DE0D0;


        /// <summary>
        ///
        /// </summary>
        public const int END_STOP_ALL = 0x66D4B0;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_RACE_DATA = 0x68ECC0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_WAIT_FOR_MUSIC_TRANSITION = 0x6DE0E0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_IS_RESTART_ALLOWED = 0x6561E0;


        /// <summary>
        ///
        /// </summary>
        public const int START_MASTER_TIMER = 0x68EDE0;


        /// <summary>
        ///
        /// </summary>
        public const int STOP_MASTER_TIMER = 0x666F70;


        /// <summary>
        ///
        /// </summary>
        public const int FINALIZE_STATISTICS = 0x65E240;


        /// <summary>
        ///
        /// </summary>
        public const int CALCULATE_STATISTICS = 0x684430;


        /// <summary>
        ///
        /// </summary>
        public const int SETUP_AIRACE_LINE = 0x684230;


        /// <summary>
        ///
        /// </summary>
        public const int SET_NUM_SECTORS = 0x657830;


        /// <summary>
        ///
        /// </summary>
        public const int SET_SECTOR_TIME = 0x657870;


        /// <summary>
        ///
        /// </summary>
        public const int SET_SECTOR_OWNER = 0x657840;


        /// <summary>
        ///
        /// </summary>
        public const int SET_SECTOR_BEST_POINTS = 0x657890;


        /// <summary>
        ///
        /// </summary>
        public const int SET_SECTOR_DISTANCES = 0x6900A0;


        /// <summary>
        ///
        /// </summary>
        public const int PREPARE = 0x693F10;


        /// <summary>
        ///
        /// </summary>
        public const int PLACE_GRID = 0x694270;


        /// <summary>
        ///
        /// </summary>
        public const int CLEANUP = 0x690430;


        /// <summary>
        ///
        /// </summary>
        public const int FINISH = 0x684320;


        /// <summary>
        ///
        /// </summary>
        public const int FINISH_DISCONNECTED = 0x672180;


        /// <summary>
        ///
        /// </summary>
        public const int CALCULATE_RANKINGS = 0x683F90;


        /// <summary>
        ///
        /// </summary>
        public const int STORE_STATISTICS = 0x677230;


        /// <summary>
        ///
        /// </summary>
        public const int CHANGE_TO_PLAYER_VIEW = 0x667140;


        /// <summary>
        ///
        /// </summary>
        public const int CHANGE_TO_CINEMATIC_VIEW = 0x6671B0;


        /// <summary>
        ///
        /// </summary>
        public const int STATE_OVERRIDE_ALL = 0x667220;


        /// <summary>
        ///
        /// </summary>
        public const int STATE_CATCHUP_ALL = 0x667250;


        /// <summary>
        ///
        /// </summary>
        public const int STATE_CHECK_ALL = 0x6579B0;


        /// <summary>
        ///
        /// </summary>
        public const int STATE_CHECK = 0x66D610;


        /// <summary>
        ///
        /// </summary>
        public const int STATE_CHECK_ANY = 0x66D6F0;


        /// <summary>
        ///
        /// </summary>
        public const int STATE_CHECK_FIRST = 0x66D760;


        /// <summary>
        ///
        /// </summary>
        public const int UPDATE_POST_RACE_STATS = 0x6672A0;


        /// <summary>
        ///
        /// </summary>
        public const int RACE_SHOW_TURN_INDICATOR = 0x6672C0;


        /// <summary>
        ///
        /// </summary>
        public const int RACE_HIDE_TURN_INDICATOR = 0x667380;


        /// <summary>
        ///
        /// </summary>
        public const int RACE_ENABLE_DAMAGE = 0x66D220;


        /// <summary>
        ///
        /// </summary>
        public const int RACE_SET_HANDICAP = 0x657200;


        /// <summary>
        ///
        /// </summary>
        public const int DO_DDAY_RESET = 0x6905E0;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_STAGING = 0x66C080;


        /// <summary>
        ///
        /// </summary>
        public const int EXIT_STAGING = 0x67FCC0;


        /// <summary>
        ///
        /// </summary>
        public const int START_RACE_2 = 0x6985E0;


        /// <summary>
        ///
        /// </summary>
        public const int FINISH_RACE = 0x6987B0;


        /// <summary>
        ///
        /// </summary>
        public const int EXTRAPOLATE_FINISH = 0x698900;


        /// <summary>
        ///
        /// </summary>
        public const int PRE_PASS_STATISTICS = 0x68DF70;


        /// <summary>
        ///
        /// </summary>
        public const int SET_FOR_BEST_SECTOR = 0x656DD0;


        /// <summary>
        ///
        /// </summary>
        public const int ENABLE_COLLISIONS = 0x66C620;


        /// <summary>
        ///
        /// </summary>
        public const int DISABLE_COLLISIONS = 0x66C580;


        /// <summary>
        ///
        /// </summary>
        public const int SET_STAGING = 0x68D9F0;


        /// <summary>
        ///
        /// </summary>
        public const int ENABLE_DAMAGE = 0x66C1E0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_NEXT_GOAL = 0x692B60;


        /// <summary>
        ///
        /// </summary>
        public const int RACE_OVER = 0x66C220;


        /// <summary>
        ///
        /// </summary>
        public const int LAUNCH = 0x66C250;


        /// <summary>
        ///
        /// </summary>
        public const int SET_DIST_DRIVEN = 0x6DE020;


        /// <summary>
        ///
        /// </summary>
        public const int SET_TIMER = 0x65D090;


        /// <summary>
        ///
        /// </summary>
        public const int KILL_TIMER = 0x65D140;


        /// <summary>
        ///
        /// </summary>
        public const int SET_HANDICAP = 0x656100;


        /// <summary>
        ///
        /// </summary>
        public const int SAVE_START_POSITION = 0x68E3B0;


        /// <summary>
        ///
        /// </summary>
        public const int HAS_FINISH_REASON = 0x656AF0;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_STOP = 0x66C7C0;


        /// <summary>
        ///
        /// </summary>
        public const int CHECKPOINT_REACHED = 0x692AF0;


        /// <summary>
        ///
        /// </summary>
        public const int START_EXTRAPOLATION = 0x66C500;


        /// <summary>
        ///
        /// </summary>
        public const int STOP_EXTRAPOLATION = 0x66C540;


        /// <summary>
        ///
        /// </summary>
        public const int ENABLE_AI_CONTROL = 0x695F60;


        /// <summary>
        ///
        /// </summary>
        public const int SET_COUNTDOWN_DISABLED = 0x666320;


        /// <summary>
        ///
        /// </summary>
        public const int SET_STATE = 0x666C00;


        /// <summary>
        ///
        /// </summary>
        public const int AWARD_PLAYER_BOUNTY = 0x6EA570;


        /// <summary>
        ///
        /// </summary>
        public const int JUMP_TO_CAR_LOT = 0x6DEE30;


        /// <summary>
        ///
        /// </summary>
        public const int ABANDON_RACE = 0x6E5570;


        /// <summary>
        ///
        /// </summary>
        public const int JUMP_TO_SAFE_HOUSE = 0x6DEEA0;


        /// <summary>
        ///
        /// </summary>
        public const int NAVIGATE_PLAYER_TO = 0x6DEF40;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_TUTORIAL = 0x6E2800;


        /// <summary>
        ///
        /// </summary>
        public const int DO_ZONE_MENU_ACTION = 0x6EA210;


        /// <summary>
        ///
        /// </summary>
        public const int RELOAD_WORLD = 0x6DF260;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_WINNING_POST_RACE_SCREEN = 0x6E28B0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_LOSING_POST_RACE_SCREEN = 0x6E28A0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_STEER = 0x6EA820;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_GAS = 0x6EA860;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_BRAKE = 0x6EA8A0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_HAND_BRAKE = 0x6EA8E0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_NOS = 0x6EA920;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_WON = 0x6DF320;


        /// <summary>
        ///
        /// </summary>
        public const int SET_VEHICLE_ON_GROUND = 0x6E5790;


        /// <summary>
        ///
        /// </summary>
        public const int ACTIVATE_DRIFT_MODE = 0x6EA9A0;


        /// <summary>
        ///
        /// </summary>
        public const int DEACTIVATE_DRIFT_MODE = 0x6EAA00;


        /// <summary>
        ///
        /// </summary>
        public const int DRIFT_SECTION_ENTERED = 0x6DF350;


        /// <summary>
        ///
        /// </summary>
        public const int DRIFT_SECTION_EXITED = 0x6DF390;


        /// <summary>
        ///
        /// </summary>
        public const int DRIFT_FEEDBACK_TRIGGER_ENTERED = 0x6DF3C0;


        /// <summary>
        ///
        /// </summary>
        public const int DRIFT_FINALIZE_SCORE = 0x6DF400;


        /// <summary>
        ///
        /// </summary>
        public const int DRIFT_RESET_SCORE = 0x6DF450;


        /// <summary>
        ///
        /// </summary>
        public const int USE_SECTIONS_IN_DRIFT = 0x6DF340;


        /// <summary>
        ///
        /// </summary>
        public const int SET_MAX_SCORE_FOR_SECTION = 0x6DF490;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_WAS_TOO_SLOW_IN_DRIFT_RACE = 0x466AB0;


        /// <summary>
        ///
        /// </summary>
        public const int WIND_TRIGGER_ENTERED = 0x6EAA70;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_TRIGGER_ENTERED = 0x6DE3B0;


        /// <summary>
        ///
        /// </summary>
        public const int ACTIVATE_DRIFT_CAMERA = 0x6DF4A0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_AIGOAL = 0x6E5810;


        /// <summary>
        ///
        /// </summary>
        public const int START_RACE_FROM_IN_GAME = 0x6DF4D0;


        /// <summary>
        ///
        /// </summary>
        public const int SKIP_CAREER_INTRO = 0x6DF580;


        /// <summary>
        ///
        /// </summary>
        public const int SET_FREE_ROAM_START_MARKER = 0x6DF590;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACE_EXPIRED = 0x6E28C0;


        /// <summary>
        ///
        /// </summary>
        public const int MUSIC__REQUEST_TRANSITION = 0x6E2990;


        /// <summary>
        ///
        /// </summary>
        public const int MUSIC__SET_WAIT_STATE = 0x6DF600;


        /// <summary>
        ///
        /// </summary>
        public const int MUSIC__FORCE_KILL_MUSIC = 0x6DF790;


        /// <summary>
        ///
        /// </summary>
        public const int RENDER__ENABLE_CRASH_VISUAL_TREATMENT = 0x6DF950;


        /// <summary>
        ///
        /// </summary>
        public const int RENDER__KILL_SMOKE = 0x6DF970;


        /// <summary>
        ///
        /// </summary>
        public const int ACTIVATE_DEFAULT_CAMERA_OVERRIDE = 0x6DF7E0;


        /// <summary>
        ///
        /// </summary>
        public const int DEACTIVATE_DEFAULT_CAMERA_OVERRIDE = 0x6DF8D0;


        /// <summary>
        ///
        /// </summary>
        public const int INFINITE_LAPS = 0x466AB0;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_ICONS = 0x6E2B20;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_COAST = 0x6DF980;


        /// <summary>
        ///
        /// </summary>
        public const int RACER__END_FORCE_STOP = 0x6DF9A0;


        /// <summary>
        ///
        /// </summary>
        public const int ENABLE_TRIGGER = 0x6DF5B0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOULD_SKIP_MATCHUP_SCREEN = 0x6DFA80;


        /// <summary>
        ///
        /// </summary>
        public const int UPDATE_SCORES = 0x6DFB20;


        /// <summary>
        ///
        /// </summary>
        public const int UPDATE_EVENT_SCORES = 0x6DFB30;


        /// <summary>
        ///
        /// </summary>
        public const int MOVIE__REFRESH_TRACK_AFTER_PLAYING = 0x6DFBD0;


        /// <summary>
        ///
        /// </summary>
        public const int TRACK__ENABLE_ZONE_SWITCHING = 0x6DFBF0;


        /// <summary>
        ///
        /// </summary>
        public const int CHECK_KING_HUB_DOMINATED = 0x6DFC10;

    }

    /// <summary>
    /// A class for Undercover functions.
    /// </summary>
    public static class UndercoverFunctions
    {
        /// <summary>
        /// LUA function: FE::FEDialogScreen::ShowOk(char const *, bool)
        /// </summary>
        public const int FEDIALOGSCREEN_SHOW_OK = 0x005B01E0;

        /// <summary>
        /// 
        /// </summary>
        public const int FEDIALOGSCREEN_SHOW_OK_CANCEL = 0x005B0250;

        /// <summary>
        /// 
        /// </summary>
        public const int FEDIALOGSCREEN_SHOW_YES_NO = 0x005B0310;

        /// <summary>
        /// 
        /// </summary>
        public const int FEDIALOGSCREEN_SHOW_CANCEL = 0x005A3D80;

        /// <summary>
        /// LUA function: FE::FEDialogScreen::ShowDialog(char const *, char const *, char const *, char const *)
        /// </summary>
        public const int FEDIALOGSCREEN_SHOW_DIALOG = 0x005A3BE0;
        
        /// <summary>
        /// 
        /// </summary>
        public const int FORCE_PURSUIT_START = 0x0065C840;

        /// <summary>
        /// 
        /// </summary>
        public const int BAIL_PURSUIT = 0x6672F0;

        /// <summary>
        /// 
        /// </summary>
        public const int FORCE_PURSUIT_END = 0x669000;


        /// <summary>
        ///
        /// </summary>
        public const int ACTIVITY__RUN = 0x006592D0;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_SYSTEM = 0x66C5E0;


        /// <summary>
        ///
        /// </summary>
        public const int RESTART_MISSION = 0x67ACA0;


        /// <summary>
        ///
        /// </summary>
        public const int CHANGE_GAME_MODE = 0x667AB0;


        /// <summary>
        ///
        /// </summary>
        public const int PUDDLE = 0x66BC20;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_HUD_COST_TO_STATE_POINTS = 0x66ECE0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_SOUND_EVENT = 0x66AA10;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_PLAY_SOUND_EFFECT = 0x66A690;


        /// <summary>
        ///
        /// </summary>
        public const int PROCESS_AREA_STIMULUS = 0x66B870;


        /// <summary>
        ///
        /// </summary>
        public const int TERMINATE_MUSIC = 0x66E8E0;


        /// <summary>
        ///
        /// </summary>
        public const int END_MISSION = 0x678C10;


        /// <summary>
        ///
        /// </summary>
        public const int DISABLE_PURSUIT_VEHICLE = 0x668460;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA_PHOTO_FINISH = 0x667790;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA_SHAKE = 0x6677D0;


        /// <summary>
        ///
        /// </summary>
        public const int ICECAR_ATTACH = 0x669450;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_HIDE_CHARACTER = 0x679A70;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_RESULTS = 0x66D980;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_HUD_PURSUIT_BAR = 0x66F360;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_MISSION_NIS = 0x67A290;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_CANYON_INSTRUCTION_FLASHERS = 0x66D3D0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_NUKE_SMACK = 0x66A3C0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_LAST_SCENE = 0x679BA0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_MISSION_TRAFFIC_DENSITY = 0x66CC50;


        /// <summary>
        ///
        /// </summary>
        public const int STOP_OBJECT_EFFECT = 0x66E690;


        /// <summary>
        ///
        /// </summary>
        public const int MAIN_SERVICE = 0x669C00;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA_TRACK_CAR = 0x667890;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_MISSION_FMV = 0x67A0C0;


        /// <summary>
        ///
        /// </summary>
        public const int END_CAR_STOP = 0x668850;


        /// <summary>
        ///
        /// </summary>
        public const int COKE_CHALLENGE_TRIGGER = 0x667D20;


        /// <summary>
        ///
        /// </summary>
        public const int DYNAMIC_REGION = 0x6686E0;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_COP_CAM = 0x66EB10;


        /// <summary>
        ///
        /// </summary>
        public const int BECOME_PLAYER_CAR = 0x6673B0;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_AIVEHICLE = 0x66DFD0;


        /// <summary>
        ///
        /// </summary>
        public const int STOP_CUSTOM_MUSIC = 0x66E650;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_HUD_RVM = 0x66F3A0;


        /// <summary>
        ///
        /// </summary>
        public const int PROCESS_STIMULUS = 0x66BBC0;


        /// <summary>
        ///
        /// </summary>
        public const int DEBUG_PRINT = 0x6680E0;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_CAR_STOP = 0x668FB0;


        /// <summary>
        ///
        /// </summary>
        public const int BECOME_AI_CAR = 0x667360;


        /// <summary>
        ///
        /// </summary>
        public const int DISMISS_AIFROM_RACE = 0x6684E0;


        /// <summary>
        ///
        /// </summary>
        public const int DEBUG_SCREEN_MESSAGE = 0x6681F0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_PLAYER_COLLISION_CACHE = 0x66D2A0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_AIVEHICLE_DRIVER_SUBCLASS = 0x66C870;


        /// <summary>
        ///
        /// </summary>
        public const int WORLD_MAP_ON_IN_TRIGGER = 0x66FBB0;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_HUD_WORLD_DAMAGE = 0x66F570;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_EXPLOSION = 0x66E1A0;


        /// <summary>
        ///
        /// </summary>
        public const int MISSION_FLASHER = 0x698670;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_WORLD_EXPLOSION = 0x66E510;


        /// <summary>
        ///
        /// </summary>
        public const int ENABLE_COLLISION_GEOMETRY = 0x6687B0;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_HUD_DISTANCE_BAR = 0x66EF20;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_HUD_DISTANCE_TO_LOCATION = 0x66F050;


        /// <summary>
        ///
        /// </summary>
        public const int MAIN_MIN_BOOT = 0x6699C0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_LIGHTS = 0x684EC0;


        /// <summary>
        ///
        /// </summary>
        public const int SURFACE_EFFECT = 0x66E720;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_RAIN = 0x66A790;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CAR_SMOKE_KILL = 0x669F60;


        /// <summary>
        ///
        /// </summary>
        public const int FIRE_EVENT_TAG = 0x678FD0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_DETAIL = 0x66A130;


        /// <summary>
        ///
        /// </summary>
        public const int LOCKOUT_NON_SCRIPTED_COPS = 0x6696F0;


        /// <summary>
        ///
        /// </summary>
        public const int REFRESH_HUD = 0x66C0D0;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_PROPS = 0x66C3F0;


        /// <summary>
        ///
        /// </summary>
        public const int WORLD_MAP_ON = 0x66FB30;


        /// <summary>
        ///
        /// </summary>
        public const int HUD_FADE_TO_BLACK_ON = 0x669390;


        /// <summary>
        ///
        /// </summary>
        public const int DESPAWN_AIVEHICLE = 0x668380;


        /// <summary>
        ///
        /// </summary>
        public const int NISCAR_DAMAGE_RESET = 0x6849C0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_MINIMAP_TARGET = 0x66D4D0;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_SEQUENCER = 0x66C4B0;


        /// <summary>
        ///
        /// </summary>
        public const int LOAD_LOST = 0x6695D0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_TOTALLED_ANIM = 0x66DAC0;


        /// <summary>
        ///
        /// </summary>
        public const int MAIN_RENDER = 0x669B00;


        /// <summary>
        ///
        /// </summary>
        public const int END_SPEED_BREAKER = 0x6688C0;


        /// <summary>
        ///
        /// </summary>
        public const int ICE_CAMERA_PAUSE = 0x6693D0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_STOP_EFFECTS = 0x66AB20;


        /// <summary>
        ///
        /// </summary>
        public const int GTRIGGER_INTERNAL = 0x684030;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_MOMENT_BY_POSITION = 0x66B350;


        /// <summary>
        ///
        /// </summary>
        public const int VOICE_OVER_MOMENT = 0x66F9A0;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_HITPOINT_DAMAGE = 0x66EBD0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_MESSAGE_SCREEN = 0x66D410;


        /// <summary>
        ///
        /// </summary>
        public const int SET_AIPLAYER_OFFSET = 0x66C7A0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_NITRO = 0x684FF0;


        /// <summary>
        ///
        /// </summary>
        public const int HIDE_PART = 0x6692D0;


        /// <summary>
        ///
        /// </summary>
        public const int DRIVE_SAFELY = 0x668570;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_RACE_MOVIE = 0x66B710;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_TIME_OF_DAY = 0x66ABA0;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_HUD_OPPONENT_ICON = 0x66F2D0;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_COP = 0x66E100;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_SPOT_LIGHT = 0x66AA50;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA_HELI_COP_CAM = 0x667620;


        /// <summary>
        ///
        /// </summary>
        public const int E_RESTART_MISSION = 0x67ACA0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_MISSION_VOICE_OVER = 0x67A490;


        /// <summary>
        ///
        /// </summary>
        public const int ICE_CAMERA_UNPAUSE = 0x669410;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_DETACH = 0x66A050;


        /// <summary>
        ///
        /// </summary>
        public const int SET_OPPONENT_GOAL = 0x66CEB0;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_PUSH_BUTTON_OVERLAY = 0x66F680;


        /// <summary>
        ///
        /// </summary>
        public const int UNBLOCK_INPUT = 0x66F840;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_LIGHT_RIGS = 0x66A270;


        /// <summary>
        ///
        /// </summary>
        public const int KILL_JOINT = 0x669520;


        /// <summary>
        ///
        /// </summary>
        public const int SET_OPPONENT_WAYPOINTS = 0x66D210;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_OVERLAY_MESSAGE = 0x66A4D0;


        /// <summary>
        ///
        /// </summary>
        public const int BECOME_PURSUIT_CAR = 0x667450;


        /// <summary>
        ///
        /// </summary>
        public const int RELOAD_HUD = 0x66C220;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CAR_SMOKE_OVERRIDE = 0x669FE0;


        /// <summary>
        ///
        /// </summary>
        public const int MAIN_IO = 0x6698E0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_FAKE_FAR = 0x66A170;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_RACE_COUNTDOWN = 0x66D8F0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_OPPONENT_TARGET_VEHICLE = 0x66D0F0;


        /// <summary>
        ///
        /// </summary>
        public const int DAMAGE_LIGHTS = 0x667FE0;


        /// <summary>
        ///
        /// </summary>
        public const int PROCESS_RESULTS = 0x66B9D0;


        /// <summary>
        ///
        /// </summary>
        public const int HUD_FADE_TO_BLACK_OFF = 0x669350;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA_COP_CAM = 0x6675E0;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_HUD_DAMAGE = 0x66EE10;


        /// <summary>
        ///
        /// </summary>
        public const int BLOCK_INPUT = 0x6674B0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_AUDITION_BREAKER_MUSIC = 0x66AFE0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_WORLD_ANIM_TRIGGER = 0x66AC80;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_SHOW_HUD = 0x66A9D0;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_CONSTRAINT = 0x66EA00;


        /// <summary>
        ///
        /// </summary>
        public const int QUEUE_MOVIE = 0x66BE80;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_RACE_MUSIC = 0x0066B830;


        /// <summary>
        ///
        /// </summary>
        public const int CINEMATIC_MOMENT = 0x667BE0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CAR_HIDE_PART = 0x669EB0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_COP_AUTO_SPAWN_MODE = 0x66C900;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA_KILL_ICE = 0x667660;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_PIXELATE = 0x66A650;


        /// <summary>
        ///
        /// </summary>
        public const int CELL_CALL = 0x6679F0;


        /// <summary>
        ///
        /// </summary>
        public const int E_911_CALL = 0x666D70;


        /// <summary>
        ///
        /// </summary>
        public const int JUMP_TO_STRATEGY_FLOW = 0x6694D0;


        /// <summary>
        ///
        /// </summary>
        public const int WAKE_OBJECT = 0x66FA90;


        /// <summary>
        ///
        /// </summary>
        public const int DISENGAGE_GPS = 0x6684A0;


        /// <summary>
        ///
        /// </summary>
        public const int CLEAR_OPPONENT_WAYPOINTS = 0x667CA0;


        /// <summary>
        ///
        /// </summary>
        public const int ADD_SMS = 0x697150;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_SCREEN_FLASH = 0x66A940;


        /// <summary>
        ///
        /// </summary>
        public const int SET_MISSION_LEG = 0x66CB90;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CAR_WINDOW_DAMAGE = 0x684CC0;


        /// <summary>
        ///
        /// </summary>
        public const int MAIN_AUDIO = 0x6698A0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_MISSION_HEAT = 0x66C9D0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_NOSMODIFERS = 0x66CDC0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_RELEASE_CAR_CONTROL = 0x66A870;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_HUD_MINIMAP = 0x66F210;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_HUD_TIMER = 0x66F460;


        /// <summary>
        ///
        /// </summary>
        public const int LOAD_MINIMAP_RESOURCES = 0x669670;


        /// <summary>
        ///
        /// </summary>
        public const int SET_OPPONENT_TARGET_MARKER = 0x66CFD0;


        /// <summary>
        ///
        /// </summary>
        public const int KILL_OBJECT = 0x669560;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_OBJECT_EFFECT = 0x66B530;


        /// <summary>
        ///
        /// </summary>
        public const int SET_MISSION_TRAFFIC_PATTERN = 0x66CD00;


        /// <summary>
        ///
        /// </summary>
        public const int STOP_OBJECT_EFFECTS = 0x66E6E0;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_SPEEDBREAKER_IMMUNITY = 0x66F790;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_ROADBLOCK = 0x66E470;


        /// <summary>
        ///
        /// </summary>
        public const int CAMERA_OPPONENT_COP_CAM = 0x667710;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_REATTACH = 0x66A820;


        /// <summary>
        ///
        /// </summary>
        public const int SHOCK_OBJECT = 0x66D370;


        /// <summary>
        ///
        /// </summary>
        public const int BREAKER_STOP_COPS = 0x667530;


        /// <summary>
        ///
        /// </summary>
        public const int E_CAMERA_SHAKE = 0x6677D0;


        /// <summary>
        ///
        /// </summary>
        public const int DDAY_FLOW_DONE = 0x668030;


        /// <summary>
        ///
        /// </summary>
        public const int CANCEL_AUTO_SAVE_REQUEST = 0x6679B0;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_HUD_FLASHER_TIMER = 0x66F180;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_WORLD_GEOMETRY = 0x66ADC0;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_SMACKABLE = 0x6869F0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_TRAFFIC_PATTERN = 0x66D320;


        /// <summary>
        ///
        /// </summary>
        public const int MAIN_SIMULATION = 0x669C40;


        /// <summary>
        ///
        /// </summary>
        public const int DESTROY_VEHICLE = 0x668420;


        /// <summary>
        ///
        /// </summary>
        public const int HIDE_MINIMAP_TARGET = 0x669150;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_NIS = 0x66B480;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_CAR_DAMAGE = 0x6848B0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_POST_MISSION_FLOW = 0x66D840;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_MISSION_SELECTION_SET = 0x66D670;


        /// <summary>
        ///
        /// </summary>
        public const int HIDE_OBJECT = 0x669190;


        /// <summary>
        ///
        /// </summary>
        public const int LOCK_MISSION_HEAT = 0x6696B0;


        /// <summary>
        ///
        /// </summary>
        public const int ROLLING_CHECK = 0x66C670;


        /// <summary>
        ///
        /// </summary>
        public const int MAIN_STREAMER = 0x669D10;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_CUSTOM_MUSIC = 0x66B090;


        /// <summary>
        ///
        /// </summary>
        public const int MAIN_ONLINE = 0x669A60;


        /// <summary>
        ///
        /// </summary>
        public const int ACCELERATE = 0x667040;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_MOMENT_BY_KEY = 0x66B280;


        /// <summary>
        ///
        /// </summary>
        public const int RESET_PLAYER_CAR = 0x66C340;


        /// <summary>
        ///
        /// </summary>
        public const int SET_MISSION_HIGHWAY_TRAFFIC_PARAMETERS = 0x66CA90;


        /// <summary>
        ///
        /// </summary>
        public const int EXAMPLE_EVENT = 0x668B70;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_PRE_RACE_MATCHUP = 0x668A80;


        /// <summary>
        ///
        /// </summary>
        public const int SET_AIAVOIDABLE = 0x66C750;


        /// <summary>
        ///
        /// </summary>
        public const int SET_MISSION_THREAT = 0x66CC10;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_FRAGMENT = 0x66E310;


        /// <summary>
        ///
        /// </summary>
        public const int ENGAGE_GPS = 0x668990;


        /// <summary>
        ///
        /// </summary>
        public const int MAIN_UI = 0x669DD0;


        /// <summary>
        ///
        /// </summary>
        public const int ENABLE_MODELING = 0x668800;


        /// <summary>
        ///
        /// </summary>
        public const int AUTO_SAVE = 0x667260;


        /// <summary>
        ///
        /// </summary>
        public const int SET_MISSION_DIFFICULTY = 0x66C940;


        /// <summary>
        ///
        /// </summary>
        public const int SET_NO_BRAKES_MODIFIER = 0x66CD80;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_FREEZE_CAMERA = 0x0065C0B0;


        /// <summary>
        ///
        /// </summary>
        public const int NIS_PLAY = 0x0065C110;


        /// <summary>
        ///
        /// </summary>
        public const int SET_PLAYER_START_POSITION = 0x00662020;


        /// <summary>
        ///
        /// </summary>
        public const int GAME__SPAWN_COP = 0x0065C390;


        /// <summary>
        ///
        /// </summary>
        public const int SPAWN_CHARACTER = 0x006594A0;


        /// <summary>
        ///
        /// </summary>
        public const int UNSPAWN_CHARACTER = 0x00659500;


        /// <summary>
        ///
        /// </summary>
        public const int SEND_CHARACTER_STIMULUS = 0x0065F4F0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACER_LAPS_LEFT = 0x0065C4A0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACER_GOAL = 0x006620D0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_CHECKPOINT_REACHED = 0x006621E0;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_LAP_FINISHED = 0x00662250;


        /// <summary>
        ///
        /// </summary>
        public const int RACE_OVER_CAR_BEHAVIOUR = 0x00662300;


        /// <summary>
        ///
        /// </summary>
        public const int NOTIFY_RACE_FINISHED = 0x006623D0;


        /// <summary>
        ///
        /// </summary>
        public const int SET_RACE_ACTIVITY = 0x0065C690;


        /// <summary>
        ///
        /// </summary>
        public const int SET_MISSION_ACTIVITY = 0x0065C6E0;


        /// <summary>
        ///
        /// </summary>
        public const int START_RACE = 0x00662760;


        /// <summary>
        ///
        /// </summary>
        public const int START_MISSION = 0x0065C700;


        /// <summary>
        ///
        /// </summary>
        public const int ABANDON_RACE = 0x0065F930;


        /// <summary>
        ///
        /// </summary>
        public const int PLAY_FINISH_CAMERA = 0x00662C30;


        /// <summary>
        ///
        /// </summary>
        public const int SET_COPS_ENABLED = 0x0065C7C0;


        /// <summary>
        ///
        /// </summary>
        public const int ENTER_POST_RACE_FLOW = 0x00662D40;


        /// <summary>
        ///
        /// </summary>
        public const int NO_NEW_PURSUITS_OR_COPS = 0x0065C820;


        /// <summary>
        ///
        /// </summary>
        public const int SET_TRAFFIC_SPEED = 0x0065C960;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_PAUSE_MENU = 0x00659660;


        /// <summary>
        ///
        /// </summary>
        public const int UNLOCK_RACE = 0x00663150;


        /// <summary>
        ///
        /// </summary>
        public const int JUMP_TO_CAR_LOT = 0x00659790;


        /// <summary>
        ///
        /// </summary>
        public const int JUMP_TO_SAFE_HOUSE = 0x00BA6C42;


        /// <summary>
        ///
        /// </summary>
        public const int BLOW_ENGINE = 0x0065FF00;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_AI_CONTROL = 0x00663220;


        /// <summary>
        ///
        /// </summary>
        public const int CLEAR_AI_CONTROL = 0x00663290;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_ENGAGE_EVENTS = 0x00BA6CA2;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_MENU_GATES = 0x00BA6CD2;


        /// <summary>
        ///
        /// </summary>
        public const int ALLOW_ENAGE_SAFEHOUSE = 0x00BA6D02;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_LOSING_POST_RACE_SCREEN = 0x0065CCE0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_WINNING_POST_RACE_SCREEN = 0x0065CCF0;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_ONLINE_POST_RACE_SCREEN = 0x00659A50;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_POST_EVENT_SCREEN = 0x00659A90;


        /// <summary>
        ///
        /// </summary>
        public const int SHOW_ACQUISITION_SCREEN = 0x0065CD00;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_STEER = 0x00663370;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_GAS = 0x006633B0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_BRAKE = 0x006633F0;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_HANDBRAKE = 0x00663430;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_NOS = 0x00663470;


        /// <summary>
        ///
        /// </summary>
        public const int PLAYER_WON = 0x0065CD80;


        /// <summary>
        ///
        /// </summary>
        public const int SET_VEHICLE_ON_GROUND = 0x0065FFA0;


        /// <summary>
        ///
        /// </summary>
        public const int ACTIVATE_FAR_CAMERA = 0x00659B50;


        /// <summary>
        ///
        /// </summary>
        public const int SET_AIGOAL = 0x00660020;


        /// <summary>
        ///
        /// </summary>
        public const int SET_PURSUIT_TARGET = 0x00660070;


        /// <summary>
        ///
        /// </summary>
        public const int SET_PURSUIT_OFFSET = 0x006600C0;


        /// <summary>
        ///
        /// </summary>
        public const int TOGGLE_ALLOW_PURSUIT_COOLDOWN = 0x65CDB0;


        /// <summary>
        ///
        /// </summary>
        public const int START_RACE_FROM_IN_GAME = 0x00659B70;


        /// <summary>
        ///
        /// </summary>
        public const int YOU_WON = 0x0065CEC0;


        /// <summary>
        ///
        /// </summary>
        public const int FORCE_PURSUIT_MUSIC = 0x00BA6E22;

    }

    /// <summary>
    /// A class for functions related functions.
    /// </summary>
    public static class Function
    {
        static Dictionary<IntPtr, string> memoryStringPointers = new Dictionary<IntPtr, string>();
        /// <summary>
        /// Call a <see cref="Function"/> address.
        /// </summary>
        /// <param name="address">The address to call.</param>
        /// <param name="o">The parameters to pass to the function.</param>
        public static void Call(int address, params object[] o)
        {
            Call(address, true, o);
        }

        /// <summary>
        /// Call a <see cref="Function"/> address.
        /// </summary>
        /// <param name="address">The address to call.</param>
        /// <param name="o">The parameters to pass to the function.</param>
        /// <param name="align">Whether to align the stack or not.</param>
        public static void Call(int address, bool align, params object[] o)
        {
            ASMBuilder function = new ASMBuilder();

            // Push parameters to the stack backwards since the stack is LIFO
            for (int i = o.Length; i --> 0;)
            {
                if (o[i] is byte)
                {
                    function.Push((int)o[i]);
                    //Log.Print("TEST", string.Format("Pushing byte {0} to the stack", (byte)o[i]));
                }
                else if (o[i] is int)
                {
                    function.Push((int)o[i]);
                    //Log.Print("TEST", string.Format("Pushing int {0} to the stack", (int)o[i]));
                }
                else if (o[i] is float)
                {
                    function.Push((float)o[i]);
                    //Log.Print("TEST", string.Format("Pushing float {0} to the stack", (float)o[i]));
                }
                else if (o[i] is bool)
                {
                    bool b = (bool)o[i];

                    function.Push(b.ToByte());
                }
                else if (o[i] is string)
                {
                    string s = (string)o[i];

                    IntPtr addr = IntPtr.Zero;
                    IntPtr handle = GameMemory.memory.ProcessHandle;
                    if (memoryStringPointers.ContainsValue(s))
                    {
                        addr = memoryStringPointers.FirstOrDefault(x => x.Value == s).Key;
                    }
                    else
                    {
                        addr = NativeMethods.VirtualAllocEx(handle, IntPtr.Zero, (uint)s.Length + 4, AllocationType.Commit, MemoryProtection.ExecuteReadWrite);

                        if (addr == IntPtr.Zero)
                        {
                            Log.Print("ERROR", "Failed to allocate memory!");
                            return;
                        }

                        UIntPtr bytesWritten = UIntPtr.Zero;

                        if (!NativeMethods.WriteProcessMemory(handle, addr, Encoding.ASCII.GetBytes(s), (uint)s.Length + 4, out bytesWritten))
                        {
                            Log.Print("ERROR", "Could not write process memory!");
                            return;
                        }
                        else memoryStringPointers.Add(addr, s);

                        if (s.Length + 4 != (int)bytesWritten)
                        {
                            Log.Print("ERROR", "String length is not equal to the amount of bytes written.");
                        }

                    }

                    function.Push(addr.ToInt32());

                }
                else if (o[i] is Locval)
                {
                    int value = (Locval)o[i];
                    function.PushWORDPTRDS(value);

                    //Log.Print("TEST", string.Format("Pushing the value of [0x{0}] to the stack", value.ToString("X")));
                }
                else if (o[i] is uint)
                {
                    function.Push((uint)o[i]);
                    //Log.Print("TEST", string.Format("Pushing uint {0} to the stack", (uint)o[i]));
                }
                else if (o[i] is Vector3) // experimental (not known yet):
                {
                    Vector3 vec = (Vector3)o[i];
                    // REMEMBER THAT THE STACK IS LIFO!
                    function.Push(vec.y); // In EAGL the Z is basically Y, I swapped them for convinence, it should get pushed first. This haven't been test so I might be wrong either way I need to code the pushes differently for different game engines.
                    function.Push(vec.z);
                    function.Push(vec.x);
                }
                else
                {
                    Log.Print("Function Error", string.Format("The type {0} is not supported in Function.Call yet! Pushing 0 instead.", o[i].GetType()));
                    function.Push(0);
                }
            }

            function.MovEAX(address);
            function.CallEAX();

            if (align)
            {
                // For stack alignment to prevent crashes
                for (int i = 0; i < o.Length; i++)
                {
                    function.PopEAX();
                }
            }

            function.Return();

            ASM.CallAssembly(function.ToArray());
        }
    }
}
