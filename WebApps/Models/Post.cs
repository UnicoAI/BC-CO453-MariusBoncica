using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WebApps.Models
{
    [Serializable]
    public class Post
    {

        public int PostID { get; set; }

        // username of the post's author
        [StringLength(20), Required]
        public String Username { get; set; }

        public DateTime Timestamp { get; set; }

        public int Likes { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        /// <summary>
        /// comment
        /// </summary>
        public Post()
        {
            Timestamp = DateTime.Now;
            Likes = 0;
        }

        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
            Likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (Likes > 0)
            {
                Likes--;
            }
        }
        public string DiscriminatorValue
        {
            get
            {
                return this.GetType().Name;
            }
        }

        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        public String FormatElapsedTime()
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - Timestamp;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }

}
