using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* D = derevo
 * K = kamen
 * J = jelezo
 * Z = zoloto
 * A = almaz
 * O = pustota
 * P = palka
 */

namespace Minecraft
{
    class Material
    {
        private string _material;

        public Material()
        {
            _material = "O";
        }
        private Material(string material)
        {
            _material = material;
        }

        public void SetMaterial(char material)
        {
            _material = Convert.ToString(material);
        }

        public string GetMaterial()
        {
            return _material;
        }

        public static Material operator +(Material firstMaterial, Material secondMaterial)
        {
            Material tmp = new Material(firstMaterial._material + secondMaterial._material);
            return tmp;
        }
    }
}