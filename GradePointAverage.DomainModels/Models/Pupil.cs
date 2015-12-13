using System;
using System.Collections.Generic;
using GradePointAverage.BaseRepository.Entity.Impl;

namespace GradePointAverage.DomainModels.Models
{
    public class Pupil : BaseEntity
    {
        public String  Name
        {
            get;
            set;
        }

        public List<Mark> Marks
        {
            get;
            set;
        } 
    }
}
