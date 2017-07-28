namespace SoftBlueBD
{
    partial class Mechaniczne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mechaniczne));
            this.panel1 = new System.Windows.Forms.Panel();
            this.advancedDataGridView2 = new ADGV.AdvancedDataGridView();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.WalutaComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.identyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridComboBoxElement = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznaczenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementyElektroniczneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementyElektroniczneDataSetMechaniczne = new SoftBlueBD.ElementyElektroniczneDataSetMechaniczne();
            this.elementyElektroniczneTableAdapter = new SoftBlueBD.ElementyElektroniczneDataSetMechaniczneTableAdapters.elementyelektroniczneTableAdapter();
            this.LabelPodsumowanie = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneDataSetMechaniczne)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.advancedDataGridView2);
            this.panel1.Controls.Add(this.advancedDataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 438);
            this.panel1.TabIndex = 0;
            // 
            // advancedDataGridView2
            // 
            this.advancedDataGridView2.AllowUserToOrderColumns = true;
            this.advancedDataGridView2.AutoGenerateColumns = false;
            this.advancedDataGridView2.AutoGenerateContextFilters = true;
            this.advancedDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.advancedDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identyfikatorDataGridViewTextBoxColumn,
            this.DataGridComboBoxElement,
            this.opisDataGridViewTextBoxColumn,
            this.oznaczenieDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn,
            this.producentDataGridViewTextBoxColumn,
            this.ilośćDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.WalutaComboBox});
            this.advancedDataGridView2.DataSource = this.elementyElektroniczneBindingSource;
            this.advancedDataGridView2.DateWithTime = false;
            this.advancedDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.advancedDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView2.Name = "advancedDataGridView2";
            this.advancedDataGridView2.Size = new System.Drawing.Size(755, 438);
            this.advancedDataGridView2.TabIndex = 8;
            this.advancedDataGridView2.TimeFilter = false;
            this.advancedDataGridView2.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView2.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            this.advancedDataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellEndEdit);
            this.advancedDataGridView2.CurrentCellDirtyStateChanged += new System.EventHandler(this.advancedDataGridView2_CurrentCellDirtyStateChanged);
            this.advancedDataGridView2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.advancedDataGridView2_DataError);
            this.advancedDataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.advancedDataGridView2_EditingControlShowing);
            this.advancedDataGridView2.SelectionChanged += new System.EventHandler(this.advancedDataGridView2_SelectionChanged);
            this.advancedDataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.advancedDataGridView2_KeyDown);
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToOrderColumns = true;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(755, 438);
            this.advancedDataGridView1.TabIndex = 0;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            this.advancedDataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellEndEdit);
            this.advancedDataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.advancedDataGridView1_KeyDown);
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
            // identyfikatorDataGridViewTextBoxColumn
            // 
            this.identyfikatorDataGridViewTextBoxColumn.DataPropertyName = "Identyfikator";
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
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.opisDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // oznaczenieDataGridViewTextBoxColumn
            // 
            this.oznaczenieDataGridViewTextBoxColumn.DataPropertyName = "Oznaczenie";
            this.oznaczenieDataGridViewTextBoxColumn.HeaderText = "Oznaczenie";
            this.oznaczenieDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.oznaczenieDataGridViewTextBoxColumn.Name = "oznaczenieDataGridViewTextBoxColumn";
            this.oznaczenieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // elementyElektroniczneBindingSource
            // 
            this.elementyElektroniczneBindingSource.DataMember = "elementyelektroniczne";
            this.elementyElektroniczneBindingSource.DataSource = this.elementyElektroniczneDataSetMechaniczne;
            // 
            // elementyElektroniczneDataSetMechaniczne
            // 
            this.elementyElektroniczneDataSetMechaniczne.DataSetName = "ElementyElektroniczneDataSetMechaniczne";
            this.elementyElektroniczneDataSetMechaniczne.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elementyElektroniczneTableAdapter
            // 
            this.elementyElektroniczneTableAdapter.ClearBeforeFill = true;
            // 
            // LabelPodsumowanie
            // 
            this.LabelPodsumowanie.AutoSize = true;
            this.LabelPodsumowanie.Location = new System.Drawing.Point(12, 462);
            this.LabelPodsumowanie.Name = "LabelPodsumowanie";
            this.LabelPodsumowanie.Size = new System.Drawing.Size(35, 13);
            this.LabelPodsumowanie.TabIndex = 1;
            this.LabelPodsumowanie.Text = "label1";
            // 
            // Mechaniczne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 484);
            this.Controls.Add(this.LabelPodsumowanie);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(288, 310);
            this.Name = "Mechaniczne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elementy Mechaniczne";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mechaniczne_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mechaniczne_FormClosed);
            this.Load += new System.EventHandler(this.Mechaniczne_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneDataSetMechaniczne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private ADGV.AdvancedDataGridView advancedDataGridView2;
        private ElementyElektroniczneDataSetMechaniczne elementyElektroniczneDataSetMechaniczne;
        private System.Windows.Forms.BindingSource elementyElektroniczneBindingSource;
        private ElementyElektroniczneDataSetMechaniczneTableAdapters.elementyelektroniczneTableAdapter elementyElektroniczneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataGridComboBoxElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznaczenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn WalutaComboBox;
        private System.Windows.Forms.Label LabelPodsumowanie;
    }
}