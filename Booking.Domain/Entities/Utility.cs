﻿using Booking.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.Entities
{
    public class Utility : Entity
    {
        public int LocationId { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }
        public bool IsDefault { get; private set; }
        public virtual Location Location { get; private set; }
        public virtual ICollection<BookingUtility> BookingUtilities { get; private set; }
    }
}
