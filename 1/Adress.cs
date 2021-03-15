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
        public Adress(string city, string street, int nh)
        {
            this.city = city;
            this.street = street;
            this.nh = nh;
        }

        public Adress()
        {
            city = "";
            street = "";
            nh = 0;
        }

        public void SetInfo()
        {
            Console.Write("Город: ");
            this.city = Console.ReadLine();
            Console.Write("Улица: ");
            this.street = Console.ReadLine();
            Console.Write("Номер дома: ");
            this.nh = Convert.ToInt32(Console.ReadLine());
        }

        public void GetInfo()
        {
            Console.WriteLine("Город: " + city);
            Console.WriteLine("Улица: " + street);
            Console.WriteLine("Номер дома: " + nh);
        }
    }
}
