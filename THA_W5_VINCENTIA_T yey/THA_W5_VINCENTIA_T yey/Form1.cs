using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W5_VINCENTIA_T_yey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> listId = new List<string>();
        public List<string> listNama = new List<string>();
        public List<int> listHarga = new List<int>();
        public List<int> listStock = new List<int>();
        public List<string> listIdcategoryproduct = new List<string>();

        public List<string> listIdcategory = new List<string>();
        public List<string> listNamacategory = new List<string>();

        public DataTable dtProdukSimpan = new DataTable();
        public DataTable dtProdukTampil = new DataTable();
        public DataTable dtCategory = new DataTable();

        private DataRow row;


        public void Form1_Load(object sender, EventArgs e)
        {
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");

            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");

            listIdcategory.Add("C1");
            listIdcategory.Add("C2");
            listIdcategory.Add("C3");
            listIdcategory.Add("C4");
            listIdcategory.Add("C5");

            listNamacategory.Add("Jas");
            listNamacategory.Add("T-Shirt");
            listNamacategory.Add("Rok");
            listNamacategory.Add("Celana");
            listNamacategory.Add("Cawat");

            listId.Add("J001");
            listId.Add("T001");
            listId.Add("T002");
            listId.Add("R001");
            listId.Add("J002");
            listId.Add("C001");
            listId.Add("C002");
            listId.Add("R002");

            listNama.Add("Jas Hitam");
            listNama.Add("T-Shirt Black Pink");
            listNama.Add("T-Shirt Obsessive");
            listNama.Add("Rok mini");
            listNama.Add("Jeans Biru");
            listNama.Add("Celana Pendek Coklat");
            listNama.Add("Cawat Blink-blink");
            listNama.Add("Rocca Shirt");

            listHarga.Add(100000);
            listHarga.Add(70000);
            listHarga.Add(75000);
            listHarga.Add(82000);
            listHarga.Add(90000);
            listHarga.Add(60000);
            listHarga.Add(1000000);
            listHarga.Add(50000);

            listStock.Add(10);
            listStock.Add(20);
            listStock.Add(16);
            listStock.Add(26);
            listStock.Add(5);
            listStock.Add(11);
            listStock.Add(1);
            listStock.Add(8);

            listIdcategoryproduct.Add("C1");
            listIdcategoryproduct.Add("C2");
            listIdcategoryproduct.Add("C2");
            listIdcategoryproduct.Add("C3");
            listIdcategoryproduct.Add("C4");
            listIdcategoryproduct.Add("C4");
            listIdcategoryproduct.Add("C5");
            listIdcategoryproduct.Add("C2");

            listIdcategory.Add("C1");
            listIdcategory.Add("C2");
            listIdcategory.Add("C3");
            listIdcategory.Add("C4");
            listIdcategory.Add("C5");

            listNamacategory.Add("Jas");
            listNamacategory.Add("T-Shirt");
            listNamacategory.Add("Rok");
            listNamacategory.Add("Celana");
            listNamacategory.Add("Cawat");

            datagridviewProduct.DataSource = dtProdukSimpan;
            datagridviewCategory.DataSource = dtCategory;

            foreach (string a in listId)
            {
                int h = listId.IndexOf(a);
                dtProdukSimpan.Rows.Add(listId[h], listNama[h], listHarga[h], listStock[h], listIdcategoryproduct[h]);
            }

            for (int i = 0; i < listIdcategory.Count; i++)
            {
                row = dtCategory.NewRow();
                row[0] = listIdcategory[i];
                row[1] = listNamacategory[i];
                dtCategory.Rows.Add(row);
            }
            datagridviewProduct.ClearSelection();
            datagridviewCategory.ClearSelection();
            foreach (string s in listNamacategory)
            {
                comboboxCategory.Items.Add(s);
                comboboxProduct.Items.Add(s);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

            if ((textboxNamaProduct.Text == "") && ((textboxHarga.Text == "") && ((textboxStock.Text == "") && (comboboxCategory.SelectedValue == null))))
            {
                MessageBox.Show("Input yang lengkap yeah", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textboxHarga.Text = "";
                comboboxCategory.SelectedIndex = -1;
                textboxNamaProduct.Text = "";
                textboxStock.Text = "";
            }
            else
            {
                string hurufpertama = textboxNamaProduct.Text.Substring(0, 1).ToUpper();
                int nomer = 0;

                foreach (string g in listId)
                {
                    char a = g[0];
                    string b = a.ToString();
                    if (b == hurufpertama)
                    {
                        int nomer2 = Convert.ToInt32(g.Substring(1));
                        if (nomer <= nomer2)
                        {
                            nomer = nomer2;
                        }
                    }
                }
                string kode = hurufpertama;
                for (int i = nomer.ToString().Length; i < 3; i++)
                {
                    kode = kode + "0";
                }
                kode = kode + (nomer + 1).ToString();
                int indeks = comboboxCategory.SelectedIndex;
                string c = listIdcategory[indeks];
                listId.Add(kode);
                listNama.Add(textboxNamaProduct.Text);
                listHarga.Add(Convert.ToInt32(textboxHarga.Text));
                listStock.Add(Convert.ToInt32(textboxStock.Text));
                listIdcategoryproduct.Add(c);

                row = dtProdukSimpan.NewRow();
                row[0] = kode;
                row[1] = textboxNamaProduct.Text;
                row[2] = textboxHarga.Text;
                row[3] = textboxStock.Text;
                row[4] = c;
                dtProdukSimpan.Rows.Add(row);

                textboxNamaProduct.Clear();
                textboxHarga.Clear();
                textboxStock.Clear();
                comboboxCategory.SelectedIndex = -1;
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            comboboxProduct.Enabled = false;
            comboboxProduct.SelectedIndex = -1;
            datagridviewProduct.DataSource = dtProdukSimpan;
            datagridviewProduct.ClearSelection();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            comboboxProduct.Enabled = true;
        }

        private void buttonAddcategory_Click(object sender, EventArgs e)
        {
            if (textboxNamaCategory.Text == "")
            {
                MessageBox.Show("Diisi dulu dong bray", "Error cuy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int num = 1;
                bool yaa = false;
                if (listNamacategory.Contains(textboxNamaCategory.Text))
                {
                    yaa = true;
                }
                if (yaa)
                {
                    MessageBox.Show("Category udah ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!yaa)
                {
                    foreach (string t in listIdcategory)
                    {
                        if (t.StartsWith("C"))
                        {
                            int num2 = int.Parse(t.Substring(1));
                            if (num2 >= num)
                            {
                                num = num2 + 1;
                            }
                        }
                    }
                    string idcats = "C" + (num).ToString();
                    listIdcategory.Add(idcats);
                    datagridviewCategory.ClearSelection();
                    comboboxCategory.Items.Add(textboxNamaCategory.Text);
                    comboboxProduct.Items.Add(textboxNamaCategory.Text);
                    listNamacategory.Add(textboxNamaCategory.Text);
                    dtCategory.Rows.Add(idcats, textboxNamaCategory.Text);
                    textboxNamaCategory.Clear();
                }
            }
        }

        private void textboxHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
            {

                e.Handled = true;


            }
        }

        private void textboxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
            {

                e.Handled = true;

            }

        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (datagridviewProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih dulu item yang mau kamu ganti", "Error cuy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                foreach (DataRow row in dtProdukSimpan.Rows)
                {
                    int indeks = comboboxCategory.SelectedIndex;
                    int index = listId.FindIndex(a => a.Contains(datagridviewProduct.CurrentRow.Cells["ID Product"].Value.ToString()));
                    string idbaru = "";
                    if (row[0].ToString() == listId[index])
                    {
                        idbaru = listIdcategory[indeks];
                        row[1] = textboxNamaProduct.Text;
                        row[2] = textboxHarga.Text;
                        row[3] = textboxStock.Text;
                        row[4] = idbaru;
                        if (row[3].ToString() == "0")
                        {
                            dtProdukSimpan.Rows.Remove(row);
                            break;
                        }
                    }
                }
                textboxNamaProduct.Clear();
                textboxHarga.Clear();
                textboxStock.Clear();
                comboboxCategory.SelectedIndex = -1;
                datagridviewProduct.ClearSelection();
            }
        }

        private void datagridviewProduct_MouseClick(object sender, MouseEventArgs e)
        {
            textboxNamaProduct.Text = datagridviewProduct.CurrentRow.Cells["Nama Product"].Value.ToString();
            textboxHarga.Text = datagridviewProduct.CurrentRow.Cells["Harga"].Value.ToString();
            textboxStock.Text = datagridviewProduct.CurrentRow.Cells["Stock"].Value.ToString();

            int index = listIdcategory.FindIndex(a => a.Contains(datagridviewProduct.CurrentRow.Cells["ID Category"].Value.ToString()));
            string o = listNamacategory[index];
            comboboxCategory.Text = o;
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            if (datagridviewProduct.SelectedRows.Count != 0)
            {
                int selectedIndex = datagridviewProduct.CurrentCell.RowIndex;
                datagridviewProduct.Rows.RemoveAt(selectedIndex);

                listId.RemoveAt(selectedIndex);
                listNama.RemoveAt(selectedIndex);
                listHarga.RemoveAt(selectedIndex);
                listStock.RemoveAt(selectedIndex);
                listIdcategoryproduct.RemoveAt(selectedIndex);

                dtProdukSimpan.Clear();
                foreach (string b in listId)
                {
                    int i = listId.IndexOf(b);
                    dtProdukSimpan.Rows.Add(listId[i], listNama[i], listHarga[i], listStock[i], listIdcategoryproduct[i]);
                }
                textboxNamaProduct.Clear();
                textboxHarga.Clear();
                textboxStock.Clear();
                comboboxCategory.SelectedIndex = -1;
                datagridviewProduct.ClearSelection();
            }

        }

        private void buttonRemoveCategory_Click(object sender, EventArgs e)
        {
            if (datagridviewCategory.SelectedRows.Count == 0)
            {
                MessageBox.Show("yey");
                textboxNamaCategory.Text = "";
                return;
            }
            int index = datagridviewProduct.CurrentCell.RowIndex;

            if (datagridviewCategory.SelectedRows.Count != 0)
            {
                string select = listIdcategory[index];
                for (int i = listIdcategory.Count - 1; i >= 0; i--)
                {
                    if (listIdcategory[i] == (select))
                    {
                        listId.RemoveAt(i);
                        listNama.RemoveAt(i);
                        listHarga.RemoveAt(i);
                        listStock.RemoveAt(i);
                        listIdcategoryproduct.RemoveAt(i);
                    }
                }
                listIdcategory.RemoveAt(index);
                listNamacategory.RemoveAt(index);
                comboboxProduct.Items.Remove(textboxNamaCategory.Text);
                comboboxCategory.Items.Remove(textboxNamaCategory.Text);
            }
            dtCategory.Rows.Clear();
            dtProdukSimpan.Rows.Clear();

            foreach (string a in listId)
            {
                int j = listId.IndexOf(a);
                dtProdukSimpan.Rows.Add(listId[j], listNama[j], listHarga[j], listStock[j], listIdcategoryproduct[j]);
            }
            for (int i = 0; i < listIdcategory.Count; i++)
            {
                row = dtCategory.NewRow();
                row[0] = listIdcategory[i];
                row[1] = listNamacategory[i];
                dtCategory.Rows.Add(row);
            }
            datagridviewProduct.DataSource = dtProdukSimpan;
            datagridviewProduct.ClearSelection();
            datagridviewCategory.ClearSelection();
            textboxNamaCategory.Text = "";
        }

        private void comboboxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridviewProduct.DataSource = dtProdukTampil;
            string y = comboboxProduct.Text;
            dtProdukTampil.Clear();
            foreach (DataRow row in dtCategory.Rows)
            {
                if (y == row[1].ToString())
                {
                    foreach (DataRow dataRow in dtProdukSimpan.Rows)
                    {
                        if (dataRow["ID Category"].ToString() == row[0].ToString())
                        {
                            dtProdukTampil.Rows.Add(dataRow["ID Product"], dataRow["Nama Product"], dataRow["Harga"], dataRow["Stock"], dataRow["ID Category"]);
                        }
                    }
                }
            }
            datagridviewProduct.ClearSelection();
        }
    }
}
        
    