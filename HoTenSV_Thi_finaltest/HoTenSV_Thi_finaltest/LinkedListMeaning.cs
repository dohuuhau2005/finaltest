using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTenSV_Thi_finaltest
{
    internal class LinkedListMeaning
    {
        MeaningNode first;
        MeaningNode last;

        public LinkedListMeaning()
        {
            First = null;
            Last = null;
        }

        internal MeaningNode First { get => first; set => first = value; }
        internal MeaningNode Last { get => last; set => last = value; }

        public void AddMeaning(MeaningNode meaning)
        {
            if (First == null && Last == null)
            {
                First = Last = meaning;
            }
            else
            {
                last.Next = meaning;
                Last=Last.Next;
            }
        }
    }
}
