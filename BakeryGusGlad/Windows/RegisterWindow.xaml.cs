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
using System.Windows.Shapes;

using static BakeryGusGlad.ClassHelper.EFClass;
using BakeryGusGlad.Windows;

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
            // валидация 
            if (string.IsNullOrWhiteSpace(TbLogin.Text))
            {
                MessageBox.Show("Пустой логин");
                return;
            }

            // добавление пользоватля

            ContextDB.User.Add(new DB.User
            {
                Login = TbLogin.Text,
                Password = PbPassword.Password,
                Email = tbxEmail.Text,
                RoleID = 1
            });

            ContextDB.SaveChanges();

            MessageBox.Show("OK");
        }
    }
}
