using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_14___Aula_199___Exercício.Services {
    interface IOnlinePaymentService {
        public abstract double PaymentFee(double amount);
        public abstract double Interest(double amount, int months);
    }
}
