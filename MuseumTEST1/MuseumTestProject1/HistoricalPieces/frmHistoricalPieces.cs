using Museum_BusinessLayer.HistoricalPieces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cooldatagridview;

namespace MuseumTestProject1.HistoricalPieces
{
    public partial class frmHistoricalPieces : Form
    {

        private static DataTable _dtAllPieces = clsHistoricalPiecesBusiness.GetAllHistoricalPieces();

        // we will cyt some columns from the above data table into a new one
        private DataTable _dtPieces = _dtAllPieces.DefaultView.ToTable(false,
            "HistoricalpieceID",
            "PieceName",
            "PieceDescription",
            "DivisionName",
            "AdditionalNotes"
            );

        private void _RefreshPiecesList()
        {

        }

        public frmHistoricalPieces()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private  void frmHistoricalPieces_Load(object sender, EventArgs e)
        {
            dgvPieces.DataSource = _dtPieces;
            lblPiecesCount.Text = dgvPieces.Rows.Count.ToString();

            

            if (dgvPieces.Rows.Count > 0)
            {
                dgvPieces.CoolGrid();
                dgvPieces.Columns[0].HeaderText = "ID";
                dgvPieces.Columns[0].Width = 35;

                dgvPieces.Columns[1].HeaderText = "اسم القطعة";
                dgvPieces.Columns[1].Width = 90;

                dgvPieces.Columns[2].HeaderText = "وظيفة القطعة";
                dgvPieces.Columns[2].Width = 390;

                dgvPieces.Columns[3].HeaderText = "تابعة لقسم";
                dgvPieces.Columns[3].Width = 90;

                dgvPieces.Columns[4].HeaderText = "ملاحظات اضافية";
                dgvPieces.Columns[4].Width = 390;

                
            }

            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
