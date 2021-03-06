﻿using System;
using Controller;
using System.Windows.Forms;

namespace View
{
    public partial class Frm_EditarServicoBase : Form
    {
        public Frm_EditarServicoBase()
        {
            InitializeComponent();
        }

        private void Frm_EditarServicoBase_Load(object sender, EventArgs e)
        {
            foreach (var item in ControllerServicoBase.LoadList())
            {
                Txt_ServicoBase.Items.Add(item);
            }
        }

        /// <summary>
        /// Gerando o arquivo com as informações do serviço base.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControllerServicoBase.Save(Txt_Nome.Text, Txt_Observacoes.Text, Txt_Valor.Text);
        }

        private void Btm_Carregar_Click(object sender, EventArgs e)
        {
            Model.ServicoBase servicoBase = new Model.ServicoBase();

            servicoBase = ControllerServicoBase.Load(Txt_ServicoBase.Text);

            Txt_Nome.Text = servicoBase.Nome;
            Txt_Observacoes.Text = servicoBase.Observacoes;
            Txt_Valor.Text = servicoBase.Valor;
        }
    }
}
