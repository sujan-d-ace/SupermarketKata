using SupermarketKata.Entity;
using System.Collections.Generic;

namespace SupermarketKata.Services.Interface
{
    public interface ICheckout
    {
        List<Items> Scan(string item);
        int GetTotalPrice();
    }
}
