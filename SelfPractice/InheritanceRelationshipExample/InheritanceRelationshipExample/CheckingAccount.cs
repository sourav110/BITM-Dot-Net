﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipExample
{
    class CheckingAccount : BankAccount
    {
        public double ServiceCharge { set; get; }

        public override void Transfer(string from, string to, int amount)
        {
            //todo
        }

    }
} 
