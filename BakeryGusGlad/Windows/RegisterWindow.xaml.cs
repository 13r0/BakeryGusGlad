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

using static BakeryGusGlad.ClassHelper.EFClass;
using BakeryGusGlad.Windows;
using BakeryGusGlad.ClassHelper;

namespace BakeryGusGlad.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            if (tbxPass.Password == "")
            {
                MessageBox.Show("Введите пароль");
            }
           

            ContextDB.User.Add(new DB.User
            {
                Login = tbxLogin.Text,
                Password = tbxPass.Password,
                Email = tbxEmail.Text,
            });

            ContextDB.SaveChanges();

            MessageBox.Show("OK");
        }
    }
}
