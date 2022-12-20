namespace Test

{

    class Program
    {
        static void Main(String[] args){
            Console.WriteLine("Input Value in Decimal: ");
            int dec = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The base : ");
            int Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Converted {0} from Decimal To Chosen Base of {1} is {2}",dec,Base,FromDecimalToAnyBase(dec,Base));

            }

        static int FromDecimalToAnyBase(int Decimal, int Base ){
            string two ="";
            
            while (Decimal > 0){
                two = Decimal % Base + two;
                Decimal = Decimal /Base;
            }
            return Convert.ToInt32(two);

        }

}}