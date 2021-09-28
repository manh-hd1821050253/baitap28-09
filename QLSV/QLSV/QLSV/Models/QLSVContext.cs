using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QLSV.Models
{
    public partial class QLSVContext : DbContext
    {
        // tạo ra sợ dây kết nối entity
        static string ketnoidatabase = "name=QLSVContext"; // name trùng với tên của class
        public QLSVContext() :  base(ketnoidatabase)
        {

        }
        public virtual DbSet<SinhVien> Sinhviens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>().Property(sv => sv.Tensv).IsUnicode(true);
        }
    }
}