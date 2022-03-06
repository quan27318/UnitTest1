using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace UnitTest.Models{
    [Table("Person Class")]
    public class Person{
        [Key]
        public int StudentID{get; set;}

        [Column("Student Name", TypeName ="ntext")]
        [MaxLength(200)]
        public string StudentName{get;set;}
        [Column("Age", TypeName ="ntext")]
        [MaxLength(20)]
        public string Age{get;set;}
        [Column("Address", TypeName ="ntext")]
        [MaxLength(200)]
        public string Address{get;set;}
    }
}