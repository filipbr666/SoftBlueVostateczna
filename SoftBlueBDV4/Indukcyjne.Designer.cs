namespace SoftBlueBD
{
    partial class Indukcyjne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indukcyjne));
            this.panel1 = new System.Windows.Forms.Panel();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.elementyElektroniczneDataSetIndukcyjne = new SoftBlueBD.ElementyElektroniczneDataSetIndukcyjne();
            this.elementyElektroniczneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementyElektroniczneTableAdapter = new SoftBlueBD.ElementyElektroniczneDataSetIndukcyjneTableAdapters.elementyelektroniczneTableAdapter();
            this.identyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridComboBoxElement = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wartośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obudowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tolerancjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prądDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezystancjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokalizacjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostawcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneDataSetIndukcyjne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.advancedDataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 413);
            this.panel1.TabIndex = 0;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToOrderColumns = true;
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identyfikatorDataGridViewTextBoxColumn,
            this.DataGridComboBoxElement,
            this.wartośćDataGridViewTextBoxColumn,
            this.obudowaDataGridViewTextBoxColumn,
            this.tolerancjaDataGridViewTextBoxColumn,
            this.prądDataGridViewTextBoxColumn,
            this.rezystancjaDataGridViewTextBoxColumn,
            this.producentDataGridViewTextBoxColumn,
            this.lokalizacjaDataGridViewTextBoxColumn,
            this.dostawcaDataGridViewTextBoxColumn,
            this.ilośćDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.elementyElektroniczneBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(792, 413);
            this.advancedDataGridView1.TabIndex = 0;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            this.advancedDataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.advancedDataGridView1_CurrentCellDirtyStateChanged);
            this.advancedDataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.advancedDataGridView1_DataError);
            this.advancedDataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.advancedDataGridView1_EditingControlShowing);
            this.advancedDataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.advancedDataGridView1_KeyDown);
            // 
            // elementyElektroniczneDataSetIndukcyjne
            // 
            this.elementyElektroniczneDataSetIndukcyjne.DataSetName = "ElementyElektroniczneDataSetIndukcyjne";
            this.elementyElektroniczneDataSetIndukcyjne.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elementyElektroniczneBindingSource
            // 
            this.elementyElektroniczneBindingSource.DataMember = "elementyelektroniczne";
            this.elementyElektroniczneBindingSource.DataSource = this.elementyElektroniczneDataSetIndukcyjne;
            // 
            // elementyElektroniczneTableAdapter
            // 
            this.elementyElektroniczneTableAdapter.ClearBeforeFill = true;
            // 
            // identyfikatorDataGridViewTextBoxColumn
            // 
            this.identyfikatorDataGridViewTextBoxColumn.DataPropertyName = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.HeaderText = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.identyfikatorDataGridViewTextBoxColumn.Name = "identyfikatorDataGridViewTextBoxColumn";
            this.identyfikatorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DataGridComboBoxElement
            // 
            this.DataGridComboBoxElement.DataPropertyName = "Element";
            this.DataGridComboBoxElement.HeaderText = "Element";
            this.DataGridComboBoxElement.MinimumWidth = 22;
            this.DataGridComboBoxElement.Name = "DataGridComboBoxElement";
            this.DataGridComboBoxElement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridComboBoxElement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // wartośćDataGridViewTextBoxColumn
            // 
            this.wartośćDataGridViewTextBoxColumn.DataPropertyName = "Wartość";
            this.wartośćDataGridViewTextBoxColumn.HeaderText = "Wartość";
            this.wartośćDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.wartośćDataGridViewTextBoxColumn.Name = "wartośćDataGridViewTextBoxColumn";
            this.wartośćDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // obudowaDataGridViewTextBoxColumn
            // 
            this.obudowaDataGridViewTextBoxColumn.DataPropertyName = "Obudowa";
            this.obudowaDataGridViewTextBoxColumn.HeaderText = "Obudowa";
            this.obudowaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.obudowaDataGridViewTextBoxColumn.Name = "obudowaDataGridViewTextBoxColumn";
            this.obudowaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tolerancjaDataGridViewTextBoxColumn
            // 
            this.tolerancjaDataGridViewTextBoxColumn.DataPropertyName = "Tolerancja";
            this.tolerancjaDataGridViewTextBoxColumn.HeaderText = "Tolerancja";
            this.tolerancjaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tolerancjaDataGridViewTextBoxColumn.Name = "tolerancjaDataGridViewTextBoxColumn";
            this.tolerancjaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // prądDataGridViewTextBoxColumn
            // 
            this.prądDataGridViewTextBoxColumn.DataPropertyName = "Prąd";
            this.prądDataGridViewTextBoxColumn.HeaderText = "Prąd";
            this.prądDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.prądDataGridViewTextBoxColumn.Name = "prądDataGridViewTextBoxColumn";
            this.prądDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // rezystancjaDataGridViewTextBoxColumn
            // 
            this.rezystancjaDataGridViewTextBoxColumn.DataPropertyName = "Rezystancja";
            this.rezystancjaDataGridViewTextBoxColumn.HeaderText = "Rezystancja";
            this.rezystancjaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rezystancjaDataGridViewTextBoxColumn.Name = "rezystancjaDataGridViewTextBoxColumn";
            this.rezystancjaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // producentDataGridViewTextBoxColumn
            // 
            this.producentDataGridViewTextBoxColumn.DataPropertyName = "Producent";
            this.producentDataGridViewTextBoxColumn.HeaderText = "Producent";
            this.producentDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.producentDataGridViewTextBoxColumn.Name = "producentDataGridViewTextBoxColumn";
            this.producentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // lokalizacjaDataGridViewTextBoxColumn
            // 
            this.lokalizacjaDataGridViewTextBoxColumn.DataPropertyName = "Lokalizacja";
            this.lokalizacjaDataGridViewTextBoxColumn.HeaderText = "Lokalizacja";
            this.lokalizacjaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.lokalizacjaDataGridViewTextBoxColumn.Name = "lokalizacjaDataGridViewTextBoxColumn";
            this.lokalizacjaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dostawcaDataGridViewTextBoxColumn
            // 
            this.dostawcaDataGridViewTextBoxColumn.DataPropertyName = "Dostawca";
            this.dostawcaDataGridViewTextBoxColumn.HeaderText = "Dostawca";
            this.dostawcaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dostawcaDataGridViewTextBoxColumn.Name = "dostawcaDataGridViewTextBoxColumn";
            this.dostawcaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ilośćDataGridViewTextBoxColumn
            // 
            this.ilośćDataGridViewTextBoxColumn.DataPropertyName = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.ilośćDataGridViewTextBoxColumn.Name = "ilośćDataGridViewTextBoxColumn";
            this.ilośćDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Indukcyjne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 437);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(288, 310);
            this.Name = "Indukcyjne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elementy Indukcyjne";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Indukcyjne_FormClosed);
            this.Load += new System.EventHandler(this.Indukcyjne_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneDataSetIndukcyjne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private ElementyElektroniczneDataSetIndukcyjne elementyElektroniczneDataSetIndukcyjne;
        private System.Windows.Forms.BindingSource elementyElektroniczneBindingSource;
        private ElementyElektroniczneDataSetIndukcyjneTableAdapters.elementyelektroniczneTableAdapter elementyElektroniczneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataGridComboBoxElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obudowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tolerancjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prądDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezystancjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokalizacjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostawcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
    }
}