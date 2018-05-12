using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesofSortQuestion
{
    public class Exam : IEnumerable
    {
        Question[] exam = new Question[1];
        int count = 0;
        int revision = 0;

        internal Question this[int index]
        {
            get
            {
                CheckIndex(index);
                return (exam[index]);
            }
            set
            {
                CheckIndex(index);
                exam[index] = value;
                revision++;
            }
        }

        internal int Count
        {
            get
            {
                return (count);
            }
        }

        internal int Revision
        {
            get
            {
                return (revision);
            }
        }

        internal static IComparer SortByHardshipLevel
        {
            get
            {
                return ((IComparer)new Question.SortByHardshipLevelClass());
            }
        }

        internal static IComparer SortByTopic
        {
            get
            {
                return ((IComparer)new Question.SortByTopicClass());
            }
        }

        internal static IComparer SortByScore
        {
            get
            {
                return ((IComparer)new Question.SortByScoreClass());
            }
        }

        internal static IComparer SortById
        {
            get
            {
                return ((IComparer)new Question.SortByIdClass());
            }
        }

        public void Add(Question question)
        {
            if (count >= exam.Length)
            {
                exam = (Question[])Resize(exam, exam.Length * 2);
            }
            exam[count++] = question;
        }

        public static Array Resize(Array array, int newSize)
        {
            Type type = array.GetType().GetElementType();
            Array newArray = Array.CreateInstance(type, newSize);
            Array.Copy(array, 0, newArray, 0, Math.Min(array.Length, newSize));
            return newArray;
        }

        internal void CheckIndex(int index)
        {
            if (index >= count)
                throw new ArgumentOutOfRangeException(@"Index value out of range");
        }

        public void Sort()
        {
            Array.Sort(exam, 0, count);
        }

        public void Sort(Question.SortMetric sortMetric)
        {
            switch (sortMetric)
            {
                case Question.SortMetric.Txt:
                    Array.Sort(exam, 0, count);
                    break;
                case Question.SortMetric.Id:
                    Array.Sort(exam, 0, count, SortById);
                    break;
                case Question.SortMetric.HardshipLevel:
                    Array.Sort(exam, 0, count, SortByHardshipLevel);
                    break;
                case Question.SortMetric.Topic:
                    Array.Sort(exam, 0, count, SortByTopic);
                    break;
                case Question.SortMetric.Score:
                    Array.Sort(exam, 0, count, SortByScore);
                    break;

            }
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return (new QuestionExamEnumerator(this));
        }

        #endregion
        public class QuestionExamEnumerator : IEnumerator
        {
            Exam questionExam;
            int index;
            int revision;

            #region IEnumerator Members

            public void Reset()
            {
                index = -1;
                revision = questionExam.Revision;
            }

            public object Current
            {
                get
                {
                    if (revision != questionExam.Revision)
                        throw new InvalidOperationException(@"Collection modified while enumerating.");
                    return (questionExam[index]);
                }
            }

            public bool MoveNext()
            {

                if (++index >= questionExam.Count)
                    return (false);
                else
                    return (true);
            }

            #endregion
            internal QuestionExamEnumerator(Exam questionExam)
            {
                this.questionExam = questionExam;
                Reset();
            }

        }
    }


}
