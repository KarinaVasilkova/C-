using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class ResearchTeam
    {
        private string _researchTopic;
        private string _organizationTitle;
        private int _registrationNumber;
        private TimeFrame _researchDuration;
        private Paper[] _listOfPublication;

        public ResearchTeam() : this("default researchTopic", "default organizationTitle", 0, TimeFrame.Year)
        {

        }

        public ResearchTeam(string researchTopic, string organizationTitle, int registrationNumber, TimeFrame researchDuration)
        {
            _researchTopic = researchTopic;
            _organizationTitle = organizationTitle;
            _registrationNumber = registrationNumber;
            _researchDuration = researchDuration;
        }

        public string ResearchTopic
        {
            get { return _researchTopic; }
            set { _researchTopic = value; }
        }

        public string OrganizationTitle
        {
            get { return _organizationTitle; }
            set { _organizationTitle = value; }
        }

        public int registrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }

        public TimeFrame ResearchDuration
        {
            get { return _researchDuration; }
            set { _researchDuration = value; }
        }

        public Paper[] ListOfPublication
        {
            get { return _listOfPublication; }
            set { _listOfPublication = value; }
        }

        public virtual string ToShortString()
        {
            return string.Format(" ResearchTopic: {0},\n OrganizationTitle: {1},\n RegistrationNumber: {2},\n ResearchDuration: {3}\n", researchTopic, organizationTitle, registrationNumber, researchDuration);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var paper in Paper)
            {
                stringBuilder.AppendLine(paper.ToString());
            }
            return string.Format(" MagazineName: {0},\n Timing: {1},\n MagazineDate: {2},\n Article: {3},\n MiddleRate: {4}\n", MagazineName, Timing, MagazineDate, stringBuilder, MiddleRate);
        }

        public void AddPaper(params Paper[] papers)
        {
            Array.Resize(ref _listOfPublication, Paper.Length + papers.Length);
            Array.Copy(papers, 0, Paper, Paper.Length - papers.Length, papers.Length);
        }

        protected bool Equals(ResearchTeam other)
        {
            return string.Equals(_researchTopic, other._researchTopic) && _organizationTitle == other._organizationTitle && _registrationNumber.Equals(other._registrationNumber) && _researchDuration == other._researchDuration && Equals(_listOfPublication, other._listOfPublication);
        }

    }

    
}
