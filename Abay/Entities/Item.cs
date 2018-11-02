﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Item
    {
        private int _id;
        private string _name;
        private string _description;
        private double _initialPrice;
        private double _finalPrice;
        private DateTime _startDate;
        private DateTime _endDate;
        private int _state;
        private User _sellerUser;
        private User _buyerUser;
        private ItemCategory _category;

        public Item()
        { 

        }

        public Item(string name, double initialPrice, int state, User seller, ItemCategory categoryId)
        {
            Name = name;
            InitialPrice = initialPrice;
            State = state;
            SellerUser = seller;
            Category = categoryId;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public double InitialPrice { get => _initialPrice; set => _initialPrice = value; }
        public double FinalPrice { get => _finalPrice; set => _finalPrice = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
        public int State { get => _state; set => _state = value; }
        public User SellerUser { get => _sellerUser; set => _sellerUser = value; }
        public User BuyerUser { get => _buyerUser; set => _buyerUser = value; }
        public ItemCategory Category { get => _category; set => _category = value; }
        
    }
}
