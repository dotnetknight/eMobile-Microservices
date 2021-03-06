﻿using eMobile.Orders.Domain.PhonesEntity;
using System;

namespace eMobile.Orders.Domain.DimensionsEntity
{
    public class Dimensions : BaseEntity
    {
        public Phone Phone { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Guid PhoneId { get; set; }
    }
}
