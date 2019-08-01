namespace Shawer_System.View.Pages.Normally_App
{
    partial class 文件图像识别
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cxFlatTabControl1 = new CxFlatUI.CxFlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.ocR识别1 = new Shawer_System.View.Pages.Normally_App.文件识别.OCR识别();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.cxFlatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 719);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cxFlatTabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 682);
            this.panel3.TabIndex = 67;
            // 
            // cxFlatTabControl1
            // 
            this.cxFlatTabControl1.Controls.Add(this.tabPage1);
            this.cxFlatTabControl1.Controls.Add(this.tabPage2);
            this.cxFlatTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cxFlatTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cxFlatTabControl1.Font = new System.Drawing.Font("幼圆", 10F);
            this.cxFlatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.cxFlatTabControl1.Location = new System.Drawing.Point(0, 0);
            this.cxFlatTabControl1.Name = "cxFlatTabControl1";
            this.cxFlatTabControl1.SelectedIndex = 0;
            this.cxFlatTabControl1.Size = new System.Drawing.Size(975, 682);
            this.cxFlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.cxFlatTabControl1.TabIndex = 0;
            this.cxFlatTabControl1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ocR识别1);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OCR文字";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图像识别";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 37);
            this.panel2.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("幼圆", 12F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(30, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 65;
            this.label11.Text = ">  文件识别";
            // 
            // ocR识别1
            // 
            this.ocR识别1.BackColor = System.Drawing.Color.White;
            this.ocR识别1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ocR识别1.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ocR识别1.Location = new System.Drawing.Point(3, 3);
            this.ocR识别1.Name = "ocR识别1";
            this.ocR识别1.Size = new System.Drawing.Size(969, 636);
            this.ocR识别1.TabIndex = 0;
            // 
            // 文件图像识别
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "文件图像识别";
            this.Size = new System.Drawing.Size(975, 719);
            this.Load += new System.EventHandler(this.图像识别_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.cxFlatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CxFlatUI.CxFlatTabControl cxFlatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private 文件识别.OCR识别 ocR识别1;
    }
}
