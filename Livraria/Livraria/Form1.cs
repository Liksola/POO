using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace Livraria
{
    public partial class Livraria : Form
    {
        private SQLiteConnectionManager connectionManager;

        public Livraria()
        {
            InitializeComponent();

            // Inicializando o gerenciador de conexão com o caminho do banco de dados
            string databasePath = "livraria.db";
            connectionManager = new SQLiteConnectionManager(databasePath);

            // Criar a tabela de livros no banco de dados se ela ainda não existir
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS Livros (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Titulo TEXT NOT NULL,
                                        Autor TEXT NOT NULL,
                                        Ano INTEGER NOT NULL,
                                        Genero TEXT,
                                        Isbn TEXT UNIQUE NOT NULL
                                    );";

            connectionManager.ExecuteNonQuery(createTableQuery);
        }

        // Adicionar livro ao banco de dados
        private void buttAdicionar_Click(object sender, EventArgs e)
        {
            int ano = int.Parse(Ano.Text);

            string insertQuery = $"INSERT INTO Livros (Titulo, Autor, Ano, Genero, Isbn) " +
                                 $"VALUES ('{Titulo.Text}', '{Autor.Text}', {ano}, '{Genero.Text}', '{ISBN.Text}')";

            connectionManager.ExecuteNonQuery(insertQuery);


            AtualizarLista();
        }

        // Atualizar lista de livros na interface
        private void AtualizarLista()
        {
            Lista.Items.Clear();

            string selectQuery = "SELECT * FROM Livros";
            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string informacoesLivro = $"Título: {reader["Titulo"]}, Autor: {reader["Autor"]}, " +
                                                      $"Ano: {reader["Ano"]}, Gênero: {reader["Genero"]}, ISBN: {reader["Isbn"]}";
                            Lista.Items.Add(informacoesLivro);
                        }
                    }
                }

                connectionManager.CloseConnection(connection);
            }
        }

        // Editar livro selecionado
        private void butEditar_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex != -1)
            {
                int ano = int.Parse(Ano.Text);
                int id = Lista.SelectedIndex + 1;

                string updateQuery = $"UPDATE Livros SET Titulo = '{Titulo.Text}', Autor = '{Autor.Text}', " +
                                     $"Ano = {ano}, Genero = '{Genero.Text}', Isbn = '{ISBN.Text}' WHERE Id = {id}";

                connectionManager.ExecuteNonQuery(updateQuery);



            }
        }

        // Remover livro selecionado
        private void buttRemover_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex != -1)
            {
                int id = Lista.SelectedIndex + 1;

                string deleteQuery = $"DELETE FROM Livros WHERE Id = {id}";

                connectionManager.ExecuteNonQuery(deleteQuery);



            }
        }


        private void buttListar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
