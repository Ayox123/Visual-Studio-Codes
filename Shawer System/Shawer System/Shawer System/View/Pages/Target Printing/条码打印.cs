using Shawer_System.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace Shawer_System.View.Pages.Target_Printing
{
    public partial class 条码打印 : UserControl
    {
        public 条码打印()
        {
            InitializeComponent();
            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);//重载打印事件
        }
        public static string  printlogpath = BodyForm.logpath + "\\" + "打印日志-条码打印log.txt";//打印页面操作日志文件路径
        //打印事件
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            int width = printImage.Width;
            int height = printImage.Height;
            Rectangle destRect = new Rectangle(x, y, width, height);
            e.Graphics.DrawImage(printImage, destRect, 0, 0, printImage.Width, printImage.Height, System.Drawing.GraphicsUnit.Pixel);
        }

        string[] numbers;//号段
        private string siglenumber;//单个流水号
        private string startnumber;//起始号
        private string endnumber;//终止号

        private string year;//年度
        private string countid;//归档号
        private string serialid;//流水号
        private string savepath = BodyForm.datapath + "\\BarCode\\";//保存位置

        PrintDocument pd = new PrintDocument();
        Bitmap printImage = null;

        private string targetkinds;//操作标签类型
        //查询
        private void Bt_search_Click(object sender, EventArgs e)
        {
            //是否输入号
            if (txt_currentnumber.Text.Length > 0)
            {
                //是否是号段
                if (txt_currentnumber.Text.Trim().Contains("-"))
                {
                    numbers = txt_currentnumber.Text.Split('-');//分隔号存入数组
                    //如果终止号小于起始号时
                    if (Convert.ToInt32(numbers[1])<Convert.ToInt32(numbers[0]))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "起始流水号必须大于终止流水号", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        startnumber = numbers[0];//"-"前的字符
                        endnumber = numbers[1];//“-”后的字符
                        //记录起始流水号
                        serialid = startnumber;
                        dataGridView1.Columns.Clear();

                        string strsql = "select * from GuiDangHao where Batch_NO >='" + startnumber + "'and Batch_NO<='" + endnumber + "'";//查询语句。
                        SqlConnection conn = new SqlConnection(Settings.Default.connectestring);
                        SqlCommand cmd = new SqlCommand(strsql, conn);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        //以数据源方式绑定更快
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                   
                }
                else
                {
                    siglenumber = txt_currentnumber.Text.Trim();
                    //记录起始流水号
                    serialid = siglenumber;
                    dataGridView1.Columns.Clear();//清除列表

                    string strsql = "select * from GuiDangHao where Batch_NO='" + siglenumber + "'";//查询语句。
                    SqlConnection conn = new SqlConnection(Settings.Default.connectestring);
                    SqlCommand cmd = new SqlCommand(strsql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    //以数据源方式绑定更快
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "请输入号段或单个号码", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        #region 生成标签
        private void CreateTarget(string targetname)
        {
                EncodingOptions options = new EncodingOptions
                {
                    //条码大小
                    //Width = 377,
                    //Height = 100

                    Width = 270,
                    Height = 60
                };
                BarcodeWriter writer = new BarcodeWriter
                {
                    //条码类型
                    Format = BarcodeFormat.CODE_93,
                    Options = options
                };
                //写入条码内容
                Bitmap bitmap = writer.Write(serialid);

                //绘制流水号在条码上
                Bitmap newbm = KiSetText(bitmap, serialid, 40, 140);
                printImage = newbm;
                //判断操作类型
                if (targetkinds == "print")
                {
                    //打印
                    //pd.Print();
                }
                else if (targetkinds == "view")
                {
                    pictureBox2.Image = newbm;
                }
                else
                {
                    //存为图片
                    newbm.Save(savepath + targetname + ".png", System.Drawing.Imaging.ImageFormat.Png);
                }
        }
        #endregion

        #region 绘制文字
        public Bitmap KiSetText(Bitmap b, string txt, int x, int y)
        {
            //是否为空
            if (b == null)
            {
                return null;
            }
            //打印大小，此时转为了像素，原大小为70mm*30mm,    1mm=3.78px    故长为 378   宽为189
            Bitmap resizeImage = new Bitmap(378, 189);
            //转为绘图对象
            Graphics gfx = Graphics.FromImage(resizeImage);
            gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            //设置背景色及打印尺寸
            gfx.FillRectangle(Brushes.Transparent, new Rectangle(0, 0, resizeImage.Width, resizeImage.Height));
            //设置条码位置
            gfx.DrawImageUnscaled(b, 30, 60);
            //设置字体样式
            FontFamily fm = new FontFamily("宋体");
            Font font = new Font(fm, 15, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush sb = new SolidBrush(Color.Black);
            //绘制文字及其位置
            gfx.DrawString(txt, font, sb, new PointF(x, y));//流水号
            gfx.DrawString(year, font, sb, new PointF(40, 25));//年度
            gfx.DrawString("归档号：" + countid, font, sb, new PointF(230, 25));//归档号

            gfx.Dispose();

            //返回图像对象
            return resizeImage;
        }
        #endregion

        //保存标签
        private void Bt_createbarcode_Click(object sender, EventArgs e)
        {
            targetkinds = "save";
            //设置查询按钮不可用，避免误操作
            bt_search.BeginInvoke(new Action(() => { bt_search.Enabled/*（此处为要操作的属性）*/= false; }));

            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "确定保存号段为:"+txt_currentnumber.Text+", 共计 "+dataGridView1.Rows.Count+" 个条码标签！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {

                    //带参数调用
                    Thread thread = new Thread(new ParameterizedThreadStart(CreateTar));
                    thread.Start(serialid);

                    #region 生成标签
                    void CreateTar(object targetname)
                    {
                        EncodingOptions options = new EncodingOptions
                        {
                            //条码大小
                            //Width = 377,
                            //Height = 100

                            Width = 320,
                            Height = 80
                        };
                        BarcodeWriter writer = new BarcodeWriter
                        {
                            //条码类型
                            Format = BarcodeFormat.CODE_93,
                            Options = options
                        };
                        //写入条码内容
                        Bitmap bitmap = writer.Write(serialid);

                        //绘制流水号在条码上
                        Bitmap newbm = KiSetText(bitmap, serialid, 40, 140);
                        printImage = newbm;
                        //判断操作类型
                        if (targetkinds == "print")
                        {
                            //打印
                            pd.Print();
                        }
                        else if (targetkinds == "view")
                        {
                            pictureBox2.Image = newbm;
                        }
                        else
                        {
                            //存为图片
                            //进度条算法         100/2=50    100/10  =10 100/100=1
                            int total = 100;
                            int run = dataGridView1.Rows.Count;
                            int step = total / run;
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                year = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                countid = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                serialid = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                Thread.Sleep(50);
                                double running = 100 / dataGridView1.Rows.Count;
                                cxFlatProgressBar1.ValueNumber += Convert.ToInt32(i * running);
                                CreateTarget(serialid);
                                newbm.Save(savepath + targetname + ".png", System.Drawing.Imaging.ImageFormat.Png);
                                //选中当前正在操作的数据
                                dataGridView1.Rows[i].Selected = true;
                                //滚动条跟随选中行滚动
                                if (i>30)
                                {
                                    dataGridView1.FirstDisplayedScrollingRowIndex = i;
                                }
                            }
                        }
                        Thread.Sleep(1000);
                        cxFlatProgressBar1.ValueNumber = 0;
                        MetroFramework.MetroMessageBox.Show(this, "成功保存该号段条码标签", "消息", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        //写入操作日志
                        System.IO.FileStream fs = new System.IO.FileStream(printlogpath, System.IO.FileMode.Append);
                        System.IO.StreamWriter sw = new System.IO.StreamWriter(fs, System.Text.Encoding.Default);
                        sw.WriteLine(DateTime.Now.ToShortTimeString()+"：用户操作条码打印，成功保存了"+txt_currentnumber.Text+"之间的数据，共计："+dataGridView1.Rows.Count.ToString()+"条数据"+"\r");
                        sw.Close();
                        fs.Close();
                        bt_search.BeginInvoke(new Action(() => { bt_search.Enabled/*（此处为要操作的属性）*/= true; }));
                    }
                    #endregion
                }
                else
                {
                    bt_search.BeginInvoke(new Action(() => { bt_search.Enabled/*（此处为要操作的属性）*/= true; }));
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "列表中没有要生成的数据源", "Wrong", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                bt_search.BeginInvoke(new Action(() => { bt_search.Enabled/*（此处为要操作的属性）*/= true; }));
            }
        }

        //打印标签
        private void Bt_print_Click(object sender, EventArgs e)
        {
            targetkinds = "print";
            //设置查询按钮不可用，避免误操作
            bt_search.BeginInvoke(new Action(() => { bt_search.Enabled/*（此处为要操作的属性）*/= false; }));
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "确定打印号段为:" + txt_currentnumber.Text + ", 共计 " + dataGridView1.Rows.Count + " 个条码标签！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    //带参数调用
                    Thread thread = new Thread(new ParameterizedThreadStart(CreateTar));
                    thread.Start(serialid);

                    #region 打印标签
                    void CreateTar(object targetname)
                    {
                        EncodingOptions options = new EncodingOptions
                        {
                            //条码大小
                            //Width = 377,
                            //Height = 100

                            Width = 320,
                            Height = 80
                        };
                        BarcodeWriter writer = new BarcodeWriter
                        {
                            //条码类型
                            Format = BarcodeFormat.CODE_93,
                            Options = options
                        };
                        //写入条码内容
                        Bitmap bitmap = writer.Write(serialid);

                        //绘制流水号在条码上
                        Bitmap newbm = KiSetText(bitmap, serialid, 40, 140);
                        printImage = newbm;
                        //判断操作类型
                        if (targetkinds == "print")
                        {
                            //打印
                            //存为图片
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                year = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                countid = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                serialid = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                Thread.Sleep(50);
                                cxFlatProgressBar1.ValueNumber += 2;
                                CreateTarget(serialid);
                                pd.Print();
                                //选中当前正在操作的数据
                                dataGridView1.Rows[i].Selected = true;
                                //滚动条跟随选中行滚动
                                if (i > 30)
                                {
                                    dataGridView1.FirstDisplayedScrollingRowIndex = i;
                                }
                            }
                        }
                        else if (targetkinds == "view")
                        {
                            pictureBox2.Image = newbm;
                        }
                        else
                        {
                            //存为图片
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                year = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                countid = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                serialid = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                Thread.Sleep(50);
                                double running = 100 / dataGridView1.Rows.Count;
                                cxFlatProgressBar1.ValueNumber =Convert.ToInt32( i * running);
                                CreateTarget(serialid);
                                newbm.Save(savepath + targetname + ".png", System.Drawing.Imaging.ImageFormat.Png);

                            }
                        }
                        Thread.Sleep(1000);
                        cxFlatProgressBar1.ValueNumber = 0;
                        //生成操作日志
                        System.IO.FileStream fs = new System.IO.FileStream(printlogpath, System.IO.FileMode.Append);
                        System.IO.StreamWriter sw = new System.IO.StreamWriter(fs, System.Text.Encoding.Default);
                        sw.WriteLine(DateTime.Now.ToShortTimeString() + "：用户操作条码打印，成功打印了" + txt_currentnumber.Text + "之间的数据，共计：" + dataGridView1.Rows.Count.ToString() + "条数据" + "\r");
                        sw.Close();
                        fs.Close();
                        MetroFramework.MetroMessageBox.Show(this, "该号段中条码标签已全部打印完成", "消息", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        bt_search.BeginInvoke(new Action(() => { bt_search.Enabled/*（此处为要操作的属性）*/= true; }));
                    }
                    #endregion
                }
                else
                {
                    bt_search.BeginInvoke(new Action(() => { bt_search.Enabled/*（此处为要操作的属性）*/= true; }));
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "列表中没有要打印的数据源", "Wrong", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                bt_search.BeginInvoke(new Action(() => { bt_search.Enabled/*（此处为要操作的属性）*/= true; }));
            }
        }

        //预览标签
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //点击列标题时不触发事件
            if (e.RowIndex==-1){ }
            //选中行时才触发事件
            else
            {
                targetkinds = "view";
                int rowindex = dataGridView1.CurrentRow.Index;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    year = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                    countid = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                    serialid = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                    pictureBox2.Image = null;
                    CreateTarget(serialid);
                }
            }
        }
        

        private void Ckb_default_CheckedChanged(object sender, EventArgs e)
        {

            if (ckb_default.Checked == true)
            {
                cxFlatGroupBox1.Enabled = false;
            }
            else if (ckb_default.Checked == false)
            {
                cxFlatGroupBox1.Enabled = true;
            }
        }



        private void 条码打印_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            //初始化
            year = "";
            countid = "";
            serialid = "";
            MessageBox.Show(printlogpath);
        }

        private void CxFlatCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
