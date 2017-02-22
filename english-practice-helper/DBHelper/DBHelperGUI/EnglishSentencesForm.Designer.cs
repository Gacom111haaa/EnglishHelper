namespace DBHelperGUI
{
    partial class EnglishSentencesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.cbSplit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Content :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(76, 44);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(383, 132);
            this.txtContent.TabIndex = 2;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(76, 194);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(383, 20);
            this.txtLevel.TabIndex = 3;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(216, 242);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(76, 242);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(384, 242);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // cbSplit
            // 
            this.cbSplit.AutoSize = true;
            this.cbSplit.Checked = true;
            this.cbSplit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSplit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbSplit.Location = new System.Drawing.Point(76, 13);
            this.cbSplit.Name = "cbSplit";
            this.cbSplit.Size = new System.Drawing.Size(398, 17);
            this.cbSplit.TabIndex = 7;
            this.cbSplit.Text = "Large sentence will be split to many sentences by \'.\' or \'new line\' ";
            this.cbSplit.UseVisualStyleBackColor = true;
            // 
            // EnglishSentencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 289);
            this.Controls.Add(this.cbSplit);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EnglishSentencesForm";
            this.Text = "EnglishSentencesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.CheckBox cbSplit;
    }
}