﻿using Booking.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.Entities
{
    public class Location : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Address { get; private set; }
        public int BusinessId { get; private set; }
        public int CityId { get; private set; }
        public int DistrictId { get; private set; }
        public int WardsId { get; private set; }
        public bool IsActive { get; private set; }
        public virtual Wards Wards { get; private set; }
        public virtual ICollection<Room> Rooms { get; private set; }
    }
}
