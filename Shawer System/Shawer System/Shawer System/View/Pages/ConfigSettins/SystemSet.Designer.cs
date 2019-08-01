namespace Shawer_System.View.Pages.ConfigSettins
{
    partial class SystemSet
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_refactory = new CxFlatUI.CxFlatRoundButton();
            this.bt_openpath = new CxFlatUI.CxFlatRoundButton();
            this.bt_selectpath = new CxFlatUI.CxFlatRoundButton();
            this.txt_dailypath = new CxFlatUI.CxFlatTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cxFlatSliderBar1 = new CxFlatUI.CxFlatSliderBar();
            this.label6 = new System.Windows.Forms.Label();
            this.ckb_light = new CxFlatUI.CxFlatCheckBox();
            this.ckb_dark = new CxFlatUI.CxFlatCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_isautostart = new CxFlatUI.CxFlatCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cxFlatRoundButton2 = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatRoundButton3 = new CxFlatUI.CxFlatRoundButton();
            this.txt_cachepath = new CxFlatUI.CxFlatTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_refactory
            // 
            this.bt_refactory.ButtonType = CxFlatUI.ButtonType.Primary;
            this.bt_refactory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_refactory.Font = new System.Drawing.Font("幼圆", 9F);
            this.bt_refactory.Location = new System.Drawing.Point(605, 446);
            this.bt_refactory.Name = "bt_refactory";
            this.bt_refactory.Size = new System.Drawing.Size(101, 27);
            this.bt_refactory.TabIndex = 36;
            this.bt_refactory.Text = "恢复默认";
            this.bt_refactory.TextColor = System.Drawing.Color.White;
            this.bt_refactory.Click += new System.EventHandler(this.Bt_refactory_Click);
            // 
            // bt_openpath
            // 
            this.bt_openpath.ButtonType = CxFlatUI.ButtonType.Primary;
            this.bt_openpath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_openpath.Font = new System.Drawing.Font("幼圆", 9F);
            this.bt_openpath.Location = new System.Drawing.Point(470, 446);
            this.bt_openpath.Name = "bt_openpath";
            this.bt_openpath.Size = new System.Drawing.Size(101, 27);
            this.bt_openpath.TabIndex = 35;
            this.bt_openpath.Text = "打开目录";
            this.bt_openpath.TextColor = System.Drawing.Color.White;
            this.bt_openpath.Click += new System.EventHandler(this.Bt_openpath_Click);
            // 
            // bt_selectpath
            // 
            this.bt_selectpath.ButtonType = CxFlatUI.ButtonType.Primary;
            this.bt_selectpath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_selectpath.Font = new System.Drawing.Font("幼圆", 9F);
            this.bt_selectpath.Location = new System.Drawing.Point(335, 446);
            this.bt_selectpath.Name = "bt_selectpath";
            this.bt_selectpath.Size = new System.Drawing.Size(101, 27);
            this.bt_selectpath.TabIndex = 34;
            this.bt_selectpath.Text = "选择路径";
            this.bt_selectpath.TextColor = System.Drawing.Color.White;
            this.bt_selectpath.Click += new System.EventHandler(this.Bt_selectpath_Click);
            // 
            // txt_dailypath
            // 
            this.txt_dailypath.Enabled = false;
            this.txt_dailypath.Font = new System.Drawing.Font("幼圆", 9F);
            this.txt_dailypath.Hint = "";
            this.txt_dailypath.Location = new System.Drawing.Point(91, 443);
            this.txt_dailypath.MaxLength = 32767;
            this.txt_dailypath.Multiline = false;
            this.txt_dailypath.Name = "txt_dailypath";
            this.txt_dailypath.PasswordChar = '\0';
            this.txt_dailypath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dailypath.SelectedText = "";
            this.txt_dailypath.SelectionLength = 0;
            this.txt_dailypath.SelectionStart = 0;
            this.txt_dailypath.Size = new System.Drawing.Size(238, 33);
            this.txt_dailypath.TabIndex = 33;
            this.txt_dailypath.TabStop = false;
            this.txt_dailypath.Text = "E:\\Visual Studio Project\\WinForm Application\\ShaweClou\\Resources";
            this.txt_dailypath.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("幼圆", 9F);
            this.label8.Location = new System.Drawing.Point(88, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "日志";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("幼圆", 12F);
            this.label9.Location = new System.Drawing.Point(64, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "路径管理";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("幼圆", 9F);
            this.label7.Location = new System.Drawing.Point(88, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "透明度";
            // 
            // cxFlatSliderBar1
            // 
            this.cxFlatSliderBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cxFlatSliderBar1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cxFlatSliderBar1.Location = new System.Drawing.Point(149, 326);
            this.cxFlatSliderBar1.MaxValue = 10;
            this.cxFlatSliderBar1.MinValue = 0;
            this.cxFlatSliderBar1.Name = "cxFlatSliderBar1";
            this.cxFlatSliderBar1.ShowValue = false;
            this.cxFlatSliderBar1.Size = new System.Drawing.Size(180, 16);
            this.cxFlatSliderBar1.TabIndex = 29;
            this.cxFlatSliderBar1.Text = "cxFlatSliderBar1";
            this.cxFlatSliderBar1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cxFlatSliderBar1.Value = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("幼圆", 9F);
            this.label6.Location = new System.Drawing.Point(88, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "主题色透明度(暂不支持)";
            // 
            // ckb_light
            // 
            this.ckb_light.AutoSize = true;
            this.ckb_light.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckb_light.Font = new System.Drawing.Font("幼圆", 10F);
            this.ckb_light.Location = new System.Drawing.Point(194, 251);
            this.ckb_light.Name = "ckb_light";
            this.ckb_light.Size = new System.Drawing.Size(82, 20);
            this.ckb_light.TabIndex = 27;
            this.ckb_light.Text = "亮色系";
            this.ckb_light.UseVisualStyleBackColor = true;
            this.ckb_light.CheckedChanged += new System.EventHandler(this.Ckb_light_CheckedChanged);
            // 
            // ckb_dark
            // 
            this.ckb_dark.AutoSize = true;
            this.ckb_dark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckb_dark.Font = new System.Drawing.Font("幼圆", 10F);
            this.ckb_dark.Location = new System.Drawing.Point(91, 251);
            this.ckb_dark.Name = "ckb_dark";
            this.ckb_dark.Size = new System.Drawing.Size(82, 20);
            this.ckb_dark.TabIndex = 26;
            this.ckb_dark.Text = "暗色系";
            this.ckb_dark.UseVisualStyleBackColor = true;
            this.ckb_dark.CheckedChanged += new System.EventHandler(this.Ckb_dark_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 9F);
            this.label4.Location = new System.Drawing.Point(88, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "主题色(暂不支持)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 12F);
            this.label5.Location = new System.Drawing.Point(64, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "主题";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 9F);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(350, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "注意：此选项必须以管理员自份运行本程序";
            // 
            // cb_isautostart
            // 
            this.cb_isautostart.AutoSize = true;
            this.cb_isautostart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_isautostart.Font = new System.Drawing.Font("幼圆", 10F);
            this.cb_isautostart.Location = new System.Drawing.Point(91, 124);
            this.cb_isautostart.Name = "cb_isautostart";
            this.cb_isautostart.Size = new System.Drawing.Size(219, 20);
            this.cb_isautostart.TabIndex = 22;
            this.cb_isautostart.Text = "是否让程序开机自动启动";
            this.cb_isautostart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 9F);
            this.label1.Location = new System.Drawing.Point(88, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "启动";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F);
            this.label2.Location = new System.Drawing.Point(64, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "开机自启";
            // 
            // cxFlatRoundButton2
            // 
            this.cxFlatRoundButton2.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatRoundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cxFlatRoundButton2.Font = new System.Drawing.Font("幼圆", 9F);
            this.cxFlatRoundButton2.Location = new System.Drawing.Point(470, 517);
            this.cxFlatRoundButton2.Name = "cxFlatRoundButton2";
            this.cxFlatRoundButton2.Size = new System.Drawing.Size(101, 27);
            this.cxFlatRoundButton2.TabIndex = 40;
            this.cxFlatRoundButton2.Text = "打开目录";
            this.cxFlatRoundButton2.TextColor = System.Drawing.Color.White;
            // 
            // cxFlatRoundButton3
            // 
            this.cxFlatRoundButton3.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatRoundButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cxFlatRoundButton3.Font = new System.Drawing.Font("幼圆", 9F);
            this.cxFlatRoundButton3.Location = new System.Drawing.Point(335, 517);
            this.cxFlatRoundButton3.Name = "cxFlatRoundButton3";
            this.cxFlatRoundButton3.Size = new System.Drawing.Size(101, 27);
            this.cxFlatRoundButton3.TabIndex = 39;
            this.cxFlatRoundButton3.Text = "选择路径";
            this.cxFlatRoundButton3.TextColor = System.Drawing.Color.White;
            // 
            // txt_cachepath
            // 
            this.txt_cachepath.Enabled = false;
            this.txt_cachepath.Font = new System.Drawing.Font("幼圆", 9F);
            this.txt_cachepath.Hint = "";
            this.txt_cachepath.Location = new System.Drawing.Point(91, 514);
            this.txt_cachepath.MaxLength = 32767;
            this.txt_cachepath.Multiline = false;
            this.txt_cachepath.Name = "txt_cachepath";
            this.txt_cachepath.PasswordChar = '\0';
            this.txt_cachepath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cachepath.SelectedText = "";
            this.txt_cachepath.SelectionLength = 0;
            this.txt_cachepath.SelectionStart = 0;
            this.txt_cachepath.Size = new System.Drawing.Size(238, 33);
            this.txt_cachepath.TabIndex = 38;
            this.txt_cachepath.TabStop = false;
            this.txt_cachepath.Text = "E:\\Visual Studio Project\\WinForm Application\\ShaweClou\\Resources";
            this.txt_cachepath.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("幼圆", 9F);
            this.label10.Location = new System.Drawing.Point(88, 491);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "缓存";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("幼圆", 12F);
            this.label11.Location = new System.Drawing.Point(30, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = ">  系统设置";
            // 
            // SystemSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cxFlatRoundButton2);
            this.Controls.Add(this.cxFlatRoundButton3);
            this.Controls.Add(this.txt_cachepath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bt_refactory);
            this.Controls.Add(this.bt_openpath);
            this.Controls.Add(this.bt_selectpath);
            this.Controls.Add(this.txt_dailypath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cxFlatSliderBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckb_light);
            this.Controls.Add(this.ckb_dark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_isautostart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "SystemSet";
            this.Size = new System.Drawing.Size(975, 719);
            this.Load += new System.EventHandler(this.SystemSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CxFlatUI.CxFlatRoundButton bt_refactory;
        private CxFlatUI.CxFlatRoundButton bt_openpath;
        private CxFlatUI.CxFlatRoundButton bt_selectpath;
        private CxFlatUI.CxFlatTextBox txt_dailypath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private CxFlatUI.CxFlatSliderBar cxFlatSliderBar1;
        private System.Windows.Forms.Label label6;
        private CxFlatUI.CxFlatCheckBox ckb_light;
        private CxFlatUI.CxFlatCheckBox ckb_dark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private CxFlatUI.CxFlatCheckBox cb_isautostart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton2;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton3;
        private CxFlatUI.CxFlatTextBox txt_cachepath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
