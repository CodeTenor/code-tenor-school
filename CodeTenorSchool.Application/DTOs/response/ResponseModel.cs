using CodeTenorSchool.Entities;
using Newtonsoft.Json;
using System;

namespace CodeTenorSchool.Application.DTOs.response
{
    public class ResponseModel
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("lastModifiedDate")]
        public DateTime LastModifiedDate { get; set; }

        public ResponseModel(DomainEntity domainEntity)
        {
            Id = domainEntity.Id;
            CreatedDate = domainEntity.CreatedDate;
            LastModifiedDate = domainEntity.LastModifiedDate;
        }
    }
}
