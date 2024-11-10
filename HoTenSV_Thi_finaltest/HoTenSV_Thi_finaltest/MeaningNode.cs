using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HoTenSV_Thi_finaltest
{
    internal class MeaningNode
    {
        string meaning;
        MeaningNode next;

        public MeaningNode(string meaning, MeaningNode next)
        {
            Meaning = meaning;
            Next = next;
        }

        public string Meaning { get => meaning; set => meaning = value; }
        internal MeaningNode Next { get => next; set => next = value; }
    }
}
