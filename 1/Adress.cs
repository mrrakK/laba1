using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class Adress
    {
        private string city;
        private string street;
        private int nh;

        public string GetCity
        {
            get
            {
                return city;
            }
            set
            {
                this.city = GetCity;
            }
        }

        public string GetStreet
        {
            get
            {
                return street;
            }
            set
            {
                this.street = GetStreet;
            }
        }

        public int GetNH
        {
            get
            {
                return nh;
            }
            set
            {
                this.nh = GetNH;
            }
        }
    }
}
