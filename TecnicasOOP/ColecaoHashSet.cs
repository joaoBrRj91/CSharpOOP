using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// HashSet utiliza o codigo hash para  agrupar elemntos em categorias(ele faz isso automaticamente
/// ) para uma melhor busca de elementos
/// </summary>
namespace TecnicasOOP
{
    class ColecaoHashSet
    {

        HashSet<int> Conjunto1 = new HashSet<int>();
        HashSet<int> Conjunto2 = new HashSet<int>();

        public void AddElementoConjunto()
        {
            Conjunto1.Add(1);
            Conjunto1.Add(2);
            Conjunto1.Add(3);
            Conjunto1.Add(4);

            Conjunto2.Add(3);
            Conjunto2.Add(4);
            Conjunto2.Add(5);
            Conjunto2.Add(6);
            Conjunto2.Add(7);
            Conjunto2.Add(8);

        }

        public void InterccaoConjuntoAB() => Conjunto1.IntersectWith(Conjunto2);

        public void UniaoConjuntoAB() => Conjunto1.UnionWith(Conjunto2);

        public void DiferencaConjuntoAParaB() => Conjunto1.ExceptWith(Conjunto1);

    }
}
