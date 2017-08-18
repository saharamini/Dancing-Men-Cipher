using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DancingMenCipher.Models
{
    // use for <select><option></option></select>
    public class SelectTag
    {
        public static char[] listA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static char[] lista = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        // use for dancing men
        public static List<char> list = "abcdefghijklmnopqrstuvwxyz".ToCharArray().ToList();

        
    }
}