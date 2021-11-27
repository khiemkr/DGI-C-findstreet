using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
namespace Nieluancs
{
    class matrix
    {
        private int _vertices; // dinh
        private List<List<int>> _adjacent; // danh canh ke
        public List<List<int>> AdjValue;
        public int [,] ArrayValue;
        public List<List<int>> Adjacent
        {
            get { return _adjacent; }
            set { _adjacent = value; }
        }
        public int [,] array
        {
            get { return ArrayValue; }
            set { ArrayValue = value; }
        }
        public int Vertices
        {
            get { return _vertices; }
            set { _vertices = value; }
        }
        public List<List<int>> Value

        {
            get { return AdjValue; }
            set { AdjValue = value; }
        }
        // them columnheader cho list view
        private ColumnHeader AddColunmListView(string text)
        {
            ColumnHeader headerCol = new ColumnHeader();
            headerCol.Text = text;
            headerCol.Width = 24;
            headerCol.TextAlign = HorizontalAlignment.Center;
            headerCol.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            return headerCol;
        }
        public int[,] G = new int[20, 20];

        public List<List<int>> LoadFile(string fileName, ListView lv, ComboBox cboFrom, ComboBox cboTo, ComboBox cboVer, ComboBox cboToVer)
        {
            //ListView lv
            StreamReader fin = new StreamReader(fileName);

            // danh sach can ke
            this._adjacent = new List<List<int>>();
            this.Vertices = Convert.ToInt32(fin.ReadLine());
            string line = "";
            List<int> row;

            lv.Columns.Add(AddColunmListView(""));
            for (int iX = 0; iX < this.Vertices; ++iX)
            {
                line = fin.ReadLine();
                string[] words = line.Split(' ');
                if ((iX + 1) == 1)
                {
                    cboFrom.Items.Add("Ninh Kiều");
                    cboTo.Items.Add("Ninh Kiều");
                    cboVer.Items.Add("Ninh Kiều");
                    cboToVer.Items.Add("Ninh Kiều");

                }
                if ((iX + 1) == 2)
                {
                    cboFrom.Items.Add("Bình Thủy");
                    cboTo.Items.Add("Bình Thủy");
                    cboVer.Items.Add("Bình Thủy");
                    cboToVer.Items.Add("Bình Thủy");

                }
                if ((iX + 1) == 3)
                {
                    cboFrom.Items.Add("Cái Răng");
                    cboTo.Items.Add("Cái Răng");
                    cboVer.Items.Add("Cái Răng");
                    cboToVer.Items.Add("Cái Răng");

                }
                if ((iX + 1) == 4)
                {
                    cboFrom.Items.Add("Ô Môn");
                    cboTo.Items.Add("Ô Môn");
                    cboVer.Items.Add("Ô Môn");
                    cboToVer.Items.Add("Ô Môn");

                }
                if ((iX + 1) == 5)
                {
                    cboFrom.Items.Add("Thốt Nốt");
                    cboTo.Items.Add("Thốt Nốt");
                    cboVer.Items.Add("Thốt Nốt");
                    cboToVer.Items.Add("Thốt Nốt");

                }
                if ((iX + 1) == 6)
                {
                    cboFrom.Items.Add("Phong Điền");
                    cboTo.Items.Add("Phong Điền");
                    cboVer.Items.Add("Phong Điền");
                    cboToVer.Items.Add("Phong Điền");

                }
                if ((iX + 1) == 7)
                {
                    cboFrom.Items.Add("Thới Lai");
                    cboTo.Items.Add("Thới Lai");
                    cboVer.Items.Add("Thới Lai");
                    cboToVer.Items.Add("Thới Lai");

                }
                if ((iX + 1) == 8)
                {
                    cboFrom.Items.Add("Cờ Đỏ");
                    cboTo.Items.Add("Cờ Đỏ");
                    cboVer.Items.Add("Cờ Đỏ");
                    cboToVer.Items.Add("Cờ Đỏ");

                }
                if ((iX + 1) == 9)
                {
                    cboFrom.Items.Add("Vĩnh Thạnh");
                    cboTo.Items.Add("Vĩnh Thạnh");
                    cboVer.Items.Add("Vĩnh Thạnh");
                    cboToVer.Items.Add("Vĩnh Thạnh");

                }
                lv.Columns.Add(AddColunmListView((iX + 1).ToString()));

                // them dong vao list view
                ListViewItem lvi = new ListViewItem((iX + 1).ToString());
                lvi.UseItemStyleForSubItems = false;
                row = new List<int>();
                for (int iY = 0; iY < this.Vertices; ++iY)
                {
                    // list view sub item
                    ListViewItem.ListViewSubItem col = lvi.SubItems.Add(words[iY]);
                    col.ForeColor = Color.Blue; // mau cua list view subitem
                    if (words[iY] != "0")
                    {
                        row.Add(iY);
                        col.ForeColor = Color.Red; // mau cua list view subitem
                    }
                }
                this._adjacent.Add(row);
                lv.Items.Add(lvi);

            }
            fin.Close();
            return this._adjacent;

        }
        public List<List<int>> Loadvalue(String file)
        {
            // danh sach trong so
            StreamReader readfile = new StreamReader(file);
            this.Value = new List<List<int>>(); // khoi tao danh sach trong so
            this.Vertices = Convert.ToInt32(readfile.ReadLine()); //khoi tao dinh
            List<int> row;
            int[,] G = new int[this.Vertices, this.Vertices];
            string line = "";
            for (int iX = 0; iX < this.Vertices; ++iX)
            {
                line = readfile.ReadLine();
                string[] words = line.Split(' ');
                row = new List<int>();
                for (int iY = 0; iY < this.Vertices; ++iY)
                {
                    if (words[iY] != "0")
                    {
                        row.Add(Convert.ToInt32(words[iY]));
                    }
                }
                this.Value.Add(row);
            }
            readfile.Close();
            return this.Value;
        }
        public int [,] Graphvalue(string file) { 
            StreamReader reader = new StreamReader(file);
            this.Vertices = Convert.ToInt32(reader.ReadLine());
            this.array = new int [this.Vertices,this.Vertices];           
            string line = "";
            for(int ix=0; ix < this.Vertices; ++ix)
            {
                line = reader.ReadLine();
                string[] words = line.Split(' ');
                for (int iy=0; iy< this.Vertices; ++iy)
                {
                    if (words[iy]!= "0")
                    {
                        this.array[ix, iy] = Convert.ToInt32(words[iy]);
                    }
                    else
                    {
                        this.array[ix, iy] = 0;
                    }
                }
            }
            reader.Close();
            return this.array;
        }
    }
}
