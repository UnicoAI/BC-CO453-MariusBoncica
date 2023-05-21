using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace WebApps.Models
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Marius Boncica
    /// version 1.0
    /// </author>
    public class MessagePost : Post
    {
        // an arbitrarily long, multi-line message
        [StringLength(30)]
        public String Message { get; set; }

    }
}
