using CCWin;
using Shawer_System.Properties;
using Shawer_System.View.Pages.Target_Printing;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Shawer_System.View
{
    public partial class BodyForm : CCSkinMain
    {
        public BodyForm()
        {
            InitializeComponent();
        }
        public static string pagename;//页面
        //路径
        public static string systempath = Application.StartupPath + @"\SystemFile\";
        public static string logpath = systempath + ".logdailly";
        public static string datapath = systempath + ".data";
        public static string templet = systempath + ".temp";

        private void BodyForm_Load(object sender, EventArgs e)
        {
            //读取配置文件

            //菜单打开状态恢复
            pn_subitem1.Visible = Settings.Default.item1;
            LoadingConfigicon(pn_subitem1, pb_subright1);
            pn_subitem2.Visible = Settings.Default.item2;
            LoadingConfigicon(pn_subitem2, pb_suright2);
            pn_subitem3.Visible = Settings.Default.item3;
            LoadingConfigicon(pn_subitem3, pb_suright3);
            pn_subitem4.Visible = Settings.Default.item4;
            LoadingConfigicon(pn_subitem4, pb_suright4);

            //是否存在系统文件夹
            if (!Directory.Exists(systempath))
            {
                Directory.CreateDirectory(logpath);
                Directory.CreateDirectory(datapath);
                Directory.CreateDirectory(templet);
            }

            //路径     
            string path = Application.StartupPath + "\\Fonts\\义启-风尚黑体.ttf";
            //读取字体文件             
            PrivateFontCollection pc = new PrivateFontCollection();
            pc.AddFontFile(path);
            //实例化字体             
            Font f = new Font(pc.Families[0], 13);
            //设置字体
            lb_normalapp.Font = f;
            lb_printapp.Font = f;
            lb_putapp.Font = f;
            lb_more.Font = f;

            Pages.HomePage print = new Pages.HomePage();
            PageConvert(print, skinTabPage14, 13);
        }

        #region 加载程序时配置菜单栏折叠状态图标
        /// <summary>
        /// 加载程序时配置菜单栏折叠状态图标
        /// </summary>
        /// <param name="controlname">菜单控件名</param>
        /// <param name="iconcontrol">图标控件名</param>
        private void LoadingConfigicon(Control controlname, Control iconcontrol)
        {
            if (controlname.Visible == true)
            {
                iconcontrol.BackgroundImage = Resources.下;
            }
            else
            {
                iconcontrol.BackgroundImage = Resources.右;
            }
        }

        #endregion

        #region 是否可见，展开或关闭折叠菜单
        /// <summary>
        /// 是否可见，展开或关闭折叠菜单
        /// </summary>
        /// <param name="controlname">二级菜单控件名：panel</param>
        /// <param name="arrowimage">折叠菜单状态</param>
        /// <returns></returns>
        private bool IsVisable(Control controlname, Control arrowimage)
        {
            //是否可见
            if (!controlname.Visible)
            {
                controlname.Visible = true;
                arrowimage.BackgroundImage = Resources.下;
                AnimationControls.ShowControl(controlname, true, direction: AnchorStyles.Bottom);
            }
            else
            {
                controlname.Visible = false;
                arrowimage.BackgroundImage = Resources.右;
            }
            return true;
        }
        #endregion

        #region 状态效果
        /// <summary>
        /// 恢复状态效果
        /// </summary>
        /// <param name="controlname">恢复的控件名</param>
        private bool StatusEffect()
        {
            try
            {
                lb_submenu1_1.ForeColor = Color.Black;
                lb_submenu1_2.ForeColor = Color.Black;
                lb_submenu1_3.ForeColor = Color.Black;
                lb_submenu2_3.ForeColor = Color.Black;
                lb_submenu2_2.ForeColor = Color.Black;
                lb_submenu2_1.ForeColor = Color.Black;
                lb_submenu3_3.ForeColor = Color.Black;
                lb_submenu3_1.ForeColor = Color.Black;
                lb_submenu3_2.ForeColor = Color.Black;
                lb_submenu4_2.ForeColor = Color.Black;
                lb_submenu4_1.ForeColor = Color.Black;
                lb_submenu4_3.ForeColor = Color.Black;

                pb_st1_1.BackColor = Color.Transparent;
                pb_st1_2.BackColor = Color.Transparent;
                pb_st1_3.BackColor = Color.Transparent;
                pb_st2_3.BackColor = Color.Transparent;
                pb_st2_2.BackColor = Color.Transparent;
                pb_st2_1.BackColor = Color.Transparent;
                pb_st3_3.BackColor = Color.Transparent;
                pb_st3_1.BackColor = Color.Transparent;
                pb_st3_2.BackColor = Color.Transparent;
                pb_st4_2.BackColor = Color.Transparent;
                pb_st4_1.BackColor = Color.Transparent;
                pb_st4_3.BackColor = Color.Transparent;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        #endregion

        #region 页面切换
        /// <summary>
        /// 页面切换
        /// </summary>
        /// <param name="control">页面名字</param>
        /// <param name="container">要填充的容器</param>
        /// <param name="selectindex">页面索引</param>
        private void PageConvert(Control control, Control container, int selectindex)
        {
            //switch (pagename)
            //{
            //    case "条码打印":
            //        条码打印 print = new 条码打印
            //        {
            //            Dock = DockStyle.Fill,
            //        };
            //        print.Show();
            //        pn_rightmain.Controls.Add(print);
            //        break;

            //    case "关于我们":
            //        Pages.ConfigSettins.AboutUs aboutUs = new Pages.ConfigSettins.AboutUs
            //        {
            //            Dock = DockStyle.Fill,
            //        };
            //        aboutUs.Show();
            //        pn_rightmain.Controls.Add(aboutUs);
            //        break;
            //}
            control.Dock = DockStyle.Fill;//填充容器
            container.Controls.Add(control);//容器添加页面
            skinTabControl1.SelectedIndex = selectindex;//选择页面索引
            container.Show();
        }
        #endregion

        #region 菜单过渡效果
        private bool MenuEffect()
        {
            try
            {
                //menu1
                pn_subitem1_1.BackColor = Color.Transparent;
                pn_subitem1_2.BackColor = Color.Transparent;
                pn_subitem1_3.BackColor = Color.Transparent;
                //menu2
                pn_subitem2_1.BackColor = Color.Transparent;
                pn_subitem2_2.BackColor = Color.Transparent;
                pn_subitem2_3.BackColor = Color.Transparent;
                //menu3
                pn_subitem3_1.BackColor = Color.Transparent;
                pn_subitem3_2.BackColor = Color.Transparent;
                pn_subitem3_3.BackColor = Color.Transparent;
                //menu4
                pn_subitem4_1.BackColor = Color.Transparent;
                pn_subitem4_2.BackColor = Color.Transparent;
                pn_subitem4_3.BackColor = Color.Transparent;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        #endregion

        private void Pn_item1_Click(object sender, EventArgs e)
        {
            //折叠或展开菜单
            IsVisable(pn_subitem1, pb_subright1);
            //记录打开菜单状态
            Settings.Default.item1 = pn_subitem1.Visible;
            Settings.Default.Save();
        }

        private void Pn_item2_Click(object sender, EventArgs e)
        {
            //折叠或展开菜单
            IsVisable(pn_subitem2, pb_suright2);
            //记录打开菜单状态
            Settings.Default.item2 = pn_subitem2.Visible;
            Settings.Default.Save();
        }

        private void Pn_item3_Click(object sender, EventArgs e)
        {
            //折叠或展开菜单
            IsVisable(pn_subitem3, pb_suright3);
            //记录打开菜单状态
            Settings.Default.item3 = pn_subitem3.Visible;
            Settings.Default.Save();
        }
        private void Pn_item4_Click(object sender, EventArgs e)
        {
            //折叠或展开菜单
            IsVisable(pn_subitem4, pb_suright4);
            //记录打开菜单状态
            Settings.Default.item4 = pn_subitem4.Visible;
            Settings.Default.Save();
        }
        private void Lb_submenu2_3_Click(object sender, EventArgs e)
        {
            //选中状态
            StatusEffect();
            pb_st2_3.BackColor = Color.FromArgb(30, 150, 243);
            lb_submenu2_3.ForeColor = Color.FromArgb(30, 150, 243);
            pagename = lb_submenu2_3.Text;
            条码打印 print = new 条码打印();
            PageConvert(print, skinTabPage5, 4);
        }

        private void Lb_submenu2_2_Click(object sender, EventArgs e)
        {
            //选中状态
            StatusEffect();
            pb_st2_2.BackColor = Color.FromArgb(30, 150, 243);
            lb_submenu2_2.ForeColor = Color.FromArgb(30, 150, 243);
        }

        private void Lb_submenu2_1_Click(object sender, EventArgs e)
        {
            //选中状态
            StatusEffect();
            pb_st2_1.BackColor = Color.FromArgb(30, 150, 243);
            lb_submenu2_1.ForeColor = Color.FromArgb(30, 150, 243);
        }

        private void Lb_submenu4_2_Click(object sender, EventArgs e)
        {
            //选中状态
            StatusEffect();
            pb_st4_2.BackColor = Color.FromArgb(30, 150, 243);
            lb_submenu4_2.ForeColor = Color.FromArgb(30, 150, 243);
            pagename = lb_submenu4_2.Text;
            Pages.ConfigSettins.NormallySet set = new Pages.ConfigSettins.NormallySet();
            PageConvert(set, skinTabPage11, 10);
        }

        private void Lb_submenu4_1_Click(object sender, EventArgs e)
        {
            //选中状态
            StatusEffect();
            pb_st4_1.BackColor = Color.FromArgb(30, 150, 243);
            lb_submenu4_1.ForeColor = Color.FromArgb(30, 150, 243);
            pagename = lb_submenu4_1.Text;
            Pages.ConfigSettins.SystemSet set = new Pages.ConfigSettins.SystemSet();
            PageConvert(set, skinTabPage12, 11);
        }

        private void Lb_submenu4_3_Click(object sender, EventArgs e)
        {
            //选中状态
            StatusEffect();
            pb_st4_3.BackColor = Color.FromArgb(30, 150, 243);
            lb_submenu4_3.ForeColor = Color.FromArgb(30, 150, 243);
            pagename = lb_submenu4_3.Text;
            Pages.ConfigSettins.AboutUs about = new Pages.ConfigSettins.AboutUs();
            PageConvert(about, skinTabPage13, 12);
        }

        private void Lb_submenu1_1_Click(object sender, EventArgs e)
        {
            //选中状态
            StatusEffect();
            pb_st1_1.BackColor = Color.FromArgb(30, 150, 243);
            lb_submenu1_1.ForeColor = Color.FromArgb(30, 150, 243);
            pagename = lb_submenu1_1.Text;
            Pages.Normally_App.文件图像识别 scan = new Pages.Normally_App.文件图像识别();
            PageConvert(scan, skinTabPage1, 0);
        }

        #region 菜单过渡效果
        #region panel 菜单过渡效果
        //panel
        private void Pn_subitem1_1_MouseMove(object sender, MouseEventArgs e)
        {
            MenuEffect();
            pn_subitem1_1.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void Pn_subitem1_1_MouseLeave(object sender, EventArgs e)
        {
            MenuEffect();
        }

        private void Pn_subitem1_2_MouseMove(object sender, MouseEventArgs e)
        {
            MenuEffect();
            pn_subitem1_2.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void Pn_subitem1_2_MouseLeave(object sender, EventArgs e)
        {
            MenuEffect();
        }

        private void Pn_subitem1_3_MouseMove(object sender, MouseEventArgs e)
        {
            MenuEffect();
            pn_subitem1_3.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void Pn_subitem1_3_MouseLeave(object sender, EventArgs e)
        {
            MenuEffect();
        }

        private void Pn_subitem2_1_MouseMove(object sender, MouseEventArgs e)
        {
            MenuEffect();
            pn_subitem2_1.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void Pn_subitem2_1_MouseLeave(object sender, EventArgs e)
        {
            MenuEffect();
        }

        private void Pn_subitem2_2_MouseMove(object sender, MouseEventArgs e)
        {
            MenuEffect();
            pn_subitem2_2.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void Pn_subitem2_2_MouseLeave(object sender, EventArgs e)
        {
            MenuEffect();
        }

        private void Pn_subitem2_3_MouseMove(object sender, MouseEventArgs e)
        {
            MenuEffect();
            pn_subitem2_3.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void Pn_subitem2_3_MouseLeave(object sender, EventArgs e)
        {
            MenuEffect();
        }

        private void Pn_subitem3_1_MouseMove(object sender, MouseEventArgs e)
        {
            MenuEffect();
            pn_subitem3_1.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void Pn_subitem3_1_MouseLeave(object sender, EventArgs e)
        {
            MenuEffect();
        }

        private void Pn_subitem3_2_MouseMove(object sender, MouseEventArgs e)
        {
            MenuEffect();
            pn_subitem3_2.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void Pn_subitem3_2_MouseLeave(object sender, EventArgs e)
        {
            MenuEffect();
        }

        private void Pn_subitem3_3_MouseMove(object sender, MouseEventArgs e)
        {
            MenuEffect();
            pn_subitem3_3.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void Pn_subitem3_3_MouseLeave(object sender, EventArgs e)
        {
            MenuEffect();
        }

        private void Pn_subitem4_1_MouseMove(object sender, MouseEventArgs e)
        {
            MenuEffect();
            pn_subitem4_1.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void Pn_subitem4_1_MouseLeave(object sender, EventArgs e)
        {
            MenuEffect();
        }

        private void Pn_subitem4_2_MouseMove(object sender, MouseEventArgs e)
        {
            MenuEffect();
            pn_subitem4_2.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void Pn_subitem4_2_MouseLeave(object sender, EventArgs e)
        {
            MenuEffect();
        }

        private void Pn_subitem4_3_MouseMove(object sender, MouseEventArgs e)
        {
            MenuEffect();
            pn_subitem4_3.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void Pn_subitem4_3_MouseLeave(object sender, EventArgs e)
        {
            MenuEffect();
        }
        #endregion

        #region label 
        //label
        private void Lb_submenu1_1_MouseMove(object sender, MouseEventArgs e)
        {
            lb_submenu1_1.MouseMove += Pn_subitem1_1_MouseMove;
        }
        private void Lb_submenu1_1_MouseLeave(object sender, EventArgs e)
        {
            lb_submenu1_1.MouseLeave += Pn_subitem1_1_MouseLeave;
        }
        private void Lb_submenu1_2_MouseMove(object sender, MouseEventArgs e)
        {
            lb_submenu1_2.MouseMove += Pn_subitem1_2_MouseMove;
        }
        private void Lb_submenu1_2_MouseLeave(object sender, EventArgs e)
        {
            lb_submenu1_2.MouseLeave += Pn_subitem1_2_MouseLeave;
        }
        private void Lb_submenu1_3_MouseMove(object sender, MouseEventArgs e)
        {
            lb_submenu1_3.MouseMove += Pn_subitem1_3_MouseMove;
        }
        private void Lb_submenu1_3_MouseLeave(object sender, EventArgs e)
        {
            lb_submenu1_3.MouseLeave += Pn_subitem1_3_MouseLeave;
        }
        private void Lb_submenu2_1_MouseMove(object sender, MouseEventArgs e)
        {
            lb_submenu2_1.MouseMove += Pn_subitem2_1_MouseMove;
        }
        private void Lb_submenu2_1_MouseLeave(object sender, EventArgs e)
        {
            lb_submenu2_1.MouseLeave += Pn_subitem2_1_MouseLeave;
        }
        private void Lb_submenu2_2_MouseMove(object sender, MouseEventArgs e)
        {
            lb_submenu2_2.MouseMove += Pn_subitem2_2_MouseMove;
        }
        private void Lb_submenu2_2_MouseLeave(object sender, EventArgs e)
        {
            lb_submenu2_2.MouseLeave += Pn_subitem2_2_MouseLeave;
        }
        private void Lb_submenu2_3_MouseMove(object sender, MouseEventArgs e)
        {
            lb_submenu2_3.MouseMove += Pn_subitem2_3_MouseMove;
        }
        private void Lb_submenu2_3_MouseLeave(object sender, EventArgs e)
        {
            lb_submenu2_3.MouseLeave += Pn_subitem2_3_MouseLeave;
        }
        private void Lb_submenu3_1_MouseMove(object sender, MouseEventArgs e)
        {
            lb_submenu3_1.MouseMove += Pn_subitem3_1_MouseMove;
        }
        private void Lb_submenu3_1_MouseLeave(object sender, EventArgs e)
        {
            lb_submenu3_1.MouseLeave += Pn_subitem3_1_MouseLeave;
        }
        private void Lb_submenu3_2_MouseMove(object sender, MouseEventArgs e)
        {
            lb_submenu3_2.MouseMove += Pn_subitem3_2_MouseMove;
        }
        private void Lb_submenu3_2_MouseLeave(object sender, EventArgs e)
        {
            lb_submenu3_2.MouseLeave += Pn_subitem3_2_MouseLeave;
        }
        private void Lb_submenu3_3_MouseMove(object sender, MouseEventArgs e)
        {
            lb_submenu3_3.MouseMove += Pn_subitem3_3_MouseMove;
        }
        private void Lb_submenu3_3_MouseLeave(object sender, EventArgs e)
        {
            lb_submenu3_3.MouseLeave += Pn_subitem3_3_MouseLeave;
        }
        private void Lb_submenu4_1_MouseMove(object sender, MouseEventArgs e)
        {
            lb_submenu4_1.MouseMove += Pn_subitem4_1_MouseMove;
        }
        private void Lb_submenu4_1_MouseLeave(object sender, EventArgs e)
        {
            lb_submenu4_1.MouseLeave += Pn_subitem4_1_MouseLeave;
        }
        private void Lb_submenu4_2_MouseMove(object sender, MouseEventArgs e)
        {
            lb_submenu4_2.MouseMove += Pn_subitem4_2_MouseMove;
        }
        private void Lb_submenu4_2_MouseLeave(object sender, EventArgs e)
        {
            lb_submenu4_2.MouseLeave += Pn_subitem4_2_MouseLeave;
        }
        private void Lb_submenu4_3_MouseMove(object sender, MouseEventArgs e)
        {
            lb_submenu4_3.MouseMove += Pn_subitem4_3_MouseMove;
        }
        private void Lb_submenu4_3_MouseLeave(object sender, EventArgs e)
        {
            lb_submenu4_3.MouseLeave += Pn_subitem4_3_MouseLeave;
        }

        #endregion
    } 
    #endregion

    #region 动画类
    public static class AnimationControls
    {
        private static readonly int MoveStep = 30;//切换速度
        private static Timer tmrAnim = null;//timer名
        private static Control control = null;//控件名
        private static AnchorStyles direction = AnchorStyles.None;//切换方向
        private static Size destSize;//控件大小

        private static void InitTimer()
        {
            if (tmrAnim == null)
            {
                tmrAnim = new Timer();
                tmrAnim.Interval = 30;
                tmrAnim.Tick += new System.EventHandler(tmrAnim_Tick);
            }
        }

        private static void tmrAnim_Tick(object sender, System.EventArgs e)
        {
            int newValue = 0;
            int offSet = 0;
            switch (direction)
            {
                case AnchorStyles.Left:
                case AnchorStyles.Right:
                    newValue = control.Width + MoveStep;
                    if (newValue > destSize.Width)
                    {
                        tmrAnim.Stop();
                        newValue = destSize.Width;
                    }

                    offSet = newValue - control.Width;
                    control.Width += offSet;
                    if (direction == AnchorStyles.Left)
                        control.Left -= offSet;
                    break;
                case AnchorStyles.Top:
                case AnchorStyles.Bottom:
                    newValue = control.Height + MoveStep;
                    if (newValue > destSize.Height)
                    {
                        tmrAnim.Stop();
                        newValue = destSize.Height;
                    }

                    offSet = newValue - control.Height;
                    control.Height += offSet;
                    if (direction == AnchorStyles.Top)
                        control.Top -= offSet;
                    break;
            }
        }

        /// <summary>
        /// 带动画显示控件
        /// </summary>
        /// <param name="control">控件名字</param>
        /// <param name="visible">是否可见</param>
        /// <param name="direction">方向</param>
        public static void ShowControl(Control control, bool visible, AnchorStyles direction = AnchorStyles.None)
        {
            if (direction == AnchorStyles.None)
            {
                control.Visible = visible;
                return;
            }

            if (!visible)
            {
                if (tmrAnim != null)
                    tmrAnim.Stop();
                control.Hide();
            }
            else
            {
                InitTimer();

                if (AnimationControls.control != control && destSize.IsEmpty)
                {
                    destSize = new Size(control.Width, control.Height);
                }
                AnimationControls.control = control;
                AnimationControls.direction = direction;
                switch (direction)
                {
                    case AnchorStyles.Left:
                    case AnchorStyles.Right:
                        if (direction == AnchorStyles.Left)
                            control.Left += control.Width;
                        control.Width = 0;
                        break;
                    case AnchorStyles.Top:
                    case AnchorStyles.Bottom:
                        if (direction == AnchorStyles.Top)
                            control.Top += control.Height;
                        control.Height = 0;
                        break;
                }
                control.Show();
                tmrAnim.Start();
            }
        }
    }
    #endregion
}
