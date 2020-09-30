using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Persistência.Base;
using Persistência.Models;
using DevExpress.XtraEditors;

namespace WF_Principal
{
    public partial class FrmLogin : FormBase
    {
        RepositorioUsuario repositorio;

        public bool logado = false;

        public FrmLogin()
        {
            InitializeComponent();
            this.repositorio = new RepositorioUsuario(new BANCO_AWMContext());
        }

        public void logar()
        {
            try
            {
                string usu = txtLogin.Text;
                string pwd = txtSenha.Text;

                if (repositorio.UsuarioEstaLogado(usu, pwd))
                {
                    logado = true;
                    this.Dispose();
                }
                else
                {
                    XtraMessageBox.Show("Usuário ou senha estão Incorretos!");
                    logado = false;
                }

            }
            catch(SqlException erro)
            {
                XtraMessageBox.Show(erro + "erro no banco");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            logar();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                logar();
        }
    }
}
