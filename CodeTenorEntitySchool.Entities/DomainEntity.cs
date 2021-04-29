using System;

namespace CodeTenorSchool.Entities
{
    public class DomainEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public DomainEntity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
            LastModifiedDate = DateTime.UtcNow;
        }

        public void UpdateModifiedDate()
        {
            LastModifiedDate = DateTime.UtcNow;
        }
    }
}
