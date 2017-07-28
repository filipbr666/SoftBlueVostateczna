using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//opis wszystkich funkcji w Formie Indukcyjne. każdy Form ma podobne funkcje!
namespace SoftBlueBD
{
    public partial class Rezystory : Form
    {
        public Rezystory()
        {
            InitializeComponent();
        }
        MySqlCommand komenda = new MySqlCommand();
        string zapytanie;
        string items;
        bool WasChange = false;
        bool DataErrorStatus = false;
        string wyliczoneWaluty;
        private void Rezystory_Load(object sender, EventArgs e)
        {
            //elementyElektroniczneTableAdapter.Connection.Open();
            // TODO: This line of code loads data into the 'elementyElektroniczneDataSetRezystory.elementyelektroniczne' table. You can move, or remove it, as needed.
            //this.elementyElektroniczneTableAdapter.Fill(this.elementyElektroniczneDataSetRezystory.elementyelektroniczne);
            // TODO: This line of code loads data into the 'elementyElektroniczneDataSetRezystory.ElementyElektroniczne' table. You can move, or remove it, as needed.
            //this.elementyElektroniczneTableAdapter.Fill(this.elementyElektroniczneDataSetRezystory.ElementyElektroniczne);
            // TODO: This line of code loads data into the 'elementyElektroniczneDataSetRezystory.ElementyElektroniczne' table. You can move, or remove it, as needed.
            //this.elementyElektroniczneTableAdapter.Fill(this.elementyElektroniczneDataSetRezystory.ElementyElektroniczne);
            //fillByRezystorToolStripButton_Click(sender, e);
            CreateSQLCommand();
            //elementyElektroniczneTableAdapter.Connection.Close();
        }

        private void CreateSQLCommand()
        {
            //tworzenie zapytania;         
            zapytanie = @"SELECT * FROM ElementyElektroniczne WHERE (";                                                         //początek zapytnia.
            try
            {
                foreach (string line in System.IO.File.ReadLines(@"Rezystory.ini"))                                   //dla każdego elemntu wpisanego w pliku konfiguracyjnym
                {
                    if (!DataGridComboBoxElement.Items.Contains(line))                                                          //jeżeli taki element jeszcze nie istnieje w comboboxie
                        DataGridComboBoxElement.Items.Add(line);                                                                //wpisz do comboboxa tę nazwę elementu
                    zapytanie = zapytanie + " (Element = '" + line + "') OR ";                                                  // za każdym takim razem wpisywana jest nazwa elementu w filtracji selecta np. Where (Element=N'kondensator') OR .....
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie odnaleziono pliku konfiguracyjnego: Rezystory.ini");                             //reakcja na błąd w otwarciu pliku konfiguracyjnego
            }
            zapytanie = zapytanie.Remove(zapytanie.Length - 3) + ") AND (Waluta IS NULL OR ";                                     // ta mądra linijka usuwa ostatniego niepotrzebnego OR'a i dodaje średnik na koniec zpaytania
            //..................Pobieranie walut.........................................................................
            try
            {
                foreach (string line in System.IO.File.ReadLines(@"Waluty.ini"))                                                //dla każdego elemntu wpisanego w pliku konfiguracyjnym
                {
                    if (!WalutaComboBox.Items.Contains(line))                                                                    //jeżeli taki element jeszcze nie istnieje w comboboxie
                        WalutaComboBox.Items.Add(line);                                                                          //wpisz do comboboxa tę nazwę elementu
                    zapytanie = zapytanie + " (Waluta = '" + line + "') OR ";                                                   // za każdym takim razem wpisywana jest nazwa elementu w filtracji selecta np. Where (Element=N'kondensator') OR .....
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie odnaleziono pliku konfiguracyjnego: Waluty.ini");
            }
            zapytanie = zapytanie.Remove(zapytanie.Length - 3) + ");";                                                          //usunięcie tego co niepotrzebne 
            //...........................................................................................................
            //wysłanie komendy
            try
            {
                elementyElektroniczneTableAdapter.Connection.Open();
                komenda.Connection = elementyElektroniczneTableAdapter.Connection;
                komenda.CommandText = zapytanie;
                FillByTEST(this.elementyElektroniczneDataSetRezystory.elementyelektroniczne);
                elementyElektroniczneTableAdapter.Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się połączyć z bazą, sprawdź plik konfiguracyjny: Połączenie");
                Program.MainRef.Show();
                this.Close();
            }
            LabelTEXT();
        }
        public int FillByTEST(ElementyElektroniczneDataSetRezystory.elementyelektroniczneDataTable dataTable)
        {
            elementyElektroniczneTableAdapter.Adapter.SelectCommand = this.komenda;
            if ((elementyElektroniczneTableAdapter.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = elementyElektroniczneTableAdapter.Adapter.Fill(dataTable);
            return returnValue;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                elementyElektroniczneTableAdapter.Connection.Open();
                elementyElektroniczneBindingSource.EndEdit();
                elementyElektroniczneTableAdapter.Update(this.elementyElektroniczneDataSetRezystory.elementyelektroniczne);
                elementyElektroniczneTableAdapter.Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się połączyć z bazą, sprawdź plik konfiguracyjny: Połączenie");
                Program.MainRef.Show();
                WasChange = false;
                this.Close();
            }
            Cursor.Current = Cursors.Default;
            //Rezystory_Load(sender, e);
            WasChange = false;
        }

        private void Rezystory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainRef.Show();
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            elementyElektroniczneBindingSource.Sort = advancedDataGridView1.SortString;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            elementyElektroniczneBindingSource.Filter = advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (this.advancedDataGridView1.SelectedRows.Count > 0)
                {
                    elementyElektroniczneBindingSource.RemoveAt(advancedDataGridView1.SelectedRows[0].Index);
                    WasChange = true;
                    DataErrorStatus = false;
                }
                else
                {
                    foreach (DataGridViewCell cellnumber in advancedDataGridView1.SelectedCells)
                    {
                        cellnumber.Value = "";
                    }
                    WasChange = true;
                    DataErrorStatus = false;
                }
            }
        }

        private void advancedDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            WasChange = true;
            CreateSQLCommand();
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

        private void advancedDataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("HOLA HOLA, tak nie wolno, zły format wpisany do komórki!");
            DataErrorStatus = true;
        }

