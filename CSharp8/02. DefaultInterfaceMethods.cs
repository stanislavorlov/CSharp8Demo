using System;

namespace CSharp8
{
    internal sealed class DefaultInterfaceMethods
    {
        public interface IOrder
        {
            private static readonly decimal discountPercent = 0.10m;
            DateTime Purchased { get; }
            decimal Cost { get; }

            protected static decimal DefaultLoyaltyDiscount(IOrder order)
            {
                if ((order.Purchased < DateTime.UtcNow.AddDays(-14)) && order.Cost > 1000.0M)
                {
                    return discountPercent;
                }

                return 0;
            }

            public decimal ComputeLoyaltyDiscount()
            {
                return IOrder.DefaultLoyaltyDiscount(this);
            }

            public decimal ComputeLoyaltyDiscount(decimal discount)
            {
                return discount;
            }

        }

        public class ProductOrder : IOrder
        {
            public DateTime Purchased => DateTime.UtcNow;

            public decimal Cost => new decimal(Math.Round(new Random().NextDouble(), 2));
        }

        public class AssetOrder: IOrder
        {
            public DateTime Purchased => DateTime.UtcNow;

            public decimal Cost => new decimal(Math.Round(new Random().NextDouble(), 2));

            public decimal ComputeLoyaltyDiscount()
            {
                return new decimal(Math.Round(new Random().NextDouble(), 2));
            }
        }

        public static void Run()
        {
            IOrder productOrder = new ProductOrder();
            productOrder.ComputeLoyaltyDiscount();

            IOrder assetOrder = new AssetOrder();
            assetOrder.ComputeLoyaltyDiscount();
        }
    }
}
