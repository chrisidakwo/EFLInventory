//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ErrorLog
    {
        public int id { get; set; }
        public System.DateTime error_time { get; set; }
        public string username { get; set; }
        public string error_severity { get; set; }
        public string error_proceedure { get; set; }
        public string error_line { get; set; }
        public string error_message { get; set; }
        public System.DateTime timestamp { get; set; }
    }
}
