using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1k2c_1._3
{
    class Bottle
    {
        private double _amount;
        private string _liquid;
        private bool _isEmpty;

        public Bottle() { }

        public Bottle(double amount, string liquid, bool isEmpty)
        {
            Amount = amount;
            Liquid = liquid;
            IsEmpty = isEmpty;
        }

        public double Amount
        {
            get => _amount;
            set => _amount = value != 0 ? value : 1;
        }

        public string Liquid
        {
            get => _liquid;
            set => _liquid = value != null ? value : "Выберите тип напитка";
        }

        public bool IsEmpty
        {
            get => _isEmpty;
            set => _isEmpty = value != true ? value : false;
        }

        public override string ToString() => $"{ Amount } { Liquid } { IsEmpty }";

        public static Bottle[] GetOnlyEmpty(Bottle[] bottles)
        {
            Bottle[] newOne = new Bottle[bottles.Length];
            for (int i = 0; i < bottles.Length; i++)
                newOne[i] = bottles[i];
            foreach (var g in bottles)
            {
                if (g.IsEmpty)
                {
                    Array.Resize(ref newOne, newOne.Length - 1);
                    newOne[newOne.Length - 1] = g;
                }
            }
            return newOne;
        }
    }
}
