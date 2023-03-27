using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using static BakeryGusGlad.ClassHelper.EFClass;
using BakeryGusGlad.Windows;


namespace BakeryGusGlad
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var userAuth = ContextDB.User.ToList()
               .Where(i => i.Login == TbLogin.Text &&
               i.Password == PbPassword.Password)
               .FirstOrDefault();

            if (userAuth != null)
            {

                ClassHelper.UserDataClass.user = userAuth;


                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            RegisterWindow registrationUserWindow = new RegisterWindow();
            registrationUserWindow.Show();
            this.Close();
        }
    }
}
