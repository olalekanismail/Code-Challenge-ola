using System;

namespace ConsoleApp1

{
    class Program
    {
         static void Main(string[] args)
        {
           
                string str = "ABCD";
            string str2 = "GREAVABDCLOP";


                int n = str.Length;
                permute(str, str2, 0, n - 1);
        }
        public static void permute(string str,string str2, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, str2, l + 1, r);
                    str = swap(str, l, i);

                    foreach (var item in str)
                    {
                        if (str2.Contains(item))

                        {
                            Console.WriteLine("true");

                        }
                        else
                        {
                            Console.WriteLine("false");
                        }
                    }
                }
            }

            
        }


        public static string swap(string a,
                                int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
    
}
