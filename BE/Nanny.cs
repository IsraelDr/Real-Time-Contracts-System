﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Nanny
    {
        private int ID_;                                               //ID
        private string last_name_;                                     //last name
        private string first_name_;                                    //first name
        private DateTime Birthdate_;                                        //Birthdate
        private int PhoneNumber_;                                      //Phone number
        private string address_;//(st,city,cuntry)                      //Address(St, City, Country)
        private bool elevatorExists_;                                  //Elevator exists?
        private int Floor_;                                            //Floor
        private int experience_;                                       //experience
        private int Max_number_kids_;                                  //Max number kids
        private int Min_age_;// Min_age (Month)                         //Min age (Month)
        private int Max_age_;//Max_age(Month)                           //Max age(Month)
        private bool Possible_Hourly_rate_;//Possible pay rate by Hour? //Possible Hourly rate
        private int Hourly_rate_;//                                     //Hourly rate
        private int Monthly_rate_;                                     //Monthly rate
        private bool[] Working_days_;                                  //Working days
        private int[,] Daily_Working_hours_;// Daily_Working_hours(week)//Daily Working hours(week)
        private bool Vacation_days_;// "Chinuch" or "tamat" { get; set; //Vacation days- "Chinuch" or "tamat"
        private string Recommendations_;                               //Recommendations
        private int Additional_Info_;                                  //Additional Info
        private int kidsCount_;
        private int fideback_;

        /********************/
        public int ID                    { get { return ID_; } set { ID_ = value; } }                                                //ID
        public string last_name          { get { return last_name_; } set { last_name_ = value; } }                                      //last name
        public string first_name         { get { return first_name_; } set { first_name_ = value; } }                                      //first name
        public DateTime Birthdate        { get { return Birthdate_; } set { Birthdate_ = value; } }                                       //Birthdate
        public int PhoneNumber           { get { return PhoneNumber_; } set { PhoneNumber_ = value; } }                                       //Phone number
        public string address            { get { return address_; } set { address_ = value; } }//(st,city,cuntry)                      //Address(St, City, Country)
        public bool elevatorExists       { get { return elevatorExists_; } set { elevatorExists_ = value; } }                                   //Elevator exists?
        public int Floor                 { get { return Floor_; } set { Floor_ = value; } }                                             //Floor_
        public int experience            { get { return experience_; } set { experience_ = value; } }                                        //experience
        public int Max_number_kids       { get { return Max_number_kids_; } set { Max_number_kids_ = value; } }                                   //Max number kids
        public int Min_age               { get { return Min_age_; } set { Min_age_ = value; } }// Min_age (Month)                         //Min age (Month)
        public int Max_age               { get { return Max_age_; } set { Max_age_ = value; } }//Max_age(Month)                           //Max age(Month)
        public bool Possible_Hourly_rate { get { return Possible_Hourly_rate_; } set { Possible_Hourly_rate_ = value; } }//Possible pay rate by Hour? //Possible Hourly rate
        public int Hourly_rate           { get { return Hourly_rate_; } set { Hourly_rate_ = value; } }//                                     //Hourly rate
        public int Monthly_rate          { get { return Monthly_rate_; } set { Monthly_rate_ = value; } }                                      //Monthly rate
        public bool[] Working_days       { get { return Working_days_; } set { Working_days_ = value; } }                                   //Working days
        public int[,] Daily_Working_hours{ get { return Daily_Working_hours_; } set { Daily_Working_hours_ = value; } }// Daily_Working_hours(week)//Daily Working hours(week)
        public bool Vacation_days        { get { return Vacation_days_; } set { Vacation_days_ = value; } }// "Chinuch" or "tamat" { get; set; //Vacation days- "Chinuch" or "tamat"
        public string Recommendations    { get { return Recommendations_; } set { Recommendations_ = value; } }                                //Recommendations
        public int Additional_Info       { get { return Additional_Info_; } set { Additional_Info_ = value; } }                                   //Additional Info
        public int kidsCount             { get { return kidsCount_; } set { kidsCount_ = value; } }
        public int fideback              { get { return fideback_; } set { fideback_ = value; } }
        public Nanny(params object[] parameters)
        {
            ID = (int)parameters[0];
            last_name = (string)parameters[1];
            first_name = (string)parameters[2];
            Birthdate = (DateTime)parameters[3];
            PhoneNumber = (int)parameters[4];
            address = (string)parameters[5];
            elevatorExists = (bool)parameters[6];
            Floor = (int)parameters[7];
            experience = (int)parameters[8];
            Max_number_kids = (int)parameters[9];
            Min_age = (int)parameters[10];
            Max_age = (int)parameters[11];
            Possible_Hourly_rate = (bool)parameters[12];
            Hourly_rate = (int)parameters[13];
            Monthly_rate = (int)parameters[14];
            Working_days = (bool[])parameters[15];
            Daily_Working_hours = (int[,])parameters[16];
            Vacation_days = (bool)parameters[17];
            Recommendations = (string)parameters[18];
            Additional_Info = (int)parameters[19];
            kidsCount = (int)parameters[20];
    }
        public override string ToString()
        {//using ToStringProperty() in Class Tools 
            return this.ToStringProperty();
        }
                                                  //
    }
}
