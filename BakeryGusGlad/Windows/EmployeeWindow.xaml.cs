﻿using BakeryGusGlad.ClassHelper;
using BakeryGusGlad.DB;
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

namespace BakeryGusGlad.Windows
{
    /// <summary>
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();

            
        }

        private void GetListEmployee()
        {
            List<Employee> employee = new List<Employee>();
            employee = EFClass.ContextDB.Employee.ToList();
        }
    }
}
