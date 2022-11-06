using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Controller
{
    public class FuncoesStatus
    {


        public bool verificarStatusBoolean(Status st)
        {
            switch (st)
            {
                case Status.INVALIDO:
                    return false;
                case Status.VALIDO:
                    return true;

            }
            return false;
        }

        public void imprimirAcesso(Status st)
        {
            switch (st)
            {
                case Status.INVALIDO:
                    break;
                case Status.VALIDO:
                    break;
            }
        }
    }
}
