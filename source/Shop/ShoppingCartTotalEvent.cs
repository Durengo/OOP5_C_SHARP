using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Shop
{
    public delegate float ShoppingCartChanged(float amount);

    public class ShoppingCartTotalEvent
    {
        private float TotalPrice;
        event ShoppingCartChanged CartModified;

        public ShoppingCartTotalEvent()
        {
            TotalPrice = 0.0f;
            this.CartModified += new ShoppingCartChanged(this.ChangeTotalPrice);
        }

        public float ChangeTotalPrice(float amount)
        {
            // if (amount < 0)
            // {
            //     TotalPrice -= Math.Abs(amount);
            // }
            // else
            // {
            //     TotalPrice += amount;
            // }
            return TotalPrice += amount;
        }

        public float TotalCartAmount
        {
            get { return TotalPrice; }
            set { TotalPrice = value; }
        }
    }
}
