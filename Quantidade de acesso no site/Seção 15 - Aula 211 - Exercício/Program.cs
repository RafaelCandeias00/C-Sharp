using System;
using System.Collections.Generic;
using System.IO;
using Seção_15___Aula_211___Exercício.Entities;

namespace Seção_15___Aula_211___Exercício {
    class Program {
        static void Main(string[] args) {

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { UserName = name, Instant = instant });
                        Console.WriteLine(line);
                    }
                    Console.WriteLine($"Total users: {set.Count}");
                }
            } catch (IOException e){
                Console.WriteLine(e.Message);
            }

        }
    }
}
