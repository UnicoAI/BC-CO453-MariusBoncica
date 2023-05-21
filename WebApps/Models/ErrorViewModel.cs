using System;
//<author>Marius Boncica
//</author>
//<summary>
//version 1.0
//</summary>
namespace WebApps.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
