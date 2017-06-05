using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BowlingProject {

    public class Program {

        //int[] scores = new int[10];
        private List<int> scores = new List<int>();

        void Run() {
            Random rnd = new Random();
            for(int idx = 0; idx < 10; idx++) {
                int number = rnd.Next(11);
                scores.Add(number);
            }
            foreach(int anInt in scores) {
                Debug.WriteLine(anInt);
            }
        }

        static void Main(string[] args) {
            (new Program()).Run();
        }
    }
}
