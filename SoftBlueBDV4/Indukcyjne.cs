﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SoftBlueBD
{
    public partial class Indukcyjne : Form
    {
        public Indukcyjne()
        {
            InitializeComponent();
        }

        MySqlCommand komenda = new MySqlCommand();
        string zapytanie;
        string items;
        bool WasChange = false;

        private void Indukcyjne_Load(object sender, EventArgs e)
        {



            // TODO: This line of code loads data into the 'elementyElektroniczneDataSetIndukcyjne.elementyelektroniczne' table. You can move, or remove it, as needed.
            //this.elementyElektroniczneTableAdapter.Fill(this.elementyElektroniczneDataSetIndukcyjne.elementyelektroniczne);
            // TODO: This line of code loads data into the 'elementyElektroniczneDataSetIndukcyjne.ElementyElektroniczne' table. You can move, or remove it, as needed.
            //this.elementyElektroniczneTableAdapter.Fill(this.elementyElektroniczneDataSetIndukcyjne.ElementyElektroniczne);
            // TODO: This line of code loads data into the 'elementyElektroniczneDataSetIndukcyjne.ElementyElektroniczne' table. You can move, or remove it, as needed.
            //this.elementyElektroniczneTableAdapter.Fill(this.elementyElektroniczneDataSetIndukcyjne.ElementyElektroniczne);
            //fillByIndukcyjneToolStripButton_Click(sender, e);
            CreateSQLCommand();

        }

        private void CreateSQLCommand()
        {
            //tworzenie zapytania;

            zapytanie = @"SELECT Identyfikator, Element, Wartość, Obudowa, Tolerancja, Typ, Producent, Prąd, Lokalizacja, Ilość, Dostawca, Cena FROM ElementyElektroniczne WHERE Element=' ' OR ";
            try
            {
                foreach (string line in System.IO.File.ReadLines(@"Elementy Indukcyjne.ini"))
                {
                    if (!DataGridComboBoxElement.Items.Contains(line))
                        DataGridComboBoxElement.Items.Add(line);
                    zapytanie = zapytanie + " (Element = N'" + line + "') OR ";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie odnaleziono pliku konfiguracyjnego: Elementy Indukcyjne");
            }
            zapytanie = zapytanie.Remove(zapytanie.Length - 3) + ";";
            //wysłanie komendy
            try
            {
                elementyElektroniczneTableAdapter.Connection.ConnectionString = System.IO.File.ReadAllText(@"Połączenie.ini");
                elementyElektroniczneTableAdapter.Connection.Open();
                komenda.Connection = elementyElektroniczneTableAdapter.Connection;
                komenda.CommandText = zapytanie;
                FillByTEST(this.elementyElektroniczneDataSetIndukcyjne.elementyelektroniczne);
                elementyElektroniczneTableAdapter.Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się połączyć z bazą, sprawdź plik konfiguracyjny: Połączenie");
                Program.MainRef.Show();
                this.Close();
            }

        }

        public int FillByTEST(ElementyElektroniczneDataSetIndukcyjne.elementyelektroniczneDataTable dataTable)
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
                elementyElektroniczneTableAdapter.Update(this.elementyElektroniczneDataSetIndukcyjne.elementyelektroniczne);
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
            WasChange = false;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            elementyElektroniczneBindingSource.Filter = advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            elementyElektroniczneBindingSource.Sort = advancedDataGridView1.SortString;
        }

        private void Indukcyjne_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WasChange == true)
            {
                if (MessageBox.Show("Chcesz zapisać zmiany?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { SaveButton_Click(sender, e); }
            }

            Program.MainRef.Show();
        }

        private void advancedDataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Jesteś pewien, że chcesz usunąć ten element?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    elementyElektroniczneBindingSource.RemoveCurrent();
                    WasChange = true;
                }
            }
        }

        private void advancedDataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("HOLA HOLA, tak nie wolno, zły format wpisany do komórki!");
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

        private void advancedDataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            WasChange = true;
        }
    }
}
