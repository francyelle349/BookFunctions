using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class LivroController
    {
        public DataTable ListarLivrosDoBanco()
        {
            MostrarLivroParaFuncionario mostrarLivroParaFuncionario = new MostrarLivroParaFuncionario();
            var livros = mostrarLivroParaFuncionario.listaGrid();


            return livros;
        }

        public void apagarLivro(DataGridView data)
        {
            Livro livro = new Livro();

            livro.apagarLivros(data);
        }

        //controller cadastrar livro
        public void CadastroLivro(int isnb, String titulo,
              string autor, string descricao, string genero, int estoque, double saldoUnitario)
        {

            Livro livro = new Livro();

            livro.cadastroLivro(isnb, titulo, autor, descricao, genero, estoque, saldoUnitario);



        }


        public void atualizarLivros(string titulo, string autor, string descricao, string genero, long estoque, double precoUnitario, String isnb)
        {
            Livro livro = new Livro();

            livro.EditarLivro(titulo, autor, descricao, genero, estoque, precoUnitario, isnb);
        }
// mostrar os livros
        public DataTable ListarLivrosDoBanco()
        {
            Livro livro = new Livro();
            DataTable livros = livro.listaDeLivros();

            return livros;
        }
    }
}
