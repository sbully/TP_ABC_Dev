using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace MDevoldere.Tools.Serializer
{
    public class AppDataManager<T>
    {
        string dirName;

        public string BinPath { get; protected set; }

        public string XmlPath { get; protected set; }

        public List<T> Items { get; protected set; }


        public AppDataManager() : this("") { }

        public AppDataManager(string _filename)
        {
            if (String.IsNullOrEmpty(_filename))
            {
                _filename = "AppDataManager";
            }

           dirName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tedi");


            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(BinPath);
            }

            BinPath = Path.Combine(dirName , _filename + ".bin");
            XmlPath = Path.Combine(dirName , _filename + ".xml");

            

            Items = new List<T>();
        }

        public AppDataManager(string _filename, List<T> _defaultItems) : this(_filename)
        {
            if (_defaultItems != null)
            {
                Items = _defaultItems;
            }
        }

        public List<T> Load()
        {
            List<T> loaded = AppDataSerializer.LoadBin<List<T>>(BinPath);

            if (loaded != null)
            {
                Items = loaded;
                return Items;
            }

            return new List<T>();
        }

        public List<T> LoadXml()
        {
            List<T> loaded = AppDataSerializer.LoadXml<List<T>>(XmlPath);

            if (loaded != null)
            {
                Items = loaded;
                return Items;
            }

            return new List<T>();
        }

        public void Save()
        {
            AppDataSerializer.SaveBin(BinPath, Items);
        }

        public void SaveXml()
        {
            AppDataSerializer.SaveXml(XmlPath, Items);
        }
    }
}