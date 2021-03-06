using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks : Producto
    {
        
        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        /// <summary>
        /// Constructor de Snacks
        /// </summary>
        /// <param name="codigo">Codigo de barras</param>
        /// <param name="marca">Marca del producto</param>
        /// <param name="color">Color primario del empaque</param>
        public Snacks(EMarca marca, string codigo, ConsoleColor color)
            : base(codigo, marca, color)
        {
        }

        /// <summary>
        /// Devuelve un string con los datos del snack
        /// </summary>
        /// <returns></returns>
        public sealed override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
