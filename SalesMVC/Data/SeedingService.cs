using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesMVC.Models;
using SalesMVC.Models.Enums;

namespace SalesMVC.Data
{
    public class SeedingService 
    {
        private SalesMVCContext _context;

        public SeedingService(SalesMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Sales");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");
            Department d5 = new Department(5, "Management");

            Seller s2 = new Seller(2, "Dwight Schrute", "beetss@dudermifflin.com", new DateTime(1970, 01, 20), 3000.0, d1);
            Seller s3 = new Seller(3, "Stanley Hudson", "stanleyhudson@dudermifflin.com", new DateTime(1951, 07, 14), 3000.0, d1);
            Seller s4 = new Seller(4, "Andy Bernard", "narddog@dudermifflin.com", new DateTime(1973, 02, 09), 3000.0, d1);
            Seller s5 = new Seller(5, "Phyllis Vance", "prhylisg@dudermifflin.com", new DateTime(1954, 06, 16), 3000.0, d1);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2005, 09, 25), 1000.0, SalesStatus.Billed, s2);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2005, 09, 25), 1000.0, SalesStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2005, 09, 25), 5000.0, SalesStatus.Billed, s2);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2005, 09, 25), 3000.0, SalesStatus.Billed, s2);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2005, 09, 25), 7000.0, SalesStatus.Billed, s2);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2005, 09, 25), 1000.0, SalesStatus.Billed, s2);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2007, 09, 25), 1000.0, SalesStatus.Billed, s3);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2007, 09, 25), 7000.0, SalesStatus.Billed, s3);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2007, 09, 25), 3000.0, SalesStatus.Billed, s3);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2007, 09, 25), 8000.0, SalesStatus.Billed, s3);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2005, 11, 25), 3000.0, SalesStatus.Billed, s5);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2006, 11, 25), 4000.0, SalesStatus.Billed, s5);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2006, 11, 25), 500.0, SalesStatus.Billed, s5);

            _context.Department.AddRange(d1, d2, d3, d4, d5);
            _context.Seller.AddRange(s2, s3, s4, s5);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, sr11, sr12, sr13);

            _context.SaveChanges();
        }
    }
}
