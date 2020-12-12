using beadando.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando.Abstractions
{

    public interface IAccountManager
    {
        BindingList<Account> Accounts { get; }

        Account CreateAccount(Account account);
    }
}
