using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevScape
{
    class ProgrammingSkill : Skill
    {
        private Language language;
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
        public ProgrammingSkill(Language language, int rating) : base(rating)
        {
            Language = language;
        }

        public ProgrammingSkill(Language language, double stars) : base(stars)
        {
            Language = language;
        }

        public override string ToString()
        {
            return string.Format("Language: {0}\n{1}", Language, base.ToString());
        }
    }
}
