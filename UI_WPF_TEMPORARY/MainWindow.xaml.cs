﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using GoogleMapsAPI;
using BE;
using BL;

namespace UI_WPF_TEMPORARY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static BL_imp bl = new BL_imp();
        public MainWindow()
        {
            try
            {
                InitializeComponent();

                bl.AddMother(new Mother(1, "first", "last", "0798512565", "jerusalem", "jerusalem", new bool[] { true, false, true, false, true, false, true }, new TimeSpan[,] { { new TimeSpan(5, 3, 5), new TimeSpan(8, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(8, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(8, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(8, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(8, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(8, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(8, 3, 5) } }, "comment", MyEnum.Paymentmethode.houerly));
                bl.AddMother(new Mother(2, "first", "last", "0798512565", "tel aviv", "tel aviv", new bool[] { true, false, true, false, true, false, true }, new TimeSpan[,] { { new TimeSpan(5, 3, 5), new TimeSpan(15, 3, 5) }, { new TimeSpan(15, 3, 5), new TimeSpan(15, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(15, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 15) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 15) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 15) } }, "comment", MyEnum.Paymentmethode.houerly));
                bl.AddMother(new Mother(3, "first", "last", "0798512565", "basel", "basel", new bool[] { true, false, true, false, true, false, true }, new TimeSpan[,] { { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) } }, "comment", MyEnum.Paymentmethode.houerly));
                bl.AddMother(new Mother(4, "first", "last", "0798512565", "tiberias", "tiberias", new bool[] { true, false, true, false, true, false, true }, new TimeSpan[,] { { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) } }, "comment", MyEnum.Paymentmethode.houerly));
                bl.AddNanny(new Nanny(1, "first", "last", new DateTime(1994, 05, 17), 0798516858, "bern", true, 6, 5, 12, 2, 6, false, 200, 300, new bool[] { true, false, true, false, true, false, true }, new TimeSpan[,] { { new TimeSpan(5,3,5), new TimeSpan(5, 13, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 13, 5) },{ new TimeSpan(5, 3, 5), new TimeSpan(5, 13, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 13, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 13, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 13, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 13, 5) } }, MyEnum.Vacation.Chinuch, "recommend", 15,1));
                bl.AddNanny(new Nanny(7, "first", "last", new DateTime(1994, 05, 17), 0798516858, "tel aviv", true, 6, 5, 12, 2, 6, false, 200, 300, new bool[] { true, false, true, false, true, false, true }, new TimeSpan[,] { { new TimeSpan(5, 3, 5), new TimeSpan(15, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(15, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(15, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(15, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(15, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(15, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(15, 3, 5) } }, MyEnum.Vacation.Chinuch, "recommend", 15,34));
                bl.AddNanny(new Nanny(90, "first", "last", new DateTime(1994, 05, 17), 0798516858, "jerusalem", true, 6, 5, 12, 2, 6, false, 200, 300, new bool[] { true, false, true, false, true, false, true }, new TimeSpan[,] { { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) } }, MyEnum.Vacation.Chinuch, "recommend", 15,4));
                bl.AddNanny(new Nanny(4, "first", "last", new DateTime(1994, 05, 17), 0798516858, "ashdod", true, 6, 5, 12, 2, 6, false, 200, 300, new bool[] { true, false, true, false, true, false, true }, new TimeSpan[,] { { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) } }, MyEnum.Vacation.tamat, "recommend", 15,3));
                bl.AddNanny(new Nanny(6, "first", "last", new DateTime(1994, 05, 17), 0798516858, "bnei brak", true, 6, 5, 12, 2, 6, false, 200, 300, new bool[] { true, false, true, false, true, false, true }, new TimeSpan[,] { { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) }, { new TimeSpan(5, 3, 5), new TimeSpan(5, 3, 5) } }, MyEnum.Vacation.tamat, "recommend", 15,5));
                bl.AddChild(new Child(1, 3, "Jankel", new DateTime(1994, 05, 12), true));
                bl.AddChild(new Child(2, 1, "Shloime", new DateTime(1994, 05, 12), true));
                bl.AddChild(new Child(3, 3, "Jossi", new DateTime(1994, 05, 12), true));
                bl.AddChild(new Child(4, 2, "Avi", new DateTime(1994, 05, 12), true));
                bl.AddContract(new Contract(4,1, true, false, 17, 485, MyEnum.Paymentmethode.houerly, new DateTime(1994, 05, 17), new DateTime(2000, 05, 17),19.15));
                bl.AddContract(new Contract(4,2,true, false, 17, 485, MyEnum.Paymentmethode.houerly, new DateTime(1994, 05, 17), new DateTime(2000, 05, 17),15.14));
                bl.AddContract(new Contract(4,3, true, false, 17, 485, MyEnum.Paymentmethode.houerly, new DateTime(1994, 05, 17), new DateTime(2000, 05, 17),751.5));
                bl.AddContract(new Contract(4,4, true, false, 17, 485, MyEnum.Paymentmethode.houerly, new DateTime(1994, 05, 17), new DateTime(2000, 05, 17),14000.50));
            }
            catch (Exception e)
            {
                MessageBox.Show( e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
        void openwindow(object sender, EventArgs e)
        {
            this.Show();
        }

        private void MotherButton_Click(object sender, RoutedEventArgs e)
        {
            ListAll a = new ListAll(0);
            a.Show();
            this.Hide();
            a.Closed += new EventHandler(openwindow);
        }

        private void NannyButton_Click(object sender, RoutedEventArgs e)
        {
            ListAll b = new ListAll(1);
            b.Show();
            this.Hide();
            b.Closed += new EventHandler(openwindow);
        }

        private void ChildButton_Click(object sender, RoutedEventArgs e)
        {
            ListAll c = new ListAll(2);
            c.Show();
            this.Hide();
            c.Closed += new EventHandler(openwindow);
        }

        private void ContractsButton_Click(object sender, RoutedEventArgs e)
        {
            ListAll d = new ListAll(3);
            d.Show();
            this.Hide();
            d.Closed += new EventHandler(openwindow);
        }
    }
}
