using CodeTenorSchool.Entities;
using Newtonsoft.Json;
using System;

namespace CodeTenorSchool.Application.DTOs.response
{
    public class UserResponseModel
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("idNo")]
        public string IdNo { get; set; }

        public UserResponseModel(User person)
        {
            Id = person.Id;
            Name = person.Name;
            Surname = person.Surname;
            Age = person.Age;
            IdNo = person.IdNo;
        }
    }
}
