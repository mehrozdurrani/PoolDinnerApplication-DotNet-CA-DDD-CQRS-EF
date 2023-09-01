﻿using PoolDinner.Domain.Models;

namespace PoolDinner.Domain.DinnerAggregate.ValueObjects
{
    public sealed class ReservationId : ValueObject
    {
        public Guid Value;

        private ReservationId(Guid value)
        {
            Value = value;
        }

        public static ReservationId CreateUnique()
        {
            return new(Guid.NewGuid());
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}

