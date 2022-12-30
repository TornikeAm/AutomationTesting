namespace Test

{

    class Program
    {
        static void Main(String[] args){
            Engine Passenger_car= new Engine(300,200,"sedan",2651264321,3,1,12,"Mondeo",1,"Ford");
            Engine Truck= new Engine(400,220,"Truck-Pickup",2651242681,2,1,16,"Silverado",1,"Chevrolet");
            Engine Bus= new Engine(350,260,"Double-decker bus",2651264479,3,1,12,"Benz-busses",1,"Mercedes");
            Engine Scooter= new Engine(300,200,"Scooter",2651264761,3,1,12,"Xmax",1,"Yamaha");
            
            Console.WriteLine("Passenger Car");
            Console.WriteLine("Car Manufacturer : " + Passenger_car.GetManufacturer() + "\nCar Type : " + Passenger_car.getType()+ 
            "\nCar Power is " + Passenger_car.getPower() + "\nVolume " + Passenger_car.getVolume() + "\nSerial number " + Passenger_car.getSerialNum()
            + "\nWheels number: " + Passenger_car.getWheelsNumber() + "\nNumber: " + Passenger_car.GetNumber() + "\nPermisable load : " + Passenger_car.GetPermisibleLoad()
            +"\nNumber Of Gears : " + Passenger_car.GetGears() + "\n");
            
            Console.WriteLine("Truck : ");
            Console.WriteLine("Car Manufacturer : " + Truck.GetManufacturer() + "\nCar Type : " + Truck.getType()+ 
            "\nCar Power is " + Truck.getPower() + "\nVolume " + Truck.getVolume() + "\nSerial number " + Truck.getSerialNum()
            + "\nWheels number: " + Truck.getWheelsNumber() + "\nNumber: " + Truck.GetNumber() + "\nPermisable load : " + Truck.GetPermisibleLoad()
            +"\nNumber Of Gears : " + Truck.GetGears() + "\n");

            Console.WriteLine("Bus");
            Console.WriteLine("Car Manufacturer : " + Bus.GetManufacturer() + "\nCar Type : " + Bus.getType()+ 
            "\nCar Power is " + Bus.getPower() + "\nVolume " + Bus.getVolume() + "\nSerial number " + Bus.getSerialNum()
            + "\nWheels number: " + Bus.getWheelsNumber() + "\nNumber: " + Bus.GetNumber() + "\nPermisable load : " + Bus.GetPermisibleLoad()
            +"\nNumber Of Gears : " + Bus.GetGears() + "\n");

            Console.WriteLine("Scooter");
            Console.WriteLine("Car Manufacturer : " + Scooter.GetManufacturer() + "\nCar Type : " + Scooter.getType()+ 
            "\nCar Power is " + Scooter.getPower() + "\nVolume " + Scooter.getVolume() + "\nSerial number " + Scooter.getSerialNum()
            + "\nWheels number: " + Scooter.getWheelsNumber() + "\nNumber: " + Scooter.GetNumber() + "\nPermisable load : " + Scooter.GetPermisibleLoad()
            +"\nNumber Of Gears : " + Scooter.GetGears() + "\n");
            
            }

    }}