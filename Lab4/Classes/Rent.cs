using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4.Classes
{
    public class Rent : IXmlSerializable
    {
        private string rentFirmName;
        private List<Vehicle> rentedVehicles;

        public string RentFirmName { get { return rentFirmName; } set { rentFirmName = value; } }
        public List<Vehicle> RentedVehicles { get { return rentedVehicles; } set { rentedVehicles = value; } }

        public Rent()
        {
            rentedVehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            rentedVehicles.Add(vehicle);
        }

        public override string ToString()
        {
            string rented = null;
            rentedVehicles.ForEach(car => rented += car);
            return rentFirmName + " " + rented;
        }

        public string ToShortString()
        {
            // add date 
            return RentFirmName + " " + RentedVehicles.Sum(car => car.Car.Price);
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            using (XmlReader subReader = reader.ReadSubtree())
            {
                subReader.MoveToContent();
                ReadXmlSubTree(subReader);
            }
            reader.Read();
        }

        private void ReadXmlSubTree(XmlReader reader)
        {
            while (reader.Read())
            {
                rentFirmName = reader.ReadElementContentAsString();
                reader.ReadStartElement();
                while (reader.Name == "Vehicle")
                {
                    Vehicle v = new Vehicle();                    
                    v.ReadXml(reader);
                    AddVehicle(v);
                }
                reader.ReadEndElement();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("RentFirmName", rentFirmName);
            writer.WriteStartElement("RentedVehicles");
            rentedVehicles.ForEach(vehicle => vehicle.WriteXml(writer));
            writer.WriteEndElement();
        }
    }
}
