using System;


namespace Unit03.Game
{
    // TODO: Implement the Seeker class as follows...

    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// <para>The person looking for the Hider.</para>
        /// <para>
        /// The responsibility of a Seeker is to keep track of its location.
        /// </para>
        /// </summary>
        
        public class Word
        {

            public string random_word = "";
            public Word()
            {
                random_word = "apple";
            }

            public string GetRandomWord()
            {
                return random_word;
            }

            public string CurrentLetter(string letter)
            {
                this.random_word = letter;
                return letter;
            }

        }


    // 2) Create the class constructor. Use the following method comment.
        
        /// <summary>
        /// Constructs a new instance of Seeker.
        /// </summary>
       

    // 3) Create the GetLocation() method. Use the following method comment.
        
        /// <summary>
        /// Gets the current location.
        /// </summary>
        /// <returns>The current location as an int.</returns>
        

    // 4) Create the MoveLocation(int location) method. Use the following method comment.
        
        /// <summary>
        /// Moves to the given location.
        /// </summary>
        /// <param name="letter">The given location.</param>
    
}