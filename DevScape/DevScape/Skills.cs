using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevScape
{
    /***
     * Possible bugs:
     * - A get of the ProgrammingSkills/BusinessSkills return a shallow copy of the object.
     *   The get returns a list of the specific type. If you change a value from the list,
     *   then it is also changed in the object you received the list from because the
     *   reference is the same.
     * - A get of a single skill also returns a shallow copy.
     * - These things can be solved by making the class serializable and clone it with the ObjectCloner class.
     * 
     ***/
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

        public void Add(ProgrammingSkill skill)
        {
            if (!Contains(skill.Language))
            {
                ProgrammingSkills.Add(skill);
            }
            else
            {
                throw new SkillAlreadyExistsException(string.Format("The skill {0} already exists", skill.Language));
            }
        }

        public void Add(BusinessSkill skill)
        {
            if (!Contains(skill.Business))
            {
                BusinessSkills.Add(skill);
            }
            else
            {
                throw new SkillAlreadyExistsException(string.Format("The skill {0} already exists", skill.Business));
            }
        }

        public bool Contains(Language language)
        {
            return ProgrammingSkills.Exists(x => x.Language == language);
        }

        public bool Contains(Business business)
        {
            return BusinessSkills.Exists(x => x.Business == business);
        }

        public void Remove(Language language)
        {
            ProgrammingSkills.Remove(GetSkill(language));
        }

        public void Remove(Business business)
        {
            BusinessSkills.Remove(GetSkill(business));
        }

        public ProgrammingSkill GetSkill(Language language)
        {
            return ProgrammingSkills.Find(x => x.Language == language);
        }

        public BusinessSkill GetSkill(Business business)
        {
            return BusinessSkills.Find(x => x.Business == business);
        }

        public void Upgrade(Language language, int rate)
        {
            GetSkill(language).Upgrade(rate);
        }

        public void Upgrade(Language language, double stars)
        {
            GetSkill(language).Upgrade(stars);
        }

        public void Downgrade(Language language, int rate)
        {
            GetSkill(language).Downgrade(rate);
        }

        public void Downgrade(Language language, double stars)
        {
            GetSkill(language).Downgrade(stars);
        }

        public void Upgrade(Business business, int rate)
        {
            GetSkill(business).Upgrade(rate);
        }

        public void Upgrade(Business business, double stars)
        {
            GetSkill(business).Upgrade(stars);
        }

        public void Downgrade(Business business, int rate)
        {
            GetSkill(business).Downgrade(rate);
        }

        public void Downgrade(Business business, double stars)
        {
            GetSkill(business).Downgrade(stars);
        }

        public int ProgrammingAvarage()
        {
            int avarage = 0;
            foreach(ProgrammingSkill skill in ProgrammingSkills)
            {
                avarage += skill.Rating;
            }
            return avarage / ProgrammingSkills.Count;
        }

        public int BusinessAvarage()
        {
            int avarage = 0;
            foreach(BusinessSkill skill in BusinessSkills)
            {
                avarage += skill.Rating;
            }
            return avarage / ProgrammingSkills.Count;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("**********\n");
            foreach(ProgrammingSkill skill in ProgrammingSkills)
            {
                builder.Append(skill).Append("\n**********\n");
            }
            foreach(BusinessSkill skill in BusinessSkills)
            {
                builder.Append(skill).Append("\n**********\n");
            }
            builder.Remove(builder.Length - 2, 2);
            return builder.ToString();
        }
    }
}
