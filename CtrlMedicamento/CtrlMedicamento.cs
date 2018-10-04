using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dados;

namespace Controle
{
    public class CtrlMedicamento
    {
        public void SalvarMedicamentoNoArquivo(String _path, Medicamento _p)
        {
            try
            {
                MedicamentoDAO dao = new MedicamentoDAO();

                dao.SalvarMedicamentoArqivo(_path, _p);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Dictionary<Int64, Medicamento> ObterMedicamentoDoArquivo(String _path)
        {
            try
            {
                MedicamentoDAO dao = new MedicamentoDAO();

                return dao.ObterMedicamentoDoArquivo(_path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
