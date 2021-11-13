using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// Interface dédiée au stockage des notebook
    /// </summary>
    public interface IStorage
    {
        /// <summary>
        /// Permet de charger un notebook
        /// </summary>
        /// <returns></returns>
        Logic.NoteBook Load();

        /// <summary>
        /// Permet de sauvegarder un notebook
        /// </summary>
        /// <param name="nb"></param>
        /// <returns></returns>
        Logic.NoteBook Save(Logic.NoteBook nb)
;    }
}
