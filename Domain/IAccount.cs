using System;

public interface IAccount
{

    public void AddTransaction(decimal amount);

    public int GetRewardPoints(string accountName);
    public decimal GetBalance(string accountName);

    /// <summary>
    /// Implemented in the child classes
    /// </summary>
    /// <param name="amount"></param>
    /// <returns></returns>
    public abstract int CalculateRewardPoints(decimal amount);
}
