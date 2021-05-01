namespace DemoApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhachHang
    {
        [Key]
        public string MaKhachHang { get; set; }

        public string TenKhachHang { get; set; }
    }
}
