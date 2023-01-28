using System;


    class program{
        static int ASCII_SIZE=256;
        static void Main(string[] args){
            int[] arr = {13,14,15,22,1,5,0};
            while (true){
                Console.WriteLine("Enter a String/ if stop click n: ");
                var input =Console.ReadLine();
                if (input.ToLower() == "n"){
                    break;  
                }
                Console.WriteLine("Most Repeated Consecutive char is : " + maxRepeating(input));
                Console.WriteLine("Number of Most Repeated Char is : " + MaxNumber(input));
            }
            Console.WriteLine("Maximum number of Consecitive digits : " + MaxNumIdenticalDigits(arr));

        }

        // Maximum Repeating Char in string
        public static char maxRepeating(string str)
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
    // determining the maximum number of consecutive identical digits
    public static int MaxNumIdenticalDigits(int[] arr){
        HashSet<int> S = new HashSet<int>();
        foreach (int x in arr) S.Add(x);

        int ans = 0;
        foreach (int x in arr) {

        if (!S.Contains(x - 1)) {
            int j = x;
            while (S.Contains(j)) j++;
 
            ans = Math.Max(ans, j - x);
          }
        }
    return ans+1;
  } 
    // determining the maximum number of consecutive identical letters of the Latin alphabet in a string
    public static int MaxNumber(string str)
        {
            int[] count = new int[ASCII_SIZE];
            int len = str.Length;
            for (int i = 0; i < len; i++) count[str[i]]++;
            int max = -1;

            for (int i=0; i<len; i++){
                if (max < count[str[i]]){
                    max = count[str[i]];
                }

            }
            return max;

}           

    }
