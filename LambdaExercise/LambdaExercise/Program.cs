using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int> { 90, 71, 82, 93, 75, 82 };
            // only scores greater than 80
            List<int> greaterScores = scores.Where(n => n > 80).ToList();

            Console.WriteLine("{0} scores are greater than 80", greaterScores.Count());
            Console.ReadLine();
        }
    }
}
