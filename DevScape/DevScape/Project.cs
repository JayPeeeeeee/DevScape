using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevScape
{
    class Project
    {
        private double difficulty;
        private Language language;
        private DateTime startDate;
        private DateTime dueDate;
        private decimal profit;

        public double Difficulty
        {
            get
            {
                return difficulty;
            }
            private set
            {
                if((value >= 0) && (value <= 100))
                {
                    difficulty = value;
                }
                else
                {
                    if(value > 100)
                    {
                        difficulty = 100;
                    }
                    else
                    {
                        difficulty = 0;
                    }
                }
            }
        }

        public Language Language
        {
            get
            {
                return language;
            }
            private set
            {
                language = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            private set
            {
                startDate = value;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            private set
            {
                dueDate = value;
            }
        }

        public decimal Profit
        {
            get
            {
                return profit;
            }
            private set
            {
                profit = value;
            }
        }

        public Project(double difficulty, Language language, DateTime startDate, DateTime dueDate, decimal profit)
        {
            Difficulty = difficulty;
            Language = language;
            StartDate = startDate;
            DueDate = dueDate;
            Profit = profit;
        }
    }
}
