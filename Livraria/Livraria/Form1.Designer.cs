namespace Livraria
{
    partial class Livraria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Titulo = new TextBox();
            Autor = new TextBox();
            Genero = new TextBox();
            Ano = new TextBox();
            ISBN = new TextBox();
            textBox6 = new TextBox();
            buttAdicionar = new Button();
            buttRemover = new Button();
            butEditar = new Button();
            buttListar = new Button();
            Lista = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            textBox3 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.BackColor = Color.FromArgb(192, 255, 255);
            Titulo.Location = new Point(80, 65);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(199, 23);
            Titulo.TabIndex = 0;
            // 
            // Autor
            // 
            Autor.BackColor = Color.FromArgb(192, 255, 255);
            Autor.Location = new Point(80, 94);
            Autor.Name = "Autor";
            Autor.Size = new Size(199, 23);
            Autor.TabIndex = 1;
            // 
            // Genero
            // 
            Genero.BackColor = Color.FromArgb(192, 255, 255);
            Genero.Location = new Point(80, 152);
            Genero.Name = "Genero";
            Genero.Size = new Size(199, 23);
            Genero.TabIndex = 2;
            // 
            // Ano
            // 
            Ano.BackColor = Color.FromArgb(192, 255, 255);
            Ano.Location = new Point(80, 123);
            Ano.Name = "Ano";
            Ano.Size = new Size(199, 23);
            Ano.TabIndex = 18;
            // 
            // ISBN
            // 
            ISBN.BackColor = Color.FromArgb(192, 255, 255);
            ISBN.Location = new Point(80, 181);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(199, 23);
            ISBN.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Info;
            textBox6.Location = new Point(12, 12);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(369, 38);
            textBox6.TabIndex = 5;
            textBox6.Text = "Para adicionar um livro, preencha corretamente os campos abaixo e selecione a opcao Adicionar";
            // 
            // buttAdicionar
            // 
            buttAdicionar.BackColor = Color.FromArgb(192, 192, 255);
            buttAdicionar.Location = new Point(12, 211);
            buttAdicionar.Name = "buttAdicionar";
            buttAdicionar.Size = new Size(100, 40);
            buttAdicionar.TabIndex = 6;
            buttAdicionar.Text = "Adicionar";
            buttAdicionar.UseVisualStyleBackColor = false;
            buttAdicionar.Click += buttAdicionar_Click;
            // 
            // buttRemover
            // 
            buttRemover.BackColor = Color.FromArgb(192, 192, 255);
            buttRemover.Location = new Point(12, 374);
            buttRemover.Name = "buttRemover";
            buttRemover.Size = new Size(100, 40);
            buttRemover.TabIndex = 7;
            buttRemover.Text = "Remover";
            buttRemover.UseVisualStyleBackColor = false;
            buttRemover.Click += buttRemover_Click;
            // 
            // butEditar
            // 
            butEditar.BackColor = Color.FromArgb(192, 192, 255);
            butEditar.Location = new Point(12, 300);
            butEditar.Name = "butEditar";
            butEditar.Size = new Size(100, 40);
            butEditar.TabIndex = 8;
            butEditar.Text = "Editar";
            butEditar.UseVisualStyleBackColor = false;
            butEditar.Click += butEditar_Click;
            // 
            // buttListar
            // 
            buttListar.BackColor = Color.FromArgb(192, 192, 255);
            buttListar.Location = new Point(12, 449);
            buttListar.Name = "buttListar";
            buttListar.Size = new Size(100, 40);
            buttListar.TabIndex = 9;
            buttListar.Text = "Listar";
            buttListar.UseVisualStyleBackColor = false;
            buttListar.Click += buttListar_Click;
            // 
            // Lista
            // 
            Lista.BackColor = Color.FromArgb(192, 255, 192);
            Lista.FormattingEnabled = true;
            Lista.ItemHeight = 15;
            Lista.Location = new Point(387, 9);
            Lista.Name = "Lista";
            Lista.Size = new Size(484, 484);
            Lista.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(12, 65);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(62, 23);
            textBox1.TabIndex = 11;
            textBox1.Text = "Titulo";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(12, 94);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(62, 23);
            textBox2.TabIndex = 12;
            textBox2.Text = "Autor";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Info;
            textBox4.Location = new Point(12, 153);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(62, 23);
            textBox4.TabIndex = 14;
            textBox4.Text = "Genero";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Info;
            textBox5.Location = new Point(12, 182);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(62, 23);
            textBox5.TabIndex = 15;
            textBox5.Text = "ISBN";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Info;
            textBox7.Location = new Point(12, 123);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(62, 23);
            textBox7.TabIndex = 17;
            textBox7.Text = "Ano";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(12, 257);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(369, 37);
            textBox3.TabIndex = 19;
            textBox3.Text = "Para editar um livro, clique no livro na lista, altere as informacoes nos campos acima e clique em Editar";
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Info;
            textBox8.Location = new Point(12, 346);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(369, 22);
            textBox8.TabIndex = 20;
            textBox8.Text = "Para remover um livro, clique no livro na lista e clique em Remover";
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.Info;
            textBox9.Location = new Point(12, 420);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(369, 23);
            textBox9.TabIndex = 21;
            textBox9.Text = "Clique em Listar para exibir as alteracoes na lista";
            
            // 
            // Livraria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 498);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox3);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Lista);
            Controls.Add(buttListar);
            Controls.Add(butEditar);
            Controls.Add(buttRemover);
            Controls.Add(buttAdicionar);
            Controls.Add(textBox6);
            Controls.Add(ISBN);
            Controls.Add(Ano);
            Controls.Add(Genero);
            Controls.Add(Autor);
            Controls.Add(Titulo);
            Name = "Livraria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Livraria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Titulo;
        private TextBox Autor;
        private TextBox Genero;
        private TextBox Ano;
        private TextBox ISBN;
        private TextBox textBox6;
        private Button buttAdicionar;
        private Button buttRemover;
        private Button butEditar;
        private Button buttListar;
        private ListBox Lista;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox3;
        private TextBox textBox8;
        private TextBox textBox9;
    }
}
