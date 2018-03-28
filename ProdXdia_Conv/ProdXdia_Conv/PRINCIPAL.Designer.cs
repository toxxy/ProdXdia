namespace ProdXdia_Conv
{
    partial class CONVERSION_DIARIA
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
            this.CONVERSIONDIARIA = new System.Windows.Forms.DataGridView();
            this.SUMMARYMANODEOBRA = new System.Windows.Forms.DataGridView();
            this.SUMMARYCONVERSIONDIARIA = new System.Windows.Forms.DataGridView();
            this.REPORTEMANODEOBRA = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CONVERSIONDIARIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUMMARYMANODEOBRA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUMMARYCONVERSIONDIARIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTEMANODEOBRA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CONVERSIONDIARIA
            // 
            this.CONVERSIONDIARIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CONVERSIONDIARIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CONVERSIONDIARIA.Location = new System.Drawing.Point(3, 25);
            this.CONVERSIONDIARIA.Name = "CONVERSIONDIARIA";
            this.CONVERSIONDIARIA.Size = new System.Drawing.Size(1848, 338);
            this.CONVERSIONDIARIA.TabIndex = 0;
            // 
            // SUMMARYMANODEOBRA
            // 
            this.SUMMARYMANODEOBRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SUMMARYMANODEOBRA.Location = new System.Drawing.Point(36, 28);
            this.SUMMARYMANODEOBRA.Name = "SUMMARYMANODEOBRA";
            this.SUMMARYMANODEOBRA.Size = new System.Drawing.Size(400, 400);
            this.SUMMARYMANODEOBRA.TabIndex = 8;
            // 
            // SUMMARYCONVERSIONDIARIA
            // 
            this.SUMMARYCONVERSIONDIARIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SUMMARYCONVERSIONDIARIA.Location = new System.Drawing.Point(442, 28);
            this.SUMMARYCONVERSIONDIARIA.Name = "SUMMARYCONVERSIONDIARIA";
            this.SUMMARYCONVERSIONDIARIA.Size = new System.Drawing.Size(400, 400);
            this.SUMMARYCONVERSIONDIARIA.TabIndex = 9;
            // 
            // REPORTEMANODEOBRA
            // 
            this.REPORTEMANODEOBRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.REPORTEMANODEOBRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.REPORTEMANODEOBRA.Location = new System.Drawing.Point(3, 25);
            this.REPORTEMANODEOBRA.Name = "REPORTEMANODEOBRA";
            this.REPORTEMANODEOBRA.Size = new System.Drawing.Size(649, 408);
            this.REPORTEMANODEOBRA.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.REPORTEMANODEOBRA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 436);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORTE DE MANO DE OBRA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CONVERSIONDIARIA);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1854, 366);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONVERSION DIARIA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SUMMARYCONVERSIONDIARIA);
            this.groupBox3.Controls.Add(this.SUMMARYMANODEOBRA);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(690, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(874, 436);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SUMMARY";
            // 
            // CONVERSION_DIARIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 824);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CONVERSION_DIARIA";
            this.Text = "CONVERSION DIARIA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CONVERSIONDIARIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUMMARYMANODEOBRA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUMMARYCONVERSIONDIARIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTEMANODEOBRA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CONVERSIONDIARIA;
        private System.Windows.Forms.DataGridView SUMMARYMANODEOBRA;
        private System.Windows.Forms.DataGridView SUMMARYCONVERSIONDIARIA;
        private System.Windows.Forms.DataGridView REPORTEMANODEOBRA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

