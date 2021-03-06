﻿using eMobile.Orders.Domain.PhonesEntity;
using System;

namespace eMobile.Orders.Domain.DisplayEntity
{
    public class Display : BaseEntity
    {
        public Phone Phone { get; set; }
        public double Size { get; set; }
        public int VerticalResolution { get; set; }
        public int HorizontalResolution { get; set; }
        public Guid PhoneId { get; set; }
    }
}
