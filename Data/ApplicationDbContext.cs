using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CayLapBu.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CayLapBu.Models.TXTLopHoc> TXTLopHoc { get; set; } = default!;

        public DbSet<CayLapBu.Models.TXTSinhVien> TXTSinhVien { get; set; } = default!;
    }
