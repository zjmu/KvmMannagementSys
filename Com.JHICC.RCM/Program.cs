using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Com.JHICC.RCM
{
    static class Program
    {
        public static bool isValidUser;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //text git
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var kvmForm = new MainFrameForm();
            kvmForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(kvmForm);
            //               if (isValidUser == true)
            //                 Application.Run(new ParentForm());

        }
    }
}


