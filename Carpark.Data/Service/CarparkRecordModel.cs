﻿namespace Carpark.Data.Service
{
    public class CarparkRecordModel
    {
        public string CarParkNo { get; set; }
        public string Address { get; set; }
        public decimal XCoord { get; set; }
        public decimal YCoord { get; set; }
        public string CarParkType { get; set; }
        public string TypeOfParkingSystem { get; set; }
        public string ShortTermParking { get; set; }
        public string FreeParking { get; set; }
        public string NightParking { get; set; }
        public string CarParkDeck { get; set; }
        public decimal GannyHeight { get; set; }
        public string CarParkBasement { get; set; }
    }
}
