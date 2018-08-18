using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("HelloWorld", "This is my implementation of a mock StackOverFlow post.");

            Console.WriteLine("The date and time of the creation of this post is: {0}",post.DateTimeOfCreation.ToString());

            // let's up-vote/down-vote this post n times, then display its vote value
            var upvotes = 0;
            var downvotes = 0;
            try
            {
                Console.WriteLine("How many times would you like to up-vote this post?");
                upvotes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many times would you like to down-vote this post?");
                downvotes = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new Exception("Input must be an integer");
            }
            for (int i = 0; i < upvotes; i++)
                post.Upvote();

            for (int i = 0; i < downvotes; i++)
                post.Downvote();

            Console.WriteLine("This post has a vote value of: {0}",post.GetVoteValue());
        }
    }
}
