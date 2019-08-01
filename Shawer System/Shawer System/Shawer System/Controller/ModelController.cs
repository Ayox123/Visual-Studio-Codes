using Shawer_System.Model;

namespace Shawer_System.Controller
{
    public class ModelController
    {
        public Login View;

        public ModelClass Model;

        public ModelController(Login view)
        {
            //初始化了一个Model
            Model = new ModelClass() { User = "Admin", Password = "system" };
            //通过构造函数将View注入到Controllor中
            this.View = view;

            //建立起View 和Controllor的关联
            //这时候View中能使用它所对应的Controllor进行业务逻辑的操作,Model也能和VIEW UI控件进行双向绑定
            this.View.ModelController = this;

        }


        /// <summary>
        /// 执行一个业务逻辑
        /// </summary>
        public void UpdatePerson()
        {
            UpdateToDataBase(Model);
        }

        private void UpdateToDataBase(ModelClass p)
        {
            //do some thing
            //执行将数据插入到数据库的操作
            System.Windows.Forms.MessageBox.Show("User:" + p.User + " Password:" + p.Password);
        }


    }

}
