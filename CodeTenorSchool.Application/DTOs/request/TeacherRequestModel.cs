using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CodeTenorSchool.Application.DTOs.request
{
    public struct TeacherRequestModel : IRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("idNo")]
        public string IdNo { get; set; }

        [JsonProperty("courses")]
        public List<Guid> Courses { get; set; }
    }
}
