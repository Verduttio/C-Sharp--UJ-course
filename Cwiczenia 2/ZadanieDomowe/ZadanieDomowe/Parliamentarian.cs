using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe
{
    class VoteEventArgs : EventArgs
    {
        public bool Vote() 
        {
            Random rd = new Random();
            int vote = rd.Next();
            return vote % 2 == 0;
        }

        public int Id { get; set; }

    }

    class Parliamentarian
    {
        public int Id { get; set; }


        public delegate void CastedVoteEventHandler(object source, VoteEventArgs args);

        public event CastedVoteEventHandler CastedVote;

        protected virtual void OnCastedVote()
        {
            if (CastedVote != null)
                CastedVote(this, new VoteEventArgs() {Id = this.Id });
        }

        public void OnStartedVoting (object source, VotingEventArgs e)
        {
            Console.WriteLine($"Parliamentarian {Id} has started voting!" + e.Topic);
        }

        public void OnFinishedVoting (object source, VotingEventArgs e)
        {
            OnCastedVote();
            Console.WriteLine($"Parliamentarian {Id} has ended voting." + e.Topic);
        }

    }
}
