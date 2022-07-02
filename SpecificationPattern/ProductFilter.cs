using SpecificationPattern.Enums;
using System.Collections.Generic;

namespace SpecificationPattern
{
    public class ProductFilter
    {
        // Quando falamos sobre princípios SOLID, a letra O significa:
        // Open-close principle
        //
        // Ela diz que uma classe deve estar aberta para extensão mas fechada para modificação
        // No caso deste ProductFilter, este princípio foi ferido no momento em que foram implementados
        // os vários tipos de FilterBy
        // Assim, cada vez que for necessário um novo filtro, um novo método, com nova lógica seria implementado
        // nessa mesma classe, tornando ela grande, complexa e que sempre terá que ser modificada.
        //
        // Para resolver esse problema, o padrão Specification foi implementado no diretorio: SpecificationPattern

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
            {
                if (p.Color == color)
                    yield return p;
            }
        }

        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
            {
                if (p.Size == size)
                    yield return p;
            }
        }

        public IEnumerable<Product> FilterByColorAndBySize(IEnumerable<Product> products, Color color, Size size)
        {
            foreach (var p in products)
            {
                if (p.Color == color && p.Size == size)
                    yield return p;
            }
        }
    }
}
