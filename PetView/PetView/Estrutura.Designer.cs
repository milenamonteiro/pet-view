namespace PetView
{
    partial class Estrutura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnDono = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.registros1 = new PetView.Registros();
            this.agendamento1 = new PetView.Agendamento();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnAgendamento);
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Controls.Add(this.btnAnimal);
            this.panel1.Controls.Add(this.btnDono);
            this.panel1.Controls.Add(this.btnFuncionario);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnMedico);
            this.panel1.Controls.Add(this.btnRegistros);
            this.panel1.Controls.Add(this.btnAgenda);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 768);
            this.panel1.TabIndex = 0;
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.btnAgendamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAgendamento.FlatAppearance.BorderSize = 0;
            this.btnAgendamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgendamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgendamento.Location = new System.Drawing.Point(0, 48);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Padding = new System.Windows.Forms.Padding(10);
            this.btnAgendamento.Size = new System.Drawing.Size(196, 80);
            this.btnAgendamento.TabIndex = 10;
            this.btnAgendamento.Text = "Novo agendamento";
            this.btnAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamento.UseVisualStyleBackColor = false;
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgendamento_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastro.Location = new System.Drawing.Point(0, 128);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(10);
            this.btnCadastro.Size = new System.Drawing.Size(196, 80);
            this.btnCadastro.TabIndex = 9;
            this.btnCadastro.Text = "Novo cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAnimal.FlatAppearance.BorderSize = 0;
            this.btnAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.Font = new System.Drawing.Font("Calibri", 13F);
            this.btnAnimal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAnimal.Location = new System.Drawing.Point(0, 208);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Padding = new System.Windows.Forms.Padding(30, 10, 10, 10);
            this.btnAnimal.Size = new System.Drawing.Size(196, 80);
            this.btnAnimal.TabIndex = 8;
            this.btnAnimal.Text = "Animal";
            this.btnAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnimal.UseVisualStyleBackColor = false;
            this.btnAnimal.Visible = false;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnDono
            // 
            this.btnDono.BackColor = System.Drawing.Color.Transparent;
            this.btnDono.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDono.FlatAppearance.BorderSize = 0;
            this.btnDono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDono.Font = new System.Drawing.Font("Calibri", 13F);
            this.btnDono.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDono.Location = new System.Drawing.Point(0, 288);
            this.btnDono.Name = "btnDono";
            this.btnDono.Padding = new System.Windows.Forms.Padding(30, 10, 10, 10);
            this.btnDono.Size = new System.Drawing.Size(196, 80);
            this.btnDono.TabIndex = 7;
            this.btnDono.Text = "Dono";
            this.btnDono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDono.UseVisualStyleBackColor = false;
            this.btnDono.Visible = false;
            this.btnDono.Click += new System.EventHandler(this.btnDono_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Calibri", 13F);
            this.btnFuncionario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFuncionario.Location = new System.Drawing.Point(0, 368);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Padding = new System.Windows.Forms.Padding(30, 10, 10, 10);
            this.btnFuncionario.Size = new System.Drawing.Size(196, 80);
            this.btnFuncionario.TabIndex = 6;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Visible = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(196, 58);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnMedico
            // 
            this.btnMedico.BackColor = System.Drawing.Color.Transparent;
            this.btnMedico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMedico.FlatAppearance.BorderSize = 0;
            this.btnMedico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMedico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedico.Font = new System.Drawing.Font("Calibri", 13F);
            this.btnMedico.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMedico.Location = new System.Drawing.Point(0, 448);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Padding = new System.Windows.Forms.Padding(30, 10, 10, 10);
            this.btnMedico.Size = new System.Drawing.Size(196, 80);
            this.btnMedico.TabIndex = 5;
            this.btnMedico.Text = "Médico";
            this.btnMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedico.UseVisualStyleBackColor = false;
            this.btnMedico.Visible = false;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegistros.FlatAppearance.BorderSize = 0;
            this.btnRegistros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistros.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistros.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegistros.Location = new System.Drawing.Point(0, 528);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Padding = new System.Windows.Forms.Padding(10);
            this.btnRegistros.Size = new System.Drawing.Size(196, 80);
            this.btnRegistros.TabIndex = 4;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistros.UseVisualStyleBackColor = false;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.Transparent;
            this.btnAgenda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgenda.Location = new System.Drawing.Point(0, 608);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Padding = new System.Windows.Forms.Padding(10);
            this.btnAgenda.Size = new System.Drawing.Size(196, 80);
            this.btnAgenda.TabIndex = 3;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogOut.Location = new System.Drawing.Point(0, 688);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10);
            this.btnLogOut.Size = new System.Drawing.Size(196, 80);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Sair";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(196, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 58);
            this.panel2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Location = new System.Drawing.Point(1095, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 58);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // registros1
            // 
            this.registros1.Location = new System.Drawing.Point(213, 162);
            this.registros1.Name = "registros1";
            this.registros1.Size = new System.Drawing.Size(727, 95);
            this.registros1.TabIndex = 3;
            this.registros1.Visible = false;
            // 
            // agendamento1
            // 
            this.agendamento1.Location = new System.Drawing.Point(213, 64);
            this.agendamento1.Name = "agendamento1";
            this.agendamento1.Size = new System.Drawing.Size(727, 70);
            this.agendamento1.TabIndex = 2;
            this.agendamento1.Visible = false;
            // 
            // Estrutura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.registros1);
            this.Controls.Add(this.agendamento1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estrutura";
            this.Text = "Estrutura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSair;
        private Agendamento agendamento1;
        private Registros registros1;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnDono;
    }
}