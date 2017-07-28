using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//bardzo ważna biblioteka!

namespace SoftBlueBD
{
    public partial class Indukcyjne : Form
    {
        public Indukcyjne()
        {
            InitializeComponent();
        }


        MySqlCommand komenda = new MySqlCommand();                                   //zmienna komendy dla mysql
        string zapytanie;                                                            //zmienna przechwoująca zapytanie do MYSQL
        bool WasChange = false;                                                      // zmienna wykrywająca jakąkolwiek zmianę w komórkach datagrida
        bool DataErrorStatus = false;                                                //zmienna wykrywająca błędne dane w komórkach (głównie chodzi o kolumnę ilość, czy faktycznie jest tam cyfra/ liczba bez przecinka)
        string wyliczoneWaluty;
        private void Indukcyjne_Load(object sender, EventArgs e)
        {


            CreateSQLCommand();                                                         //patrz dalej

        } //ładowanie Forma

        private void CreateSQLCommand()
        {
            //tworzenie zapytania;         
            zapytanie = @"SELECT * FROM ElementyElektroniczne WHERE (";                                                         //początek zapytnia.
            try
            {
                foreach (string line in System.IO.File.ReadLines(@"Elementy Indukcyjne.ini"))                                   //dla każdego elemntu wpisanego w pliku konfiguracyjnym
                {
                    if (!DataGridComboBoxElement.Items.Contains(line))                                                          //jeżeli taki element jeszcze nie istnieje w comboboxie
                        DataGridComboBoxElement.Items.Add(line);                                                                //wpisz do comboboxa tę nazwę elementu
                    zapytanie = zapytanie + " (Element = '" + line + "') OR ";                                                  // za każdym takim razem wpisywana jest nazwa elementu w filtracji selecta np. Where (Element=N'kondensator') OR .....
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie odnaleziono pliku konfiguracyjnego: Elementy Indukcyjne.ini");                             //reakcja na błąd w otwarciu pliku konfiguracyjnego
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
            try

            {
                elementyElektroniczneTableAdapter.Connection.ConnectionString = System.IO.File.ReadAllText(@"Połączenie.ini");//tworzenie połęczeniowego stringa którego treść znajduje się w pliku konfiguracyjnym
                elementyElektroniczneTableAdapter.Connection.Open();                                                            //otwarcie połączenia(chyba niepotrzebne nawet)
                komenda.Connection = elementyElektroniczneTableAdapter.Connection;                                              // połączenie
                komenda.CommandText = zapytanie;                                                                                // ustawienie w komendę utworzonego zapytania
                FillByTEST(this.elementyElektroniczneDataSetIndukcyjne.elementyelektroniczne);                                  // zapełnienie datagrida uzyskanymi danymi z bazy danych
                elementyElektroniczneTableAdapter.Connection.Close();                                                           //zamknięcie połączenia
            }//wysłanie komendy
            catch (Exception)
            {
                MessageBox.Show("Nie udało się połączyć z bazą, sprawdź plik konfiguracyjny: Połączenie");
                Program.MainRef.Show();
                this.Close();
            }//obśługa błędu w połączeniu z plikiem konfiguracyjnym, lub błędną jego zawartością
            LabelTEXT(); // uzupełnienie labela z informacjami          
        } //tworzenie zapytania do bazy

        public int FillByTEST(ElementyElektroniczneDataSetIndukcyjne.elementyelektroniczneDataTable dataTable)
        {
            elementyElektroniczneTableAdapter.Adapter.SelectCommand = this.komenda;                                             //komenda przysłana do adaptera
            if ((elementyElektroniczneTableAdapter.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }// wyczyszczenie bufora dataTable przed uzupełnieniem
            int returnValue = elementyElektroniczneTableAdapter.Adapter.Fill(dataTable);                                        //zapełnienie tablicy nowymi danymi
            return returnValue;                                                                                                 // zwrócenie danych
        }//funkcja wygenerowana przez program, wypełnienie datagrida danymi z bazy

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;                                                                                //zmiana kursora na czekający
            try
            {
                elementyElektroniczneTableAdapter.Connection.Open();                                                            //otwarcie połączenia
                elementyElektroniczneBindingSource.EndEdit();                                                                   // sygnał zakończenia edycji
                elementyElektroniczneTableAdapter.Update(this.elementyElektroniczneDataSetIndukcyjne.elementyelektroniczne);    // update adaptera
                elementyElektroniczneTableAdapter.Connection.Close();                                                           //zamknięcie połączenia
            }//zakończenie edycji i update danych
            catch (Exception)
            {
                MessageBox.Show("Nie udało się połączyć z bazą, sprawdź plik konfiguracyjny: Połączenie");
                Program.MainRef.Show();
                WasChange = false;
                this.Close();

            }//obsługa błędu w update'cie danych w przypadku gdy plik konfiguracyjny jest błędnie zapisany lub go nie ma
            Cursor.Current = Cursors.Default;                                                                                   //zwolnienie kursora
            WasChange = false;                                                                                                  //ZMIANA wykrycia zmiany w datagridzie na false - bo już zaminy zostału zapisane wiec luzik
        }//(nazwa zrobiona z buttona(w peirwotnej wersji był to przycisk a teraz to zwykła funkcja zapisująca dane w głównej bazie

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            elementyElektroniczneBindingSource.Filter = advancedDataGridView1.FilterString;
        }//funkcja obsługi filtrowania datagrida

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            elementyElektroniczneBindingSource.Sort = advancedDataGridView1.SortString;
        }//funkcja obsługi sortowania datagrida

