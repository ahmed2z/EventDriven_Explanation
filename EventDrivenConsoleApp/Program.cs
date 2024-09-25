namespace EventDrivenConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Step 3: Set the threshold and create objects
            TemperatureSensor sensor = new TemperatureSensor(30); // Threshold is 30°C
            Subscriber subscriber = new Subscriber();


            // Step 4: Subscribe to the event
            sensor.OnThresholdExceeded += subscriber.OnThresholdExceededHandler;




            // Simulate checking the temperature
            sensor.CheckTemperature(25); // Below threshold, no event
            sensor.CheckTemperature(35); // Above threshold, event triggered

            Console.ReadLine(); 


        }
    }
}