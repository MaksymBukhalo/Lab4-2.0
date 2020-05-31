using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4.Classes
{
    public class Vehicle : IXmlSerializable, ICloneable, IEquatable<Vehicle>
    {
        private CarCategory carCategory;
        private Car car;
        private DateTime rentStartDate;
        private int rentPrice, duration;
        private string carNumber;

        public CarCategory CarCategory { get { return carCategory; } set { carCategory = value; } }
        public Car Car { get { return car; } set { car = value; } }
        public DateTime RentStartDate { get { return rentStartDate; } set { rentStartDate = value; } }
        public int RentPrice { get { return rentPrice; } set { rentPrice = value; } }
        public int Duration { get { return duration; } set { duration = value; } }
        public string CarNumber { get { return carNumber; } set { carNumber = value; } }

        public object Clone()
        {
            return new Vehicle
            {
                car = (Car)this.car.Clone(),
                carCategory = this.carCategory,
                rentStartDate = this.rentStartDate,
                rentPrice = this.rentPrice,
                duration = this.duration,
                carNumber = this.carNumber
            };
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement();
            carCategory = (CarCategory)Enum.Parse(typeof(CarCategory), reader.ReadElementContentAsString());
            Car c = new Car();
            c.ReadXml(reader);
            car = c;
            rentStartDate = DateTime.Parse(reader.ReadElementContentAsString());
            rentPrice = reader.ReadElementContentAsInt();
            duration = reader.ReadElementContentAsInt();
            carNumber = reader.ReadElementContentAsString();
            reader.ReadEndElement();
        }

        public override string ToString()
        {
            return $" {carCategory} {car} {carNumber} {rentPrice} {duration} {rentStartDate.ToShortDateString()} ";
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement(GetType().Name);
            writer.WriteElementString("CarCategory", carCategory.ToString());
            car.WriteXml(writer);
            writer.WriteElementString("RentStartDate",  rentStartDate.ToShortDateString());
            writer.WriteElementString("RentPrice", rentPrice.ToString());
            writer.WriteElementString("Duration", duration.ToString());
            writer.WriteElementString("CarNumber", carNumber.ToString());
            writer.WriteEndElement();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Vehicle);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + carCategory.GetHashCode();
            hash = hash * 23 + car.GetHashCode();
            hash = hash * 23 + rentStartDate.GetHashCode();
            hash = hash * 23 + rentPrice.GetHashCode();
            hash = hash * 23 + duration.GetHashCode();
            hash = hash * 23 + carNumber.GetHashCode();
            return hash;
        }

        public bool Equals(Vehicle other)
        {
            if (other == null)
                return false;
            return carCategory == other.carCategory && car.Equals(other.car) &&
                rentStartDate == other.rentStartDate && rentPrice == other.rentPrice &&
                duration == other.duration && carNumber == other.carNumber;
        }
    }
}
