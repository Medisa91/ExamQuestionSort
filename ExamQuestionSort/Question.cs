using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesofSortQuestion
{
    public class Question : IComparable
    {
        public enum SortMetric
        {
            Txt,
            Id,
            HardshipLevel,
            Topic,
            Score
        };

        public virtual string Txt
        {
            get
            {
                return ("Question");
            }
        }

        public virtual int Id
        {
            get
            {
                return (0);
            }
        }

        public virtual string HardshipLevel
        {
            get
            {
                return (null);
            }
        }

        public virtual string Topic
        {
            get
            {
                return (null);
            }
        }

        public virtual double Score
        {
            get
            {
                return (0.0);
            }
        }

        public int CompareTo(object obj)
        {
            Question other = (Question)obj;
            return (this.Txt.CompareTo(other.Txt));
        }

        public class SortByHardshipLevelClass : IComparer
        {
            #region IComparer Members

            public int Compare(object x, object y)
            {
                Question Questionx = (Question)x;
                Question Questiony = (Question)y;

                return (((IComparable)Questionx.HardshipLevel).CompareTo(Questiony.HardshipLevel));
            }

            #endregion

        }

        public class SortByTopicClass : IComparer
        {
            #region IComparer Members

            public int Compare(object x, object y)
            {
                Question Questionx = (Question)x;
                Question Questiony = (Question)y;

                return (String.Compare(Questionx.Topic, Questiony.Topic));
            }

            #endregion
        }

        public class SortByScoreClass : IComparer
        {
            #region IComparer Members

            public int Compare(object x, object y)
            {
                Question Questionx = (Question)x;
                Question Questiony = (Question)y;

                return (((IComparable)Questionx.Score).CompareTo(Questiony.Score));
            }

            #endregion

        }

        public class SortByIdClass : IComparer
        {
            #region IComparer Members

            public int Compare(object x, object y)
            {
                Question Questionx = (Question)x;
                Question Questiony = (Question)y;

                return (((IComparable)Questionx.Id).CompareTo(Questiony.Id));
            }

            #endregion

        }
    }

}
