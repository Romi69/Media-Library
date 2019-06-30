using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeTest
{
    class Program
    {
        #region --- TestData ---
        public static List<Product> products = new List<Product>()
        {
            new Product() {Id = 1, Name="Narancs", Barcode="2800457", Vat=25, Price=219M, Department=15 },
            new Product() {Id = 2, Name="Paradicsom", Barcode="2800924", Vat=25, Price=499M, Department=18 },
            new Product() {Id = 3, Name="Coca-Cola 2,15L", Barcode="5998473647225", Vat=25, Price=439M, Department=42 },
            new Product() {Id = 4, Name="Nesquick kakaó 800g", Barcode="5995454103228", Vat=25, Price=1299M, Department=27 },
            new Product() {Id = 5, Name="Orange juice 100% 2L", Barcode="40058644895117", Vat=25, Price=519M, Department=40 },
            new Product() {Id = 6, Name="Tej (Mizo) 1,5% 1L", Barcode="59987745524266", Vat=5, Price=169M, Department=4 },
        };
        #endregion

        static void Main(string[] args)
        {
            BarcodeValidationAttribute bva = new BarcodeValidationAttribute();

            foreach (Product prod in products.Where(p=>p.Price>350))
            {
                if (!bva.Validate(prod))
                {
                    Console.WriteLine($"Invalid barcode in product! {prod.Barcode}");
                }
                Console.WriteLine(prod);
            }
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [BarcodeValidation(CodeType="EAN,UPC")]
        public string Barcode { get; set; }
        public int Vat { get; set; }
        public decimal Price { get; set; }
        public int Department { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Barcode: {Barcode}, Vat: {Vat}, Price: {Price}, Deprt: {Department}";
        }

    }

    public class BarcodeValidationAttribute : Attribute, IValidation
    {
        public string CodeType { get; set; }

        public bool Validate(object obj)
        {
            Type t = obj.GetType();
            foreach (PropertyInfo prop in t.GetProperties())
            {
                foreach (Attribute attr in prop.GetCustomAttributes())
                {
                    if (attr.ToString() == "AttributeTest.BarcodeValidationAttribute")
                    {
                        if (!CheckBarcode(attr, obj))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private bool CheckBarcode(Attribute attr, Object obj)
        {
            //t.GetProperty(prop.Name).GetCustomAttribute(attr.GetType())
            string[] bcTypes = attr.ToString().Split(',');

            return true;
        }
    }

    public interface IValidation
    {
        bool Validate(object obj);
    }
}
