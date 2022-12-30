namespace Test

{

    class Chassis : Transmission{
        //attributes
        public int wheelsNumber;
        public int number;
        public int permisibleLoad;

        public Chassis(int wheelsNumber,int number,int permisibleLoad,string type,int NumOfGears,string manufacturer):base(type,NumOfGears,manufacturer){
            this.wheelsNumber=wheelsNumber;
            this.number=number;
            this.permisibleLoad = permisibleLoad;
        }


        public int getWheelsNumber(){
            return wheelsNumber;

        }

        public int GetNumber(){
            return number;
        }

        public int GetPermisibleLoad(){
            return permisibleLoad;
        }

        
    }
}