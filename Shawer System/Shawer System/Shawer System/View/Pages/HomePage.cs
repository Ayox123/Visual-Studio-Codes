using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shawer_System.View.Pages
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        Timer timer;
        #region 图片定时切换
        private void PartConvert()
        {

        }
        #endregion

        #region 导航栏点击效果
        private bool IsClick()
        {
            try
            {
                pb_part1.BackColor = Color.FromArgb(243, 243, 243);
                pb_part2.BackColor = Color.FromArgb(243, 243, 243);
                pb_part3.BackColor = Color.FromArgb(243, 243, 243);
                pb_part4.BackColor = Color.FromArgb(243, 243, 243);
                pb_part5.BackColor = Color.FromArgb(243, 243, 243);
                pb_part6.BackColor = Color.FromArgb(243, 243, 243);
                pb_part7.BackColor = Color.FromArgb(243, 243, 243);
                pb_part8.BackColor = Color.FromArgb(243, 243, 243);
                pb_part9.BackColor = Color.FromArgb(243, 243, 243);
                pb_part10.BackColor = Color.FromArgb(243, 243, 243);
                pb_part11.BackColor = Color.FromArgb(243, 243, 243);
                pb_part12.BackColor = Color.FromArgb(243, 243, 243);
                pb_part13.BackColor = Color.FromArgb(243, 243, 243);
                pb_part14.BackColor = Color.FromArgb(243, 243, 243);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        #endregion

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void Pb_part1_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part1.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part2_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part2.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part3_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part3.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part4_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part4.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part5_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part5.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part6_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part6.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part7_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part7.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part8_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part8.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part9_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part9.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part10_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part10.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part11_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part11.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part12_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part12.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part13_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part13.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Pb_part14_Click(object sender, EventArgs e)
        {
            IsClick();
            pb_part14.BackColor = Color.FromArgb(31, 150, 243);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //string name = "" ;
           // int pageindex = 0;
            //string[] pages = { "skinTabPage1", "skinTabPage2", "skinTabPage3", "skinTabPage4", "skinTabPage5", "skinTabPage6", "skinTabPage7", "skinTabPage8", "skinTabPage9", "skinTabPage10", "skinTabPage111", "skinTabPage12", "skinTabPage13", "skinTabPage14" };
            //for (int i = 0; i < pages.Length; i++)
            //{
            //    if (pageindex<pages.Length)
            //    {
            //        pageindex++;
            //        name = pages[pageindex];
            //    }
            //    else
            //    {
            //        name = pages[i];
            //    }
            //}
            //MessageBox.Show(name);
                pageindex++;
                convertpage();
            if (pageindex>skinTabControl1.TabCount)
            {
                pageindex = 0;
            }
        }
        int pageindex = 0;
        private void convertpage()
        {
            switch (pageindex)
            {
                case 0:
                    skinTabControl1.SelectedTab = skinTabPage1;
                    IsClick();
                    pb_part1.BackColor = Color.FromArgb(31, 150, 243);
                    break;
                case 1:
                    skinTabControl1.SelectedTab = skinTabPage2;
                    IsClick();
                    pb_part2.BackColor = Color.FromArgb(31, 150, 243);
                    break;
                case 2:
                    skinTabControl1.SelectedTab = skinTabPage3;
                    IsClick();
                    pb_part3.BackColor = Color.FromArgb(31, 150, 243);
                    break;
                case 3:
                    skinTabControl1.SelectedTab = skinTabPage4;
                    IsClick();
                    pb_part4.BackColor = Color.FromArgb(31, 150, 243);
                    break;
                case 4:
                    skinTabControl1.SelectedTab = skinTabPage5;
                    IsClick();
                    pb_part5.BackColor = Color.FromArgb(31, 150, 243);
                    break;
                case 5:
                    skinTabControl1.SelectedTab = skinTabPage6;
                    IsClick();
                    pb_part6.BackColor = Color.FromArgb(31, 150, 243);
                    break;
                case 6:
                    skinTabControl1.SelectedTab = skinTabPage7;
                    IsClick();
                    pb_part7.BackColor = Color.FromArgb(31, 150, 243);
                    break;
                case 7:
                    skinTabControl1.SelectedTab = skinTabPage8;
                    IsClick();
                    pb_part8.BackColor = Color.FromArgb(31, 150, 243);
                    break;
                case 8:
                    skinTabControl1.SelectedTab = skinTabPage9;
                    IsClick();
                    pb_part9.BackColor = Color.FromArgb(31, 150, 243);
                    break;
                case 9:
                    skinTabControl1.SelectedTab = skinTabPage10;
                    IsClick();
                    pb_part10.BackColor = Color.FromArgb(31, 150, 243);
                    break;
                case 10:
                    skinTabControl1.SelectedTab = skinTabPage11;
                    IsClick();
                    pb_part11.BackColor = Color.FromArgb(31, 150, 243);
                    break;
                case 11:
                    skinTabControl1.SelectedTab = skinTabPage12;
                    IsClick();
                    pb_part12.BackColor = Color.FromArgb(31, 150, 243);
                    break;
                case 12:
                    skinTabControl1.SelectedTab = skinTabPage13;
                    IsClick();
                    pb_part13.BackColor = Color.FromArgb(31, 150, 243);
                    break;
            }
        }
    }
}
