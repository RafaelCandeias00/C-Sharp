using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_15___Aula_212___Exercício.Entities {
    class CodeStudents {
        public int Code { get; set; }

        public CodeStudents(int codStudent) {
            Code = codStudent;
        }

        public override int GetHashCode() {
            return Code.GetHashCode();
        }
        public override bool Equals(object obj) {
            if (!(obj is CodeStudents)) {
                return false;
            }
            CodeStudents other = obj as CodeStudents;
            return Code.Equals(other.Code);
        }
    }
}
