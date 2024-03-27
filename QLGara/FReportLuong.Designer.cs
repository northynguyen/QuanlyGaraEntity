namespace QLGara
{
    partial class FReportLuong
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
            this.lUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLGaraDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLGaraDataset = new QLGara.QLGaraDataset();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lUONGTableAdapter = new QLGara.QLGaraDatasetTableAdapters.LUONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // lUONGBindingSource
            // 
            this.lUONGBindingSource.DataMember = "LUONG";
            this.lUONGBindingSource.DataSource = this.qLGaraDatasetBindingSource;
            // 
            // qLGaraDatasetBindingSource
            // 
            this.qLGaraDatasetBindingSource.DataSource = this.qLGaraDataset;
            this.qLGaraDatasetBindingSource.Position = 0;
            // 
            // qLGaraDataset
            // 
            this.qLGaraDataset.DataSetName = "QLGaraDataset";
            this.qLGaraDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lUONGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGara.ReportLuong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(986, 820);
            this.reportViewer1.TabIndex = 0;
            // 
            // lUONGTableAdapter
            // 
            this.lUONGTableAdapter.ClearBeforeFill = true;
            // 
            // FReportLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 838);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FReportLuong";
            this.Text = "FReportLuong";
            this.Load += new System.EventHandler(this.FReportLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLGaraDataset qLGaraDataset;
        private System.Windows.Forms.BindingSource qLGaraDatasetBindingSource;
        private System.Windows.Forms.BindingSource lUONGBindingSource;
        private QLGaraDatasetTableAdapters.LUONGTableAdapter lUONGTableAdapter;
    }
}