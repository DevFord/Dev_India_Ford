using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Locator.Models
{
    public class LocatorInput
    {
            public string _DealerName { get; set; }
            public string DealerName
            {
                get
                {
                    return string.IsNullOrEmpty(_DealerName) ? null : _DealerName;
                }
                set { _DealerName = value; }
            }
            public string _Latitude { get; set; }
            public string Latitude
            {
                get
                {
                    return string.IsNullOrEmpty(_Latitude) ? null : _Latitude;
                }
                set { _Latitude = value; }
            }
            public string _Longitude { get; set; }
            public string Longitude
            {
                get
                {
                    return string.IsNullOrEmpty(_Longitude) ? null : _Longitude;
                }
                set { _Longitude = value; }
            }
            public string _Address { get; set; }
            public string Address
            {
                get
                {
                    return string.IsNullOrEmpty(_Address) ? null : _Address;
                }
                set { _Address = value; }
            }
            public string _Locality { get; set; }
            public string Locality
            {
                get
                {
                    return string.IsNullOrEmpty(_Locality) ? null : _Locality;
                }
                set { _Locality = value; }
            }
            public string _PostCode { get; set; }
            public string PostCode
            {
            get
            {
                return string.IsNullOrEmpty(_PostCode) ? null : _PostCode;
            }
                set { _PostCode = value; }
            }
            public string _Country { get; set; }
            public string Country
            {
                get
                {
                    return string.IsNullOrEmpty(_Country) ? null : _Country;
                }
                set { _Country = value; }
            }
            public string _CountryCode { get; set; }
            public string CountryCode
            {
                get
                {
                    return string.IsNullOrEmpty(_CountryCode) ? null : _CountryCode;
                }
                set { _CountryCode = value; }
            }
            public string _Car { get; set; }
            public string Car
            {
                get
                {
                    return string.IsNullOrEmpty(_Car) ? null : _Car;
                }
                set { _Car = value; }
            }
            public string _Motability { get; set; }
            public string Motability
            {
                get
                {
                    return string.IsNullOrEmpty(_Motability) ? null : _Motability;
                }
                set { _Motability = value; }
            }
            public string _Used { get; set; }
            public string Used
            {
                get
                {
                    return string.IsNullOrEmpty(_Used) ? null : _Used;
                }
               set { _Used = value; }
            }
            public string _FordStore { get; set; }
            public string FordStore
            {
                get
                {
                    return string.IsNullOrEmpty(_FordStore) ? null : _FordStore;
                }
                set { _FordStore = value; }
            }
            public string _TransitService { get; set; }
            public string TransitService
            {
                get
                {
                    return string.IsNullOrEmpty(_TransitService) ? null : _TransitService;
                }
                set { _TransitService = value; }
            }
            public string _SmallBusinessandFleet { get; set; }
            public string SmallBusinessandFleet
            {
                get
                {
                    return string.IsNullOrEmpty(_SmallBusinessandFleet) ? null : _SmallBusinessandFleet;
                }
                set { _SmallBusinessandFleet = value; }
            }
            public string _AccidentRepairCenter { get; set; }
            public string AccidentRepairCenter
            {
                get
                {
                    return string.IsNullOrEmpty(_AccidentRepairCenter) ? null : _AccidentRepairCenter;
                }
                set { _AccidentRepairCenter = value; }
            }
            public string _FordRental { get; set; }
            public string FordRental
            {
                get
                {
                    return string.IsNullOrEmpty(_FordRental) ? null : _FordRental;
                }
                set { _FordRental = value; }
            }
            public string _VehiclesSales { get; set; }
            public string VehiclesSales
            {
                get
                {
                    return string.IsNullOrEmpty(_VehiclesSales) ? null : _VehiclesSales;
                }
                set { _VehiclesSales = value; }
            }
            public string _VehicleService { get; set; }
            public string VehicleService
            {
                get
                {
                    return string.IsNullOrEmpty(_VehicleService) ? null : _VehicleService;
                }
                set { _VehicleService = value; }
            }
            public string _Parts { get; set; }
            public string Parts
            {
                get
                {
                    return string.IsNullOrEmpty(_Parts) ? null : _Parts;
                }
                set { _Parts = value; }
            }       
    }
}