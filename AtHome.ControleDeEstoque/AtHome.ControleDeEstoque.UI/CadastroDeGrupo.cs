using System;
using System.Windows.Forms;
using AtHome.ControleDeEstoque.Data;
using AtHome.ControleDeEstoque.Domain;

namespace AtHome.ControleDeEstoque.UI
{
    public partial class CadastroDeGrupo : Form
    {
        public CadastroDeGrupo()
        {
            InitializeComponent();
        }

        GrupoDAO _grupoDAO = new GrupoDAO();
        long _id;

        private void CadastroDeGrupo_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarRegistro();           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir?", CadastroDeGrupo.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    Grupo grupo = _grupoDAO.GetDataByID(_id);
                    _grupoDAO.Delete(grupo);                    
                    CarregarDataGrid();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, CadastroDeGrupo.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }   

        bool Validacao()
        {
            string msg = String.Empty;

            if (txtNomeGrupo.Text == String.Empty)
                msg = "Digitar o nome do grupo!\n";

            if (msg == String.Empty)
                return true;

            MessageBox.Show(msg, CadastroDeGrupo.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private void LimparCampos()
        {
            _id = 0;
            txtNomeGrupo.Text = String.Empty;
            grdGrupo.ClearSelection();
            txtNomeGrupo.Focus();
        }

        private void CarregarDataGrid()
        {
            try
            {

                this.grdGrupo.RowEnter -= new
                    DataGridViewCellEventHandler(grdGrupo_RowEnter);
 
                grdGrupo.DataSource = _grupoDAO.GetAll();
                grdGrupo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdGrupo.AllowUserToDeleteRows = false;

                grdGrupo.Columns["Id"].Visible = false;

                grdGrupo.Columns["Descricao"].Width = 250;
                grdGrupo.Columns["Descricao"].HeaderText = "Nome do Grupo";

                this.grdGrupo.RowEnter += new
                    DataGridViewCellEventHandler(grdGrupo_RowEnter);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CadastroDeGrupo.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grdGrupo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)grdGrupo.Rows[e.RowIndex];
            txtNomeGrupo.Text = row.Cells["Descricao"].Value.ToString();
            _id = Convert.ToInt64(row.Cells["id"].Value.ToString());
        }

        private void txtNomeGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) SalvarRegistro();
        }

        private void SalvarRegistro()
        {
            if (MessageBox.Show("Deseja salvar?", CadastroDeGrupo.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(System.Windows.Forms.DialogResult.Yes))
            {
                Grupo grupo = null;

                if (!Validacao()) return;

                if (!_id.Equals(0))
                {
                    grupo = _grupoDAO.GetDataByID(_id);
                    grupo.Descricao = txtNomeGrupo.Text;
                }
                else
                {
                    grupo = new Grupo(txtNomeGrupo.Text);
                }

                try
                {
                    if (!grupo.Id.Equals(0))
                        _grupoDAO.Update(grupo);
                    else
                        _id = _grupoDAO.Save(grupo);

                    CarregarDataGrid();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, CadastroDeGrupo.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                
        }

        private void txtNomeGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '[') || (e.KeyChar == ']') || (e.KeyChar == (char)39))
            {
                e.Handled = true;
            }
        }

        private void CadastroDeGrupo_Activated(object sender, EventArgs e)
        {
            txtNomeGrupo.Focus();
        }
                
    }
}
