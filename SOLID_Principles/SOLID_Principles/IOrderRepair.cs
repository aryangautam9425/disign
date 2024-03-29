﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    interface IOrder
    {
        void ProcessOrder(string modelName);
    }
    interface IRepair 
    { 
        void ProcessPhoneRepair(string modelName);
        void ProcessAccessoryRepair(string accessoryType);
    }
}
