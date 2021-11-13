using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Storage
{
    /// <summary>
    /// Gère la sauvegarde du notebook au format JSON 
    /// </summary>
    public class JsonStorage : Logic.IStorage
    {
        /// <summary>
        /// Nom du fichier JSON 
        /// </summary>
        private String fileName;

        /// <summary>
        /// Permet d'initialiser un la classe
        /// </summary>
        /// <param name="fname"></param>
        public JsonStorage(String fileName)
        {
            this.fileName = fileName;
        }

        /// <summary>
        /// Permet de charger un notebook
        /// 
        /// Logique de fonctionnement : On ouvre un flux de lecture (avec le filename), puis on utilise DataContractJsonSerializer (.NET 5 est ultérieur !) pour 
        /// interpréter les infos dans le json sous forme d'un notebook 
        /// </summary>
        /// <returns></returns>
        public NoteBook Load()
        {
            Logic.NoteBook notebook = null;

            try
            {
                using (FileStream stream = new FileStream(this.fileName, FileMode.Open))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Logic.NoteBook));
                    notebook = serializer.ReadObject(stream) as NoteBook;
                }
            }
            catch
            {
                notebook = new NoteBook();
            }

            return notebook;
        }

        /// <summary>
        /// Permet de sauvegarder un notebook
        /// 
        /// Logiaue de fonctionnement : On ouvre un flux d'écriture et grace au serializer, on 
        /// stock les data du notebook passé en paramètre 
        /// </summary>
        /// <param name="nb">Notebook à enregister</param>
        public void Save(NoteBook nb)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Logic.NoteBook));

            using (FileStream stream = new FileStream(this.fileName, FileMode.Open))
            {
                serializer.WriteObject(stream, nb);
            }
        }
    }
}
