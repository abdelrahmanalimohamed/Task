using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    class Person
    {
        public Wallet Wallet { get; set; }
       
        private List<Wallet> _walletsList { get; set; }

        public List<Wallet> Wallets
        {
            get { return _walletsList; }

            set { _walletsList = value; }
        }
        public Person(int WalletNumber)
        {
            Wallets = new List<Wallet>(WalletNumber);
        }


    }
 } 

