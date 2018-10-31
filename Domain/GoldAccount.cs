using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class GoldAccount : IAccount
    {
        /// <summary>
        /// 1 point for each $5 deposited
        /// 1 point for each $2,000 in account balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override int CalculateRewardPoints(decimal amount)
        {
            return (int)decimal.Floor((Balance / GoldBalanceCostPerPoint) + (amount / GoldTransactionCostPerPoint));
        }


        /**
         * Add Transaction Method as required by classes implementing IAccount interface.
        */
        public void AddTransaction(decimal amount)
        {
            // only award reward points on deposit
            if (amount>0) RewardPoints += CalculateRewardPoints(amount);
            // always update balance
            Balance += amount;
        }

        private const int GoldTransactionCostPerPoint = 5;
        private const int GoldBalanceCostPerPoint = 2000;
    }
}

