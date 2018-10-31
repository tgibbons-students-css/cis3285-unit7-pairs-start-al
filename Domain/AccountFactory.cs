using System;

/**
 * Static class to allow use of CreateAccount. As this class simply creates accounts and does not need to access fields,
 * it makes more sense to have a class that does not need to be instantiated to access methods.
 **/
public static class AccountFactory : IAccount
{
    public static AccountBase CreateAccount(AccountType type)
    {
        AccountBase account = null;
        switch (type)
        {
            case AccountType.Silver:
                account = new SilverAccount();
                break;
            case AccountType.Gold:
                account = new GoldAccount();
                break;
            case AccountType.Platinum:
                account = new PlatinumAccount();
                break;
        }
        return account;
    }

}
