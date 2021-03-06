﻿namespace SQL_Project
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
            this.components = new System.ComponentModel.Container();
            this.quintaDeBatatasDataSet = new SQL_Project.QuintaDeBatatasDataSet();
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
            this.listaBatatas = new System.Windows.Forms.DataGridView();
            this.quintaDeBatatasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quintaDeBatatasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBatatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quintaDeBatatasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // quintaDeBatatasDataSet
            // 
            this.quintaDeBatatasDataSet.DataSetName = "QuintaDeBatatasDataSet";
            this.quintaDeBatatasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TipoTextBox
            // 
            this.TipoTextBox.Location = new System.Drawing.Point(99, 36);
            this.TipoTextBox.Name = "TipoTextBox";
            this.TipoTextBox.Size = new System.Drawing.Size(134, 22);
            this.TipoTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // EpocaTextBox
            // 
            this.EpocaTextBox.Location = new System.Drawing.Point(99, 84);
            this.EpocaTextBox.Name = "EpocaTextBox";
            this.EpocaTextBox.Size = new System.Drawing.Size(134, 22);
            this.EpocaTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Época";
            // 
            // PrecoTextBox
            // 
            this.PrecoTextBox.Location = new System.Drawing.Point(99, 132);
            this.PrecoTextBox.Name = "PrecoTextBox";
            this.PrecoTextBox.Size = new System.Drawing.Size(134, 22);
            this.PrecoTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Preço (Kg)";
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(322, 34);
            this.DescTextBox.Multiline = true;
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(214, 118);
            this.DescTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descrição";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(34, 185);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(161, 73);
            this.Insert.TabIndex = 14;
            this.Insert.Text = "Inserir";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(193, 264);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(161, 73);
            this.Change.TabIndex = 15;
            this.Change.Text = "Alterar";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(375, 185);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(161, 73);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Eliminar";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // listaBatatas
            // 
            this.listaBatatas.AllowUserToAddRows = false;
            this.listaBatatas.AllowUserToDeleteRows = false;
            this.listaBatatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaBatatas.Location = new System.Drawing.Point(34, 360);
            this.listaBatatas.Name = "listaBatatas";
            this.listaBatatas.ReadOnly = true;
            this.listaBatatas.RowTemplate.Height = 24;
            this.listaBatatas.Size = new System.Drawing.Size(502, 230);
            this.listaBatatas.TabIndex = 17;
            this.listaBatatas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listaBatatas_CellMouseDoubleClick);
            // 
            // quintaDeBatatasDataSetBindingSource
            // 
            this.quintaDeBatatasDataSetBindingSource.DataSource = this.quintaDeBatatasDataSet;
            this.quintaDeBatatasDataSetBindingSource.Position = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(601, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 45);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Qual o tipo de Batata que foi plantada no terreno 2 e que usou fertilizante 15?";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(648, 176);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(240, 378);
            this.dataGridView2.TabIndex = 19;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(727, 104);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 20;
            this.buttonFind.Text = "Find Out!";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(920, 602);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listaBatatas);
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
            this.Name = "MainForm";
            this.Text = "A pretty Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quintaDeBatatasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBatatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quintaDeBatatasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuintaDeBatatasDataSet quintaDeBatatasDataSet;
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
        private System.Windows.Forms.DataGridView listaBatatas;
        private System.Windows.Forms.BindingSource quintaDeBatatasDataSetBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonFind;
    }
}

