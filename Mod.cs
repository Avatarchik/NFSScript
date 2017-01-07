using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NFSScript
{
    /// <summary>
    /// Mod is the base class from which every NFSScript mod derives.
    /// </summary>
    public class Mod
    {
        /// <summary>
        /// The initialize method name.
        /// </summary>
        public const string INITIALIZE_METHOD = "Initialize";

        /// <summary>
        /// The main method name.
        /// </summary>
        public const string MAIN_METHOD = "Main";

        /// <summary>
        /// The update method name.
        /// </summary>
        public const string UPDATE_METHOD = "Update";

        /// <summary>
        /// The OnKeyDown method name.
        /// </summary>
        public const string ONKEYDOWN_METHOD = "OnKeyDown";

        /// <summary>
        /// The OnKeyUp method name.
        /// </summary>
        public const string ONKEYUP_METHOD = "OnKeyUp";

        /// <summary>
        /// The OnGameplayStart method name.
        /// </summary>
        public const string ONGAMEPLAYSTART_METHOD = "OnGameplayStart";

        /// <summary>
        /// The OnGameplayExit method name.
        /// </summary>
        public const string ONGAMEPLAYEXIT_METHOD = "OnGameplayExit";

        /// <summary>
        /// The OnActivityEnter method name.
        /// </summary>
        public const string ONACTIVITYENTER_METHOD = "OnActivityEnter";

        /// <summary>
        /// The OnActivityExit method name.
        /// </summary>
        public const string ONACTIVITYEXIT_METHOD = "OnActivityExit";

        /// <summary>
        /// The OnExit method name.
        /// </summary>
        public const string ONEXIT_METHOD = "OnExit";

        /// <summary>
        /// Initialize is called when the script is ready and enabled just before any of the Main and Update methods are called.
        /// </summary>
        public virtual void Initialize()
        { }

        /// <summary>
        /// Main is called after the Initialize method is called and before the Update method is called.
        /// </summary>
        public virtual void Main()
        { }

        /// <summary>
        /// Update method is called every 1ms.
        /// </summary>
        public virtual void Update()
        {
        }

        /// <summary>
        /// This method is called when the gameplay starts.
        /// </summary>
        public virtual void OnGameplayStart()
        {

        }

        /// <summary>
        /// This method is called when the gameplay is stopped (When the player enters the garage/car lot/etc...).
        /// </summary>
        public virtual void OnGameplayExit()
        {

        }

        /// <summary>
        /// This method is called when the player has entered an activity (Doesn't work in Most Wanted and Undercover, yet).
        /// </summary>
        public virtual void OnActivityEnter()
        {

        }

        /// <summary>
        /// This method is called when the player has exited from an activity (Doesn't work in Most Wanted and Undercover, yet).
        /// </summary>
        public virtual void OnActivityExit()
        {

        }

        /// <summary>
        /// This method is called when a key is being held in-game.
        /// </summary>
        public virtual void OnKeyDown(Keys key)
        { }

        /// <summary>
        /// This method is called when a key has been released in-game.
        /// </summary>
        public virtual void OnKeyUp(Keys key)
        { }
        
        /// <summary>
        /// This method is called when the script is being terminated.
        /// </summary>
        public virtual void OnExit()
        {

        }

        /// <summary>
        /// Basically makes the thread sleep but without the need to reference System.Threading.
        /// </summary>
        /// <param name="ms"></param>
        public static void Sleep(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }
    }
}
