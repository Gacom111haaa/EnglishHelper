using DBHelper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
namespace DBHelperGUI
{
    public partial class DBGUI : Form
    {
        private IEnglishSentencesRepository target = null;
        private List<EnglishSentences> actual = null;
        public DBGUI()
        {
            InitializeComponent();
            if (target == null)
            {
                target = new EnglishSentencesRepository();
            }
        }

        private void DBGUI_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            EnglishSentencesForm ESF = new EnglishSentencesForm(null, true);
            ESF.FormClosed += new FormClosedEventHandler(CRUD_FormClosed);
            ESF.ShowDialog();
        }
        void CRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshGrid(txtContentSearch.Text, txtLevelSearch.Text);
        }
        private void btRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid(txtContentSearch.Text, txtLevelSearch.Text);
        }

        public void RefreshGrid(string content = "", string level = "")
        {
            try
            {
                IEnumerable<EnglishSentences> iq = target.ToList();
                if (!string.IsNullOrEmpty(content))
                {
                    iq = iq.Where(o => o.Content.Contains(txtContentSearch.Text));
                }
                if (!string.IsNullOrEmpty(level))
                {
                    int iLevel = 0;
                    try
                    {
                        iLevel = int.Parse(level);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not parse " + level + ",make sure your level is numberic.");
                    }
                    iq = iq.Where(o => o.Level == iLevel);
                }
                if (iq != null)
                {
                    actual = iq.ToList();
                    dataGridView1.DataSource = actual;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var form = dataGridView1.Rows[e.RowIndex].DataBoundItem as EnglishSentences;
            if (form == null)
            {
                MessageBox.Show("Error happend,please try again!");
            }
            else
            {
                EnglishSentencesForm ESF = new EnglishSentencesForm(form);
                ESF.FormClosed += new FormClosedEventHandler(CRUD_FormClosed);
                ESF.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentDoubleClick(sender, e);
        }

        private void btQDelete_Click(object sender, EventArgs e)
        {
            if (actual != null)
            {
                try
                {

                    foreach (EnglishSentences eng in actual)
                    {
                        if (eng != null)
                        {
                            target.DeleteByID(eng.ID);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Delete success!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentDoubleClick(sender, e);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshGrid(txtContentSearch.Text, txtLevelSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}