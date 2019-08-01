using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Shawer_System.View.Pages.ConfigSettins
{
    public partial class AboutUs : UserControl
    {
        public AboutUs()
        {
            InitializeComponent();
        }
        public static string version = "测试 V1.1.50";
        Thread thread;
        private void Bt_updatecheck_Click(object sender, EventArgs e)
        {
            bt_updatecheck.Enabled = false;
            lb_version.Visible = false;
            bt_updatecheck.Text = "正在查找";
            loadingView1.Visible = true;
            loadingView1.Enabled = true;
            thread = new Thread(new ThreadStart(CheckVerison));
            thread.Start();
        }

        private void CheckVerison()
        {
            Thread.Sleep(4000);
            if (!File.Exists(Application.StartupPath + "\\.updateinfo.ini"))
            {
                bt_updatecheck.BeginInvoke(new Action(() => { bt_updatecheck.Text = "检测更新"; }));//恢复按钮
                bt_updatecheck.BeginInvoke(new Action(() => { bt_updatecheck.Enabled = true; }));//恢复按钮
                lb_version.BeginInvoke(new Action(() => { lb_version.Visible = true; }));//提示出现 
                lb_version.BeginInvoke(new Action(() => { lb_version.Text = "当前为最新版本"; }));//提示内容
                loadingView1.BeginInvoke(new Action(() => { loadingView1.Visible = false; }));//隐藏加载
                loadingView1.BeginInvoke(new Action(() => { loadingView1.Enabled = false; }));//加载不可用
            }
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            lb_verison.Text = version;//版本信息
        }
    }
}
