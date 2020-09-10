using System;
using System.Collections.Generic;

namespace FizzBuzzaKata
{
    /// <summary>
    /// Enum used to clarify gametypes
    /// </summary>
    enum GameTypes
    { 
        FizzBuzzStandard = 0,
        FizzBuzzPop = 1,
        FizzBuzzVariation = 2
    }

    /// <summary>
    /// FizzBuzz class that allows three variations:
    /// 1: Standard FizzBuzz
    /// 2: FizzBuzzPop
    /// 3: FuzzBuzz with custom variations
    /// </summary>
    public class FizzBuzz
    {
        /// <summary>
        /// Sorted Dictionary to store variations with a multiplier (int) and its corresponding
        /// response string.
        /// </summary>
        private SortedDictionary<int, string> variations = new SortedDictionary<int, string>();

        /// <summary>
        /// Allows the frontend to add variations with thier own dictionary if needed.
        /// </summary>
        /// <param name="customVariations">Dictionary sent in from the frontend to replace 
        /// the class dictionary</param>
        public void AddSubstitution(SortedDictionary<int, string> customVariations)
        {
            variations = customVariations;
        }

        /// <summary>
        /// Allows the frontend to add variations one at a time.
        /// </summary>
        /// <param name="multiplier">Multiplier used to determine the response string. I.E. 3</param>
        /// <param name="substitution">Response string corresponding to the multiplier I.E. Fizz</param>
        public void AddSubstitution(int multiplier, string substitution)
        {
            variations.Add(multiplier, substitution);
        }
        /// <summary>
        /// The frontend is able to set the game type from this method.
        /// </summary>
        /// <param name="gameType">Integer corresponding to the game type enum</param>
        public void SetGameType(int gameType)
        {
            variations.Clear();

            if (gameType == (int)GameTypes.FizzBuzzStandard)
            {
                InitializeFizzBuzzStandard();
            }
            else if (gameType == (int)GameTypes.FizzBuzzPop)
            {
                InitializeFizzBuzzPop();
            }
            else
            {
                // do nothing
            }
        }
        /// <summary>
        /// Sets the correct dictionary for a standard game of FizzBuzz.
        /// </summary>
        private void InitializeFizzBuzzStandard()
        {
            variations.Add(3, "fizz");
            variations.Add(5, "buzz");
        }
        /// <summary>
        /// Sets the correct dictionary for a standard game of FizzBuzzPop.
        /// </summary>
        private void InitializeFizzBuzzPop()
        {
            variations.Add(3, "fizz");
            variations.Add(5, "buzz");
            variations.Add(7, "pop");
        }
        /// <summary>
        /// Returns the correct in game answer given a key.
        /// </summary>
        /// <param name="key">Integer sent in to be converted into an answer</param>
        /// <returns>Correct answer given the game type and variations</returns>
        public string GetAnswer(int key)
        {
            string answer = String.Empty;

            foreach (var variation in variations)
            {
                int multiplier = variation.Key;
                string substitution = variation.Value;

                if (key % multiplier == 0)
                {
                    answer += substitution + " ";
                }
            }

            if (answer == String.Empty)
            {
                return key.ToString();
            }
            else
            {
                return answer.TrimEnd(' ');
            }
        }
    }
}
