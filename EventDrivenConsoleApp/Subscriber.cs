﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenConsoleApp
{
    
    public class Subscriber
    {

        // Method to handle the event
        public void OnThresholdExceededHandler(string message)
        {
            Console.WriteLine(message);
        }

    }
}
