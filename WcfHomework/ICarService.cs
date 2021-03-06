﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfHomework
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICarService
    {

        [OperationContract]
        List<Car> GetAllCars();

        [OperationContract]
        List<Car> GetCarById(string id);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfHomework.ContractType".
    [DataContract]
    public class Car
    {
        [DataMember]
        public string ID;
        [DataMember]
        public string Make;
        [DataMember]
        public string Model;
        [DataMember]
        public string Doors;
        [DataMember]
        public decimal Price;
    }
}
