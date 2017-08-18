using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DancingMenCipher.Models
{
    // Letter Frequency - count each letter
    public static class Counting
    {
        public static Dictionary<char, int> CharacterCount(this string strings)
        {
            return strings
                .GroupBy(c => c)
                .OrderByDescending(g => g.Count()).
                ToDictionary(g => g.Key, g => g.Count());
        }
    }
}