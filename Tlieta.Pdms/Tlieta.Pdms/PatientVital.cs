//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tlieta.Pdms
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientVital
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string BPHigh { get; set; }
        public string BPLow { get; set; }
        public string PulseRate { get; set; }
        public string RespiratoryRate { get; set; }
        public string Temperature { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BMI { get; set; }
        public System.DateTime TimeLine { get; set; }
    }
}
