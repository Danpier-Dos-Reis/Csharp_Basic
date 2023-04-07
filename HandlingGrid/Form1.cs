using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccesLawyer;
using HandlingGrid.Modelos;

namespace HandlingGrid
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            InitMainForm();
        }
        #region Métodos Privados
        private void InitMainForm()
        {
            LoadPeople();
        }

        private void LoadPeople(string searchText = null)
        {
            dgvPeople.DataSource = new frmMainFormDAL().GetPeople();
        }
        #endregion

        #region Eventos
        private void frmMain_Load(object sender, EventArgs e)
        {
            InitMainForm();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var people = new frmMainFormDAL().GetPeople(tbSearch.Text);
            dgvPeople.DataSource = people;
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            tbSearch.Text = null;
        }
        #endregion
    }
}
