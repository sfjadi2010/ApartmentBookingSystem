﻿namespace ABS.Domain.Entities.Shared;

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

    public static Money Zero(Currency currency) => new Money(0, currency);

    public bool IsZero() => this == Zero(Currency);
}
