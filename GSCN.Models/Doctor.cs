using System;
using System.Collections.Generic;

namespace GSCN.Models
{
    public class BankInfo
    {
        public int BankinfoId { get; set; }

        public string BankName { get; set; }

        public string BankCode { get; set; }

        public string AccountName { get; set; }

        public string BranchName { get; set; }

        public string AccountNumber { get; set; }

        public string BranchEmail { get; set; }

        public string IFSCCode { get; set; }

        public string MICRCode { get; set; }

        public bool Notification { get; set; }

        public int DoctorId { get; set; }

    }

    public class FeesAndTiming
    {
        //Design accordingly using the screen level.
        public int FandTId { get; set; }

        public string HospitalName { get; set; }

        public string Specialization { get; set; }

        public string MyProperty { get; set; }

        public int DoctorId { get; set; }

    }

    public class Doctor
    {
        public int DoctorId { get; set; }

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

        public List<BankInfo> BankInformations { get; set; }

        public List<EducationalDetails> EducationalDetails { get; set; }

        public List<ContactDetails> ContactInfo { get; set; }

        public List<FeesAndTiming> FeesAndTimings { get; set; }

        public List<Experience> ExperienceDetails { get; set; }

        public List<OtherInformation> OtherInformation { get; set; }

    }

    public class EducationalDetails
    {
        public int EducationalId { get; set; }

        public string Qualification { get; set; }

        public string College { get; set; }

        public DateTime PassOutYear { get; set; }

        public int DoctorId { get; set; }
    }

    public class ContactDetails
    {
        public int ContactId { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string City { get; set; }

        public string LandMark { get; set; }

        public string PostalCode { get; set; }

        public string District { get; set; }

        public int DoctorId { get; set; }
    }


    public class Experience
    {
        public int ExperId { get; set; }

        public int Organization { get; set; }

        public int Designation { get; set; }

        public DateTime FromDate { get; set; }

        public bool Current { get; set; }

        public DateTime ToDate { get; set; }

        public int DoctorId { get; set; }
    }

    public class OtherInformation
    {
        public int OtherId { get; set; }

        public string Speciality { get; set; }

        public string Expertise { get; set; }

        public string ResearchAwards { get; set; }

        public string Others { get; set; }

        public int DoctorId { get; set; }
    }

    public enum DoctorType
    {
        EmpanelDoctor,
        TelemedDoctor
    }

    public enum Gender
    {
        Mail,
        Femail
    }

    public enum Specialization
    {
        Neurology,
        Urology
    }
}
