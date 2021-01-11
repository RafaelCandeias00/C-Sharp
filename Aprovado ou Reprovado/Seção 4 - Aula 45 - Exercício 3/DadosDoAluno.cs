using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_4___Aula_45___Exercício_3 {
    class DadosDoAluno {
        public string nomeAluno;
        public double notaAluno1;
        public double notaAluno2;
        public double notaAluno3;

        public double notaFinal() {
            return notaAluno1 + notaAluno2 + notaAluno3;
        }

        public bool Aprovado() {
            if (notaFinal() >= 60.0) {
                return true;
            } else {
                return false;
            }
        }
        public double notaRestante() {
            if (Aprovado()) {
                return 0.0;
            } else {
                return 60.0 - notaFinal();
            }
        }

    }
}
