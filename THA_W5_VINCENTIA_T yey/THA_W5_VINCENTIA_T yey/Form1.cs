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
                string f = textboxNamaProduct.Text.Substring(0, 1).ToUpper();
                int num = 0;

                foreach (string g in listId)
                {
                    char a = g[0];
                    string b = a.ToString();
                    if (b == f)
                    {
                        int num2 = Convert.ToInt32(g.Substring(1));
                        if (num <= num2)
                        {
                            num = num2;
                        }
                    }
                }
                string ce = f;
                for (int i = num.ToString().Length; i < 3; i++)
                {
                    ce = ce + "0";
                }
                ce = ce + (num + 1).ToString();
                int indeks = comboboxCategory.SelectedIndex;
                string c = listIdcategory[indeks];

                listId.Add(ce);
                listNama.Add(textboxNamaProduct.Text);
                listHarga.Add(Convert.ToInt32(textboxHarga.Text));
                listStock.Add(Convert.ToInt32(textboxStock.Text));
                listIdcategoryproduct.Add(c);

                row = dtProdukSimpan.NewRow();
                row[0] = ce;
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
                MessageBox.Show("Input yang lengkap yeah", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                int num = 1;
                bool t = false;
                if (listNamacategory.Contains(textboxNamaCategory.Text))
                {
                    t = true;
                }
                if (true)
                {
                    MessageBox.Show("dah ada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (!t)
                {
                    foreach (string b in listIdcategory)
                    {
                        if (b.StartsWith("C"))
                        {
                            int num2 = int.Parse(b.Substring(1));
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
                MessageBox.Show("pilih dulu", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                MessageBox.Show("pilih dulu", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textboxNamaCategory.Text = "";
                return;
            }

            int categoryIndex = datagridviewCategory.CurrentCell.RowIndex;
            string categoryId = listIdcategory[categoryIndex];

            // Remove any products associated with the category
            for (int i = listIdcategoryproduct.Count - 1; i >= 0; i--)
            {
                if (listIdcategoryproduct[i] == categoryId)
                {
                    listId.RemoveAt(i);
                    listNama.RemoveAt(i);
                    listHarga.RemoveAt(i);
                    listStock.RemoveAt(i);
                    listIdcategoryproduct.RemoveAt(i);
                }
            }

            // Remove the category
            listIdcategory.RemoveAt(categoryIndex);
            listNamacategory.RemoveAt(categoryIndex);
            comboboxProduct.Items.Remove(datagridviewCategory.CurrentRow.Cells["Nama Category"].Value.ToString());
            comboboxCategory.Items.Remove(datagridviewCategory.CurrentRow.Cells["Nama Category"].Value.ToString());

            // Remove the selected row from the DataGridView
            datagridviewCategory.Rows.RemoveAt(categoryIndex);

            // Refresh the category and product datagridviews
            dtCategory.Rows.Clear();
            foreach (string tt in listIdcategory)
            {
                int rowIndex = listIdcategory.IndexOf(tt);
                dtCategory.Rows.Add(tt, listNamacategory[rowIndex]);
            }

            dtProdukSimpan.Rows.Clear();
            foreach (string productId in listId)
            {
                int rowIndex = listId.IndexOf(productId);
                dtProdukSimpan.Rows.Add(listId[rowIndex], listNama[rowIndex], listHarga[rowIndex], listStock[rowIndex], listIdcategoryproduct[rowIndex]);
            }

            // Clear the textboxes and selection
            textboxNamaCategory.Clear();
            datagridviewCategory.ClearSelection();

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
        
    