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
using BE;
using BL;
namespace UI_WPF_TEMPORARY
{
    /// <summary>
    /// Interaction logic for MotherDetails.xaml
    /// </summary>
    public partial class MotherDetails : UserControl
    {
        static BL_imp bl = new BL_imp();
        static Window fr;
        bool isUpdate = false;
        public MotherDetails(Window f,Mother mother=null)
        {
            InitializeComponent();
            var values = from Enum e in Enum.GetValues(typeof(MyEnum.Paymentmethode))
                         select new { ID = e, Name = e.ToString() };
            foreach (var value in values)
            {
                new_paymentmethode.Items.Add(value.Name);
            }
            fr = f;
            isUpdate = false;
            if(mother!=null)
            {
                isUpdate = true;
                new_ID.Text = mother.ID + "";
                new_LastName.Text = mother.Lastname;
                new_Firstname.Text = mother.Firstname;
                new_Phonenumber.Text = mother.Phonenumber + "";
                new_Address.Text = mother.Adress;
                new_surrounding_address.Text = mother.surrounding_adress + "";
                new_Sunday.IsChecked = mother.nanny_required[0];
                new_Monday.IsChecked = mother.nanny_required[1];
                new_Tuesday.IsChecked = mother.nanny_required[2];
                new_Wednesday.IsChecked = mother.nanny_required[3];
                new_Thursday.IsChecked = mother.nanny_required[4];
                new_Friday.IsChecked = mother.nanny_required[5];
                new_Saturday.IsChecked = mother.nanny_required[6];
                new_Sunday_start.Time = new RoyT.TimePicker.DigitalTime(21, 00);
                new_Sunday_end.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[0, 1].Hours, mother.daily_Nanny_required[0, 1].Minutes);
                new_Monday_start.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[1, 0].Hours, mother.daily_Nanny_required[1, 0].Minutes);
                new_Monday_end.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[1, 1].Hours, mother.daily_Nanny_required[1, 1].Minutes);
                new_Tuesday_start.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[2, 0].Hours, mother.daily_Nanny_required[2, 0].Minutes);
                new_Tuesday_end.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[2, 1].Hours, mother.daily_Nanny_required[2, 1].Minutes);
                new_Wednesday_start.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[3, 0].Hours, mother.daily_Nanny_required[3, 0].Minutes);
                new_Wednesday_end.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[3, 1].Hours, mother.daily_Nanny_required[3, 1].Minutes);
                new_Thursday_start.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[4, 0].Hours, mother.daily_Nanny_required[4, 0].Minutes);
                new_Thursday_end.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[4, 1].Hours, mother.daily_Nanny_required[4, 1].Minutes);
                new_Friday_start.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[5, 0].Hours, mother.daily_Nanny_required[5, 0].Minutes);
                new_Friday_end.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[5, 1].Hours, mother.daily_Nanny_required[5, 1].Minutes);
                new_Saturday_start.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[6, 0].Hours, mother.daily_Nanny_required[6, 0].Minutes);
                new_Saturday_end.Time = new RoyT.TimePicker.DigitalTime(mother.daily_Nanny_required[6, 1].Hours, mother.daily_Nanny_required[6, 1].Minutes);
                new_comment.Text = mother.Comment;
                new_paymentmethode.Text = mother.Paymentmethode.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Mother mother = new Mother(new_ID.Text,new_LastName.Text, new_Firstname.Text,
                                            new_Phonenumber.Text, new_Address.Text,
                                            new_surrounding_address.Text,
                                            new bool[] {new_Sunday.IsChecked==true, new_Monday.IsChecked == true ,
                                    new_Tuesday.IsChecked==true,new_Wednesday.IsChecked==true,new_Thursday.IsChecked==true,
                                    new_Friday.IsChecked==true,new_Saturday.IsChecked==true},
                                            new TimeSpan[,] { {new_Sunday_start.Time.ToTimeSpan(),new_Sunday_end.Time.ToTimeSpan() },
                                    {new_Monday_start.Time.ToTimeSpan(),new_Monday_end.Time.ToTimeSpan() },
                                    {new_Tuesday_start.Time.ToTimeSpan(),new_Tuesday_end.Time.ToTimeSpan() },
                                    {new_Wednesday_start.Time.ToTimeSpan(),new_Wednesday_end.Time.ToTimeSpan() },
                                    {new_Thursday_start.Time.ToTimeSpan(),new_Thursday_end.Time.ToTimeSpan() },
                                    {new_Friday_start.Time.ToTimeSpan(),new_Friday_end.Time.ToTimeSpan() },
                                    {new_Saturday_start.Time.ToTimeSpan(),new_Saturday_end.Time.ToTimeSpan() }},
                                            new_comment.Text,new_paymentmethode.Text);
                if (isUpdate)
                    bl.UpdateMother(mother);
                else
                    bl.AddMother(mother);
                fr.Close();
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}