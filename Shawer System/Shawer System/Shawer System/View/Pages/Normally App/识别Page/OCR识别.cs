using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shawer_System.Properties;

namespace Shawer_System.View.Pages.Normally_App.文件识别
{
    public partial class OCR识别 : UserControl
    {
        public OCR识别()
        {
            InitializeComponent();
        }

        private void OCR识别_Load(object sender, EventArgs e)
        {
            //读取配置文件
            txt_path.Text = Settings.Default.ocrsavepath;
        }

        private void Pb_openpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //获取路径并保存配置文件
                txt_path.Text = dialog.SelectedPath;
                Settings.Default.ocrsavepath = txt_path.Text;
                Settings.Default.Save();
            }
        }

        private void Pb_openpath_MouseMove(object sender, MouseEventArgs e)
        {
            pb_openpath.Image = null;
            pb_openpath.Image = Resources.文件夹__1_;
        }

        private void Pb_openpath_MouseLeave(object sender, EventArgs e)
        {
            pb_openpath.Image = null;
            pb_openpath.Image = Resources.文件夹;
        }

        private void Bt_save_Click(object sender, EventArgs e)
        {
            DialogResult dialog =  MetroFramework.MetroMessageBox.Show(this, "这是一个弹窗", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialog==DialogResult.OK)
            {

            }
        }

        private void CxFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
