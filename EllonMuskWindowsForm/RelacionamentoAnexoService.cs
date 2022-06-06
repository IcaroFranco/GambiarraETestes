using System.Collections.Generic;

namespace EllonMuskWindowsForm
{
    public abstract class RelacionamentoAnexoService
    {
        public List<string> Anexos { get; set; } = new List<string>();
        public abstract string SalvarAnexo();
        public override string ToString() => GetType().Name;
    }

    public class AnexoClienteService : RelacionamentoAnexoService
    {

        public override string SalvarAnexo()
        {
            return "Salvo na tabela Anexo do Cliente";
        }
    }
    public class AnexoSolicitacaoService : RelacionamentoAnexoService
    {
        public override string SalvarAnexo()
        {
            return "Salvo na tabela Anexo da Solicitação";
        }
    }
    public class AnexoVisitaService : RelacionamentoAnexoService
    {
        public override string SalvarAnexo()
        {
            return "Salvo na tabela Anexo da Visita";
        }
    }
}
