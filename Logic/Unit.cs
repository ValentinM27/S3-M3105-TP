using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// Classe gérant les unités
    /// </summary>
    public class Unit : PedagogicalElement
    {
        //Liste des modules
        private List<Module> modules = new List<Module>();

        public List<Module> Modules
        {
            get => this.modules;

            set
            {
                this.modules = value;
            }
        }

        /// <summary>
        /// Retourne la liste des modules
        /// </summary>
        /// <returns></returns>
        public Module[] ListModules()
        {
            return this.modules.ToArray();
        }

        /// <summary>
        /// Permet d'ajouter un module
        /// </summary>
        /// <param name="m"></param>
        public void Add(Module m)
        {
            this.modules.Add(m);
        }

        /// <summary>
        /// Permet de supprimer un module
        /// </summary>
        /// <param name="m"></param>
        public void Remove(Module m)
        {
            this.modules.Remove(m);
        }
    }
}
