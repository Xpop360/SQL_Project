namespace SQL_Project
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
            this.quintaDeBatatasDataSet = new SQL_Project.QuintaDeBatatasDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.quintaDeBatatasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // quintaDeBatatasDataSet
            // 
            this.quintaDeBatatasDataSet.DataSetName = "QuintaDeBatatasDataSet";
            this.quintaDeBatatasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(753, 411);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quintaDeBatatasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QuintaDeBatatasDataSet quintaDeBatatasDataSet;
    }
}

