using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DataLayer;

namespace PasswordEdit {
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window {
        private Query q;
        public Login() {
            InitializeComponent();
            q = new Query();
            new MockUser("fabio", "scopel");
            }

        private void Button_Click(object sender, RoutedEventArgs e) {
        if(q.CheckUserAuthetication(TBUser.Text, TBPassword.Text))
        {


            TbEdit.Visibility=System.Windows.Visibility.Visible;
            BtEdit.Visibility = System.Windows.Visibility.Visible;
        }
        else {
            MessageBox.Show("username or password is invalid");

            }

            }

        private void BtEdit_Click(object sender, RoutedEventArgs e) {
                q.UpdatePassword(TBUser.Text, TBPassword.Text,TbEdit.Text);
            }
        }
    }
