﻿using ABS.Domain.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Domain.Entities.Bookings.Events;

public sealed record BookingCanceledDomainEvent(Guid BookingId) : IDomainEvent;
