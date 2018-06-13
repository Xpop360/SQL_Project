namespace SQL_Project
{
    partial class MainForm
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
            this.quintaDeBatatasDataSet = new SQL_Project.QuintaDeBatatasDataSet();
            this.listaColheitas = new System.Windows.Forms.ListBox();
            this.TipoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EpocaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrecoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quintaDeBatatasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // quintaDeBatatasDataSet
            // 
            this.quintaDeBatatasDataSet.DataSetName = "QuintaDeBatatasDataSet";
            this.quintaDeBatatasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaColheitas
            // 
            this.listaColheitas.FormattingEnabled = true;
            this.listaColheitas.ItemHeight = 16;
            this.listaColheitas.Location = new System.Drawing.Point(12, 410);
            this.listaColheitas.Name = "listaColheitas";
            this.listaColheitas.Size = new System.Drawing.Size(855, 180);
            this.listaColheitas.TabIndex = 1;
            this.listaColheitas.SelectedIndexChanged += new System.EventHandler(this.listaColheitas_SelectedIndexChanged);
            // 
            // TipoTextBox
            // 
            this.TipoTextBox.Location = new System.Drawing.Point(203, 38);
            this.TipoTextBox.Name = "TipoTextBox";
            this.TipoTextBox.Size = new System.Drawing.Size(134, 22);
            this.TipoTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // EpocaTextBox
            // 
            this.EpocaTextBox.Location = new System.Drawing.Point(203, 86);
            this.EpocaTextBox.Name = "EpocaTextBox";
            this.EpocaTextBox.Size = new System.Drawing.Size(134, 22);
            this.EpocaTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Época";
            // 
            // PrecoTextBox
            // 
            this.PrecoTextBox.Location = new System.Drawing.Point(203, 134);
            this.PrecoTextBox.Name = "PrecoTextBox";
            this.PrecoTextBox.Size = new System.Drawing.Size(134, 22);
            this.PrecoTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Preço (Kg)";
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(485, 38);
            this.DescTextBox.Multiline = true;
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(214, 118);
            this.DescTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descrição";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(51, 249);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(161, 73);
            this.Insert.TabIndex = 14;
            this.Insert.Text = "Inserir";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(354, 249);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(161, 73);
            this.Change.TabIndex = 15;
            this.Change.Text = "Alterar";
            this.Change.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(660, 249);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(161, 73);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Eliminar";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(879, 602);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrecoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EpocaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaColheitas);
            this.Name = "MainForm";
            this.Text = "A pretty Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quintaDeBatatasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuintaDeBatatasDataSet quintaDeBatatasDataSet;
        private System.Windows.Forms.ListBox listaColheitas;
        private System.Windows.Forms.TextBox TipoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EpocaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrecoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
    }
}

