using Carpark.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpark.Core
{
    public class EnumMapper
    {
        public static ECarParkType MapCarParkType(string carParkTypeString)
        {
            string normalizedString = carParkTypeString.ToUpper();

            switch (normalizedString)
            {
                case "BASEMENT CAR PARK":
                    return ECarParkType.BasementCarPark;

                case "MULTI-STOREY CAR PARK":
                    return ECarParkType.MultiStoreyCarPark;

                case "SURFACE CAR PARK":
                    return ECarParkType.SurfaceCarPark;

                default:
                    return ECarParkType.BasementCarPark;
            }
        }

        public static EFreeParking MapFreeParkingType(string freeParkingType)
        {
            string normalizedString = freeParkingType.ToUpper();

            switch (normalizedString)
            {
                case "NO":
                    return EFreeParking.No;

                case "SUN & PH FR 7AM-10.30PM":
                    return EFreeParking.SunPhFr7AmTo1030Pm;

                default:
                    return EFreeParking.No;
            }
        }

        public static ENightParkingType MapNightParkingType(string nightParkingType)
        {
            string normalizedString = nightParkingType.ToUpper();

            switch (normalizedString)
            {
                case "NO":
                    return ENightParkingType.NO;

                case "YES":
                    return ENightParkingType.YES;

                default:
                    return ENightParkingType.NO;
            }
        }

        public static EShortTermParking MapShortTermParkingType(string shortTermParkingType)
        {
            string normalizedString = shortTermParkingType.ToUpper();

            switch (normalizedString)
            {
                case "NO":
                    return EShortTermParking.No;

                case "7AM-7PM":
                    return EShortTermParking.AM7to7PM;

                case "7AM-10.30PM":
                    return EShortTermParking.AM7to1030PM;

                case "WHOLE DAY":
                    return EShortTermParking.WholeDay;

                default:
                    return EShortTermParking.No;
            }
        }

        public static ETypeOfParking MapTypeOfParking(string typeOfParking)
        {
            string normalizedString = typeOfParking.ToUpper();

            switch (normalizedString)
            {
                case "ELECTRONIC PARKING":
                    return ETypeOfParking.ElectronicParking;

                case "COUPON PARKING":
                    return ETypeOfParking.CouponParking;

                default:
                    return ETypeOfParking.ElectronicParking;
            }
        }
    }
}
