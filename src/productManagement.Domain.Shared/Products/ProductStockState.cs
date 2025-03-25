using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productManagement.Products
{
    public enum ProductStockState : byte
    {
        Preorder,
        InStock,
        NotAvailable,
        Stopped
    }
}
