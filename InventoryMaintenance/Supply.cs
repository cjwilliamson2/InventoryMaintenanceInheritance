﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Supply : InventoryItem
    {
        public Supply() { }

        public Supply(int itemNo, string description, decimal price, string manufacturer) : base(itemNo, description, price)
        {
            Manufacturer = manufacturer;
        }

        public string Manufacturer { get; set; } = "";

        public override string GetDisplayText() => $"{ItemNo}    {Manufacturer} {Description} ({Price:c})";
    }
}
