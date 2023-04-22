using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe
{
    class VotingEventArgs : EventArgs
    {
        public String Topic { get; set; }
    }

    class Parliament
    {
        List<Parliamentarian> _parliamentarians;
        public String Topic { get; set; }
        private int _yesVotes;
        private int _noVotes; // optional

        public Parliament()
        {
            _parliamentarians = new List<Parliamentarian>();
            _yesVotes = 0;
            _noVotes = 0;
        }

        public List<Parliamentarian> Parliamentarians() { return _parliamentarians; }

        //////////
        public delegate void StartedVotingEventHandler(object source, VotingEventArgs args);

        public event StartedVotingEventHandler StartedVoting;
        protected virtual void OnStartedVoting()
        {
            if (StartedVoting != null)
                StartedVoting(this, new VotingEventArgs() { Topic = this.Topic });
        }


        public delegate void FinishedVotingEventHandler(object source, VotingEventArgs args);

        public event StartedVotingEventHandler FinishedVoting;
        protected virtual void OnFinishedVoting()
        {
            if (FinishedVoting != null)
                FinishedVoting(this, new VotingEventArgs() { Topic = this.Topic });
        }
        ///////////

        public void OnCastedVote(object source, VoteEventArgs e)
        {
            bool vote = e.Vote();
            Console.WriteLine($"Parliamentarian {e.Id} vote: " + vote);
            if (vote) _yesVotes++; else _noVotes++;
        }


        public void StartVoting()
        {
            Console.WriteLine("We are starting voting!");
            OnStartedVoting();
            OnFinishedVoting();
            Console.WriteLine("We have ended voting!");
            VotingResult();
        }

        public void VotingResult()
        {
            Console.WriteLine("\nVoting results for " + Topic);
            Console.WriteLine("For yes: " + _yesVotes + " votes");
            Console.WriteLine("For no: " + _noVotes + " votes");
        }



    }
}
