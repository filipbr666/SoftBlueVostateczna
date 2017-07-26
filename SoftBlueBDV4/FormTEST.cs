using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoftBlueBD
{
    public partial class FormTEST : Form
    {
        public FormTEST()
        {
            InitializeComponent();
        }
        SqlCommand komenda = new SqlCommand();
        string zapytanie;

        string items;
        private void CreateSQLCommand()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        public int FillByTEST(ElementyElektroniczneDataSetTEST.ElementyElektroniczneDataTable dataTable)
        {
            elementyElektroniczneTableAdapter.Adapter.SelectCommand = this.komenda;
            if ((elementyElektroniczneTableAdapter.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = elementyElektroniczneTableAdapter.Adapter.Fill(dataTable);
            return returnValue;
        }
        private void FormTEST_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'elementyElektroniczneDataSetTEST.ElementyElektroniczne' table. You can move, or remove it, as needed.
            this.elementyElektroniczneTableAdapter.Fill(this.elementyElektroniczneDataSetTEST.ElementyElektroniczne);
            //CreateSQLCommand();
            //this.elementyElektroniczneTableAdapter.FillByALL(this.elementyElektroniczneDataSetTEST.ElementyElektroniczne);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void advancedDataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Jesteś pewien, że chcesz usunąć ten element?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    elementyElektroniczneBindingSource.RemoveCurrent();
                }

            }
            Savethis();
        }
        private void Savethis()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                elementyElektroniczneBindingSource.EndEdit();
                elementyElektroniczneTableAdapter.Update(this.elementyElektroniczneDataSetTEST.ElementyElektroniczne);
            }
            catch (Exception)
            {

                throw;
            }
            Cursor.Current = Cursors.Default;

        }

        private void FormTEST_FormClosed(object sender, FormClosedEventArgs e)
        {

            Savethis();
            Program.MainRef.Show();
        }

        private void advancedDataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int column = advancedDataGridView1.CurrentCell.ColumnIndex;
            TextBox auto_text = e.Control as TextBox;
            if (auto_text != null)
            {
                auto_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                auto_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
                int i = 0;
                foreach (DataGridViewRow item in advancedDataGridView1.Rows)
                {
                    if (!sc.Contains(item.Cells[column].Value.ToString()))
                        sc.Add(item.Cells[column].Value.ToString());
                    i = item.Index + 2;
                    if (i == advancedDataGridView1.RowCount)
                        break;
                }
                auto_text.AutoCompleteCustomSource = sc;

            }
        }
    }
}
/*
* @"SELECT        Identyfikator, Element, Wartość, Obudowa, Tolerancja, Typ, Producent, Prąd, Lokalizacja, Ilość, Dostawca, Cena
FROM            ElementyElektroniczne
WHERE (Element = 'cewka') OR
                         (Element = 'Cewka') OR
                         (Element = 'Cewki') OR
                         (Element = 'cewki') OR
                         (Element = 'dławik') OR
                         (Element = 'Dławik') OR
                         (Element = 'Dlawik') OR
                         (Element = 'dlawik') OR
                         (Element = 'dlawiki') OR
                         (Element = 'Dlawiki') OR
                         (Element = 'Transformator') OR
                         (Element = 'transformator') OR
                         (Element = 'Transformatory') OR
                         (Element = 'transformatory')";
                         */
