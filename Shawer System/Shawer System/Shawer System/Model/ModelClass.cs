using System.ComponentModel;

namespace Shawer_System.Model
{
    public class ModelClass : INotifyPropertyChanged
    {
        private string _user;
        public string User
        {
            get { return _user; }
            set { _user = value; OnPropertyChanged("User"); }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged("Password"); }
        }

        #region INotifyPropertyChanged 成员
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion

    }
}
