using System.Xml;
namespace Test

{

    class Program
    {
        static void Main(String[] args){
            XmlWriterSettings settings = new XmlWriterSettings();  
            List<Engine> carTypes = new List<Engine>();
            Engine Passenger_car= new Engine(300,200,"sedan",2651264321,3,1,12,"Passenger_car",1,"Ford");
            Engine Truck= new Engine(400,220,"Truck-Pickup",2651242681,2,1,16,"Truck",1,"Chevrolet");
            Engine Bus= new Engine(350,260,"Double-decker bus",2651264479,3,1,12,"Bus",1,"Mercedes");
            Engine Scooter= new Engine(300,200,"Scooter",2651264761,3,1,12,"Scooter",1,"Yamaha");
            carTypes.Add(Passenger_car);
            carTypes.Add(Truck);
            carTypes.Add(Bus);
            carTypes.Add(Scooter);
            
            XmlWriterSettings Sett = new XmlWriterSettings();
            Sett.Indent = true;
            Sett.IndentChars = "\t";

            for (var i=0; i<4; i++){
                Console.WriteLine(carTypes[i].GetType());            
                using (XmlWriter writer = XmlWriter.Create(carTypes[i] + ".xml", Sett))  
            {  
                writer.WriteStartElement("Car");  
                writer.WriteElementString("Manufacturer", carTypes[i].GetManufacturer());  
                writer.WriteElementString("Type", carTypes[i].getType());  
                writer.WriteElementString("Power", carTypes[i].getPower().ToString());
                writer.WriteElementString("Volume", carTypes[i].getVolume().ToString());
                writer.WriteElementString("Serial_Number", carTypes[i].getSerialNum().ToString());
                writer.WriteElementString("Wheels_number", carTypes[i].getWheelsNumber().ToString());
                writer.WriteElementString("Number", carTypes[i].GetNumber().ToString());
                writer.WriteElementString("Permisable_load", carTypes[i].GetPermisibleLoad().ToString());
                writer.WriteElementString("Number_Of_Gears", carTypes[i].GetGears().ToString());
                writer.WriteEndElement();  
                writer.Flush();  
            }}


    }}

}
