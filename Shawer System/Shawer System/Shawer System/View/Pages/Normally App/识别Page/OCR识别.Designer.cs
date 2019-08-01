namespace Shawer_System.View.Pages.Normally_App.文件识别
{
    partial class OCR识别
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_path = new CxFlatUI.CxFlatTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cxFlatButton1 = new CxFlatUI.Controls.CxFlatButton();
            this.bt_save = new CxFlatUI.Controls.CxFlatButton();
            this.pb_openpath = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_openpath)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "输出位置：";
            // 
            // txt_path
            // 
            this.txt_path.Font = new System.Drawing.Font("幼圆", 10F);
            this.txt_path.Hint = "";
            this.txt_path.Location = new System.Drawing.Point(109, 2);
            this.txt_path.MaxLength = 32767;
            this.txt_path.Multiline = false;
            this.txt_path.Name = "txt_path";
            this.txt_path.PasswordChar = '\0';
            this.txt_path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_path.SelectedText = "";
            this.txt_path.SelectionLength = 0;
            this.txt_path.SelectionStart = 0;
            this.txt_path.Size = new System.Drawing.Size(354, 35);
            this.txt_path.TabIndex = 1;
            this.txt_path.TabStop = false;
            this.txt_path.Text = "cxFlatTextBox1";
            this.txt_path.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cxFlatButton1);
            this.panel1.Controls.Add(this.bt_save);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_openpath);
            this.panel1.Controls.Add(this.txt_path);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 602);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 40);
            this.panel1.TabIndex = 3;
            // 
            // cxFlatButton1
            // 
            this.cxFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cxFlatButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton1.Font = new System.Drawing.Font("幼圆", 10F);
            this.cxFlatButton1.Location = new System.Drawing.Point(618, 2);
            this.cxFlatButton1.Name = "cxFlatButton1";
            this.cxFlatButton1.Size = new System.Drawing.Size(123, 37);
            this.cxFlatButton1.TabIndex = 4;
            this.cxFlatButton1.Text = "开始识别";
            this.cxFlatButton1.TextColor = System.Drawing.Color.White;
            this.cxFlatButton1.Click += new System.EventHandler(this.CxFlatButton1_Click);
            // 
            // bt_save
            // 
            this.bt_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_save.ButtonType = CxFlatUI.ButtonType.Primary;
            this.bt_save.Font = new System.Drawing.Font("幼圆", 10F);
            this.bt_save.Location = new System.Drawing.Point(785, 3);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(123, 37);
            this.bt_save.TabIndex = 3;
            this.bt_save.Text = "保存为TXT文件";
            this.bt_save.TextColor = System.Drawing.Color.White;
            this.bt_save.Click += new System.EventHandler(this.Bt_save_Click);
            // 
            // pb_openpath
            // 
            this.pb_openpath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_openpath.Image = global::Shawer_System.Properties.Resources.文件夹;
            this.pb_openpath.Location = new System.Drawing.Point(469, 7);
            this.pb_openpath.Name = "pb_openpath";
            this.pb_openpath.Size = new System.Drawing.Size(25, 25);
            this.pb_openpath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_openpath.TabIndex = 2;
            this.pb_openpath.TabStop = false;
            this.pb_openpath.Click += new System.EventHandler(this.Pb_openpath_Click);
            this.pb_openpath.MouseLeave += new System.EventHandler(this.Pb_openpath_MouseLeave);
            this.pb_openpath.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pb_openpath_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 602);
            this.panel2.TabIndex = 4;
            // 
            // OCR识别
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "OCR识别";
            this.Size = new System.Drawing.Size(975, 642);
            this.Load += new System.EventHandler(this.OCR识别_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_openpath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CxFlatUI.CxFlatTextBox txt_path;
        private System.Windows.Forms.PictureBox pb_openpath;
        private System.Windows.Forms.Panel panel1;
        private CxFlatUI.Controls.CxFlatButton bt_save;
        private System.Windows.Forms.Panel panel2;
        private CxFlatUI.Controls.CxFlatButton cxFlatButton1;
    }
}
