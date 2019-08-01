using Shawer_System.Properties;
using System;
using System.Windows.Forms;

namespace Shawer_System.View.Pages.ConfigSettins
{
    public partial class SystemSet : UserControl
    {
        public SystemSet()
        {
            InitializeComponent();
        }

        private void Ckb_dark_CheckedChanged(object sender, EventArgs e)
        {
            //设置选中状态
            if (ckb_dark.Checked == true)
            {
                ckb_dark.Checked = true;
                ckb_light.Checked = false;
                Settings.Default.themecolor = "dark";
                Settings.Default.Save();
            }
        }

        private void Ckb_light_CheckedChanged(object sender, EventArgs e)
        {
            //设置选中状态
            if (ckb_light.Checked == true)
            {
                ckb_dark.Checked = false;
                ckb_light.Checked = true;
                Settings.Default.themecolor = "light";
                Settings.Default.Save();
            }
        }

        private void Bt_selectpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //获取路径并保存配置文件
                txt_dailypath.Text = dialog.SelectedPath;
                Settings.Default.logpath = txt_dailypath.Text;
                Settings.Default.Save();
            }
        }

        private void Bt_openpath_Click(object sender, EventArgs e)
        {
            //直接打开文件夹
            string v_OpenFolderPath = txt_dailypath.Text;
            System.Diagnostics.Process.Start("explorer.exe", v_OpenFolderPath);
        }

        private void Bt_refactory_Click(object sender, EventArgs e)
        {
            //初始化日志路径
            txt_dailypath.Text = BodyForm.logpath;
            Settings.Default.logpath = BodyForm.logpath;
            Settings.Default.Save();
        }

        private void SystemSet_Load(object sender, EventArgs e)
        {
            //读取配置

            //主题配置
            if (Settings.Default.themecolor == "light")
            {
                ckb_light.Checked = true;
            }
            else
            {
                ckb_dark.Checked = true;
            }

            //路径配置
            txt_dailypath.Text = Settings.Default.logpath;
        }
    }
}
