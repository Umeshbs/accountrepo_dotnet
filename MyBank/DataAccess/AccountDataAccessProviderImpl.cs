using MyBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBank.DataAccess
{
    public class AccountDataAccessProviderImpl : IAccountDataAccessProvider
    {

        private readonly AccountSqlContext _context;

        public AccountDataAccessProviderImpl(AccountSqlContext context)
        {
            _context = context;
        }

        public void addAccount(Account account)
        {
            _context.account.Add(account);
            _context.SaveChanges();
        }

        public void deleteAccount(int ID)
        {
            var entity = _context.account.FirstOrDefault(t => t.accountno == ID);
            _context.account.Remove(entity);
            _context.SaveChanges();
        }

        public Account getAccountByID(int ID)
        {
            return _context.account.FirstOrDefault(t => t.accountno == ID);
        }

        public List<Account> getAllAccounts()
        {
            return _context.account.ToList();
        }

        public void updateAccount(Account account)
        {
            _context.account.Update(account);
            _context.SaveChanges();
        }
    }
}
