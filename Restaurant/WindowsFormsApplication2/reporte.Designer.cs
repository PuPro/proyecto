﻿namespace WindowsFormsApplication2
{
    partial class reporte
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
            this.ElfmanStraussDataSet = new WindowsFormsApplication2.ElfmanStraussDataSet();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter = new WindowsFormsApplication2.ElfmanStraussDataSetTableAdapters.ventaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ElfmanStraussDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ventaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(711, 285);
            this.reportViewer1.TabIndex = 0;
            // 
            // ElfmanStraussDataSet
            // 
            this.ElfmanStraussDataSet.DataSetName = "ElfmanStraussDataSet";
            this.ElfmanStraussDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "venta";
            this.ventaBindingSource.DataSource = this.ElfmanStraussDataSet;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(735, 320);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporte";
            this.Text = "reporte";
            this.Load += new System.EventHandler(this.reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElfmanStraussDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private ElfmanStraussDataSet ElfmanStraussDataSet;
        private ElfmanStraussDataSetTableAdapters.ventaTableAdapter ventaTableAdapter;

    }
}