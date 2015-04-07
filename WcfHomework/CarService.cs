using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace WcfHomework
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CarService : ICarService
    {

        public List<Car> GetAllCars()
        {
            XDocument db = GetDb();
            List<Car> lstCars =
                (from car in db.Descendants("car")
                 select new Car()
                 {
                     ID = car.Attribute("id").Value,
                     Make = car.Element("make").Value,
                     Model = car.Element("model").Value,
                     Doors = car.Element("doors").Value,
                     Price = Convert.ToDecimal(car.Element("price").Value)
                 }).ToList();

            return lstCars;
        }

        public List<Car> GetCarById(string id)
        {
            XDocument db = GetDb();

            List<Car> lstCar =
                (from car in db.Descendants("car")
                 where car.Attribute("id").Value.Equals(id)
                 select new Car()
                 {
                     ID = car.Attribute("id").Value,
                     Make = car.Element("make").Value,
                     Model = car.Element("model").Value,
                     Doors = car.Element("doors").Value,
                     Price = Convert.ToDecimal(car.Element("price").Value)
                 }).ToList();

            return lstCar;
        }

        /// <summary>
        /// metod za loadiranje na podatocite od xml fajlot Storage.xml
        /// treba da se vnese apsolutnata pateka do lokacijata kade e fajlot
        /// </summary>
        /// <returns></returns>
        private XDocument GetDb()
        {
            //return XDocument.Load(@"..\..\Storage.xml");
            return XDocument.Load(@"c:\users\gp\documents\visual studio 2013\Projects\WcfHomework\WcfHomework\Storage.xml");
        }
    }
}
