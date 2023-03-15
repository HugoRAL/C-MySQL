namespace test1
{
    partial class Form1
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
            this.BoxName = new System.Windows.Forms.TextBox();
            this.BoxPass = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.LabelSus = new System.Windows.Forms.Label();
            this.Dados = new System.Windows.Forms.DataGridView();
            this.BntInsert = new System.Windows.Forms.Button();
            this.BntUpdate = new System.Windows.Forms.Button();
            this.BntRemove = new System.Windows.Forms.Button();
            this.TBID = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(136, 150);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(100, 20);
            this.BoxName.TabIndex = 0;
            // 
            // BoxPass
            // 
            this.BoxPass.Location = new System.Drawing.Point(136, 189);
            this.BoxPass.Name = "BoxPass";
            this.BoxPass.Size = new System.Drawing.Size(100, 20);
            this.BoxPass.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(100, 248);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // LabelSus
            // 
            this.LabelSus.AutoSize = true;
            this.LabelSus.Location = new System.Drawing.Point(133, 292);
            this.LabelSus.Name = "LabelSus";
            this.LabelSus.Size = new System.Drawing.Size(0, 13);
            this.LabelSus.TabIndex = 3;
            // 
            // Dados
            // 
            this.Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dados.Location = new System.Drawing.Point(332, 51);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(403, 242);
            this.Dados.TabIndex = 4;
            // 
            // BntInsert
            // 
            this.BntInsert.Location = new System.Drawing.Point(28, 51);
            this.BntInsert.Name = "BntInsert";
            this.BntInsert.Size = new System.Drawing.Size(75, 23);
            this.BntInsert.TabIndex = 5;
            this.BntInsert.Text = "Insert";
            this.BntInsert.UseVisualStyleBackColor = true;
            this.BntInsert.Click += new System.EventHandler(this.BntInsert_Click);
            // 
            // BntUpdate
            // 
            this.BntUpdate.Location = new System.Drawing.Point(119, 51);
            this.BntUpdate.Name = "BntUpdate";
            this.BntUpdate.Size = new System.Drawing.Size(75, 23);
            this.BntUpdate.TabIndex = 6;
            this.BntUpdate.Text = "Update";
            this.BntUpdate.UseVisualStyleBackColor = true;
            this.BntUpdate.Click += new System.EventHandler(this.BntUpdate_Click);
            // 
            // BntRemove
            // 
            this.BntRemove.Location = new System.Drawing.Point(211, 51);
            this.BntRemove.Name = "BntRemove";
            this.BntRemove.Size = new System.Drawing.Size(75, 23);
            this.BntRemove.TabIndex = 7;
            this.BntRemove.Text = "Remove";
            this.BntRemove.UseVisualStyleBackColor = true;
            this.BntRemove.Click += new System.EventHandler(this.BntRemove_Click);
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(136, 111);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(100, 20);
            this.TBID.TabIndex = 8;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(72, 114);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(18, 13);
            this.LabelID.TabIndex = 9;
            this.LabelID.Text = "ID";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(72, 153);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Nome";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(72, 192);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(53, 13);
            this.labelPass.TabIndex = 11;
            this.labelPass.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Banco de dados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(763, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.BntRemove);
            this.Controls.Add(this.BntUpdate);
            this.Controls.Add(this.BntInsert);
            this.Controls.Add(this.Dados);
            this.Controls.Add(this.LabelSus);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.BoxPass);
            this.Controls.Add(this.BoxName);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.TextBox BoxPass;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label LabelSus;
        private System.Windows.Forms.DataGridView Dados;
        private System.Windows.Forms.Button BntInsert;
        private System.Windows.Forms.Button BntUpdate;
        private System.Windows.Forms.Button BntRemove;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label label1;
    }
}

