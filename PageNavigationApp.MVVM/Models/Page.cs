﻿namespace PageNavigationApp.MVVM.Models
{
    public class Page
    {
        public int CustomerCount { get; set; }
        public string? ProductStatus { get; set; }
        public DateOnly OrderDate { get; set; }
        public decimal TransactionValue { get; set; }
        public TimeOnly ShipmentDelivery { get; set; }
        public bool LocationStatus { get; set; }
    }
}
