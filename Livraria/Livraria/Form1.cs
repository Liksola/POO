using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Livraria
{
    public partial class Livraria : Form
    {
        public Livraria()
        {
            InitializeComponent();
        }
        private List<Livro> livros = new List<Livro>();

        private void buttAdicionar_Click(object sender, EventArgs e)
        {
            int ano = int.Parse(Ano.Text);

            Livro novoLivro = new Livro(Titulo.Text, Autor.Text, ano, Genero.Text, ISBN.Text);

            livros.Add(novoLivro);
            AtualizarLista();
        }
        private void AtualizarLista()
        {
            Lista.Items.Clear();
            foreach (var livro in livros)
            {
                string informacoesLivro = $"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}, Gênero: {livro.Genero}, ISBN: {livro.ISBN}";
                Lista.Items.Add(informacoesLivro);
            }
        }
        private void buttListar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            Livro livroSelecionado = livros[Lista.SelectedIndex];

            livroSelecionado.Titulo = Titulo.Text;
            livroSelecionado.Autor = Autor.Text;
            livroSelecionado.Ano = int.Parse(Ano.Text);
            livroSelecionado.Genero = Genero.Text;
            livroSelecionado.ISBN = ISBN.Text;

        }

        private void buttRemover_Click(object sender, EventArgs e)
        {
            livros.RemoveAt(Lista.SelectedIndex);

        }
    }
}

