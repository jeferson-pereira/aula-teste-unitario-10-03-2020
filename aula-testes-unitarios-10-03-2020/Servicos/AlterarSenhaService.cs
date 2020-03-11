using aula_testes_unitarios_10_03_2020.Interfaces;
using aula_testes_unitarios_10_03_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_testes_unitarios_10_03_2020.Servicos
{
    internal class AlterarSenhaService : ISubitemMenu
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public AlterarSenhaService(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Executar()
        {
            Console.WriteLine("Informe seu usuário: ");
            var nomeUsuario = Console.ReadLine();

            Console.WriteLine("Informe sua nova  senha: ");
            var senhaUsuario = Console.ReadLine();
            Console.WriteLine("Informe sua senha novamente: ");
            var senhaUsuarioDois = Console.ReadLine();

            if (senhaUsuario != senhaUsuarioDois)
                

            var usuario = _usuarioRepositorio.GetAll().FirstOrDefault(x => x.Nome.Equals(nomeUsuario));
            if (usuario != null)
                Console.WriteLine($"Bem vindo {usuario.Nome}");
            else
                Console.WriteLine("senha alterada com sucesso!");
        }
    }
}
