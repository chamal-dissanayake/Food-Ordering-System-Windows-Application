﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    internal class UlogName
    {
        static string UserName;
        public static string userName
        {
            get
            {
                return UserName;
                 
            }
            set
            {
                    UserName = value;   
            }
        }
    }
}
