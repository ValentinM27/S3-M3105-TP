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
        public Unit()
        {
            Module test = new Module();
            test.Name = "test";
            test.Coef = 1;
            modules.Add(test);
        }

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
    }
}
