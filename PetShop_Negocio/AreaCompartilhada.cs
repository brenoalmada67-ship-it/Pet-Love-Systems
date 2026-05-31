using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PetShop_Negocio.Mapeamento;

namespace PetShop_Negocio
{
    /// Classe estática responsável por manter o estado da sessão global da aplicação.
    /// Armazena os dados do usuário autenticado para validação de permissões nas telas.
    public static class AreaCompartilhada
    {
        public static Usuario UsuarioLogado { get; set; }
    }
}