        private void Indukcyjne_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainRef.Show();                                                         // pokaż menu główne
        }// obsługa programu: co ma się stać po zamknięciu okna 

        private void Indukcyjne_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WasChange == true && DataErrorStatus == false)                                                                                                   //jeżeli były zmiany w datagridzie i status błędnego wpisania do datagrida jest false to
            {
                DialogResult dialog = MessageBox.Show("Czy chcesz zapisać zmiany?", "Zapisywanie zmian", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);//wyskakuje okno dialogowe zapisy zmian
                if (dialog == DialogResult.Yes)                                                                                                                  // jeżeli przycisnie się yes
                {
                    SaveButton_Click(sender, e);                                                                                                                 // zapisz wszystko
                }
                if (dialog == DialogResult.Cancel)                                                                                                               // kliknie się cancel
                {
                    e.Cancel = true;                                                                                                                             // przerwanie zamykania
                }
            }
            DataErrorStatus = false;                                                                                                                             // zmiana statusu błędu na false (użyte po to by nie wyskakiwało okno HOLAHOLA błąd w komórce (i żeby zapis mógł nastąpić
        }// obsługa programu: co ma się stać w czasie zamykania programu

        private void advancedDataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)                                                                       // jeżeli wystąpi zdarzenie kliknięcia delete to
            {
                if (this.advancedDataGridView1.SelectedRows.Count > 0)                                          //jeżeli zaznaczono wiersz cały!!!!! to
                {
                    elementyElektroniczneBindingSource.RemoveAt(advancedDataGridView1.SelectedRows[0].Index);   //usuń każdy zaznaczony wiersz
                    WasChange = true;                                                                           // wystąpily zmiany
                    DataErrorStatus = false;                                                                    // error ustawiany na fałsz po to by zapis mół nastąpić
                }
                else
                {
                    foreach (DataGridViewCell cellnumber in advancedDataGridView1.SelectedCells)                //ale gdy chcesz usunąć tylko zaznaczone komórki!
                    {
                        cellnumber.Value = "";                                                                  // wpisz do nich nic i usuń to co było
                    }
                    WasChange = true;
                    DataErrorStatus = false;
                }
            }
        }// obsługa wciśnięcia przycisku w datagridzie (obsługa przycisku delete)

        private void advancedDataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("HOLA HOLA, tak nie wolno, zły format wpisany do komórki!");
            DataErrorStatus = true;                                                                        // jak jest error to status erroru jest true
        }// obsługa błędnego wpisania wartości w datagrida

        private void advancedDataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int column = advancedDataGridView1.CurrentCell.ColumnIndex;                                     // wychwytywanie kolumny aktualnie edytowanej komórki
            TextBox auto_text = e.Control as TextBox;                                                       //zmienna do autowypełnienia tekstami z kolumn
            if (auto_text != null)
            {
                auto_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                auto_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection sc = new AutoCompleteStringCollection();                       // sc wychwytuje wszystkie wyrazy z kolumny
                int i = 0;
                foreach (DataGridViewRow item in advancedDataGridView1.Rows)                                 // dla każdego itemu w edytowanej kolumnie wpisz do kolekcji zawartość każdej komóki
                {
                    if (!sc.Contains(item.Cells[column].Value.ToString()))
                        sc.Add(item.Cells[column].Value.ToString());
                    i = item.Index + 2;
                    if (i == advancedDataGridView1.RowCount)
                        break;
                }
                auto_text.AutoCompleteCustomSource = sc;                                                    //porównaj i zaproponuj autouzupełnienie
            }// to w necie tłumaczyli, tam jest lepiej to opisane
        }//obsługa zdardzeń w czasie edytowania datagrida (obsługa autouzupełnienia)

        private void advancedDataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            WasChange = true;                                                                               // jak cokolwiek się zmieni to was change faktycznie nastąpiło
        }// reakcja programu na jakąkolwiek faktyczną zmianę w datagridzie

        private void advancedDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            LabelTEXT();
        }//Gdywystąpi jakakolwiek zmiana w datagridzie uzupełnij Label z informacjami

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
    }
}
