using System;

namespace CodeTenorSchool.Entities
{
    public class DomainEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public DomainEntity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
        }
    }
}
