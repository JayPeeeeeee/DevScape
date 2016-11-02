using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevScape
{
    class BusinessSkill : Skill
    {
        private Business business;
        public Business Business
        {
            get
            {
                return business;
            }
            private set
            {
                business = value;
            }
        }

        public BusinessSkill(Business business, int rating) : base(rating)
        {
            Business = business;
        }

        public BusinessSkill(Business business, double stars) : base(stars)
        {
            Business = business;
        }

        public override string ToString()
        {
            return string.Format("Business: {0}\n{1}", Business, base.ToString());
        }
    }
}
