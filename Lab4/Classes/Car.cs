using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4.Classes
{
    public class Car : IXmlSerializable, ICloneable, IEquatable<Car>
    {
        private string prodCompany, model;
        private int price, prodYear;
        
        public string ProdCompany
        { 
            get 
            { 
                return prodCompany; 
            } 
            set 
            { 
                prodCompany = value; 
            } 
        }

        public string Model { 
            get 
            { 
                return model; 
            } 
            set 
            { 
                model = value; 
            } 
        }

        public int Price {
            get 
            { 
                return price; 
            } 
            set 
            {
                price = value; 
            } 
        }

        public int ProdYear 
        { 
            get 
            { 
                return prodYear; 
            } 
            set 
            { 
                prodYear = value; 
            } 
        }

        public object Clone()
        {
            return new Car
            {
                prodCompany = this.prodCompany,
                model = this.model,
                price = this.price,
                prodYear = this.prodYear
            };
        }

        public bool Equals(Car other)
        {
            if (other == null)
                return false;
            return prodCompany == other.prodCompany && model == other.model &&
                price == other.price && prodYear == other.prodYear;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Car);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + prodCompany.GetHashCode();
            hash = hash * 23 + model.GetHashCode();
            hash = hash * 23 + price.GetHashCode();
            hash = hash * 23 + prodYear.GetHashCode();
            return hash;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement();
            prodCompany = reader.ReadElementContentAsString();
            model = reader.ReadElementContentAsString();
            price = reader.ReadElementContentAsInt();
            prodYear = reader.ReadElementContentAsInt();
            reader.ReadEndElement();

        }

        public override string ToString()
        {
            return $" {prodCompany} {model} {prodYear} {price} ";
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement(GetType().Name);
            writer.WriteElementString("ProductionCompany", prodCompany);
            writer.WriteElementString("Model", model);
            writer.WriteElementString("Price", price.ToString());
            writer.WriteElementString("ProductionYear", prodYear.ToString());
            writer.WriteEndElement();
        }
    }
}
