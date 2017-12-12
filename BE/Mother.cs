﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mother
    {
        private int ID_;
        private string Lastname_;
        private string Firstname_;
        private int Phonenumber_;
        private string Adress_;//(psikim)
        private string surrounding_adress_;
        private bool[] nanny_required_;
        private int[,] Daily_Nanny_required_;
        private string Comment_;
        private MyEnum.Paymentmethode Paymentmethode_;
        

        public int ID                               { get { return ID_; } set { ID_ = value; } }
        public string Lastname                      { get { return Lastname_; } set { Lastname_ = value; } }
        public string Firstname                     { get { return Firstname_; } set { Firstname_ = value; } }
        public int Phonenumber                      { get { return Phonenumber_; } set { Phonenumber_ = value; } }
        public string Adress                        { get { return Adress_; } set { Adress_ = value; } }//(psikim)
        public string surrounding_adress            { get { return surrounding_adress_; } set { surrounding_adress_ = value; } }
        public bool[] nanny_required                { get { return nanny_required_; } set { nanny_required_ = value; } }
        public int[,] Daily_Nanny_required          { get { return Daily_Nanny_required_; } set { Daily_Nanny_required_ = value; } }
        public string Comment                       { get { return Comment_; } set { Comment_ = value; } }
        public MyEnum.Paymentmethode Paymentmethode { get { return Paymentmethode_; } set { Paymentmethode_ = value; } }
        public Mother(params object[] parameters)
        {
            ID = (int)(parameters[0]);
            Lastname = (string)parameters[1];
            Firstname = (string)parameters[2];
            Phonenumber = (int)parameters[3];
            Adress = (string)parameters[4];
            surrounding_adress = (string)parameters[5];
            nanny_required = (bool[])parameters[6];
            Daily_Nanny_required = (int[,])parameters[7];
            Comment = (string)parameters[8];
            Paymentmethode = (MyEnum.Paymentmethode)parameters[9];
        }
        public override string ToString()
        {//using ToStringProperty() in Class Tools 
            return this.ToStringProperty();
        }
        
    }
}
