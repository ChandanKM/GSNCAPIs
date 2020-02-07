using System;
using System.Collections.Generic;
using System.Text;

namespace GSCN.Dto
{
    public class DtoBankInfo
    {
        public string BankName { get; set; }

        public string BankCode { get; set; }

        public string AccountName { get; set; }

        public string BranchName { get; set; }

        public string AccountNumber { get; set; }

        public string BranchEmail { get; set; }

        public string IFSCCode { get; set; }

        public string MICRCode { get; set; }

        public bool Notification { get; set; }

    }

    public class DtoFeesAndTiming
    {
        //Design accordingly using the screen level.
        public string HospitalName { get; set; }

        public string Specialization { get; set; }

        public string MyProperty { get; set; }

    }

    public class DtoDoctor
    {
        public string Title { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Specialization { get; set; }

        public int MyProperty { get; set; }

        public DateTime RegisteredYear { get; set; }

        public string RegistrationNo { get; set; }

        public string InternationalBoard { get; set; }

        public int Experience { get; set; }

        public int Country { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Gender { get; set; }

        public string AboutMe { get; set; }

        public List<DtoBankInfo> DtoBankInformations { get; set; }

        public List<DtoEducationalDetails> DtoEducationalDetails { get; set; }

        public List<DtoContactDetails> DtoContactInfo { get; set; }

        public List<DtoFeesAndTiming> DtoFeesAndTimings { get; set; }

        public List<DtoExperience> DtoExperienceDetails { get; set; }

        public List<DtoOtherInformation> DtoOtherInformation { get; set; }

    }

    public class DtoEducationalDetails
    {
        public int EducationalId { get; set; }

        public string Qualification { get; set; }

        public string College { get; set; }

        public DateTime PassOutYear { get; set; }

    }

    public class DtoContactDetails
    {
        public int ContactId { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string City { get; set; }

        public string LandMark { get; set; }

        public string PostalCode { get; set; }

        public string District { get; set; }

    }


    public class DtoExperience
    {
        public int ExperId { get; set; }

        public int Organization { get; set; }

        public int Designation { get; set; }

        public DateTime FromDate { get; set; }

        public bool Current { get; set; }

        public DateTime ToDate { get; set; }

    }

    public class DtoOtherInformation
    {
        public int OtherId { get; set; }

        public string Speciality { get; set; }

        public string Expertise { get; set; }

        public string ResearchAwards { get; set; }

        public string Others { get; set; }
    }


}
