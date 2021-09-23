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
        private List<Module> modules;

        public List<Module> Modules
        {
            get => this.modules;

            set
            {
                this.modules = value;
            }
        }
    }
}
