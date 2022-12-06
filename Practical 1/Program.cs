namespace Test
{
    class Program
    {

        static char maxRepeating(string str)
{
        int count = 0;
        char res = str[0];
        int cur_count = 1;
 
       for (int i = 0; i < str.Length; i++)
        {
            if (i < str.Length - 1 &&
                str[i] == str[i + 1])
                cur_count++;
 
            else
            {
                if (cur_count > count)
                {
                    count = cur_count;
                    res = str[i];
                }
                cur_count = 1;
            }
        }
    return res;
}

        static void Main(string[] args) {
            while (true){
                Console.WriteLine("Enter a String/ If Stop click n: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "n"){
                    break;   
                }
                Console.WriteLine("Most Repeated Consocutive char is : " + maxRepeating(input));

            }

            
        }   
    }

}
