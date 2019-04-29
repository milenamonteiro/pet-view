namespace PetView
{
    partial class FormAnimal
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpCadastroAnimal = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDono = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.txtRGA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.nupIdade = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.flpBotoes = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpCadastroAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupIdade)).BeginInit();
            this.flpBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCadastroAnimal
            // 
            this.tlpCadastroAnimal.ColumnCount = 4;
            this.tlpCadastroAnimal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCadastroAnimal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpCadastroAnimal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCadastroAnimal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpCadastroAnimal.Controls.Add(this.label2, 0, 1);
            this.tlpCadastroAnimal.Controls.Add(this.cboDono, 1, 0);
            this.tlpCadastroAnimal.Controls.Add(this.label3, 2, 1);
            this.tlpCadastroAnimal.Controls.Add(this.label4, 0, 2);
            this.tlpCadastroAnimal.Controls.Add(this.label5, 2, 2);
            this.tlpCadastroAnimal.Controls.Add(this.label6, 0, 3);
            this.tlpCadastroAnimal.Controls.Add(this.label1, 0, 0);
            this.tlpCadastroAnimal.Controls.Add(this.txtEspecie, 1, 1);
            this.tlpCadastroAnimal.Controls.Add(this.txtRaca, 3, 1);
            this.tlpCadastroAnimal.Controls.Add(this.txtNomeAnimal, 1, 2);
            this.tlpCadastroAnimal.Controls.Add(this.txtRGA, 1, 3);
            this.tlpCadastroAnimal.Controls.Add(this.label7, 0, 4);
            this.tlpCadastroAnimal.Controls.Add(this.rtxtDescricao, 1, 4);
            this.tlpCadastroAnimal.Controls.Add(this.nupIdade, 3, 2);
            this.tlpCadastroAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCadastroAnimal.Location = new System.Drawing.Point(0, 74);
            this.tlpCadastroAnimal.Name = "tlpCadastroAnimal";
            this.tlpCadastroAnimal.Padding = new System.Windows.Forms.Padding(10, 10, 10, 80);
            this.tlpCadastroAnimal.RowCount = 6;
            this.tlpCadastroAnimal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpCadastroAnimal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpCadastroAnimal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpCadastroAnimal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpCadastroAnimal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlpCadastroAnimal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpCadastroAnimal.Size = new System.Drawing.Size(1170, 536);
            this.tlpCadastroAnimal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F);
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(35, 10, 10, 10);
            this.label2.Size = new System.Drawing.Size(115, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Espécie:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDono
            // 
            this.cboDono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDono.Font = new System.Drawing.Font("Calibri", 13F);
            this.cboDono.FormattingEnabled = true;
            this.cboDono.Location = new System.Drawing.Point(269, 22);
            this.cboDono.Name = "cboDono";
            this.cboDono.Size = new System.Drawing.Size(286, 29);
            this.cboDono.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F);
            this.label3.Location = new System.Drawing.Point(588, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(35, 10, 10, 10);
            this.label3.Size = new System.Drawing.Size(96, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "Raça:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13F);
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(35, 10, 10, 10);
            this.label4.Size = new System.Drawing.Size(181, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome do animal:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13F);
            this.label5.Location = new System.Drawing.Point(588, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(35, 10, 10, 10);
            this.label5.Size = new System.Drawing.Size(101, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "Idade:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13F);
            this.label6.Location = new System.Drawing.Point(13, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(35, 10, 10, 10);
            this.label6.Size = new System.Drawing.Size(91, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "RGA:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F);
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(35, 10, 10, 10);
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dono:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEspecie.Font = new System.Drawing.Font("Calibri", 13F);
            this.txtEspecie.Location = new System.Drawing.Point(274, 78);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(276, 29);
            this.txtEspecie.TabIndex = 19;
            // 
            // txtRaca
            // 
            this.txtRaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRaca.Font = new System.Drawing.Font("Calibri", 13F);
            this.txtRaca.Location = new System.Drawing.Point(849, 78);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(276, 29);
            this.txtRaca.TabIndex = 20;
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeAnimal.Font = new System.Drawing.Font("Calibri", 13F);
            this.txtNomeAnimal.Location = new System.Drawing.Point(274, 133);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(276, 29);
            this.txtNomeAnimal.TabIndex = 21;
            // 
            // txtRGA
            // 
            this.txtRGA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRGA.Font = new System.Drawing.Font("Calibri", 13F);
            this.txtRGA.Location = new System.Drawing.Point(274, 188);
            this.txtRGA.Name = "txtRGA";
            this.txtRGA.Size = new System.Drawing.Size(276, 29);
            this.txtRGA.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13F);
            this.label7.Location = new System.Drawing.Point(13, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(35, 10, 10, 10);
            this.label7.Size = new System.Drawing.Size(132, 42);
            this.label7.TabIndex = 12;
            this.label7.Text = "Descrição:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxtDescricao
            // 
            this.rtxtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtDescricao.Font = new System.Drawing.Font("Calibri", 13F);
            this.rtxtDescricao.Location = new System.Drawing.Point(274, 241);
            this.rtxtDescricao.Name = "rtxtDescricao";
            this.rtxtDescricao.Size = new System.Drawing.Size(276, 152);
            this.rtxtDescricao.TabIndex = 24;
            this.rtxtDescricao.Text = "";
            // 
            // nupIdade
            // 
            this.nupIdade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nupIdade.Font = new System.Drawing.Font("Calibri", 13F);
            this.nupIdade.Location = new System.Drawing.Point(849, 133);
            this.nupIdade.Name = "nupIdade";
            this.nupIdade.Size = new System.Drawing.Size(277, 29);
            this.nupIdade.TabIndex = 25;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(770, 10);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(175, 50);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(575, 10);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(10);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(175, 50);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(965, 10);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(10);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(175, 50);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(1170, 74);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cadastrar animal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpBotoes
            // 
            this.flpBotoes.Controls.Add(this.btnCadastrar);
            this.flpBotoes.Controls.Add(this.btnCancelar);
            this.flpBotoes.Controls.Add(this.btnLimpar);
            this.flpBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpBotoes.Location = new System.Drawing.Point(0, 610);
            this.flpBotoes.Name = "flpBotoes";
            this.flpBotoes.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.flpBotoes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpBotoes.Size = new System.Drawing.Size(1170, 100);
            this.flpBotoes.TabIndex = 7;
            // 
            // FormAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpCadastroAnimal);
            this.Controls.Add(this.flpBotoes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormAnimal";
            this.Size = new System.Drawing.Size(1170, 710);
            this.tlpCadastroAnimal.ResumeLayout(false);
            this.tlpCadastroAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupIdade)).EndInit();
            this.flpBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCadastroAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.TextBox txtRGA;
        private System.Windows.Forms.RichTextBox rtxtDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel flpBotoes;
        private System.Windows.Forms.NumericUpDown nupIdade;
    }
}
