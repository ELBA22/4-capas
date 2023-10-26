using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly NewAppContext _context;
        private RolRepository _roles;
        public UnitOfWork(NewAppContext context)
        {
            _context = context;
        }
        private UserRepository _users;
        public IRol Rols
        {
            get
            {
                if (_roles == null)
                {
                    _roles = new RolRepository(_context);
                }
                return _roles;
            }
        }
        public IUser Users
        {
            get
            {
                if(_users == null)
                {
                    _users = new UserRepository(_context);
                }
                return _users;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}