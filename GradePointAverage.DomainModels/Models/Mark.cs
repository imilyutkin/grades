using System.ComponentModel.DataAnnotations;
using GradePointAverage.BaseRepository.Entity.Impl;

namespace GradePointAverage.DomainModels.Models
{
    public class Mark : BaseEntity
    {
        [Required]
        public int Value
        {
            get;
            set;
        }

        [Required]
        public Subject Subject
        {
            get;
            set;
        }
    }
}
