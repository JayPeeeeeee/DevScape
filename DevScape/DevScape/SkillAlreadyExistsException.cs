using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevScape
{
    class SkillAlreadyExistsException : Exception
    {
        public SkillAlreadyExistsException()
        {

        }

        public SkillAlreadyExistsException(string message) : base(message)
        {

        }

        public SkillAlreadyExistsException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
