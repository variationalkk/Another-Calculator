using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppXiong
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Login login;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(login=new Login());

            //if (login.Feedbac == 1)
            //{
            //    login.Close();
            //    Application.Run(caculator = new Caculate());

            //}
            //else if (login.Feedbac == 2)
            //{
            //    login.Close();
            //    Application.Run(setter = new Setting());

            //}


        }
    }
}
