﻿using Common.Command;
using eMobile.Phones.Models.Dtos;
using System.Collections.Generic;

namespace eMobile.Phones.Models.Commands
{
    public class CreatePhoneCommand : ICommand
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public PhoneDimensions Dimensions { get; set; }
        public List<PhoneMedia> Media { get; set; }
        public PhoneDisplay Display { get; set; }
        public double Weight { get; set; }
        public string CPUModel { get; set; }
        public int RAM { get; set; }
        public string OS { get; set; }
        public double Price { get; set; }
    }
}
