using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class Paper
    {
        public string PaperTitle { get; }
        public Person PaperAuthor { get; }
        public DateTime PaperDate { get; }

        public Paper(string paperTitle, Person paperAuthor, DateTime paperDate)
        {
            PaperTitle = paperTitle;
            PaperAuthor = paperAuthor;
            PaperDate = paperDate;
        }

        public Paper(string v, Person karinaVasilkova, (int, int, int) p) : this("New Paper", new Person(), new DateTime())
        {

        }

        public override string ToString()
        {
            return string.Format("PaperTitle: \n {0},\n  PaperAuthor: {1},\n  PaperDate: {2}", PaperTitle, PaperAuthor, PaperDate);
        }

    }

    
}