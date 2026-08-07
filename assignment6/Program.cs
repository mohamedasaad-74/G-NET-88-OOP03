using assignment6.delivryaddress;
using assignment6.ship;
using System.Security.Cryptography.X509Certificates;

namespace assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //   a) What is the difference between a class and a struct?
            //(*)class =>Refrence type عباره عن =>heabتخزن في = > support inheritance and All Features in oop =>can be null
            //(*)struct =>value type =>stack => not support inheritance =>cant be null
            //=================================================================
            //  b) Why are classes more suitable than structs for large applications?
            //==class =>Refrence type عباره عن =>heabتخزن في
            //بتاخد مساحه تخزين كبيره 
            //support inheritance and All Features in oop
            //ref in the same object =>equality


            #endregion
            #region Question2
            //a) Which class is the parent class?
            //=============Shipment=====

            //  b) Which class is the child class?
            //=========Express shipment======

            //  c) What members are inherited by ExpressShipment?
            //============Tracking code===========

            // d) Why is inheritance better than duplicating the same code in multiple classes?
            //reusability ,esae of mainenance , reuces code redunancy 
            #endregion
            #region part2 practical 


            // 1. Create a DeliveryCenter object
            //DeliveryCenter center = new DeliveryCenter();

            //// 2. Read Delivery Center Name from user
            //Console.Write("Enter Delivery Center Name: ");
            //center.CenterName = Console.ReadLine();


            //// 3 Read data for StandardShipment & Create object directly

            //Console.WriteLine(" Enter Standard Shipment Details");
            //Console.Write("Tracking Code: ");
            //string sCode = Console.ReadLine();

            //Console.Write("Description: ");
            //string sDesc = Console.ReadLine();

            //Console.Write("Weight : ");
            //double sWeight = double.Parse(Console.ReadLine());

            //Console.Write("Delivery Fee: ");
            //decimal sFee = decimal.Parse(Console.ReadLine());

            //Console.WriteLine(" Enter Destination Address ");
            //Console.Write("City: ");
            //string sCity = Console.ReadLine();
            //Console.Write("Street: ");
            //string sStreet = Console.ReadLine();
            //Console.Write("Building Number: ");
            //int sBuilding = int.Parse(Console.ReadLine());

            //DeliveryAddress sAddress = new DeliveryAddress(sCity, sStreet, sBuilding);

            // Create object using parameterized constructor only
            // StandardShipment standard = new StandardShipment(sCode, sDesc, sWeight, sFee, sAddress);


            // 4  Read data for ExpressShipment & Create object directly

            //Console.WriteLine(" Enter Express Shipment Details");
            //Console.Write("Tracking Code: ");
            //string eCode = Console.ReadLine();

            //Console.Write("Description: ");
            //string eDesc = Console.ReadLine();

            //Console.Write("Weight : ");
            //double eWeight = double.Parse(Console.ReadLine());

            //Console.Write("Delivery Fee: ");
            //decimal eFee = decimal.Parse(Console.ReadLine());

            //Console.Write("Extra Fee: ");
            //decimal extraFee = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("--- Enter Destination Address ---");
            //Console.Write("City: ");
            //string eCity = Console.ReadLine();
            //Console.Write("Street: ");
            //string eStreet = Console.ReadLine();
            //Console.Write("Building Number: ");
            //int eBuilding = int.Parse(Console.ReadLine());

            //DeliveryAddress eAddress = new DeliveryAddress(eCity, eStreet, eBuilding);

            // Create object using parameterized constructor only
            // ExpressShipment express = new ExpressShipment(eCode, eDesc, eWeight, eFee, eAddress, extraFee);


            // 5  Read data for InternationalShipment & Create object directly

            //Console.WriteLine(" Enter International Shipment Details ---");
            //Console.Write("Tracking Code: ");
            //string iCode = Console.ReadLine();

            //Console.Write("Description: ");
            //string iDesc = Console.ReadLine();

            //Console.Write("Weight (KG): ");
            //double iWeight = double.Parse(Console.ReadLine());

            //Console.Write("Delivery Fee: ");
            //decimal iFee = decimal.Parse(Console.ReadLine());

            //Console.Write("Destination Country: ");
            //string country = Console.ReadLine();

            //Console.Write("Customs Fee: ");
            //decimal customsFee = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("--- Enter Destination Address ---");
            //Console.Write("City: ");
            //string iCity = Console.ReadLine();
            //Console.Write("Street: ");
            //string iStreet = Console.ReadLine();
            //Console.Write("Building Number: ");
            //int iBuilding = int.Parse(Console.ReadLine());

            //DeliveryAddress iAddress = new DeliveryAddress(iCity, iStreet, iBuilding);

            // Create object using parameterized constructor only
            //            InternationalShipment international = new InternationalShipment(iCode, iDesc, iWeight, iFee, iAddress, customsFee, country);


            //            // 7. Add shipments to Delivery Center
            //            // --------------------sol ------------------------------
            //            if (center.AddShipment(standard))
            //                Console.WriteLine("\nStandard shipment added successfully.");

            //            if (center.AddShipment(express))
            //                Console.WriteLine("Express shipment added successfully.");

            //            if (center.AddShipment(international))
            //                Console.WriteLine("International shipment added successfully.");


            //            // 8. Print all shipments         
            //            Console.WriteLine(" ALL SHIPMENTS");
            //            center.PrintAllShipments();
            //           

            // 9. Search for shipment using Indexer (by Tracking Code

            //            Console.Write("Enter tracking code to search: ");
            //            string searchCode = Console.ReadLine();

            //            Shipment searchedShipment = center[searchCode];

            //            if (searchedShipment != null)
            //            {
            //                Console.WriteLine("\nShipment Found:");
            //                Console.WriteLine(searchedShipment);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Shipment with this tracking code was not found.");
            //            }


            //            // 10. Remove one shipment by Tracking Code
            //            // --------------------------------------------------
            //            Console.WriteLine("\n================ REMOVE SHIPMENT ================");
            //            Console.Write("Enter tracking code to remove: ");
            //            string removeCode = Console.ReadLine();

            //            bool isRemoved = center.RemoveShipment(removeCode);

            //            if (isRemoved)
            //            {
            //                Console.WriteLine($"Shipment '{removeCode}' removed successfully.");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Failed to remove shipment '{removeCode}'. Not found.");
            //            }

            //            
            //            // 11. Print remaining shipments after removal
            //           
            //            Console.WriteLine("\n================ REMAINING SHIPMENTS ================");
            //            center.PrintAllShipments();

            //            Console.WriteLine("\nPress any key to exit...");
            //            Console.ReadKey();

            #endregion
        }
    }
}

