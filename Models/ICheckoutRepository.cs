using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    public interface ICheckoutRepository
    {

        IQueryable<Checkout> Checkouts { get; }

        public void SaveCheckout(Checkout checkout);
    }
}
