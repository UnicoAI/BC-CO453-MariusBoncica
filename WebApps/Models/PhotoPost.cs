using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace WebApps.Models
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// @version 0.1
    /// </author>
    public class PhotoPost : Post
    {
        // the name of the image file
        [StringLength(128), Required]
        public String Filename { get; set; }

        // a one line image caption
        [StringLength(30), Required]
        public String Caption { get; set; }
    }
}
