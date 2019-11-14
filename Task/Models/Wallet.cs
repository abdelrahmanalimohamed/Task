using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    class Wallet
    {
       List<CardTypes> listCards = new List<CardTypes>();
       private CardTypes _cardTypes;
       public List<CardTypes> _cardTypeses
       {
           get { return listCards; }
           set { listCards = value; }
       }

       public Wallet(List<CardTypes> cardTypeses)
       {
           this._cardTypeses = cardTypeses;
       }


    }
}
