using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAvanSistema_TratamentoErro_Aula04_Exercicios
{
    internal class ExcecaoAcimaDeCem : Exception
    {
        public ExcecaoAcimaDeCem (double soma) : base($"A soma ultrapassou 100") { }
    }
}
