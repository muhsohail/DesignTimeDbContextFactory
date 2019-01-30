using System;

namespace Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string StudentId { get; set; }
        public string ClassName { get; set; }

        public int Age { get; set; }
    }
}
