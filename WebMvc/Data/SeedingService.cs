using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;
using WebMvc.Models.Enums;

namespace WebMvc.Data
{
    public class SeedingService
    {
        private WebMvcContext _context;

        public SeedingService(WebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.SalesRecord.Any() ||
                _context.Seller.Any())
            {
                return;
            }

            Department computers = new Department(1, "Computers");
            Department electronics = new Department(2, "Electronics");
            Department books = new Department(3, "Books");
            Department smartphones = new Department(4, "Smartphones");
            Department fashion = new Department(5, "Fashion");

            Seller seller1 = new Seller(1, "Bob", "bob@gmail.com", new DateTime(1996, 4, 20), 1400, books);
            Seller seller2 = new Seller(2, "Alex", "alex@gmail.com", new DateTime(1992, 1, 13), 1700, computers);
            Seller seller3 = new Seller(3, "Jimmy", "jimmy@gmail.com", new DateTime(1985, 7, 11), 1700, smartphones);
            Seller seller4 = new Seller(4, "Michael", "michael@gmail.com", new DateTime(1995, 11, 3), 1400, books);
            Seller seller5 = new Seller(5, "Ashley", "ash@gmail.com", new DateTime(1996, 2, 18), 1700, electronics);
            Seller seller6 = new Seller(6, "Lucy", "lucy@gmail.com", new DateTime(1990, 6, 11), 1500, fashion);

            SalesRecord s1 = new SalesRecord(1, new DateTime(2018, 03, 20), 2300, SaleStatus.Billed, seller2);
            SalesRecord s2 = new SalesRecord(2, new DateTime(2017, 07, 10), 1300, SaleStatus.Pending, seller2);
            SalesRecord s3 = new SalesRecord(3, new DateTime(2016, 08, 21), 300, SaleStatus.Billed, seller3);
            SalesRecord s4 = new SalesRecord(4, new DateTime(2018, 07, 23), 2600, SaleStatus.Billed, seller4);
            SalesRecord s5 = new SalesRecord(5, new DateTime(2018, 07, 11), 2150, SaleStatus.Pending, seller5);
            SalesRecord s6 = new SalesRecord(6, new DateTime(2018, 07, 8), 2220, SaleStatus.Canceled, seller6);
            SalesRecord s7 = new SalesRecord(7, new DateTime(2018, 06, 8), 800, SaleStatus.Pending, seller6);
            SalesRecord s8 = new SalesRecord(8, new DateTime(2018, 02, 8), 9300, SaleStatus.Billed, seller6);
            SalesRecord s9 = new SalesRecord(9, new DateTime(2017, 11, 28), 1300, SaleStatus.Billed, seller5);
            SalesRecord s10 = new SalesRecord(10, new DateTime(2017, 11, 30), 370, SaleStatus.Canceled, seller4);
            SalesRecord s11 = new SalesRecord(11, new DateTime(2017, 11, 25), 199, SaleStatus.Pending, seller5);
            SalesRecord s12 = new SalesRecord(12, new DateTime(2017, 12, 12), 45, SaleStatus.Billed, seller3);
            SalesRecord s13 = new SalesRecord(13, new DateTime(2017, 2, 22), 72, SaleStatus.Billed, seller2);
            SalesRecord s14 = new SalesRecord(14, new DateTime(2017, 3, 4), 130, SaleStatus.Billed, seller1);
            SalesRecord s15 = new SalesRecord(15, new DateTime(2017, 4, 4), 1700, SaleStatus.Pending, seller1);
            SalesRecord s16 = new SalesRecord(16, new DateTime(2019, 4, 4), 1690, SaleStatus.Pending, seller1);
            SalesRecord s17 = new SalesRecord(17, new DateTime(2019, 4, 6), 1430, SaleStatus.Pending, seller5);
            SalesRecord s18 = new SalesRecord(18, new DateTime(2019, 8, 6), 4999, SaleStatus.Pending, seller6);
            SalesRecord s19 = new SalesRecord(19, new DateTime(2019, 8, 26), 1420, SaleStatus.Billed, seller6);
            SalesRecord s20 = new SalesRecord(20, new DateTime(2019, 9, 26), 27, SaleStatus.Billed, seller6);
            SalesRecord s21 = new SalesRecord(21, new DateTime(2019, 4, 26), 72, SaleStatus.Billed, seller5);
            SalesRecord s22 = new SalesRecord(22, new DateTime(2018, 4, 15), 1100, SaleStatus.Canceled, seller4);
            SalesRecord s23 = new SalesRecord(23, new DateTime(2018, 2, 12), 1000, SaleStatus.Billed, seller4);
            SalesRecord s24 = new SalesRecord(24, new DateTime(2017, 1, 13), 475, SaleStatus.Canceled, seller5);
            SalesRecord s25 = new SalesRecord(25, new DateTime(2017, 2, 20), 300, SaleStatus.Billed, seller2);

            _context.Department.AddRange(computers, electronics, fashion, books, smartphones);
            _context.Seller.AddRange(seller1, seller2, seller3, seller4, seller5, seller6);
            _context.SalesRecord.AddRange(
                s1, s2, s3, s4, s5, s6, s7, s8, s9, s10,
                s11, s12, s13, s14, s15, s16, s17, s18, s19, s20,
                s21, s22, s23, s24, s25);

            _context.SaveChanges();
        }
    }
}
