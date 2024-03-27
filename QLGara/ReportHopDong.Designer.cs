namespace QLGara
{
    partial class ReportHopDong
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hOPDONGCHITIETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLGaraDataset = new QLGara.QLGaraDataset();
            this.hOPDONG_CHITIETTableAdapter = new QLGara.QLGaraDatasetTableAdapters.HOPDONG_CHITIETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGCHITIETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hOPDONGCHITIETBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGara.ReportHopDong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1483, 881);
            this.reportViewer1.TabIndex = 0;
            // 
            // hOPDONGCHITIETBindingSource
            // 
            this.hOPDONGCHITIETBindingSource.DataMember = "HOPDONG_CHITIET";
            this.hOPDONGCHITIETBindingSource.DataSource = this.qLGaraDataset;
            // 
            // qLGaraDataset
            // 
            this.qLGaraDataset.DataSetName = "QLGaraDataset";
            this.qLGaraDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOPDONG_CHITIETTableAdapter
            // 
            this.hOPDONG_CHITIETTableAdapter.ClearBeforeFill = true;
            // 
            // ReportHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 905);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportHopDong";
            this.Text = "ReportHopDong";
            this.Load += new System.EventHandler(this.ReportHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGCHITIETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLGaraDataset qLGaraDataset;
        private System.Windows.Forms.BindingSource hOPDONGCHITIETBindingSource;
        private QLGaraDatasetTableAdapters.HOPDONG_CHITIETTableAdapter hOPDONG_CHITIETTableAdapter;
    }
}