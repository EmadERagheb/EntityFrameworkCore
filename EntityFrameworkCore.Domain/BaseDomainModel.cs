using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCore.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        //SQL Server Only
        //[Timestamp]
        //byte[] Version { get; set; }

        [ConcurrencyCheck]
        public Guid Version { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