        private void advancedDataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            WasChange = true;
        }

        private void Rezystory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WasChange == true && DataErrorStatus == false)
            {
                DialogResult dialog = MessageBox.Show("Czy chcesz zapisać zmiany?", "Zapisywanie zmian", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    SaveButton_Click(sender, e);
                }
                if (dialog == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            DataErrorStatus = false;
        }

        private void LabelTEXT()
        {
            //obliczanie liczby elementów............................................
            int sum = 0;
            decimal[] kasa = new decimal[WalutaComboBox.Items.Count];

            for (int j = 0; j < advancedDataGridView1.Rows.Count; ++j)
            {

                sum += Convert.ToInt32(advancedDataGridView1.Rows[j].Cells[10].Value);                  //cells 10 bo tam jest właśnie kolumna ilość
            }
            int i = 0;
            foreach (string item in WalutaComboBox.Items)
            {
                wyliczoneWaluty = "";
                for (int j = 0; j < advancedDataGridView1.Rows.Count; ++j)
                {
                    if (Convert.ToString(advancedDataGridView1.Rows[j].Cells[12].Value) == item)
                        try
                        {
                            kasa[i] += Convert.ToDecimal(advancedDataGridView1.Rows[j].Cells[11].Value) * Convert.ToDecimal(advancedDataGridView1.Rows[j].Cells[10].Value);
                        }
                        catch (Exception)
                        {
                        }
                }
                for (int a = 0; a < WalutaComboBox.Items.Count; ++a)
                {
                    wyliczoneWaluty += " " + kasa[a].ToString() + " [" + WalutaComboBox.Items[a].ToString() + "] ";
                }
                i++;
            }

            //.......................................................................

            LabelPodsumowanie.Text = "W bazie " + this.Text.ToString() + " znajduje się: " + ((advancedDataGridView1.RowCount) - 1).ToString() + " elementy(ów)" + " o łącznej ilości: " + sum.ToString() + ". O wartości: " + wyliczoneWaluty;//wypisanie tekstu
        }//funkcja do uzupełnienia labela informacjami zmienianymi na bierząco

        private void advancedDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            LabelTEXT();
        }
    }
}
