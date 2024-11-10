namespace HoTenSV_Thi_finaltest
{
    internal class VocabularyBinaryTree
    {
        VocabbularyNode root;

        internal VocabbularyNode Root { get => root; set => root = value; }


        public void Input()
        {
            while (true)
            {
                Console.Write("Input Vocabulary : ");
                string a = Console.ReadLine();
                VocabbularyNode NewVocab = new VocabbularyNode(a);
                while (searchNode(NewVocab, NewVocab.Vocab))
                {
                    Console.Write("Input Vocabulary again : ");
                    a = Console.ReadLine();
                    NewVocab = new VocabbularyNode(a);
                }
                Console.Write("\n Input Meaning : ");
                string mean = Console.ReadLine();
                MeaningNode Newmean = new MeaningNode(mean, null);
                NewVocab.Meaning.AddMeaning(Newmean);
            }
        }
        private void Insert(VocabbularyNode newNode, string newVocab, MeaningNode newMean)
        {
            if (newNode == null)
            {
                newNode.Vocab = newVocab;
                newNode.Meaning.AddMeaning(newMean);

            }
            if (newVocab.CompareTo(newNode.Vocab) == 0)
            {
                newNode.Meaning.AddMeaning(newMean);
            }
            if (newVocab.CompareTo(newNode.Vocab) < 0)
            {
                Insert(newNode.Left, newVocab, newMean);
            }
            if (newVocab.CompareTo(newNode.Vocab) > 0)
            {
                Insert(newNode.Right, newVocab, newMean);
            }


        }
        private bool searchNode(VocabbularyNode node, string word)
        {
            if (node != null)
            {
                if (node.Vocab.CompareTo(word) == 0)
                {
                    return true;
                }


                if (word.CompareTo(node.Vocab) < 0)
                {
                    return searchNode(node.Left, word);
                }
                if (word.CompareTo(node.Vocab) > 0)
                {
                    return searchNode(node.Right, word);
                }
            }
            return true;
        }
        public void show()
        {
            Console.WriteLine("list tu vung : ");
            root.LNR();
        }

    }
}
