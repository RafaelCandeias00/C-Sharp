using System;

namespace Alugando_quartos {
    class DadosEstudantes {
        public string Name { get; set; }
        public string Email { get; set; }

        public DadosEstudantes(string name, string email) {
            Name = name;
            Email = email;
        }

        public override string ToString() {
            return $"{Name}, {Email}";
        }
    }
}
