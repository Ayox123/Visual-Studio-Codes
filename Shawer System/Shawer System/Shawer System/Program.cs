using Shawer_System.View;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Shawer_System
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new BodyForm());

            //阻止程序多开
            Process instance = RunningInstance();
            if (instance == null)
            {
                #region 登录验证
                //登录验证
                Login login = new Login();
                //界面转换
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {
                    login.Dispose();
                    Application.Run(new BodyForm());
                }
                else if (login.DialogResult == DialogResult.Cancel)
                {
                    login.Dispose();
                    return;
                }
                #endregion
            }
            else
            {
                HandleRunningInstance(instance);
            }
        }

        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private const int WS_SHOWNORMAL = 1;

        public static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            //在中循环使用同名的正在运行的进程
            foreach (Process process in processes)
            {
                //忽略当前进程
                if (process.Id != current.Id)
                {
                    //请确保进程是从exe文件运行的。
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") ==
                        current.MainModule.FileName)
                    {
                        //返回另一个流程实例
                        return process;
                    }
                }
            }
            //未找到其他实例，返回null。
            return null;
        }
        public static void HandleRunningInstance(Process instance)
        {
            //确保窗口没有最小化或最大化
            ShowWindowAsync(instance.MainWindowHandle, WS_SHOWNORMAL);
            //将真实状态设置为前台窗口
            SetForegroundWindow(instance.MainWindowHandle);
        }
    }
}
