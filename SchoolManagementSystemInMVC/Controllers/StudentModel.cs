using System;

namespace SchoolManagementSystemInMVC.Controllers
{
    internal class StudentModel
    {
        public string FirstName { get; internal set; }
        public object StudentID { get; internal set; }
        public object LastName { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }
        public object Gender { get; internal set; }
        public int ClassID { get; internal set; }
        public int SubjectID { get; internal set; }
    }
}