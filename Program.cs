using System;

namespace Constructor
{
    class Car
    {
        public string model;  // Create a field

        // Create a class constructor for the Car class
        public Car()
        {
            model = "Mustang"; // Set the initial value for model
        }

        //static void Main(string[] args)
        //{
        //    Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
        //    Console.WriteLine(Ford.model);  // Print the value of model
        //}
    }
    class Car1
    {
        public string model;

        // Create a class constructor with a parameter
        public Car1(string modelName)
        {
            model = modelName;
        }

        //static void Main(string[] args)
        //{
        //    Car1 Ford = new Car1("Mustang");
        //    Console.WriteLine(Ford.model);
        //}
    }
    class example
    {
        // In-accessibility due to class being private
        //static void Main(string[] args)
        //{
        //    Car1 newob = new Car1("Ferari");
        //    Console.WriteLine(newob.model);

        //}
    }
}
