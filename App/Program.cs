using Challenge;
using System;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            CheckEdit checkEdit = new CheckEdit();
            var editThree = checkEdit.CheckIfEditCanBePerformed("pale", "bale");
            Permutation checkUnique = new Permutation();
            var result = checkUnique.CheckPermutation("ABC","BCX");
            Console.ReadLine();
        }
    }
}
