using System;
using System.ComponentModel.DataAnnotations;

namespace AcademiaCodigoWarehouseApi.Controllers.Products {
    public class ActivateProductModel {
        [Required]
        public Guid Version { get; set; }
    }
}