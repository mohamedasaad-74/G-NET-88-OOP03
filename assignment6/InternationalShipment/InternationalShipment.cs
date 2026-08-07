using assignment6.delivryaddress;
using assignment6.ship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

#region  InternationalShipment

//namespace assignment6.InternationalShipment
//{
//    public class InternationalShipment : Shipment
//    {
//        private string DestinationCountry;
//        private decimal CustomsFee;

//        public string destinoationCountry
//        {
//            get
//            {
//                return DestinationCountry;
//            }
//            set
//            {
//                if (string.IsNullOrWhiteSpace(value))
//                {
//                    Console.WriteLine("Invalid destioationCountry ");
//                    return;
//                }
//                DestinationCountry = value;
//            }
//        }
//        public decimal customsFee
//        {
//            get { return CustomsFee; }
//            set
//            {
//                if (value < 0)
//                {
//                    Console.WriteLine("Invalid customsfee");
//                    return;
//                }
//                CustomsFee = value;
//            }
//        }
//        public override decimal EstimatedCost
//        {
//            get
//            {
//                return deliveryfee + ((decimal)weight * 5) + customsFee;
//            }
//        }
//       public InternationalShipment(string TrackingCode, string Description, double Weight, decimal Delivryfee, DeliveryAddress Destination, decimal customsFee , string destinoationCountry) : base(TrackingCode, Description, Weight, Delivryfee, Destination)
//        {
//            DestinationCountry = destinoationCountry;
//           CustomsFee=customsFee;
//        }
//        public override string ToString()
//        {
//            return $"Tracking code: {trackingcode}, " +
//                 $"Description : {description}, " +
//                  $"Weight : {weight}" +
//                  $"Delivryfee : {deliveryfee}" +
//                  $"Destination : {destination}" +
//                  $"customsFee: {customsFee}" +
//                  $"destioationCountry : {destinoationCountry} "+
//                  $"EstimatedCost : {EstimatedCost} ";

//        }




//    }
//    }
#endregion