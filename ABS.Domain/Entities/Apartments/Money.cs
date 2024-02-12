using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Domain.Entities.Apartments
{
    public record Money(decimal Amount, Currency Currency)
    {
        public static Money operator +(Money left, Money right)
        {
            if (left.Currency != right.Currency)
            {
                throw new InvalidOperationException("Cannot add money in different currencies");
            }
            return new Money(left.Amount + right.Amount, left.Currency);
        }

        public static Money operator -(Money left, Money right)
        {
            if (left.Currency != right.Currency)
            {
                throw new InvalidOperationException("Cannot subtract money in different currencies");
            }
            return new Money(left.Amount - right.Amount, left.Currency);
        }

        public static Money Zero() => new Money(0, Currency.None);
    }
}
