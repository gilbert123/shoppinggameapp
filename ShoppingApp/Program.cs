using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class Program
    {
        class ProductMaster
        {
            public string SKU { get; set; }

            public string Name { get; set; }

            public double Price { get; set; }
        }
        static void Main(string[] args)
        {
            int choice = 0;
            bool done = false;
            int totalAppTV = 0, totalVGA=0;
            double totalBill = 0.0 ;
            string SKUScanned = string.Empty;

            List<ProductMaster> plist = new List<ProductMaster>();
            Console.WriteLine("1. ipd  |   Super iPad ");
            Console.WriteLine("2. mbp | MacBook Pro");
            Console.WriteLine("3. atv | Apple TV");
            Console.WriteLine("4.vga  | VGA adapter");
            Console.WriteLine("Enter 5 for bill");
            do
            {
                

                    Console.WriteLine("Enter the below Option");
                    choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        ProductMaster prod = new ProductMaster();
                        prod.SKU = "ipd";
                        prod.Name = "Super iPad";
                        prod.Price = 549.99;
                        plist.Add(prod);
                        done = false;
                        break;

                    case 2:
                        ProductMaster prod1 = new ProductMaster();
                        prod1.SKU = "mbp";
                        prod1.Name = "MacBook Pro";
                        prod1.Price = 1399.99;
                        plist.Add(prod1);
                        done = false;
                        break;

                    case 3:
                        ProductMaster prod2 = new ProductMaster();
                        prod2.SKU = "atv";
                        prod2.Name = "Apple TV";
                        prod2.Price=109.50;
                        plist.Add(prod2);
                        done = false;
                        break;

                    case 4:
                        ProductMaster prod3 = new ProductMaster();
                        prod3.SKU = "vga";
                        prod3.Name = "VGA adapter";
                        prod3.Price = 30.00;
                        plist.Add(prod3);
                        done = false;
                        break;

                    case 5:
                        break;
                    //default:
                    //    Console.WriteLine("Invaid Product SKU");
                    //    done = false;
                    //    break;
                }

                } while (choice < 5);

            int prodAppleCount = 0, prodIPadCount = 0, prodMacCount = 0,prodVGAAdpCount=0;
            double TVPrice=0.0, VGAPrice=0.0;

          if(plist.Count >0)
            {
               foreach(var item in plist)
                {
                    if(item.SKU=="atv")
                    {
                        prodAppleCount++;
                    }
                    if(item.SKU== "ipd")
                    {
                        prodIPadCount++;
                    }
                    if(item.SKU== "mbp")
                    {
                        prodMacCount++;
                    }
                    if(item.SKU=="vga")
                    {
                        prodVGAAdpCount++;
                    }

                }
            }

          if(prodMacCount < prodVGAAdpCount)
            {
                totalVGA = prodVGAAdpCount - prodMacCount;
            }

          if(prodAppleCount%3==0)
            {
                int xy = prodAppleCount / 3;
                totalAppTV = xy * 2;
            }
          else
            {
                // int mod = prodAppleCount % 3 + prodAppleCount / 3;
                totalAppTV = (prodAppleCount / 3) * 2 + prodAppleCount % 3;
            }

            if (plist.Count > 0)
            {


                foreach(var item in plist)
                {
                    if (SKUScanned != string.Empty)
                    {
                        SKUScanned = SKUScanned + "," + item.SKU;
                    }
                    else
                    {
                        SKUScanned = SKUScanned + " " + item.SKU;
                    }
                    if (item.SKU=="ipd")
                    {
                        if(prodIPadCount > 4)
                        {
                            totalBill = totalBill + 499.99;
                        }
                        else
                        {
                            totalBill = totalBill + item.Price;
                        }
                    }
                    else
                    {
                        if (item.SKU != "vga")
                        {
                            if (item.SKU == "atv")
                            {
                                TVPrice = item.Price;
                            }
                            else
                            {
                                totalBill = totalBill + item.Price;
                            }
                        }
                        else
                        {
                            VGAPrice = item.Price;
                        }
                    }
                   
                }
            }

            if(prodAppleCount>0)
            {
                totalBill = totalBill + totalAppTV * TVPrice;
            }
            if(totalVGA >0)
            {
                totalBill = totalBill + totalVGA * VGAPrice;
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("SKu Scanned: {0} ", SKUScanned);
            Console.WriteLine("Total Expected:{0}", totalBill);
            Console.WriteLine("--------------------------------------------------------");
            Console.ReadLine();

        }
    }
}
