using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_PaymentService.Models;

namespace MOD_PaymentService.Repositories
{
    public interface IPaymentRepository
    {
        List<Payment> GetPayment_dtls();
       
        void AddPayment(Payment item);


    }
}
