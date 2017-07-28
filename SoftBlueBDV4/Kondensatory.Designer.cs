namespace SoftBlueBD
{
    partial class Kondensatory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kondensatory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.advancedDataGridView = new ADGV.AdvancedDataGridView();
            this.LabelPodsumowanie = new System.Windows.Forms.Label();
            this.elementyElektroniczneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementyElektroniczneDataSetKondensatory = new SoftBlueBD.ElementyElektroniczneDataSetKondensatory();
            this.elementyElektroniczneTableAdapter = new SoftBlueBD.ElementyElektroniczneDataSetKondensatoryTableAdapters.elementyelektroniczneTableAdapter();
            this.identyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridComboBoxElement = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wartośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obudowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tolerancjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napięcieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokalizacjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostawcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WalutaComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneDataSetKondensatory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.advancedDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 438);
            this.panel1.TabIndex = 0;
            // 
            // advancedDataGridView
            // 
            this.advancedDataGridView.AllowUserToOrderColumns = true;
            this.advancedDataGridView.AutoGenerateColumns = false;
            this.advancedDataGridView.AutoGenerateContextFilters = true;
            this.advancedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.advancedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identyfikatorDataGridViewTextBoxColumn,
            this.DataGridComboBoxElement,
            this.wartośćDataGridViewTextBoxColumn,
            this.obudowaDataGridViewTextBoxColumn,
            this.tolerancjaDataGridViewTextBoxColumn,
            this.napięcieDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn,
            this.producentDataGridViewTextBoxColumn,
            this.lokalizacjaDataGridViewTextBoxColumn,
            this.dostawcaDataGridViewTextBoxColumn,
            this.ilośćDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.WalutaComboBox});
            this.advancedDataGridView.DataSource = this.elementyElektroniczneBindingSource;
            this.advancedDataGridView.DateWithTime = false;
            this.advancedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView.Name = "advancedDataGridView";
            this.advancedDataGridView.Size = new System.Drawing.Size(906, 438);
            this.advancedDataGridView.TabIndex = 0;
            this.advancedDataGridView.TimeFilter = false;
            this.advancedDataGridView.SortStringChanged += new System.EventHandler(this.advancedDataGridView_SortStringChanged);
            this.advancedDataGridView.FilterStringChanged += new System.EventHandler(this.advancedDataGridView_FilterStringChanged);
            this.advancedDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.advancedDataGridView_CurrentCellDirtyStateChanged);
            this.advancedDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.advancedDataGridView_DataError);
            this.advancedDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.advancedDataGridView_EditingControlShowing);
            this.advancedDataGridView.SelectionChanged += new System.EventHandler(this.advancedDataGridView_SelectionChanged);
            this.advancedDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.advancedDataGridView_KeyDown);
            // 
            // LabelPodsumowanie
            // 
            this.LabelPodsumowanie.AutoSize = true;
            this.LabelPodsumowanie.Location = new System.Drawing.Point(13, 457);
            this.LabelPodsumowanie.Name = "LabelPodsumowanie";
            this.LabelPodsumowanie.Size = new System.Drawing.Size(0, 13);
            this.LabelPodsumowanie.TabIndex = 1;
            // 
            // elementyElektroniczneBindingSource
            // 
            this.elementyElektroniczneBindingSource.DataMember = "elementyelektroniczne";
            this.elementyElektroniczneBindingSource.DataSource = this.elementyElektroniczneDataSetKondensatory;
            // 
            // elementyElektroniczneDataSetKondensatory
            // 
            this.elementyElektroniczneDataSetKondensatory.DataSetName = "ElementyElektroniczneDataSetKondensatory";
            this.elementyElektroniczneDataSetKondensatory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elementyElektroniczneTableAdapter
            // 
            this.elementyElektroniczneTableAdapter.ClearBeforeFill = true;
            // 
            // identyfikatorDataGridViewTextBoxColumn
            // 
            this.identyfikatorDataGridViewTextBoxColumn.DataPropertyName = "Identyfikator";
            dataGridViewCellStyle1.NullValue = null;
            this.identyfikatorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.identyfikatorDataGridViewTextBoxColumn.HeaderText = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.identyfikatorDataGridViewTextBoxColumn.Name = "identyfikatorDataGridViewTextBoxColumn";
            this.identyfikatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.identyfikatorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DataGridComboBoxElement
            // 
            this.DataGridComboBoxElement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataGridComboBoxElement.DataPropertyName = "Element";
            this.DataGridComboBoxElement.HeaderText = "Element";
            this.DataGridComboBoxElement.MinimumWidth = 22;
            this.DataGridComboBoxElement.Name = "DataGridComboBoxElement";
            this.DataGridComboBoxElement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridComboBoxElement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DataGridComboBoxElement.Width = 70;
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
            // napięcieDataGridViewTextBoxColumn
            // 
            this.napięcieDataGridViewTextBoxColumn.DataPropertyName = "Napięcie";
            this.napięcieDataGridViewTextBoxColumn.HeaderText = "Napięcie";
            this.napięcieDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.napięcieDataGridViewTextBoxColumn.Name = "napięcieDataGridViewTextBoxColumn";
            this.napięcieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            this.typDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            dataGridViewCellStyle2.Format = "N2";
            this.cenaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // WalutaComboBox
            // 
            this.WalutaComboBox.DataPropertyName = "Waluta";
            this.WalutaComboBox.HeaderText = "Waluta";
            this.WalutaComboBox.MinimumWidth = 22;
            this.WalutaComboBox.Name = "WalutaComboBox";
            this.WalutaComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WalutaComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Kondensatory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 481);
            this.Controls.Add(this.LabelPodsumowanie);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(320, 310);
            this.Name = "Kondensatory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kondensatory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kondensatory_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kondensatory_FormClosed);
            this.Load += new System.EventHandler(this.Kondensatory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneDataSetKondensatory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ADGV.AdvancedDataGridView advancedDataGridView;
        private ElementyElektroniczneDataSetKondensatory elementyElektroniczneDataSetKondensatory;
        private System.Windows.Forms.BindingSource elementyElektroniczneBindingSource;
        private ElementyElektroniczneDataSetKondensatoryTableAdapters.elementyelektroniczneTableAdapter elementyElektroniczneTableAdapter;
        private System.Windows.Forms.Label LabelPodsumowanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataGridComboBoxElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obudowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tolerancjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napięcieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokalizacjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostawcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn WalutaComboBox;
    }
}