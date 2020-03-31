namespace ReadClick
{
    partial class ReadClick
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerParaEscreverTexto = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.InvervaloParaIniciar = new System.Windows.Forms.TextBox();
            this.AbrirArquivo = new System.Windows.Forms.OpenFileDialog();
            this.CaminhoArquivo = new System.Windows.Forms.TextBox();
            this.BtnAbrirArquivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IntervaloEscrita = new System.Windows.Forms.TextBox();
            this.Iniciar = new System.Windows.Forms.Button();
            this.CaixaDeTexto = new System.Windows.Forms.RichTextBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.TimerParaEscrever = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimerParaEscreverTexto
            // 
            this.TimerParaEscreverTexto.Tick += new System.EventHandler(this.TimerParaEscreverTexto_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo Para Iniciar (Em Segundos)";
            // 
            // InvervaloParaIniciar
            // 
            this.InvervaloParaIniciar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvervaloParaIniciar.Location = new System.Drawing.Point(220, 13);
            this.InvervaloParaIniciar.Name = "InvervaloParaIniciar";
            this.InvervaloParaIniciar.Size = new System.Drawing.Size(100, 23);
            this.InvervaloParaIniciar.TabIndex = 1;
            this.InvervaloParaIniciar.Text = "10";
            // 
            // AbrirArquivo
            // 
            this.AbrirArquivo.FileName = "AbrirArquivo";
            // 
            // CaminhoArquivo
            // 
            this.CaminhoArquivo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaminhoArquivo.Location = new System.Drawing.Point(188, 53);
            this.CaminhoArquivo.Name = "CaminhoArquivo";
            this.CaminhoArquivo.Size = new System.Drawing.Size(533, 23);
            this.CaminhoArquivo.TabIndex = 2;
            // 
            // BtnAbrirArquivo
            // 
            this.BtnAbrirArquivo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirArquivo.Location = new System.Drawing.Point(14, 46);
            this.BtnAbrirArquivo.Name = "BtnAbrirArquivo";
            this.BtnAbrirArquivo.Size = new System.Drawing.Size(168, 34);
            this.BtnAbrirArquivo.TabIndex = 3;
            this.BtnAbrirArquivo.Text = "Selecionar Arquivo";
            this.BtnAbrirArquivo.UseVisualStyleBackColor = true;
            this.BtnAbrirArquivo.Click += new System.EventHandler(this.BtnAbrirArquivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Intervalo de Escrita (Em Segundos)";
            // 
            // IntervaloEscrita
            // 
            this.IntervaloEscrita.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervaloEscrita.Location = new System.Drawing.Point(621, 13);
            this.IntervaloEscrita.Name = "IntervaloEscrita";
            this.IntervaloEscrita.Size = new System.Drawing.Size(100, 23);
            this.IntervaloEscrita.TabIndex = 5;
            this.IntervaloEscrita.Text = "10";
            // 
            // Iniciar
            // 
            this.Iniciar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciar.Location = new System.Drawing.Point(14, 416);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(232, 38);
            this.Iniciar.TabIndex = 6;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // CaixaDeTexto
            // 
            this.CaixaDeTexto.Location = new System.Drawing.Point(14, 86);
            this.CaixaDeTexto.Name = "CaixaDeTexto";
            this.CaixaDeTexto.Size = new System.Drawing.Size(707, 324);
            this.CaixaDeTexto.TabIndex = 7;
            this.CaixaDeTexto.Text = "";
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(489, 416);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(232, 38);
            this.Limpar.TabIndex = 8;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // TimerParaEscrever
            // 
            this.TimerParaEscrever.Tick += new System.EventHandler(this.TimerParaEscrever_Tick);
            // 
            // ReadClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 466);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.CaixaDeTexto);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.IntervaloEscrita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAbrirArquivo);
            this.Controls.Add(this.CaminhoArquivo);
            this.Controls.Add(this.InvervaloParaIniciar);
            this.Controls.Add(this.label1);
            this.Name = "ReadClick";
            this.Text = "ReadClick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerParaEscreverTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InvervaloParaIniciar;
        private System.Windows.Forms.OpenFileDialog AbrirArquivo;
        private System.Windows.Forms.TextBox CaminhoArquivo;
        private System.Windows.Forms.Button BtnAbrirArquivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IntervaloEscrita;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.RichTextBox CaixaDeTexto;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Timer TimerParaEscrever;
    }
}

