﻿using My.CrossCuttingConcerns.CircuitBreakers;
using System;

namespace My.Persistence.CircuitBreakers
{
    public class CircuitBreakerLog
    {
        public Guid Id { get; set; }

        public Guid CircuitBreakerId { get; set; }

        public CircuitStatus Status { get; set; }

        public bool Succeeded { get; set; }

        public DateTimeOffset CreatedDateTime { get; set; }
    }
}
