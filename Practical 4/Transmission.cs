namespace Test

{

    class Transmission{
        //attributes
        public string type;
        public int NumOfGears;
        public string manufacturer;

        public Transmission(string type,int NumOfGears,string manufacturer){
            this.type = type;
            this.NumOfGears = NumOfGears;
            this.manufacturer = manufacturer;
        }


        public string GetType(){
            return type;

        }

        public int GetGears(){
            return NumOfGears;
        }

        public string GetManufacturer(){
            return manufacturer;
        }

        
    }
}