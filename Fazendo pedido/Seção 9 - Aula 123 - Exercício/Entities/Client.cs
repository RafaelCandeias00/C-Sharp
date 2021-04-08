using System;

namespace Seção_9___Aula_123___Exercício.Entities {
    class Client {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() {
        }

        public Client(string name, string email, DateTime birthDate) {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString() {
            return $"Name: {Name}," +
                $"{BirthDate.ToString("dd/mm/yyyy")} - " +
                $"{Email}";
        }
    }
}
