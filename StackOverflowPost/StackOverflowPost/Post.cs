using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Post
    {
        public int voteValue { get; private set; }
        public String Title { get; set; }
        public String Description { get; private set; }
        public DateTime DateTimeOfCreation { get; private set; } = DateTime.Now;

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }
        public void Upvote()
        {
            this.voteValue++;
        }
        public void Downvote()
        {
            this.voteValue--;
        }
        public int GetVoteValue()
        {
            return voteValue;
        }


    }
}
