using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        object Users { get; }
        object Rols { get; set; }

        Task<int> SaveAsync();
    }
}