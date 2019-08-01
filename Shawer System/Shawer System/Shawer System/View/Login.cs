using CCWin;
using Shawer_System.Controller;
using Shawer_System.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Shawer_System
{
    /// <summary>
    /// 如果需要调整页面，选中tabcontrol，设置其itemsize大小为70，36 则可以更改  location 593, 109
    /// </summary>
    public partial class Login : CCSkinMain
    {
        private ModelController _modelcontroller;
        public ModelController ModelController
        {
            get { return _modelcontroller; }
            set
            {
                this._modelcontroller = value;
                //绑定一定只能写在给Controllor赋值以后而不能写在PersonForm的构造函数中(此时Controllor还未被实例化)
                //因为我们这里采用的是Controllor-First而不是View-First，不然Controllor.Model为null会异常
                //将View通过构造函数注入到Controllor中的属于Controllor-First,这时候Controllor先创建
                //将Controllor通过构造函数注入到View中的属于View-First,这时候View先创建
                this.txt_user.DataBindings.Add("Text", ModelController.Model, "ID");
                this.txt_password.DataBindings.Add("Text", ModelController.Model, "Name");
            }
        }

        public Login()
        {
            InitializeComponent();
        }
        #region 变量
        int sleepthread;
        Thread thread1;//加载程序
        Thread thread2;//登录验证
        Thread thread3;//连接管理
        bool isinstall;//是否加载完成
        int pageindex;//页面索引
        int swicthindex;//开关索引
        string enterpresskind;//页面索引对应的回车事件
        public static string datauser;//数据库用户名
        public static string datapassword;//数据库密码
        public static string serverip;//服务器ip地址

        private static SqlConnection mySqlConnection;  //mySqlConnection   is   a   SqlConnection   object 
        private static string ConnectionString = "";
        private static bool IsCanConnectioned = false;
        #endregion

        #region 方法

        #region 加载程序
        private void Checking()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(15);//间隔50毫秒加一次进度
                sleepthread++;
                metroProgressBar1.Value++;
                if (i == 100)
                {
                    //AnimationControls.Animation.MoveStep = 1;//设置动画速度

                    isinstall = true;//加载完成传值
                    //隐藏加载界面
                    loadingView1.BeginInvoke(new Action(() => { loadingView1.Enabled/*（此处为要操作的属性）*/= false; }));
                    panel1.BeginInvoke(new Action(() => { panel1.Visible/*（此处为要操作的属性）*/= false; }));

                    AnimationControls.Animation.MoveStep = 30;//设置动画速度
                    //动画效果打开
                    label4.BeginInvoke(new Action(() => { label4.Visible/*（此处为要操作的属性）*/= true; }));
                    skinTabControl1.BeginInvoke(new Action(() => { AnimationControls.Animation.ShowControl(skinTabControl1, true, direction: AnchorStyles.Right); }));
                    //pb_connection.BeginInvoke(new Action(() => { AnimationControls.Animation.ShowControl(pb_connection, true, direction: AnchorStyles.Right); }));
                    metroProgressBar1.BeginInvoke(new Action(() => { metroProgressBar1.Visible/*（此处为要操作的属性）*/= false; }));
                    pb_connection.BeginInvoke(new Action(() => { pb_connection.Visible/*（此处为要操作的属性）*/= true; }));
                }
            }
        }
        #endregion

        #region 登录验证
        private void LoginCheck()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(10);
                if (i == 34)
                {
                    bt_login.BeginInvoke(new Action(() => { bt_login.Text/*（此处为要操作的属性）*/= "Checking.."; }));

                    #region  第一次数据库验证
                    //获取数据库连接字符串
                    ConnectionString = "server='" + txt_serverip.Text + "'; uid='" + txt_databaseuser.Text + "'; pwd='" + txt_databasepassword.Text + "'; database=CCBGRXD ";
                    //创建连接对象
                    mySqlConnection = new SqlConnection(ConnectionString);
                    //ConnectionTimeout 在.net 1.x 可以设置 在.net 2.0后是只读属性，则需要在连接字符串设置
                    //如：server=.;uid=sa;pwd=;database=PMIS;Integrated Security=SSPI; Connection Timeout=30
                    //mySqlConnection.ConnectionTimeout = 1;//设置连接超时的时间
                    try
                    {
                        //Open DataBase
                        //打开数据库
                        mySqlConnection.Open();
                        IsCanConnectioned = true;
                        lb_status.BeginInvoke(new Action(() => { lb_status.Text/*（此处为要操作的属性）*/= "成功连接数据库"; }));
                        //传值
                        Settings.Default.connectestring = "server='" + txt_serverip.Text + "'; uid='" + txt_databaseuser.Text + "'; pwd='" + txt_databasepassword.Text + "'; database=CCBGRXD ";
                        Settings.Default.connectionswicth = true;
                        Settings.Default.Save();
                    }
                    catch
                    {
                        //打开不成功 则连接不成功
                        IsCanConnectioned = false;
                        lb_status.BeginInvoke(new Action(() => { lb_status.Text/*（此处为要操作的属性）*/= "连接超时，重新连接."; }));
                        Settings.Default.connectionswicth = false;
                        Settings.Default.Save();
                    }
                    #endregion
                }
                else if (i == 68)
                {
                    bt_login.BeginInvoke(new Action(() => { bt_login.Text/*（此处为要操作的属性）*/= "Checking......"; }));

                    #region  第二次数据库验证
                    //获取数据库连接字符串
                    ConnectionString = "server='" + txt_serverip.Text + "'; uid='" + txt_databaseuser.Text + "'; pwd='" + txt_databasepassword.Text + "'; database=CCBGRXD ";
                    //创建连接对象
                    mySqlConnection = new SqlConnection(ConnectionString);
                    //ConnectionTimeout 在.net 1.x 可以设置 在.net 2.0后是只读属性，则需要在连接字符串设置
                    //如：server=.;uid=sa;pwd=;database=PMIS;Integrated Security=SSPI; Connection Timeout=30
                    //mySqlConnection.ConnectionTimeout = 1;//设置连接超时的时间
                    try
                    {

                        //Open DataBase
                        //打开数据库
                        mySqlConnection.Open();
                        IsCanConnectioned = true;
                        lb_status.BeginInvoke(new Action(() => { lb_status.Text/*（此处为要操作的属性）*/= "正在配置系统环境"; }));
                        //传值
                        Settings.Default.connectestring = "server='" + txt_serverip.Text + "'; uid='" + txt_databaseuser.Text + "'; pwd='" + txt_databasepassword.Text + "'; database=CCBGRXD ";
                        Settings.Default.connectionswicth = true;
                        Settings.Default.Save();
                    }
                    catch
                    {
                        //打开不成功 则连接不成功
                        IsCanConnectioned = false;
                        lb_status.BeginInvoke(new Action(() => { lb_status.Text/*（此处为要操作的属性）*/= "连接超时，重新连接..."; }));
                        Settings.Default.connectionswicth = false;
                        Settings.Default.Save();
                    } 
                    #endregion
                }
                else if (i == 90)
                {
                    bt_login.BeginInvoke(new Action(() => { bt_login.Text/*（此处为要操作的属性）*/= "Checking........."; }));
                    
                    #region  第三次数据库验证
                    //获取数据库连接字符串
                    ConnectionString = "server='" + txt_serverip.Text + "'; uid='" + txt_databaseuser.Text + "'; pwd='" + txt_databasepassword.Text + "'; database=CCBGRXD ";
                    //创建连接对象
                    mySqlConnection = new SqlConnection(ConnectionString);
                    //ConnectionTimeout 在.net 1.x 可以设置 在.net 2.0后是只读属性，则需要在连接字符串设置
                    //如：server=.;uid=sa;pwd=;database=PMIS;Integrated Security=SSPI; Connection Timeout=30
                    //mySqlConnection.ConnectionTimeout = 1;//设置连接超时的时间
                    try
                    {

                        //Open DataBase
                        //打开数据库
                        mySqlConnection.Open();
                        IsCanConnectioned = true;
                        lb_status.BeginInvoke(new Action(() => { lb_status.Text/*（此处为要操作的属性）*/= "服务器启动中"; }));
                        //传值
                        Settings.Default.connectestring = "server='" + txt_serverip.Text + "'; uid='" + txt_databaseuser.Text + "'; pwd='" + txt_databasepassword.Text + "'; database=CCBGRXD ";
                        Settings.Default.connectionswicth = true;
                        Settings.Default.Save();
                    }
                    catch
                    {
                        //打开不成功 则连接不成功
                        IsCanConnectioned = false;
                        lb_status.BeginInvoke(new Action(() => { lb_status.Text/*（此处为要操作的属性）*/= "连接超时，重新连接....."; }));
                        Settings.Default.connectionswicth = false;
                        Settings.Default.Save();
                    } 
                    #endregion
                }
                else if (i == 100)
                {
                    //是否建立数据连接
                    if (IsCanConnectioned == true)
                    {
                        if (txt_user.Text == "admin" && txt_password.Text == "system")
                        {
                            this.DialogResult = DialogResult.OK;//验证成功
                            this.Close();
                        }
                        else
                        {
                            //隐藏加载
                            loadingView2.BeginInvoke(new Action(() => { loadingView2.Visible/*（此处为要操作的属性）*/= false; }));
                            //恢复按钮
                            bt_login.BeginInvoke(new Action(() => { bt_login.Enabled/*（此处为要操作的属性）*/= false; }));
                            bt_login.BeginInvoke(new Action(() => { bt_login.Text/*（此处为要操作的属性）*/= "登    录"; }));
                            lb_status.Text = "用户名或密码错误";
                        }
                    }
                    else
                    {
                        //隐藏加载
                        loadingView2.BeginInvoke(new Action(() => { loadingView2.Visible/*（此处为要操作的属性）*/= false; }));
                        //恢复按钮
                        bt_login.BeginInvoke(new Action(() => { bt_login.Enabled/*（此处为要操作的属性）*/= false; }));
                        bt_login.BeginInvoke(new Action(() => { bt_login.Text/*（此处为要操作的属性）*/= "登    录"; }));
                        lb_status.Text = "数据库设置登录出错";
                    }
                }
            }
            bt_login.BeginInvoke(new Action(() => { bt_login.Enabled/*（此处为要操作的属性）*/= true; }));

        }
        #endregion

        #region 数据库连接验证
        private bool ConnectionTest(string ip, string uid, string pwd)
        {
            //获取数据库连接字符串
            ConnectionString = "server='" + ip + "'; uid='" + uid + "'; pwd='" + pwd + "'; database=CCBGRXD ";
            //创建连接对象
            mySqlConnection = new SqlConnection(ConnectionString);
            //ConnectionTimeout 在.net 1.x 可以设置 在.net 2.0后是只读属性，则需要在连接字符串设置
            //如：server=.;uid=sa;pwd=;database=PMIS;Integrated Security=SSPI; Connection Timeout=30
            //mySqlConnection.ConnectionTimeout = 1;//设置连接超时的时间
            try
            {
                swicthindex++;
                //MessageBox.Show("成功");
                if (swicthindex % 2 == 0)
                {
                    //Open DataBase
                    //打开数据库
                    mySqlConnection.Open();
                    IsCanConnectioned = true;
                    bt_test.Text = "关闭连接";
                    lb_status.Text = "连接成功";
                    //传值
                    Settings.Default.connectestring = "server='" + ip + "'; uid='" + uid + "';pwd='" + pwd + "';database=CCBGRXD";
                    Settings.Default.connectionswicth = true;
                    Settings.Default.Save();
                }
                else
                {
                    //Open DataBase
                    //关闭数据库
                    mySqlConnection.Close();
                    //传值
                    IsCanConnectioned = true;
                    Settings.Default.connectionswicth = false;
                    Settings.Default.Save();
                    //提示
                    bt_test.Text = "打开连接";
                    lb_status.Text = "已关闭连接";

                }
            }
            catch
            {
                //Can not Open DataBase
                //打开不成功 则连接不成功
                IsCanConnectioned = false;
                MessageBox.Show("失败");
                Settings.Default.connectionswicth = false;
                Settings.Default.Save();
            }
            return IsCanConnectioned;
        }
        #endregion


        #endregion

        #region 事件
        //加载程序 
        private void Login_Load(object sender, EventArgs e)//加载程序
        {
            //初始化
            enterpresskind = "login";
            serverip = "";
            datapassword = "";
            datauser = "";
            //读取配置

            //初始化数据连接开关
            Settings.Default.connectionswicth = false;
            Settings.Default.Save();

            this.TopMost = true; //窗体总在最前
            //是否接收键盘按键
            this.KeyPreview = true;
            //关闭线程自检
            CheckForIllegalCrossThreadCalls = false;
            //首先加载程序 
            loadingView1.Enabled = true;

            //开始线程
            //thread = new Thread(new ThreadStart(InitializtionPage));
            //thread.Start();
            metroProgressBar1.Visible = true;//进度条可见
            //bt_login.Enabled = false;//按钮不可用
            //线程开始执行 检查工作
            thread1 = new Thread(new ThreadStart(Checking));
            thread1.Start();

            //登录界面加载，未显示
            skinTabControl1.SelectedIndex = 1;
            skinTabPage2.Show();
        }
        //登录
        private void Bt_login_Click(object sender, EventArgs e)//登录事件
        {
            if (isinstall == true)
            {
                //重置状态
                lb_status.Text = "";
                //加载可见
                loadingView2.BackColor = Color.Red;
                loadingView2.Visible = true;
                loadingView2.Enabled = true;
                bt_login.Text = "Checking";//设置按钮提示
                bt_login.Enabled = false;//按钮不可用
                //线程开始执行 检查工作
                thread2 = new Thread(new ThreadStart(LoginCheck));
                thread2.Start();
            }


            ////改变VIEW的UI控件的值，Controllor的Model会跟着变
            //this.txt_user.Text = "user";
            //this.txt_password.Text = "123456";
            //ModelController.UpdatePerson();

        }

        //切换页面
        private void Pb_connection_Click(object sender, EventArgs e)
        {
            pageindex++;
            if (pageindex % 2 == 0)
            {
                //切换到登录页面
                enterpresskind = "login"; //触发验证数据库连接事件
                pb_connection.Image = null;
                pb_connection.Image = Resources.用户圆;
                skinTabControl1.SelectedIndex = 1;
                AnimationControls.Animation.MoveStep = 30;
                AnimationControls.Animation.ShowControl(skinTabControl1, true, direction: AnchorStyles.Right);
                skinTabPage2.Show();
            }
            else
            {
                //切换到数据库连接验证页面
                enterpresskind = "test"; //触发验证数据库连接事件
                pb_connection.Image = null;
                pb_connection.Image = Resources.连接;
                skinTabControl1.SelectedIndex = 0;
                AnimationControls.Animation.MoveStep = 30;
                AnimationControls.Animation.ShowControl(skinTabControl1, true, direction: AnchorStyles.Right);
                skinTabPage1.Show();
            }
            GC.Collect();

        }

        //数据库连接验证
        private void Bt_test_Click(object sender, EventArgs e)
        {
            ConnectionTest(txt_serverip.Text, txt_databaseuser.Text, txt_databasepassword.Text);
        }
        //保存配置
        private void Ckb_save_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_save.Checked == true)
            {
                Settings.Default.databaseuser = txt_databaseuser.Text;
                Settings.Default.databasepassword = txt_databasepassword.Text;
                Settings.Default.dataserverip = txt_serverip.Text;
                Settings.Default.Save();
            }
        }

        #region 回车按键监听
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (enterpresskind == "login")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true; // 将Handled设置为true，指示已经处理过KeyPress事件
                    Bt_login_Click(sender, e); // 登录界面如果监听到回车按钮，则触发单击事件进行登录校验
                }
            }
            else if (enterpresskind == "test")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true; // 将Handled设置为true，指示已经处理过KeyPress事件
                    Bt_test_Click(sender, e); // 登录界面如果监听到回车按钮，则触发单击事件进行登录校验
                }
            }
        }


        #endregion

        #endregion
        private void Pb_connection_MouseLeave(object sender, EventArgs e)
        {
            if (pageindex % 2 == 0)
            {
                pb_connection.Image = null;
                pb_connection.Image = Resources.用户圆__1_;
            }
            else
            {
                pb_connection.Image = null;
                pb_connection.Image = Resources.连接__1_;
            }
            GC.Collect();

        }

        private void Pb_connection_MouseMove(object sender, MouseEventArgs e)
        {
            if (pageindex % 2 == 0)
            {
                pb_connection.Image = null;
                pb_connection.Image = Resources.用户圆;
            }
            else
            {
                pb_connection.Image = null;
                pb_connection.Image = Resources.连接;
            }
            GC.Collect();
        }


    }
}
