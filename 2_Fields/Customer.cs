using System;
using System.Collections.Generic;

namespace _2_Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();


        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, String name)
            : this(id)
        {
            this.Name = name;
        }
        public void Promote()
        {
            // ....
        }
    }
}
