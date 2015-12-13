using System.Collections.Generic;
using GradePointAverage.BaseRepository.Entity.Impl;

namespace GradePointAverage.DomainModels.Models
{
    public class School : BaseEntity
    {
        public List<Pupil> Pupils
        {
            get;
            set;
        } 
    }
}
