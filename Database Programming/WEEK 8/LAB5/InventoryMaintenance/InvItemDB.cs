using System;
using System.Collections.Generic;
using System.Xml;


namespace InventoryMaintenance
{
    public static class InvItemDB
    {
        private const string Path = @"G:\2-COLLEGE-\YR4_TERM-2\Database Programming\WEEK 8\InventoryMaint with XML file\InventoryMaintenance\InventoryItems.xml";

        public static void SaveItems(List<InvItem> items)
        {
            // Add code here to write the List<InvItems> object to an XML file.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            XmlWriter XmlOutput = XmlWriter.Create(Path, settings);

            XmlOutput.WriteStartDocument();
            XmlOutput.WriteStartElement("Items");

            foreach (InvItem i in items)
            {
                XmlOutput.WriteStartElement("Item");

                XmlOutput.WriteElementString("ItemNo", Convert.ToString(i.ItemNo));
                XmlOutput.WriteElementString("Desciption", Convert.ToString(i.Description));
                XmlOutput.WriteElementString("Price", Convert.ToString(i.Price));

                XmlOutput.WriteEndElement();
            }
            XmlOutput.WriteEndElement();
            XmlOutput.Close();
        }

        public static List<InvItem> GetItems()
        {
            // create the list
            List<InvItem> items = new List<InvItem>();

            // Add code here to read the XML file into the List<InvItem> object.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;

            XmlReader XmlInput = XmlReader.Create(Path, settings);

            if (XmlInput.ReadToDescendant("Item"))
            {
                do
                {
                    InvItem i = new InvItem();
                    XmlInput.ReadStartElement("Item");
                    i.ItemNo = Convert.ToInt32(XmlInput.ReadElementContentAsString());
                    i.Description = XmlInput.ReadElementContentAsString();
                    i.Price = Convert.ToDecimal(XmlInput.ReadElementContentAsString());

                    items.Add(i);

                } while (XmlInput.ReadToNextSibling("Item"));
                
                XmlInput.Close();

            }

            return items;
        }

        
    }
}
