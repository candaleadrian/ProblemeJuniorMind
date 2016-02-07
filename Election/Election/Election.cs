using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Election
{
    [TestClass]
    public class Election
    {
        [TestMethod]
        public void ShouldOrderByVotesCandidatesFromOneElectionOffice()
        {
            var expected = new Results[] {new Results("Ciobanu",7),new Results("Bostanul",9) };
            var entry = new Results[] {new Results("Bostanul", 9),new Results("Ciobanu", 7) };
            CollectionAssert.AreEqual(expected, SortCandidatesByVotes(entry));
        }
        public Results[] SortCandidatesByVotes(Results[] electionResults)
        {
            return new Results[] { };
        }
        public struct Results
        {
            public string name;
            public int votes;
            public Results(string name, int votes)
            {
                this.name = name;
                this.votes = votes;
            } 
        }
    }
}
