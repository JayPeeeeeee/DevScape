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
            //Skill skill1 = new BusinessSkill(Business.Communication, 77);
            //Skill skill2 = new BusinessSkill(Business.DelegationManagement, 54);
            Skill skill3 = new ProgrammingSkill(Language.CSharp, 51);
            Skills skills = new Skills();
            skills.ProgrammingSkills.Add((ProgrammingSkill) skill3);
            skills.GetSkill(Language.CSharp).Upgrade(1.0);
            //skills.Add((ProgrammingSkill)skill3);
            /*skills.Upgrade(Language.Android, 5);
            skills.Upgrade(Language.ASP, 3.0);
            skills.Upgrade(Business.DelegationManagement, "hey");*/
            skills.ProgrammingSkills.First().Downgrade(1.0);
            //skills.GetSkill(Language.CSharp).Upgrade(3);
            Console.WriteLine(skill3);
            skills.GetSkill(Language.CSharp).Upgrade(1.0);
            Console.WriteLine(skill3);
            skills.GetSkill(Language.CSharp).Downgrade(1.1);
            Console.WriteLine(skill3);
            //skills.GetSkill(Language.Android).Upgrade(1.0);
            //skills.Remove(Language.CSharp);
            
            Console.Read();
        }
    }
}
