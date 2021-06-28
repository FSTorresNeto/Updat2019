using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {

            _context = context;
        }
        public void Seed()
        {
            if(_context.Department.Any()||
                    _context.Seller.Any() ||
                    _context.SalesRercod.Any())
            {
                return;
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "TI");

            Seller s1 = new Seller(1, "Torres Neto1", "torres2gmail.com1", 10001.0, new DateTime(1998, 4, 21), d1);

            Seller s2 = new Seller(2, "Torres Neto2", "torres2gmail.com2", 10002.0, new DateTime(1998, 4, 21), d1);

            Seller s3 = new Seller(3, "Torres Neto3", "torres2gmail.com3", 10003.0, new DateTime(1998, 4, 21), d1);

            Seller s4 = new Seller(4, "Torres Neto4", "torres2gmail.com4", 10004.0, new DateTime(1998, 4, 21), d2);

            Seller s5 = new Seller(5, "Torres Neto5", "torres2gmail.com5", 10005.0, new DateTime(1998, 4, 21), d2);

            Seller s6 = new Seller(6, "Torres Neto6", "torres2gmail.com6", 10006.0, new DateTime(1998, 4, 21), d2);

            SalesRecords r1 = new SalesRecords(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecords r2 = new SalesRecords(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecords r3 = new SalesRecords(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecords r4 = new SalesRecords(4, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecords r5 = new SalesRecords(5, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecords r6 = new SalesRecords(6, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecords r7 = new SalesRecords(7, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecords r8 = new SalesRecords(8, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecords r9 = new SalesRecords(9, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecords r10 = new SalesRecords(10, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecords r11 = new SalesRecords(11, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecords r12 = new SalesRecords(12, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecords r13 = new SalesRecords(13, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecords r14 = new SalesRecords(14, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecords r15 = new SalesRecords(15, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecords r16 = new SalesRecords(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecords r17 = new SalesRecords(17, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecords r18 = new SalesRecords(18, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecords r19 = new SalesRecords(19, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecords r20 = new SalesRecords(20, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecords r21 = new SalesRecords(21, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecords r22 = new SalesRecords(22, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecords r23 = new SalesRecords(23, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecords r24 = new SalesRecords(24, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecords r25 = new SalesRecords(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecords r26 = new SalesRecords(26, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecords r27 = new SalesRecords(27, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecords r28 = new SalesRecords(28, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecords r29 = new SalesRecords(29, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecords r30 = new SalesRecords(30, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s2);


            _context.Department.AddRange(d1, d2);

            _context.Seller.AddRange(s1,s2,s3,s4,s5,s6);

            _context.SalesRercod.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();

        }
    }
}
