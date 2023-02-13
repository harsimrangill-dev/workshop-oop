namespace task1
{
    class program
    {
        static void Main(string[] args) 
        {

            var codes = File.ReadAllLines("code.txt");
            var lines = new List<string>(codes);
            //methods

            foreach ( string line in lines)
            {
                char[] array;
                array = new char[12];
                for (int i = 0; i < 12; i++)
                {
                    array[i] = line[i];
                }
                Array.Sort(array);
                int c = 1;
                for (int i = 0; i < 11; i++)
                {
                    if (array[i] == array[i + 1])
                    {
                        c++;
                    }
                    else
                    {
                        Console.Write(Convert.ToString(array[i]));
                        Console.WriteLine("  :  " + c);
                        c = 1;
                    }
                }
                Console.WriteLine("\n\n\n");


            }
        }
    }
}