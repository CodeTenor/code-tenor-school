namespace CodeTenorSchool.Entities
{
    public class User: DomainEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string IdNo { get; set; }

        public User(string name, string surname, int age, string idNo)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IdNo = idNo;
        }

        public void UpdatePersonalDetails(string name = null, string surname = null, int? age = null, string idNo = null)
        {
            if (name != null)
            {
                Name = name;
            }

            if (surname != null)
            {
                Surname = surname;
            }

            if (age != null)
            {
                Age = age.Value;
            }

            if (idNo != null)
            {
                IdNo = idNo;
            }
        }
    }
}
