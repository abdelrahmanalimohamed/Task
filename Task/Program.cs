using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //After Searching the Interset formula is : I = Amt * Rate * Time 

            //I will assume the Time is : 1 month



            #region FirstTestCase


            Console.WriteLine("The First Test Case :");
            Person personF1 = new Person(2);
            CardTypes CardTypeF1 = new CardTypes("Visa", 100);

            float value = CardTypeF1.IntersetsPerCard();

            CardTypes cardTypesF2 = new CardTypes("MC", 100);
            float value2 = cardTypesF2.IntersetsPerCard();


            List<CardTypes> listF1 = new List<CardTypes>();



            listF1.Add(CardTypeF1);
            listF1.Add(cardTypesF2);
            
            Wallet walletF1 = new Wallet(listF1);

            foreach (var val in walletF1._cardTypeses)
            {
                float x = val.IntersetsPerCard();

                Console.WriteLine("First Test Case Per card " + val._type + " " + x);
            }


            Console.WriteLine("First Test Case For Person" + " " + (value2 + value));

            #endregion


            Console.WriteLine("*********************************");
            Console.WriteLine("The Second Test Case :");

            #region SecondTestCase

            Person person = new Person(2);
            List<CardTypes> ListWalletOne = new List<CardTypes>();
            List<CardTypes> listWalletTwo = new List<CardTypes>();

            CardTypes cardTypes = new CardTypes("Visa", 100);
            float v1 = cardTypes.IntersetsPerCard();

            CardTypes cardTypes2 = new CardTypes("Discover", 100);
            float v2 = cardTypes2.IntersetsPerCard();

            CardTypes cardTypes3 = new CardTypes("MC", 100);
            float v3 = cardTypes3.IntersetsPerCard();


            ListWalletOne.Add(cardTypes);
            ListWalletOne.Add(cardTypes2);

            listWalletTwo.Add(cardTypes3);

            Wallet wallet1 = new Wallet(ListWalletOne);
            Wallet wallet2 = new Wallet(listWalletTwo);

           // person.Wallet = new Wallet(2, listCardTypeses);

            foreach (var val in wallet1._cardTypeses)
            {
                float x = val.IntersetsPerCard();

                Console.WriteLine("Second Test Case for Wallet 1 " + val._type + " " + x);


            }



            foreach (var val in wallet2._cardTypeses)
            {
                float x = val.IntersetsPerCard();

                Console.WriteLine("Second Test Case for Wallet Two " + val._type + " " + x);
            }


            Console.WriteLine("Second Test Case For Person  " + " " + (v1 + v2 + v3));
            #endregion


            Console.WriteLine("************");
            Console.WriteLine("The Third Test Case  : ");

            #region ThirdCase

            //Person one
            Person person1 = new Person(1);
            List<CardTypes> ListPersonOne = new List<CardTypes>();

            CardTypes cardTypes1 = new CardTypes("Visa", 100);
            float vp_1 = cardTypes1.IntersetsPerCard();

            CardTypes cardTypes_1 = new CardTypes("MC", 100);
            float vp__1 = cardTypes_1.IntersetsPerCard();

            CardTypes cardTypes_11 = new CardTypes("Discover", 100);
            float vp___1 = cardTypes_11.IntersetsPerCard();

            ListPersonOne.Add(cardTypes1);
            ListPersonOne.Add(cardTypes_1);
            ListPersonOne.Add(cardTypes_11);
            
            Wallet wallet_Person_one = new Wallet(ListPersonOne);


            foreach (var val in wallet_Person_one._cardTypeses)
            {
                float x = val.IntersetsPerCard();

                Console.WriteLine("Third Test Case Per card person one" + val._type + " " + x);
            }






            ////Person two
            Person person2 = new Person(1);
            CardTypes cardTypes_2 = new CardTypes("Visa", 100);
            float vptwo_1 = cardTypes_2.IntersetsPerCard();

            CardTypes cardTypes_22 = new CardTypes("MC", 100);
            float vptwo_2 = cardTypes_22.IntersetsPerCard();

            List<CardTypes> list_person_two = new List<CardTypes>();
            list_person_two.Add(cardTypes_2);
            list_person_two.Add(cardTypes_22);
        
            Wallet walletPersonTwo = new Wallet(list_person_two);




            foreach (var val in walletPersonTwo._cardTypeses)
            {
                float x = val.IntersetsPerCard();

                Console.WriteLine("Third Test Case Per card person two   " + val._type + " " + x);
            }


            Console.WriteLine("Third Test Case For Person two  " + " " + (vptwo_1 + vptwo_2 ));
            #endregion
            Console.Read();
        }
    }
}
