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
                Last = Last.Next;
            }
        }
        public void showlistMeaning()
        {
            MeaningNode p = First;
            while (p != null)
            {
                Console.WriteLine(p.Meaning);
                p = p.Next;
            }
        }
    }
}
