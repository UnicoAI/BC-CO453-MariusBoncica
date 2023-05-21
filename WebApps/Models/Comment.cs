using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//<author>Marius Boncica
//</author>
//<summary>
//version 1.0
//</summary>
namespace WebApps.Models
{
    public class Comment
    {
        // Primary Key
        public int CommentID { get; set; }

        //Foreign Key
        public int PostId { get; set; }

        [DataType(DataType.MultilineText)]
        public String Text { get; set; }

     
public virtual Post Post { get; set; }
    }
}