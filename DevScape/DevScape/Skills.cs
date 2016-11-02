using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevScape
{
    class Skills
    {
        private List<ProgrammingSkill> programmingSkills;
        private List<BusinessSkill> businessSkills;
        public List<ProgrammingSkill> ProgrammingSkills
        {
            get
            {
                return programmingSkills;
            }
            private set
            {
                programmingSkills = value;
            }
        }

        public List<BusinessSkill> BusinessSkills
        {
            get
            {
                return businessSkills;
            }
            private set
            {
                businessSkills = value;
            }
        }

        public Skills()
        {
            ProgrammingSkills = new List<ProgrammingSkill>();
            BusinessSkills = new List<BusinessSkill>();
        }

        public Skills(IEnumerable<ProgrammingSkill> programmingSkills, IEnumerable<BusinessSkill> businessSkills)
        {
            ProgrammingSkills.AddRange(programmingSkills);
            BusinessSkills.AddRange(businessSkills);
        }

        /*public void Add(ProgrammingSkill skill)
        {
            ProgrammingSkills.Add(skill);
        }

        public void Add(BusinessSkill skill)
        {
            BusinessSkills.Add(skill);
        }

        public void Remove(Language language)
        {
            ProgrammingSkills.Remove(GetSkill(language));
        }

        public void Remove(Business business)
        {
            BusinessSkills.Remove(GetSkill(business));
        }*/

        public ProgrammingSkill GetSkill(Language language)
        {
            return ProgrammingSkills.Find(x => x.Language == language);
        }

        public BusinessSkill GetSkill(Business business)
        {
            return BusinessSkills.Find(x => x.Business == business);
        }

        /*public void Upgrade<K, T>(K skill, T rate)
        {
            string x = Convert.ToString(typeof(T));
            string y = Convert.ToString(typeof(K));
            Console.WriteLine("SkillType: " + y);
            Console.WriteLine("UpgradeType: " + x);
        }

        private void Upgrade<T>(Language language, T rate)
        {

        }*/
    }
}
