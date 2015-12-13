using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GradePointAverage.BaseRepository.Entity.Contracts;

namespace GradePointAverage.BaseRepository.Entity.Impl
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
    }
}
