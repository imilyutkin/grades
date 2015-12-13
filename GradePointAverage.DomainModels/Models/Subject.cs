using System;
using System.ComponentModel.DataAnnotations;
using GradePointAverage.BaseRepository.Entity.Impl;

namespace GradePointAverage.DomainModels.Models
{
    public class Subject : BaseEntity
    {
        [Required]
        public String Name
        {
            get;
            set;
        }

        public bool IsRequired
        {
            get;
            set;
        }
    }
}
