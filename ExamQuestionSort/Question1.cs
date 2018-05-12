using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesofSortQuestion
{
    public class Question1 : Question
    {
        public override string Txt
        {
            get
            {
                return ("C# class can inherit multiple ________ .");
            }
        }

        public override int Id
        {
            get
            {
                return (1);
            }
        }

        public override string HardshipLevel
        {
            get
            {
                return ("Hard");
            }
        }

        public override string Topic
        {
            get
            {
                return ("C#");
            }
        }

        public override double Score
        {
            get
            {
                return (2);
            }
        }
    }

}
