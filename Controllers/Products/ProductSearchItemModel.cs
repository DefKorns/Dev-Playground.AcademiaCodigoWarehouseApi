using System;

namespace AcademiaCodigoWarehouseApi.Controllers.Products
{
    public class ProductSearchItemModel {

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CurrentStock { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

        public Guid Version  { get; set; }
    }
}