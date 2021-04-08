using Seção_9___Aula_123___Exercício.Entities;

namespace Seção_9___Aula_123___Exercício.Entities {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() {
        }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

    }
}
