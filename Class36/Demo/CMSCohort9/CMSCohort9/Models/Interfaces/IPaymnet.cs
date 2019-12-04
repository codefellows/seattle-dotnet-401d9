using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSCohort9.Models.Interfaces
{
    public interface IPayment
    {
        void Run(double total);
    }
}
