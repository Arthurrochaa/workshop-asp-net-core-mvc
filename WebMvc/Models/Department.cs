﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace WebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Seller> sellers = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
