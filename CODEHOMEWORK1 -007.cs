using System;
using System.Collections.Generic;
namespace homework1of007
{
    class Program
    {
        static void Main(string[] args)
        {
            shirt shirt1nd = new shirt("L", "Red", 500f, "Imageone");
            shirt shirt2nd = new shirt("M", "Black", 750f, "Imagetwo");
            shirt shirt3nd = new shirt("S", "Blue", 625f, "Imagethree");
            Address jameADDDRESS = new Address("131/75 PUTTHAMONTON", "NAKHONPATOM", "10180");
            insidethecart allshoppingJame = new insidethecart(jameADDDRESS);
            User jame = new User("jame watson", "jame@gmail.com", allshoppingJame);
           
            jame.ShoppingCart.shirt(shirt1nd); jame.ShoppingCart.shirt(shirt2nd);
            jame.ShoppingCart.shirt(shirt3nd); jame.ShoppingCart.TotalCost();
        }
    }
   
    class User
    {
        public string name;
        public string email;
        public insidethecart ShoppingCart;
        public User(string valueName, string valueEmail,

        insidethecart valueShoppingCart)
        {
        name = valueName;
        email = valueEmail;
        ShoppingCart = valueShoppingCart;
        }
    }
    class shirt
    {
        public string size; public string color; public

          float worth; public string image;
        public shirt(string valueSize,
            string valueColor, float value, string valueImage)
        {
            size = valueSize;

            color = valueColor;

            worth = value;
            
            image = valueImage;
        }
    }
    class insidethecart
    {
        public float Totalcost = 0;
        public Address address;
        private List<shirt>  Shirt;
        public insidethecart(Address valueAddress)
        {
          Shirt = new List<shirt>();
          address = valueAddress;
        }
        public void shirt(shirt tShirt)
        {
          Shirt.Add(tShirt);
        }
        public void TotalCost()
        {
            foreach (shirt tshirt in Shirt)
            {
                Totalcost += tshirt.worth;
            }
            Console.WriteLine(Totalcost);
        }
    }
    class Address
    {
        public string street, city, zipcode;

        public Address(string street, string city, string zipCode)
        {
            street = street; city = city; zipCode = zipCode;
        }
    }
}


