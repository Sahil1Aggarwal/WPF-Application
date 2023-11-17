using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3._1 // name of my namespace 
{
    class Food : INotifyPropertyChanged // Here INotifyPropertyChanged  is for data binding
    {
        // // Here food is the class and we used getter and setter  and rest all are attributes of food item
        public int ID { get; set; } 

        public int Quantity { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public double TotalPrice { get { return Price * Quantity; } }

        public double CalculatedTotalPrice => Quantity * Price;

        public event PropertyChangedEventHandler PropertyChanged;

    }

}