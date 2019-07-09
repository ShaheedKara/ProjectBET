using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var Basket = new Basket();

            var Shirt = new Shirt(); //Adding test data
            Shirt.Name = "Armani";
            Shirt.Size = "l";
            Basket.shirts.Add(Shirt);
            var Golf = new Golfer();
            Golf.Name = "White";
            Golf.Size = "m";
            Basket.golfers.Add(Golf);
            var jean = new Jeans();
            jean.Name = "Skinny";
            jean.Size = "s";
            Basket.jeans.Add(jean);
            var formal = new Formal();
            formal.Name = "Guess";
            formal.Size = "l";
            Basket.formals.Add(formal);


            Console.WriteLine("Your total is : R" + Basket.CalcCost()); //output
            Console.ReadKey();
        }
        abstract class OnlineStore  //Abstract class
    {
       
            
        public string Name;    //Attributes defining classes
        public string Size;
        public double Price;

        public abstract double CalcCost();     //Abstract method 
      

        public double CostS = 10; //
        public double CostM = 20;
        public double CostL = 30;

        public double CheckSize()
        {

            if (Size == "s")
            {
                Price = CostS;
            }
            else if (Size == "m")
            {
                Price = CostM;
            }
            else if(Size == "l")
            {
                Price = CostL;
            }
            return Price;
        }




    }


    class Shirt : OnlineStore
    {
        public override double CalcCost()
        {
            
            return CheckSize();
        }
    }

    class Golfer : OnlineStore
    {
        public override double CalcCost()
        {

                return CheckSize() * 2;
        }


    }
    class Jeans : OnlineStore
    {
        public override double CalcCost()
        {
            
                return CheckSize();
        }



    }

    class Formal : OnlineStore
    {
        public override double CalcCost()
        {

                return CheckSize() + 30;
        }

    }

    class Basket : OnlineStore
    {


        public List<Shirt> shirts = new List<Shirt>();
        public List<Golfer> golfers = new List<Golfer>();
        public List<Jeans> jeans = new List<Jeans>();
        public List<Formal> formals = new List<Formal>();
       
       
        double Total;

       

        public override double CalcCost()
        {
               
                

            foreach (var item in shirts)
            {
                    
                Total += item.CalcCost();
                   


            }
            foreach (var item in golfers)
            {
                Total += item.CalcCost();
                    
                }
            foreach (var item in jeans)
            {
                Total += item.CalcCost();
                    
                }
            foreach (var item in formals)
            {
                Total += item.CalcCost();
                    
                }


            return Total;
        }



    }

    
    }


}
