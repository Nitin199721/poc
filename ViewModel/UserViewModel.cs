using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Application.Command;
using Applications.Model;
namespace Applications.ViewModel
{
    class UserViewModel
    {
        private User _user;
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        private ObservableCollection<User> _users;
        public ObservableCollection<User> users
        {
            get { return _users; }
            set { _users = value; }
        }

        private ICommand _SubmitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                
            }
        }
    }
}
