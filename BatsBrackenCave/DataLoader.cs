using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BatsBrackenCave
{
    class DataLoader
    {
        public static string LoadText(string path) =>
            File.ReadAllText(path);

        public static List<Entity> LoadEntities(string path)
        {
            List<Entity> entities = new List<Entity>();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode root = doc.DocumentElement;
            XmlNodeList entityList = root.SelectNodes("/entities/entity");
            foreach (XmlElement e in entityList)
            {
                Entity tempEntity = new Entity();
                tempEntity.name = e.GetAttribute("name");
                tempEntity.species = e.GetAttribute("species");
                tempEntity.amount = e.GetAttribute("amount");
                entities.Add(tempEntity);
            }


            return entities;


        }
        
          
        

       

    }
}
