using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    public class CardTypes
    {
     
        private string Type { get; set; }
        private float Rate { get; set; }
        private int Balance { get; set; }

        public string _type
        {
            get { return Type; }

            set { Type = value; }
        }
        public float _Rate
        {
            get { return Rate; }

            set { Rate = value; }
        }
        public int _Balance
        {

            get { return Balance; }

            set { Balance = value; }
        }

        
        public CardTypes(string type , int balance )
        {
            this._type = type;
            this._Balance = balance;

            if (type == "Visa")
            {
                this._Rate = 10/100f;
            }

            if (type == "MC")
            {
               this._Rate = 5 / 100f;
            }

            if (type == "Discover")
            {
                _Rate = 1 / 100f;
            }


        }

        public float IntersetsPerCard()
        {
            float Intersets = 0;
            if (_type == "Visa" || _type == "MC" || _type == "Discover")
            {
                Intersets = (_Balance * _Rate * 1);
            }
            
            return Intersets;
         
        }
        
    }
}
