namespace QLGara
{
    partial class ReportDoanhThu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pHIEUTHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLGaraDataset = new QLGara.QLGaraDataset();
            this.pHIEUTHU1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHUTableAdapter = new QLGara.QLGaraDatasetTableAdapters.PHIEUTHUTableAdapter();
            this.pHIEUTHU1TableAdapter = new QLGara.QLGaraDatasetTableAdapters.PHIEUTHU1TableAdapter();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHU1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.pHIEUTHUBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.pHIEUTHU1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGara.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 91);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(997, 995);
            this.reportViewer1.TabIndex = 0;
            // 
            // pHIEUTHUBindingSource
            // 
            this.pHIEUTHUBindingSource.DataMember = "PHIEUTHU";
            this.pHIEUTHUBindingSource.DataSource = this.qLGaraDataset;
            // 
            // qLGaraDataset
            // 
            this.qLGaraDataset.DataSetName = "QLGaraDataset";
            this.qLGaraDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUTHU1BindingSource
            // 
            this.pHIEUTHU1BindingSource.DataMember = "PHIEUTHU1";
            this.pHIEUTHU1BindingSource.DataSource = this.qLGaraDataset;
            // 
            // pHIEUTHUTableAdapter
            // 
            this.pHIEUTHUTableAdapter.ClearBeforeFill = true;
            // 
            // pHIEUTHU1TableAdapter
            // 
            this.pHIEUTHU1TableAdapter.ClearBeforeFill = true;
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(79, 28);
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(172, 31);
            this.txtTim.TabIndex = 4;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(281, 28);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(129, 34);
            this.btn_Tim.TabIndex = 3;
            this.btn_Tim.Text = "Tìm PT";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // ReportDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 1098);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportDoanhThu";
            this.Text = "ReportDoanhThu";
            this.Load += new System.EventHandler(this.ReportDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHU1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLGaraDataset qLGaraDataset;
        private System.Windows.Forms.BindingSource pHIEUTHUBindingSource;
        private QLGaraDatasetTableAdapters.PHIEUTHUTableAdapter pHIEUTHUTableAdapter;
        private System.Windows.Forms.BindingSource pHIEUTHU1BindingSource;
        private QLGaraDatasetTableAdapters.PHIEUTHU1TableAdapter pHIEUTHU1TableAdapter;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btn_Tim;
    }
}