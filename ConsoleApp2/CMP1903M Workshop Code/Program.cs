using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 3
            //Challenge: Get the message from the encrypted text
            //
            //1. EITHER:    Read in the .txt file into a List of Strings (or anything else?)
            //   OR:        Read in each line one at a timen and get its maximum character 
            //2. For each string:
            //      Count each character in the string
            //      The maximum is the character
            //3. Output the unencrypted message.

            //Week 3
            //Task 1: create Message object, call the readTextFromInput() method
            //Task 2: create Atbash object Step 1: pass message to encode() method Step 2: put in the encode logic
            //Task 3: put in the decode logic to the decode() method, check if it works
            //Task 4: read text to encode from a file


            //this is task 3
            Atbash enc = new Atbash();
            //encoded/dedcoded object

            //message object
            Message m = new Message();

            m.readMessageFromInput();

            if ((m.message != null) && (m.message != "" ))
            {
                //encoding the message 
                string encode = enc.encode(m.message);
                //displaying the message 
                Console.WriteLine(encode);
            }
            else
                Console.WriteLine("Error you cannot input a empty string");

            //decoding the string 
            string decode = enc.decode(enc.encode(m.message));
            Console.WriteLine(decode);

            

          

        }
    }
}
