using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetView
{
    public partial class Estrutura : Form
    {
        public Estrutura()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void OpenUserControl(UserControl usercontrol, Button button)
        {
            button.Font = new Font(button.Font.Name, 14, FontStyle.Bold);
            usercontrol.Visible = true;
            usercontrol.BringToFront();
            usercontrol.Dock = DockStyle.Fill;
        }

        void UnClickAllButtons()
        {
            List<Button> list = new List<Button> {btnAgendamento, btnCadastro, btnAnimal, btnDono, btnFuncionario, btnMedico, btnRegistros, btnAgenda, btnLogOut};
            list.ForEach(item => item.Font = new Font(btnAgendamento.Font.Name, 14, FontStyle.Regular));
        }

        void UnClickbtnCadastro()
        {
            List<Button> list = new List<Button> {btnAnimal, btnDono, btnFuncionario, btnMedico};
            list.ForEach(item => item.Visible = false);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (btnAnimal.Visible == false)
            {
                UnClickAllButtons();
                btnCadastro.Font = new Font(btnCadastro.Font.Name, 14, FontStyle.Bold);
                btnAnimal.Visible = true;
                btnDono.Visible = true;
                btnFuncionario.Visible = true;
                btnMedico.Visible = true;
            }
            else {
                UnClickAllButtons();
                UnClickbtnCadastro();
            }
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            UnClickAllButtons();
            UnClickbtnCadastro();
            OpenUserControl(agendamento1, btnAgendamento);
        }


        private void btnRegistros_Click(object sender, EventArgs e)
        {
            UnClickAllButtons();
            UnClickbtnCadastro();
            OpenUserControl(registros1, btnRegistros);
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            UnClickAllButtons();
            UnClickbtnCadastro();
            //OpenUserControl(agenda1, btnAgenda);
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            UnClickAllButtons();
            OpenUserControl(formAnimal1, btnAnimal);
        }

        private void btnDono_Click(object sender, EventArgs e)
        {
            UnClickAllButtons();
            OpenUserControl(formDono1, btnDono);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            UnClickAllButtons();
            OpenUserControl(formFuncionario1, btnFuncionario);
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            UnClickAllButtons();
            OpenUserControl(formMedico1, btnMedico);
        }
    }
}
