using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using view;

namespace com.impoauto.view {
    static class NewApplicaion
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static MenuStrip importerMenu;

        public static MenuStrip dateMenu;

        public static MenuStrip userMenu;

        public static MenuStrip reportMenu;

        public static MenuStrip brandMenu;

        public static MenuStrip rolMenu;

        public static MenuStrip modelMenu;

        public static MenuStrip autoFairMenu;

        public static MenuStrip exitMenu;

        /// <summary>
        /// @return
        /// </summary>
        public static void InitComponent()
        {
            // TODO implement here
        }

        /// <summary>
        /// @param evt
        /// @return
        /// </summary>
        public static void exitMenuActionPerformed(EventArgs evt)
        {
            // TODO implement here
        }
    }
}
