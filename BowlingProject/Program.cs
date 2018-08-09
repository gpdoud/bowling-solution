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
        int GetScoresIndex(int frame) {
            int idx = (frame - 1) * 2;
            return idx;
        }
        int GetNextBallScore(int frame) {
            int idx = GetScoresIndex(frame);
            return idx + 2;
        }
        void CalcScore() {
            for(int frame = 1; frame <= 10; frame++) {
                int idx = GetScoresIndex(frame);
                int firstBall = scores[idx];
                int secondBall = scores[idx + 1];
                int thirdBall = 0;
                if(frame == 10) {
                    thirdBall = scores[idx + 2];
                }
            }
        }
        void LoadScores() {
            Random rnd = new Random();
            for (int frame = 1; frame <= 10; frame++) {
                var score = -1;
                // first ball
                score = rnd.Next(0, 11);
                scores.Add(score);
                if (score < 10) {
                    // second ball
                    score = rnd.Next(0, 10 - score + 1);
                } else {
                    score = 0;
                }
                scores.Add(score);
                // third ball in frame 10
                if (frame == 10) { 
                    var strikeOrSpare = (scores[scores.Count - 2] == 10) // strike
                        || (scores[scores.Count - 1] + scores[scores.Count - 2] == 10); // spare
                    if (strikeOrSpare) {
                        score = rnd.Next(0, 11);
                    } else {
                        score = 0;
                    }
                    scores.Add(score);
                }
            }
        }
        void Run() {
            LoadScores();
            CalcScore();
        }

        static void Main(string[] args) {
            (new Program()).Run();
        }
    }
}
