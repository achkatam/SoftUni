namespace Facade
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BlackList
    {
        public BlackList()
        {
            BlackListedAccounts = new List<Account>();
        }
        public List<Account> BlackListedAccounts { get; set; }

        public bool CheckIfAccountIsBlackListed(Account accToBeChecked)
        {
            //if acc is in the list return true;

            return false;
        }
    }
}
