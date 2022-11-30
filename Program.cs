using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterUtilitiesBillCalculator
{
    internal class Customer//CLASS
    {
        private string Firstname;
        private string Lastname;
        private double PlotNumber;
        private string Location;
        private int Usertype;
        private double AmntUsed;

        public string Fname//OBJECT CONSTRUCTOR
        {
            get
            {
                return Firstname;
            }
            set
            {
                Firstname = value;
            }
        }

        public string Lname
        {
            get
            {
                return Lastname;
            }
            set
            {
                Lastname = value;
            }


        }
        public double Pnumber
        {
            get
            {
                return PlotNumber;
            }
            set
            {
                PlotNumber = value;
            }
        }
        public string Lction
        {
            get
            {
                return Location;
            }
            set
            {
                Location = value;

            }
        }
        public int Usrtype
        {
            get
            {
                return Usertype;
            }
            set { Usertype = value;
            }
        }
        public double AmtUsd
        {
            get
            {
                return AmntUsed;

            }
            set
            {
                AmntUsed = value;
            }
        }
//METHOD TO CALCULATE VAT
        double VRate;
        double WaterUsed;
        double VAT;

        public double CalculateVAT(double WaterUsed, double VRate, double VAT)
        {
            VAT= (VRate/100)* WaterUsed;
            return VAT;
        }


     class CustomerInfo
        {
         public static void Main(string[] args)//MAIN METHOD
          {
                string Firstname, Lastname,Location;    //VARIABLE DECLARATIONS
                double PlotNumber, VAT,AmntUsed;
                int A, B;
                
                Console.Write("Enter Firstname:");
                Firstname=Console.ReadLine();
                Console.Write("Enter Lastname:");
                Lastname = Console.ReadLine();
                Console.Write("Enter Plot number:");
                PlotNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Location:");
                Location= Console.ReadLine();
                Console.Write("Enter A for Domestic User type:");
                A=Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B for Business,commercial and Industrial user type:");
                B=Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Amount of WaterUsed:");
                AmntUsed= Convert.ToInt32(Console.ReadLine());
                
             //METHOD TO CALCULATE COSTS FOR CASE A
              if (AmntUsed<=5)
                {
                  Console.WriteLine("Potable water tariff is P3.60,Wastewater tariff is P0.65");
                    VAT = 0;
                }
                else if(AmntUsed>5&& AmntUsed < 15)
                {
                    Console.WriteLine("Potable water tariffs is P13.43,Wastewater tariff is P3.36");

                    VAT = ((14 / 100) * AmntUsed);

                }
                
                 else if(AmntUsed>15&& AmntUsed<25)

                {
                    Console.WriteLine("potable water tariff is P25.51,Wastewater tariff is P5.03");


                    VAT = ((14 / 100) * AmntUsed);
                }

                else if (AmntUsed > 25 && AmntUsed < 40)
                {
                    Console.WriteLine("potable water tariff is P36.16,Wastewater tariff is P6.71");
                    VAT = ((14 / 100) * AmntUsed);
                }
                else if (AmntUsed > 40)
                {
                    Console.WriteLine("potable water tariff is P45.21,Wastewater tariff is P8.39");

                    VAT = ((14 / 100) * AmntUsed);

                }

//METHOD TO CALCULATE TOTAL COSTS FOR CASE B
              else
                {
                    if(AmntUsed <=5) 
                    {
                        Console.WriteLine("Potable water tariffs is P4.92,Wastewater tariffs is P0.74");
                        VAT=((14/100) * AmntUsed);
                    }
                    else if ((AmntUsed > 5 && AmntUsed < 15)) 
                    {
                        Console.WriteLine ("Potable water tariffs is P4.92,Wastewater tariffs is P0.74");
                        VAT = ((14 / 100) * AmntUsed);
                    }
                    else if (AmntUsed > 15 && AmntUsed < 25)
                    {
                        
                        Console.WriteLine("Potable water tariffs is P14.61,Wastewater tariffs is P3.36");

                        VAT = ((14 / 100) * AmntUsed);

                    }
                    else if ((AmntUsed > 25 && AmntUsed < 40))
                    {
                        Console.WriteLine("Potable water tariffs is P39.35,Wastewater tariffs is P6.71");
                        VAT = ((14 / 100) * AmntUsed);
                    }
                    else if ((AmntUsed >40))
                    {
                        Console.WriteLine("Potable water tariffs is P39.35,Wastewater tariffs is P6.71");
                        VAT = ((14 / 100) * AmntUsed);
                    }

                }
               
            }
            
        }

    }
}


        
