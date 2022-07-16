using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>
            {
                new Product
                {
                     ProductCode="P001",
                     Name="Angular Speedster Board 2000",
                     Type ="Boards",
                     Brand ="Angular",
                     Description="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     HSNCode="7825",
                     QuantityInStock=10,
                     Unit ="NOS",
                     PurchaseRate =1200,
                     SaleRate =1400,
                     CGST=9,
                     SGST=9,
                     IGST=9,
                     ReorderLevel=5,
                     ProductPictureUrl="/images/products/sb-ang1.png"
                },
                new Product
                {
                     ProductCode="P002",
                     Name="Green Angular Board 3000",
                     Type ="Angular",
                     Brand ="Boards",
                     Description="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     HSNCode="7890",
                     QuantityInStock=10,
                     Unit ="NOS",
                     PurchaseRate =1200,
                     SaleRate =1400,
                     CGST=9,
                     SGST=9,
                     IGST=9,
                     ReorderLevel=5,
                     ProductPictureUrl="/images/products/sb-ang2.png"
                },
                new Product
                {
                     ProductCode="P003",
                     Name="Core Board Speed Rush 3",
                     Type ="Boards",
                     Brand ="NetCore",
                     Description="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     HSNCode="7824",
                     QuantityInStock=10,
                     Unit ="NOS",
                     PurchaseRate =1500,
                     SaleRate =1700,
                     CGST=9,
                     SGST=9,
                     IGST=9,
                     ReorderLevel=5,
                     ProductPictureUrl="/images/products/sb-core1.png"
                },
                new Product
                {
                     ProductCode="P004",
                     Name="Net Core Super Board",
                     Type ="Boards",
                     Brand ="NetCore",
                     Description="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     HSNCode="7826",
                     QuantityInStock=10,
                     Unit ="NOS",
                     PurchaseRate =1400,
                     SaleRate =1500,
                     CGST=9,
                     SGST=9,
                     IGST=9,
                     ReorderLevel=5,
                     ProductPictureUrl="/images/products/sb-core2.png"
                },
                new Product
                {
                     ProductCode="P005",
                     Name="React Board Super Whizzy Fast",
                     Type ="Boards",
                     Brand ="React",
                     Description="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     HSNCode="7827",
                     QuantityInStock=10,
                     Unit ="NOS",
                     PurchaseRate =2000,
                     SaleRate =2200,
                     CGST=9,
                     SGST=9,
                     IGST=9,
                     ReorderLevel=5,
                     ProductPictureUrl="/images/products/sb-react1.png"
                },
                new Product
                {
                     ProductCode="P006",
                     Name="Typescript Entry Board",
                     Type ="Boards",
                     Brand ="Typescript",
                     Description="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     HSNCode="7828",
                     QuantityInStock=10,
                     Unit ="NOS",
                     PurchaseRate =2500,
                     SaleRate =2700,
                     CGST=9,
                     SGST=9,
                     IGST=9,
                     ReorderLevel=5,
                     ProductPictureUrl="/images/products/sb-ts1.png"
                },
                new Product
                {
                     ProductCode="P007",
                     Name="Core Blue Hat",
                     Type ="Hats",
                     Brand ="NetCore",
                     Description="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     HSNCode="7829",
                     QuantityInStock=10,
                     Unit ="NOS",
                     PurchaseRate =2500,
                     SaleRate =2600,
                     CGST=9,
                     SGST=9,
                     IGST=9,
                     ReorderLevel=5,
                     ProductPictureUrl="/images/products/hat-core1.png"
                },
                new Product
                {
                     ProductCode="P008",
                     Name="Green React Woolen Hat",
                     Type ="Hats",
                     Brand ="React",
                     Description="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     HSNCode="7820",
                     QuantityInStock=10,
                     Unit ="NOS",
                     PurchaseRate =1500,
                     SaleRate =1700,
                     CGST=9,
                     SGST=9,
                     IGST=9,
                     ReorderLevel=5,
                     ProductPictureUrl="/images/products/hat-react1.png"
                },
                new Product
                {
                     ProductCode="P009",
                     Name="Purple React Woolen Hat",
                     Type ="Hats",
                     Brand ="React",
                     Description="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     HSNCode="7890",
                     QuantityInStock=10,
                     Unit ="NOS",
                     PurchaseRate =4700,
                     SaleRate =5000,
                     CGST=9,
                     SGST=9,
                     IGST=9,
                     ReorderLevel=5,
                     ProductPictureUrl="/images/products/hat-react2.png"
                },
                new Product
                {
                     ProductCode="P010",
                     Name="Blue Code Gloves",
                     Type ="VSCode",
                     Brand ="Gloves",
                     Description="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                     HSNCode="7850",
                     QuantityInStock=10,
                     Unit ="NOS",
                     PurchaseRate =1800,
                     SaleRate =2000,
                     CGST=9,
                     SGST=9,
                     IGST=9,
                     ReorderLevel=5,
                     ProductPictureUrl="/images/products/glove-code1.png"
                },
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();


        }
    }
}