using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTenSV_Thi_finaltest
{
    internal class VocabbularyNode
    {
        LinkedListMeaning meaning;
        string vocab;
        VocabbularyNode left;
        VocabbularyNode right;

        public VocabbularyNode(string vocab)
        {
            this.vocab = vocab;
            meaning = new LinkedListMeaning();
            Left = null;
            right = null;
        }

        public string Vocab { get => vocab; set => vocab = value; }


        internal VocabbularyNode Left { get => left; set => left = value; }
        internal VocabbularyNode Right { get => right; set => right = value; }
        internal LinkedListMeaning Meaning { get => meaning; set => meaning = value; }
    }
}
