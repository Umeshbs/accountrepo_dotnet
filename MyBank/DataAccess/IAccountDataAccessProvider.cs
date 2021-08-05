using MyBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBank.DataAccess
{
    public interface IAccountDataAccessProvider
    {
        public void addAccount(Account account);

        public List<Account> getAllAccounts();

        public Account getAccountByID(int ID);

        public void updateAccount(Account account);

        public void deleteAccount(int ID);
    }
}
