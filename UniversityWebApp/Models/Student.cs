using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString() => $"Id : {Id} , Name : {Name} , Age : {Age} , Email : {Email} , ImageUrl : {ImageUrl}";

    }
}
