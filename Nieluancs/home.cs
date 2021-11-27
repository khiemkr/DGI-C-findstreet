using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Channels;
namespace Nieluancs
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        List<List<int>> Adjacent;//danh scah canh ke
        int Vertices; // so dinh
        List<List<int>> Value;//danh sach trong so
        int[,] Graph;//mang cac trong so 
        Graphtool g; // khai bao 1 graphicsTools
        List<Point> lstPointVertices; // danh sach toa do cac dinh
        string FileName;
        public const int PicturePadding = 50; // picture padding
        

        private void lbexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private ColumnHeader AddColunmListView(string text)
        {
            ColumnHeader headerCol = new ColumnHeader();
            headerCol.Text = text;
            headerCol.Width = 24;
            headerCol.TextAlign = HorizontalAlignment.Center;
            headerCol.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            return headerCol;
        }
        private void reload()
        {
            List<int> rowvalue;
            List<int> row;
            for (int iX = 0; iX < this.Vertices; ++iX)
            {
                this.lvMatix.Columns.Add(AddColunmListView((iX + 1).ToString()));
                ListViewItem lvi = new ListViewItem((iX + 1).ToString());
                lvi.UseItemStyleForSubItems = false;
                row = new List<int>();
                rowvalue = new List<int>();
                for (int iY = 0; iY < this.Vertices; ++iY)
                {
                    ListViewItem.ListViewSubItem col = lvi.SubItems.Add(Graph[iX, iY].ToString());
                    col.ForeColor = Color.Blue; // mau cua list view subitem
                    if (this.Graph[iX, iY] != 0)
                    {
                        row.Add(iY);
                        rowvalue.Add(Graph[iX, iY]);
                        col.ForeColor = Color.Red; // mau cua list view subitem

                    }
                }
                this.Adjacent.Add(row);
                this.Value.Add(rowvalue);
                this.lvMatix.Items.Add(lvi);

            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            this.lvMatix.Clear();
            string distance = txtdis.Text;
            int from = this.cbstart.SelectedIndex;
            int to = this.cbend.SelectedIndex;
            if (distance == "")
            {
                MessageBox.Show("Please enter the distance !!");
            }
            else
            {
                if(from == to || this.Graph[from,to] !=0 || this.Graph[to, from] != 0)
                {
                    MessageBox.Show("invalid vertex or path exists?? Please choose again!!!!!!!");
                }
                else
                {
                    for(int i = 0; i< this.Vertices; i++)
                    {
                        for(int j = 0; j < this.Vertices; j++)
                        {
                            if(this.Graph[from,to] == 0 && this.Graph[to, from] == 0)
                            {
                                this.Graph[from, to] = Convert.ToInt32(distance);
                                this.Graph[to, from] = Convert.ToInt32(distance);
                            }
                    
                        }
                    }
                } 
            }
            //reset gia tri
            this.txtresult.Clear();
            this.txtDistance.Clear();
            // load lai canh ke va trong so
            this.Adjacent = new List<List<int>>();
            this.Value = new List<List<int>>();
            this.lvMatix.Columns.Add(AddColunmListView(""));
            reload();
            this.g = new Graphtool(this.picGraph.Width, this.picGraph.Height);// khoi tao graphics tool
            // lay danh sach toa do cac dinh
            this.lstPointVertices = new Vector2D(this.Vertices, this.picGraph.Width - home.PicturePadding,
                                        this.picGraph.Height - home.PicturePadding).getRandomPoint();
            // tao bitmap do thi voi danh sach ke va danh sach toa cac dinh
            this.picGraph.Image = this.g.CreateGraphics(this.Adjacent, this.lstPointVertices);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Dijkstra dis = new Dijkstra(this.Adjacent,this.Value);
            
            int start = this.cbstart.SelectedIndex;
            int end = this.cbend.SelectedIndex;

            // reset picGraphics va txtResult
            this.picGraph.Image = this.g.Reset(this.Adjacent, this.lstPointVertices);
            this.txtresult.Clear();

            if (start == end)
            {
                MessageBox.Show("Vertices are duplicate. Please choose again!", "Error vertices Selected");
                return;
            }
            
            List<int> res = dis.Mooredijkstra(this.Vertices, start, end);//danh sach duog di
            int resvalue = dis.ValueDijkstra(this.Vertices, start, end); //trong so tren dinh
            if (resvalue > 50)
            {
                MessageBox.Show("Can't find any path");
                return;
            }
            else
            {

                int index;
                this.txtresult.Text = "";
                this.txtDistance.Text = "";
                // reset bit map
                this.g = new Graphtool(this.picGraph.Width, this.picGraph.Height);// khoi tao graphics tool
                                                                                  // lay danh sach toa do cac dinh
                this.lstPointVertices = new Vector2D(this.Vertices, this.picGraph.Width - home.PicturePadding,
                                            this.picGraph.Height - home.PicturePadding).getRandomPoint();
                // tao bitmap do thi voi danh sach ke va danh sach toa cac dinh
                this.picGraph.Image = this.g.CreateGraphics(this.Adjacent, this.lstPointVertices);
                // xuat ket qua ra text box
                for (index = 0; index < res.Count - 1; ++index)
                    this.txtresult.Text += (1 + res[index]).ToString() + " ---> ";
                this.txtresult.Text += (1 + res[index]).ToString();
                // xuat trong so len text box
                this.txtDistance.Text = resvalue.ToString();
                // ve duong di len bitmap
                this.picGraph.Image = this.g.DrawPath(res, this.lstPointVertices);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.lvMatix.Clear();
            int from = this.cbstart.SelectedIndex;
            int to = this.cbend.SelectedIndex;
            if (from == to)
            {
                MessageBox.Show("invalid vertex?? Please choose again!!!!!!!");
            }
            else if(this.Graph[from, to] == 0 && this.Graph[to, from] == 0)
            {
                MessageBox.Show("Can't find any path!!!");
            }
            else
            {
                MessageBox.Show("Are you want to detele!!!!!!");
                for (int i = 0; i < this.Vertices; i++)
                {
                    for (int j = 0; j < this.Vertices; j++)
                    {
                        if (this.Graph[from, to] != 0 && this.Graph[to, from] != 0)
                        {
                            this.Graph[from, to] = 0;
                            this.Graph[to, from] = 0;
                        }
                    }
                    
                }
            }
            //reset gia tri
            this.txtresult.Clear();
            this.txtDistance.Clear();
            // load lai canh ke va trong so
            this.Adjacent = new List<List<int>>();
            this.Value = new List<List<int>>();
            this.lvMatix.Columns.Add(AddColunmListView(""));
            reload();
            this.g = new Graphtool(this.picGraph.Width, this.picGraph.Height);// khoi tao graphics tool
            // lay danh sach toa do cac dinh
            this.lstPointVertices = new Vector2D(this.Vertices, this.picGraph.Width - home.PicturePadding,
                                        this.picGraph.Height - home.PicturePadding).getRandomPoint();
            // tao bitmap do thi voi danh sach ke va danh sach toa cac dinh
            this.picGraph.Image = this.g.CreateGraphics(this.Adjacent, this.lstPointVertices);
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Document File(*.txt)|*.txt|All File(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // enable button findpath va button save image
                    this.btnsearch.Enabled = true;
                    this.btnsave.Enabled = true;

                    // reset control values
                    this.cbstart.Items.Clear();
                    this.cbend.Items.Clear();
                    this.cbVer.Items.Clear();
                    this.lvMatix.Items.Clear();
                    this.lvMatix.Columns.Clear();
                    this.txtresult.Clear();
                    this.picGraph.Image = null;
                    //
                    matrix m = new matrix();
                    //this.lvview,
                    this.FileName = ofd.FileName;
                    this.Adjacent = m.LoadFile(this.FileName,this.lvMatix, this.cbstart, this.cbend, this.cbVer,this.cbToVer);
                    this.Value = m.Loadvalue(this.FileName);
                    this.Graph = m.Graphvalue(this.FileName);
                    this.cbstart.SelectedIndex = 0;
                    this.cbend.SelectedIndex = 1;
                    

                    this.Vertices = m.Vertices;

                    this.g = new Graphtool(this.picGraph.Width, this.picGraph.Height);// khoi tao graphics tool

                    // lay danh sach toa do cac dinh
                    this.lstPointVertices = new Vector2D(this.Vertices, this.picGraph.Width - home.PicturePadding,
                                                this.picGraph.Height - home.PicturePadding).getRandomPoint();

                    // tao bitmap do thi voi danh sach ke va danh sach toa cac dinh

                    this.picGraph.Image = this.g.CreateGraphics(this.Adjacent, this.lstPointVertices);
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "Error");
                }
            }
            ofd.Dispose();
        }
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnopen_Click(sender, e);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lvview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void btnaddVer_Click(object sender, EventArgs e)
        {
            this.lvMatix.Clear();
            int Ver = this.cbVer.SelectedIndex;
            int ToVer = this.cbToVer.SelectedIndex;
            String DisVer = txtDisVer.Text;
            MessageBox.Show("are you want to Add Vertices");
            for (int i = 0; i < this.Vertices; i++)
            {
                if (this.Graph[Ver, ToVer] == 0 && this.Graph[ToVer, Ver] == 0)
                {
                    this.Graph[Ver, ToVer] = Convert.ToInt32(DisVer);
                    this.Graph[ToVer, Ver] = Convert.ToInt32(DisVer);
                }
            }
            //reset gia tri
            this.txtresult.Clear();
            this.txtDistance.Clear();
            // load lai canh ke va trong so
            this.Adjacent = new List<List<int>>();
            this.Value = new List<List<int>>();
            this.lvMatix.Columns.Add(AddColunmListView(""));
            reload();
            this.g = new Graphtool(this.picGraph.Width, this.picGraph.Height);// khoi tao graphics tool
            // lay danh sach toa do cac dinh
            this.lstPointVertices = new Vector2D(this.Vertices, this.picGraph.Width - home.PicturePadding,
                                        this.picGraph.Height - home.PicturePadding).getRandomPoint();
            // tao bitmap do thi voi danh sach ke va danh sach toa cac dinh
            this.picGraph.Image = this.g.CreateGraphics(this.Adjacent, this.lstPointVertices);
        }

        private void btndetEdge_Click(object sender, EventArgs e)
        {
            this.lvMatix.Clear();
            int Ver = this.cbVer.SelectedIndex;
            MessageBox.Show("are you want to detele Vertices");
            for(int i =0; i < this.Vertices; i++)
            {
                if(this.Graph[Ver,i] != 0 && this.Graph[i, Ver] != 0)
                {
                    this.Graph[Ver, i] = 0;
                    this.Graph[i, Ver] = 0;
                }
            }
            //reset gia tri
            this.txtresult.Clear();
            this.txtDistance.Clear();
            // load lai canh ke va trong so
            this.Adjacent = new List<List<int>>();
            this.Value = new List<List<int>>();
            this.lvMatix.Columns.Add(AddColunmListView(""));
            reload();
            this.g = new Graphtool(this.picGraph.Width, this.picGraph.Height);// khoi tao graphics tool
            // lay danh sach toa do cac dinh
            this.lstPointVertices = new Vector2D(this.Vertices, this.picGraph.Width - home.PicturePadding,
                                        this.picGraph.Height - home.PicturePadding).getRandomPoint();
            // tao bitmap do thi voi danh sach ke va danh sach toa cac dinh
            this.picGraph.Image = this.g.CreateGraphics(this.Adjacent, this.lstPointVertices);
        }
        private void home_Load(object sender, EventArgs e)
        {
            this.btnsearch.Enabled = false;
            this.btnsave.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImgDialog = new SaveFileDialog();
            saveImgDialog.DefaultExt = "png";
            saveImgDialog.Filter = "Bitmap Image (*.png)|*.png|All File (*.*)|*.*";
            saveImgDialog.AddExtension = true;
            saveImgDialog.RestoreDirectory = true;
            saveImgDialog.Title = "Save graph to image";
            string initFileName = System.IO.Path.GetFileNameWithoutExtension(this.FileName);
            saveImgDialog.FileName = initFileName;
            try
            {
                if (saveImgDialog.ShowDialog() == DialogResult.OK)
                {
                    string imgPath = saveImgDialog.FileName;

                    if (imgPath != null)
                    {
                        if (this.picGraph.Image != null)
                        {
                            this.picGraph.Image.Save(imgPath, System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            saveImgDialog.Dispose();
        }
    }
}
