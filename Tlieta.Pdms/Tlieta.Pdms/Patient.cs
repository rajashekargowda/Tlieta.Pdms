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
    
    public partial class Patient
    {
        public int PatientId { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public string KnownIllness { get; set; }
        public string KnownAllergy { get; set; }
        public string Medications { get; set; }
        public string ReferredBy { get; set; }
        public string FamilyHistory { get; set; }
        public string SocioEconomicStatus { get; set; }
        public string Diet { get; set; }
        public Nullable<bool> IsSmoker { get; set; }
        public string SmokingInfo { get; set; }
        public Nullable<bool> IsAlchoholic { get; set; }
        public string AlchoholInfo { get; set; }
        public string MedicalInsurance { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
    }
}