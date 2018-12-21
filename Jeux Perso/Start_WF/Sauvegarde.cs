using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Start_WF
{
    class Sauvegarde
    {


        // public static void WriteSave(List<object> ex) // ecriture de la liste typé dans un fichier
        public static void WriteSave()
        {                       
            List<JoueurScore> Save = MainWindow.ListScore ;
            Stream streamW = new FileStream("Save_Game.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(streamW, Save);
            streamW.Close();
        }


        public static void Read_Save() //lecture du fichier et ecriture dans la liste typé
        {

            if(File.Exists("Save_Game.bin"))
            {
                Stream streamR = new FileStream("Save_Game.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                IFormatter formatter = new BinaryFormatter();
                MainWindow.ListScore = (List<JoueurScore>) formatter.Deserialize(streamR);
                streamR.Close();
            }
            
        }
       
        
    }
}
