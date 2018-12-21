using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using CsvHelper;


namespace Recherche_Ville_chargement_CSV
{
    class ReadSaveCSV
    {



        public List<T> Read_CSV<T>(string _path)
        {
            CsvHelper.Configuration.Configuration CsvConfig = new CsvHelper.Configuration.Configuration { Delimiter = ";" };
            List<T> resultat = new List<T>();
            if (File.Exists(_path))
            {
                using (TextReader textReader = new StreamReader(_path, Encoding.GetEncoding(1252)))
                {
                    var csv = new CsvReader(textReader, CsvConfig);
                    resultat = csv.GetRecords<T>().ToList();
                    return resultat;
                }
            }
            return resultat;
        }



        public void Write_CSV<T>(string _path, List<T> _myList) where T : class
        {
            CsvHelper.Configuration.Configuration CsvConfig = new CsvHelper.Configuration.Configuration { Delimiter = ";" };
            using (TextWriter textwritter = new StreamWriter(_path, true, Encoding.GetEncoding(1252)))
            {
                var csv = new CsvWriter(textwritter, CsvConfig);
                csv.WriteRecords(_myList);
            }
        }
    }
}
