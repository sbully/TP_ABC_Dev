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

namespace Dll_Bully
{
    public class Sauvegarde
    {/// <summary>
     /// Lecture dans un Fichier .BIN
     /// </summary>
        public static T LoadBin<T>(string _path)
        {
            try
            {
                if (File.Exists(_path))
                {
                    IFormatter formatter = new BinaryFormatter();

                    using (FileStream stream = new FileStream(_path, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        if (stream.Length > 0)
                        {
                            T loaded = (T)formatter.Deserialize(stream);

                            if (loaded != null)
                            {
                                return loaded;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return default(T);
        }
        /// <summary>
        /// Sauvegarde dans un Fichier .BIN
        /// </summary>
        public static void SaveBin(string _path, object _o)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();

                using (FileStream stream = new FileStream(_path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, _o);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Lecture d'un fichier .CSV renvoi un liste typé
        /// </summary>
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
        /// <summary>
        /// Sauvegarde d'une liste typé dans un fichier CSV
        /// </summary>
        public void Write_CSV<T>(string _path, List<T> _myList) where T : class
        {
            CsvHelper.Configuration.Configuration CsvConfig = new CsvHelper.Configuration.Configuration { Delimiter = ";" };
            using (TextWriter textwritter = new StreamWriter(_path, true, Encoding.GetEncoding(1252)))
            {
                var csv = new CsvWriter(textwritter, CsvConfig);
                csv.WriteRecords(_myList);
            }
        }
        /// <summary>
        /// ajout d'une entré dans le fichier CSV
        /// </summary>
        /// <typeparam name="T">nom de la classe de l objet</typeparam>
        /// <param name="_path">chemin d'accès au fichier</param>
        /// <param name="_o">objet à enregistré</param>
        public static void Write_CSV<T>(string _path, T _o) where T : class
        {
            CsvHelper.Configuration.Configuration CsvConfig = new CsvHelper.Configuration.Configuration { Delimiter = ";" };
            using (TextWriter textwritter = new StreamWriter(_path, true, Encoding.GetEncoding(1252)))
            {
                var csv = new CsvWriter(textwritter, CsvConfig);
                csv.WriteRecord(_o);
                csv.NextRecord();
            }
        }

    }
}
