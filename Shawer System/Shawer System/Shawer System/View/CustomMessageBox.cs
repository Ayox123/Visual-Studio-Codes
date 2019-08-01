using CCWin;
using Shawer_System.Properties;
using System.Drawing;

namespace Shawer_System.View
{
    public partial class CustomMessageBox : CCSkinMain
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }
        public static bool flag = false;
        public static string infomation;
        public static Color bordercolor = Color.FromArgb(31,150,243);//边框颜色，用于信息提示
        public static Image icon;
        private void Bt_close_Click(object sender, System.EventArgs e)
        {
            flag = false;

            Close();
            icon = Resources.info;
            bordercolor = Color.FromArgb(31, 150, 243);
            return;
        }

        private void Bt_ok_Click(object sender, System.EventArgs e)
        {
            flag = true;
            Close();
            icon = Resources.info;
            bordercolor = Color.FromArgb(31, 150, 243);
            return;
        }

        private void CustomMessageBox_Load(object sender, System.EventArgs e)
        {
            pb_icon.Image = icon;
            this.BorderColor = bordercolor;
            flag = false;
            lb_info.Text = infomation;
            return;
        }
    }
}
