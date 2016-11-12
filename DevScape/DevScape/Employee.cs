using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevScape
{
    class Employee : Person
    {
        private Skills skills;
        private decimal salary;
        private WorkExperience workExperience;
        private int level;

        public Skills Skills
        {
            get
            {
                return skills;
            }
            set
            {
                skills = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public WorkExperience WorkExperience
        {
            get
            {
                return workExperience;
            }
            set
            {
                workExperience = value;
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            private set
            {
                if(value <= 100)
                {
                    level = value;
                }
                else
                {
                    level = 100;
                }
            }
        }

        public Employee(Passport passport, ContactInfo contactInfo, decimal savings, Skills skills, decimal salary, WorkExperience workExperience)
            : base(passport, contactInfo, savings)
        {
            Skills = skills;
            Level = CalculateLevel();
            Salary = salary;
            WorkExperience = workExperience;
        }

        private int CalculateLevel()
        {
            return Skills.ProgrammingAvarage();
        }

        public void Promote()
        {
            // Update the workexperience and salary
        }

        public void IncreaseSalary(double percentage)
        {
            // Increase salary with a percentage
        }

        public void Assign(Project project)
        {
            // Add a project to the todo list of the employee
        }

        public void ExecuteProject(Project project)
        {
            // Execute the project depending on the difficulty and the language
            //project.Difficulty
        }

        
        public override string ToString()
        {
            return string.Format("{0}\nSalary: {1} Euro\n**********Skills:**********\n{2}\n********************\nWork Experience: {3}\nLevel: {4}",
                                 base.ToString(), Salary, Skills, WorkExperience, Level);
        }
    }
}
