namespace SoftBlueBD
{
    partial class FormTEST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTEST));
            this.panel1 = new System.Windows.Forms.Panel();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.napięcieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tolerancjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obudowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridComboBoxElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementyElektroniczneDataSetTEST = new SoftBlueBD.ElementyElektroniczneDataSetTEST();
            this.elementyElektroniczneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementyElektroniczneTableAdapter = new SoftBlueBD.ElementyElektroniczneDataSetTESTTableAdapters.ElementyElektroniczneTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneDataSetTEST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.advancedDataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 225);
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
            this.napięcieDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.elementyElektroniczneBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(718, 225);
            this.advancedDataGridView1.TabIndex = 0;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.advancedDataGridView1_EditingControlShowing);
            this.advancedDataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.advancedDataGridView1_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // napięcieDataGridViewTextBoxColumn
            // 
            this.napięcieDataGridViewTextBoxColumn.DataPropertyName = "Napięcie";
            this.napięcieDataGridViewTextBoxColumn.HeaderText = "Napięcie";
            this.napięcieDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.napięcieDataGridViewTextBoxColumn.Name = "napięcieDataGridViewTextBoxColumn";
            this.napięcieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tolerancjaDataGridViewTextBoxColumn
            // 
            this.tolerancjaDataGridViewTextBoxColumn.DataPropertyName = "Tolerancja";
            this.tolerancjaDataGridViewTextBoxColumn.HeaderText = "Tolerancja";
            this.tolerancjaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tolerancjaDataGridViewTextBoxColumn.Name = "tolerancjaDataGridViewTextBoxColumn";
            this.tolerancjaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // obudowaDataGridViewTextBoxColumn
            // 
            this.obudowaDataGridViewTextBoxColumn.DataPropertyName = "Obudowa";
            this.obudowaDataGridViewTextBoxColumn.HeaderText = "Obudowa";
            this.obudowaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.obudowaDataGridViewTextBoxColumn.Name = "obudowaDataGridViewTextBoxColumn";
            this.obudowaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // wartośćDataGridViewTextBoxColumn
            // 
            this.wartośćDataGridViewTextBoxColumn.DataPropertyName = "Wartość";
            this.wartośćDataGridViewTextBoxColumn.HeaderText = "Wartość";
            this.wartośćDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.wartośćDataGridViewTextBoxColumn.Name = "wartośćDataGridViewTextBoxColumn";
            this.wartośćDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // identyfikatorDataGridViewTextBoxColumn
            // 
            this.identyfikatorDataGridViewTextBoxColumn.DataPropertyName = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.HeaderText = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.identyfikatorDataGridViewTextBoxColumn.Name = "identyfikatorDataGridViewTextBoxColumn";
            this.identyfikatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.identyfikatorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // elementyElektroniczneDataSetTEST
            // 
            this.elementyElektroniczneDataSetTEST.DataSetName = "ElementyElektroniczneDataSetTEST";
            this.elementyElektroniczneDataSetTEST.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elementyElektroniczneBindingSource
            // 
            this.elementyElektroniczneBindingSource.DataMember = "ElementyElektroniczne";
            this.elementyElektroniczneBindingSource.DataSource = this.elementyElektroniczneDataSetTEST;
            // 
            // elementyElektroniczneTableAdapter
            // 
            this.elementyElektroniczneTableAdapter.ClearBeforeFill = true;
            // 
            // FormTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 449);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTEST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTEST";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTEST_FormClosed);
            this.Load += new System.EventHandler(this.FormTEST_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneDataSetTEST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyElektroniczneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridComboBoxElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obudowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tolerancjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napięcieDataGridViewTextBoxColumn;
        private ElementyElektroniczneDataSetTEST elementyElektroniczneDataSetTEST;
        private System.Windows.Forms.BindingSource elementyElektroniczneBindingSource;
        private ElementyElektroniczneDataSetTESTTableAdapters.ElementyElektroniczneTableAdapter elementyElektroniczneTableAdapter;
    }
}