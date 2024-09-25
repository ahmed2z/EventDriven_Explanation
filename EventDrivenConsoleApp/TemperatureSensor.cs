using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenConsoleApp
{
    // Step 1: Define a delegate
    public delegate void ThresholdExceededEventHandler(string message);

    public class TemperatureSensor
    {

        // Step 2: Declare the event using the delegate
        public event ThresholdExceededEventHandler OnThresholdExceeded;

        private int _threshold;

        // Constructor to set the threshold
        public TemperatureSensor(int threshold)
        {
            _threshold = threshold;
        }




        // Method to simulate checking the temperature
        public void CheckTemperature(int currentTemperature)
        {
            Console.WriteLine($"Current Temperature: {currentTemperature}°C");

            // Raise the event if the temperature exceeds the threshold
            if (currentTemperature > _threshold && OnThresholdExceeded != null)
            {
                OnThresholdExceeded($"Warning: Temperature exceeded threshold! ({currentTemperature}°C)");
            }
        }


    }
}
