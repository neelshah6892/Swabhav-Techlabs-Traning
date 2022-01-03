using System;
using System.Collections.Generic;

namespace StudentApp.Modal
{
    class Student
    {
        private int _rollnumber;
        private string _name;
        private List<String> _subjects = new List<string>{};
        private List<Int32> _scores = new List<int> {};

        public Student(int rollnumber, string name)
        {
            _rollnumber = rollnumber;
            _name = name;
        }

        public int RollNumber
        {
            get
            {
                return _rollnumber;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public void addSubject(string subject)
        {
            _subjects.Add(subject);
        }

        public void addMarks(int scores)
        {
            _scores.Add(scores);
        }

        public List<String> Subjects
        {
            get
            {
                return _subjects;
            }
        }

        public List<Int32> Scores
        {
            get
            {
                return _scores;
            }
        }

        private int max;
        public int MaxScore
        {
            get
            {
                List<Int32> scores = _scores;
                max = scores[0];
                for (int i = 1; i < scores.Count; i++)
                {
                    if (scores[i] > max)
                    {
                        max = scores[i];
                    }
                }
                return max;
            }
        }

        public int MinScore
        {
            get
            {
                List<Int32> scores = _scores;
                int min = scores[0];
                for (int i = 1; i < scores.Count; i++)
                {
                    if (scores[i] < min)
                    {
                        min = scores[i];
                    }
                }
                return min;
            }
        }

        public int SecondMax
        {
            get
            {
                List<Int32> scores = _scores;
                int secondmax = scores[1];
                for (int i = 1; i < scores.Count; i++)
                {
                    if (scores[i] != max)
                    {
                        if(scores[i] > secondmax)
                        {
                            secondmax = scores[i];
                        }
                    }
                }
                return secondmax;
                //Only read operations in get
                /*scores.Remove(max);
                foreach(int score in scores)
                {
                    Console.WriteLine(score);
                }
                int secondmax = scores[0];
                for (int i = 1; i < scores.Count; i++)
                {
                    if (scores[i] > secondmax)
                    {
                        secondmax = scores[i];
                    }
                }
                return secondmax;*/
            }
        }

        public int Average
        {
            get
            {
                int sum = 0;
                int avg;
                for (int i = 0; i < _scores.Count; i++)
                {
                    sum += _scores[i];
                }
                avg = sum / _scores.Count;
                return avg;
            }
        }
    }
}
