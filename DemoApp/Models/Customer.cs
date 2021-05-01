namespace DemoApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [Key]
        public string KhachHangID { get; set; }

        public string TenKhanhhang { get; set; }

        public string SoDienThoai { get; set; }

        public string DiaChi { get; set; }
    }
}
