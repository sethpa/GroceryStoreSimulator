﻿/*****************************************************************
 * Grocery Store Simulator
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * University of Cincinnati Clermont College
 * ***************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorNamespace
{
    public class ShoppingCartItem {
        private int mProductID;
        private int mQty;
        private String mComment;

        public ShoppingCartItem(int productID, int qty, String comment) {
            this.productD = productD;
            this.qty = qty;
            this.comment = comment;
        }

        public int productD { get; set; }
        public int qty { get; set; }
        public String comment { get; set; }


    }
}
