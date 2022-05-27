using System;
using System.Collections.Generic;


namespace Unit03.Game 
{
    /// <summary>
    /// <para>The person hiding from the Seeker.</para>
    /// <para>
    /// The responsibility of Hider is to keep track of its location and distance from the seeker.
    /// </para>
    /// </summary>
    public class Jumper
    {
        public string letter = "";
        public string random_word = "";


        /// <summary>
        /// Constructs a new instance of Hider. 
        /// </summary>
        public Jumper()
        {
            random_word = "apple";
        }

        /// <summary>
        /// Gets a hint for the seeker.
        /// </summary>
        /// <returns>A new hint.</returns>
        public string GetHint()
        {
            string hint = "";
            if(random_word.Contains(letter)) 
            {
                hint = "You guessed correctly!";
            }
            else
            {
                hint = "WRONG! Be careful or the jumper will die.";
            }

            return hint;

        }

        /// <summary>
        /// Whether or not the hider has been found.
        /// </summary>
        /// <returns>True if found; false if otherwise.</returns>
        public bool IsFound()
        {
            return true;
        }


        public object CreateJumper()
        {
            var list1 = new List<Object> {@"-----",@" ___ ",@"/___\",@"\   /",@" \ / ",@"  0  ",@" /|\ ",@" / \ "};
            int counter = 0;

            if(random_word.Contains(letter))
            {
                Console.WriteLine(list1);
                return list1;
            }

            else
            {
                while (counter < 7) 
                {
                    list1.Remove(counter);
                    counter =+ 1;
                    Console.WriteLine(list1);
                }  
            }

            return list1;
        }
    }
}