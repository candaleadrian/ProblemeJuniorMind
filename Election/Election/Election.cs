using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Election
{
    [TestClass]
    public class Election
    {
        [TestMethod]
        public void ShouldReturnSortedDescendingByTotalVotesForTwoCandidates()
        {
            CandidateResult[] office1 = { new CandidateResult("Ciobanu", 7), new CandidateResult("Dobi", 9) };
            CandidateResult[] office2 = { new CandidateResult("Ciobanu", 5), new CandidateResult("Dobi", 6) };
            ResultInEachOffice[] allResults =
            {
               new ResultInEachOffice(office1),
               new ResultInEachOffice(office2),
            };
            CandidateResult[] expected = { new CandidateResult("Dobi", 15), new CandidateResult("Ciobanu", 12)};
            CollectionAssert.AreEqual(expected, SortCandidatesByVotes(allResults));
        }
        [TestMethod]
        public void ShouldSortAStructArrayByNumberOfVotesDescending()
        {
            CandidateResult[] toBeSorted = { new CandidateResult("Ciobanu", 7), new CandidateResult("Dobi", 9) };
            CandidateResult[] expected = { new CandidateResult("Dobi", 9), new CandidateResult("Ciobanu", 7) };
            CollectionAssert.AreEqual(expected, SortByVotes(toBeSorted));
        }
        [TestMethod]
        public void ShouldReturnSortedDescendingByTotalVotesForTwoCandidatesAndThreeOffices()
        {
            CandidateResult[] office1 = { new CandidateResult("Ciobanu", 7), new CandidateResult("Dobi", 9) };
            CandidateResult[] office2 = { new CandidateResult("Ciobanu", 5), new CandidateResult("Dobi", 6) };
            CandidateResult[] office3 = { new CandidateResult("Ciobanu", 2), new CandidateResult("Dobi", 0) };
            ResultInEachOffice[] allResults =
            {
               new ResultInEachOffice(office1),
               new ResultInEachOffice(office2),
               new ResultInEachOffice(office3),
            };
            CandidateResult[] expected = { new CandidateResult("Dobi", 15), new CandidateResult("Ciobanu", 14) };
            CollectionAssert.AreEqual(expected, SortCandidatesByVotes(allResults));
        }
        [TestMethod]
        public void ShouldReturnSortedDescendingByTotalVotesForThreeCandidatesAndThreeOffices()
        {
            CandidateResult[] office1 = { new CandidateResult("Ciobanu", 7), new CandidateResult("Dobi", 9), new CandidateResult("Bughi", 3) };
            CandidateResult[] office2 = { new CandidateResult("Ciobanu", 5), new CandidateResult("Dobi", 6), new CandidateResult("Bughi", 8) };
            CandidateResult[] office3 = { new CandidateResult("Ciobanu", 2), new CandidateResult("Dobi", 0), new CandidateResult("Bughi", 7) };
            ResultInEachOffice[] allResults =
            {
               new ResultInEachOffice(office1),
               new ResultInEachOffice(office2),
               new ResultInEachOffice(office3),
            };
            CandidateResult[] expected = { new CandidateResult("Bughi",18), new CandidateResult("Dobi", 15), new CandidateResult("Ciobanu", 14) };
            CollectionAssert.AreEqual(expected, SortCandidatesByVotes(allResults));
        }
        public CandidateResult[] SortCandidatesByVotes(ResultInEachOffice[] electionResults)
        {
            CandidateResult[] total = new CandidateResult[electionResults[0].office.Length];
            for (int i = 0; i < total.Length; i++)
            {
                total[i].name = electionResults[0].office[i].name;
                total[i].votes = 0;
            }
            for (int j = 0; j < electionResults.Length; j++)
            {
                for (int i = 0; i < total.Length; i++)
                {
                    total[i].votes += electionResults[j].office[i].votes;
                }
            }
            return SortByVotes(total);
        }

        private CandidateResult[] SortByVotes(CandidateResult[] total)
        {
            int k = 1;
            while (k != 0)
            {
                k = 0;
                for (int i = 1; i < total.Length; i++)
                {
                    if (total[0].votes < total[i].votes)
                        Swap(ref total[i], ref total[++k]);
                }
                Swap(ref total[0], ref total[k]);
            }
            return total;
        }

        private void Swap(ref CandidateResult firstCandidate, ref CandidateResult secondCandidate)
        {
            CandidateResult temp = firstCandidate;
            firstCandidate = secondCandidate;
            secondCandidate = temp;
        }

        public struct ResultInEachOffice
        {
            public CandidateResult[] office;
            public ResultInEachOffice(CandidateResult[] office)
            {
                this.office = office;
            }
        }
        public struct CandidateResult
        {
            public string name;
            public int votes;
            public CandidateResult(string name, int votes)
            {
                this.name = name;
                this.votes = votes;
            } 
        }
    }
}
