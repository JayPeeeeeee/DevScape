using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DevScape
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Skill skill1 = new BusinessSkill(Business.Communication, 77);
            Skill skill2 = new BusinessSkill(Business.DelegationManagement, 54);
            Skill skill3 = new ProgrammingSkill(Language.CSharp, 51);
            Skills skills = new Skills();
            skills.Add((BusinessSkill)skill1);
            skills.Add((BusinessSkill)skill2);
            skills.Add((ProgrammingSkill)skill3);
            Console.WriteLine(skills);
            skills.Add(new ProgrammingSkill(Language.Java, 54));
            if (!skills.Contains(Language.CSharp))
            {
                skills.Add(new ProgrammingSkill(Language.CSharp, 22));
            }
            Console.WriteLine(skills);
            skills.Upgrade(Language.CSharp, 12);
            Console.WriteLine(skills);
            skills.Upgrade(Language.Java, 1.226);
            Console.WriteLine(skills);*/
            /*Address address = new Address("a", "b", "c", "d", Country.Belgium, Continent.Europe);
            Employee jason = new Employee("Jason", "Pitteman", address, skills, 1000, WorkExperience.Junior);
            Console.WriteLine(jason);
            jason.Skills.Downgrade(Language.CSharp, 19);
            Console.WriteLine(jason);
            List<BusinessSkill> testinglist = jason.Skills.BusinessSkills;*/
            //Console.WriteLine(testinglist[new Random().Next(0, testinglist.Count)]);
           
            // Create all objects to create an employee

            Address address = new Address("Leffingestraat", "6", "8432", "Leffinge", Country.Belgium, Continent.Europe);
            Address birthAddress = new Address("Oostendelaan", "8", "8400", "Oostende", Country.Belgium, Continent.Europe);
            DateTime dateOfBirth = new DateTime(1993, 5, 15);
            Passport passport = new Passport("Jason", "Pitteman", address, dateOfBirth, birthAddress, Gender.Male, "BE6594-9876");
            ContactInfo info = new ContactInfo("pittemanjason@hotmail.com", "0474/76.81.90", "0474/76.81.91", "https://devbros.co");
            decimal savings = 30000;
            Skills skills = new Skills();
            skills.Add(new ProgrammingSkill(Language.Android, 67));
            skills.Add(new ProgrammingSkill(Language.CSharp, 73));
            skills.Add(new BusinessSkill(Business.Leadership, 51));
            skills.Add(new BusinessSkill(Business.Networking, 35));
            Employee jason = new Employee(passport, info, savings, skills, 3500, WorkExperience.Junior);
            Console.WriteLine("Info about employee Jason:\n");
            Console.WriteLine(jason);
            Console.Read();
        }
    }
}
