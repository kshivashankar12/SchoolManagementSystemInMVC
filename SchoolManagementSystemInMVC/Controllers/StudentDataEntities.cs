using System;

namespace SchoolManagementSystemInMVC.Controllers
{
    internal class StudentDataEntities
    {
        public object Subjects { get; internal set; }
        public object Students { get; internal set; }
        public object Classes { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}