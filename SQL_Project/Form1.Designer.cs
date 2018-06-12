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
            this.labelColheita = new System.Windows.Forms.Label();
            this.listaColheitas = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.quintaDeBatatasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // quintaDeBatatasDataSet
            // 
            this.quintaDeBatatasDataSet.DataSetName = "QuintaDeBatatasDataSet";
            this.quintaDeBatatasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelColheita
            // 
            this.labelColheita.AutoSize = true;
            this.labelColheita.Location = new System.Drawing.Point(36, 45);
            this.labelColheita.Name = "labelColheita";
            this.labelColheita.Size = new System.Drawing.Size(59, 17);
            this.labelColheita.TabIndex = 0;
            this.labelColheita.Text = "Colheita";
            // 
            // listaColheitas
            // 
            this.listaColheitas.FormattingEnabled = true;
            this.listaColheitas.ItemHeight = 16;
            this.listaColheitas.Location = new System.Drawing.Point(39, 66);
            this.listaColheitas.Name = "listaColheitas";
            this.listaColheitas.Size = new System.Drawing.Size(120, 116);
            this.listaColheitas.TabIndex = 1;
            this.listaColheitas.SelectedIndexChanged += new System.EventHandler(this.listaColheitas_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1239, 602);
            this.Controls.Add(this.listaColheitas);
            this.Controls.Add(this.labelColheita);
            this.Name = "MainForm";
            this.Text = "A pretty Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quintaDeBatatasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuintaDeBatatasDataSet quintaDeBatatasDataSet;
        private System.Windows.Forms.Label labelColheita;
        private System.Windows.Forms.ListBox listaColheitas;
    }
}

