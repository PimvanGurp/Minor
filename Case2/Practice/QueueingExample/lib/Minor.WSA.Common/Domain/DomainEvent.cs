﻿
using System;

namespace Minor.WSA.Common.Domain
{
    public abstract class DomainEvent
    {
        public readonly Guid Guid;
        public readonly DateTime Timestamp;

        public DomainEvent()
        {
            Guid = Guid.NewGuid();
            Timestamp = DateTime.Now;
        }
    }
}
