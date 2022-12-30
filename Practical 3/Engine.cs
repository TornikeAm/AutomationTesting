namespace Test

{
    class Engine : Chassis{
        //attributes
        public int power;
        public int volume;
        public string Type;
        public uint serialNumber;
        
        public Engine(int power,int volume,string type,uint SerialNumber,int wheelsNumber,int number,int permisibleLoad,string Type,int NumOfGears,string manufacturer) :
        
        base(wheelsNumber,number,permisibleLoad,Type,NumOfGears,manufacturer){
            this.power = power;
            this.volume = volume;
            this.Type = Type;
            this.serialNumber = SerialNumber;
        }

        public int getPower(){ 
            
            return power;
        }

        public int getVolume(){
            return volume;
        }
        
        public string getType(){
            return type;
        }
        public uint getSerialNum(){
            return serialNumber;
        }
    
    }
}