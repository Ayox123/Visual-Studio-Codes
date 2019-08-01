namespace Shawer_System.View
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_close = new CxFlatUI.CxFlatRoundButton();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.lb_info = new System.Windows.Forms.Label();
            this.bt_ok = new CxFlatUI.CxFlatRoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.ButtonType = CxFlatUI.ButtonType.Primary;
            this.bt_close.Font = new System.Drawing.Font("幼圆", 9F);
            this.bt_close.Location = new System.Drawing.Point(245, 199);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(121, 36);
            this.bt_close.TabIndex = 1;
            this.bt_close.Text = "知 道 了";
            this.bt_close.TextColor = System.Drawing.Color.White;
            this.bt_close.Click += new System.EventHandler(this.Bt_close_Click);
            // 
            // pb_icon
            // 
            this.pb_icon.Image = global::Shawer_System.Properties.Resources.info;
            this.pb_icon.Location = new System.Drawing.Point(18, 15);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(32, 32);
            this.pb_icon.TabIndex = 2;
            this.pb_icon.TabStop = false;
            // 
            // lb_info
            // 
            this.lb_info.Font = new System.Drawing.Font("幼圆", 11F);
            this.lb_info.Location = new System.Drawing.Point(84, 66);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(265, 114);
            this.lb_info.TabIndex = 3;
            this.lb_info.Text = "确认生成流水号为00535705-00535760号段的条码标签！";
            this.lb_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_ok
            // 
            this.bt_ok.ButtonType = CxFlatUI.ButtonType.Primary;
            this.bt_ok.Font = new System.Drawing.Font("幼圆", 9F);
            this.bt_ok.Location = new System.Drawing.Point(63, 199);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(121, 36);
            this.bt_ok.TabIndex = 4;
            this.bt_ok.Text = "确    认";
            this.bt_ok.TextColor = System.Drawing.Color.White;
            this.bt_ok.Click += new System.EventHandler(this.Bt_ok_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(429, 263);
            this.ControlBox = false;
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.pb_icon);
            this.Controls.Add(this.bt_close);
            this.EffectCaption = CCWin.TitleType.None;
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.Radius = 8;
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.TitleColor = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatRoundButton bt_close;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Label lb_info;
        private CxFlatUI.CxFlatRoundButton bt_ok;
    }
}