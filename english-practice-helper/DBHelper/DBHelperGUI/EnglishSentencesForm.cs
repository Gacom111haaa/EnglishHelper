using DBHelper;
using System;
using System.Windows.Forms;

namespace DBHelperGUI
{
    public partial class EnglishSentencesForm : Form
    {
        private EnglishSentences form = null;
        private IEnglishSentencesRepository target = null;
        private bool create = false;
        public EnglishSentencesForm(EnglishSentences formInput = null, bool create = false)
        {
            InitializeComponent();
            this.form = formInput;
            this.create = create;
            FillData(form);
            ShowHideButton(create);
            if (target == null)
            {
                target = new EnglishSentencesRepository();
            }
        }

        private void FillData(EnglishSentences input)
        {
            if (input != null)
            {
                this.txtContent.Text = input.Content;
                this.txtLevel.Text = input.Level.HasValue ? form.Level.ToString() : "";
            }else
            {
                this.txtContent.Text = "";
                this.txtLevel.Text = "";
            }
        }

        private void ShowHideButton(bool create)
        {
            //if Create operation,so we hid Delete button
            this.btDelete.Visible = !create;
            this.cbSplit.Visible = create;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (create)
                {
                    if (cbSplit.Checked)
                    {
                        string[] allString = txtContent.Text.Split(new char[] { '.', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                        string result = "";
                        foreach (var item in allString)
                        {
                            form = new EnglishSentences();
                            form.Content = item;
                            if (!string.IsNullOrEmpty(txtLevel.Text))
                            {
                                form.Level = int.Parse(txtLevel.Text);
                            }
                            target.Create(form);
                            result += item + "\r\n";
                        }
                        result = "Create " + allString.Length + " sentences success:\r\n" + result;
                        MessageBox.Show(result);
                    }
                    else
                    {
                        form = new EnglishSentences();
                        form.Content = txtContent.Text;
                        if (!string.IsNullOrEmpty(txtLevel.Text))
                        {
                            form.Level = int.Parse(txtLevel.Text);
                        }
                        target.Create(form);
                    }
                }
                else
                {
                    form.Content = txtContent.Text;
                    if (!string.IsNullOrEmpty(txtLevel.Text))
                    {
                        form.Level = int.Parse(txtLevel.Text);
                    }
                    target.Update(form);
                    MessageBox.Show("Update success!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not that easy : " + ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really delete?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    target.DeleteByID(form.ID);
                    MessageBox.Show("Delete success!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not that easy : " + ex.Message);
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}