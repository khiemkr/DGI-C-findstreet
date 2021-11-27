
namespace Nieluancs
{
    partial class home
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
            this.lbexit = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.cbstart = new System.Windows.Forms.ComboBox();
            this.cbend = new System.Windows.Forms.ComboBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btndetEdge = new System.Windows.Forms.Button();
            this.btnaddVer = new System.Windows.Forms.Button();
            this.txtdis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbVer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDisVer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbToVer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lvMatix = new System.Windows.Forms.ListView();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbexit
            // 
            this.lbexit.AutoSize = true;
            this.lbexit.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbexit.ForeColor = System.Drawing.Color.Red;
            this.lbexit.Location = new System.Drawing.Point(999, 31);
            this.lbexit.Name = "lbexit";
            this.lbexit.Size = new System.Drawing.Size(29, 31);
            this.lbexit.TabIndex = 2;
            this.lbexit.Text = "X";
            this.lbexit.Click += new System.EventHandler(this.lbexit_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearch.ForeColor = System.Drawing.Color.Navy;
            this.btnsearch.Location = new System.Drawing.Point(115, 27);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(103, 36);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "End";
            // 
            // btnadd
            // 
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadd.ForeColor = System.Drawing.Color.Navy;
            this.btnadd.Location = new System.Drawing.Point(15, 24);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(103, 39);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "AddEdge";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.ForeColor = System.Drawing.Color.Navy;
            this.btndelete.Location = new System.Drawing.Point(124, 24);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(103, 39);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "DeleteEdge";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picGraph);
            this.groupBox1.Location = new System.Drawing.Point(404, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 526);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maps";
            // 
            // picGraph
            // 
            this.picGraph.BackgroundImage = global::Nieluancs.Properties.Resources.vnm__can_tho;
            this.picGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGraph.Location = new System.Drawing.Point(6, 40);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(668, 480);
            this.picGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGraph.TabIndex = 0;
            this.picGraph.TabStop = false;
            // 
            // cbstart
            // 
            this.cbstart.FormattingEnabled = true;
            this.cbstart.Location = new System.Drawing.Point(73, 26);
            this.cbstart.Name = "cbstart";
            this.cbstart.Size = new System.Drawing.Size(107, 28);
            this.cbstart.TabIndex = 15;
            // 
            // cbend
            // 
            this.cbend.FormattingEnabled = true;
            this.cbend.Location = new System.Drawing.Point(73, 65);
            this.cbend.Name = "cbend";
            this.cbend.Size = new System.Drawing.Size(107, 28);
            this.cbend.TabIndex = 16;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(11, 26);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(231, 51);
            this.txtresult.TabIndex = 18;
            // 
            // btnopen
            // 
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnopen.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnopen.ForeColor = System.Drawing.Color.Navy;
            this.btnopen.Location = new System.Drawing.Point(6, 26);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(103, 37);
            this.btnopen.TabIndex = 19;
            this.btnopen.Text = "OPENFILE";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(224, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(442, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Nieluancs.Properties.Resources.e2c0cc964e2f4e53233cbaa11b13af7e;
            this.button3.Font = new System.Drawing.Font("SimSun-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Indigo;
            this.button3.Location = new System.Drawing.Point(12, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1072, 68);
            this.button3.TabIndex = 23;
            this.button3.Text = "SYSTEM FIND STREET";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtresult);
            this.groupBox3.Location = new System.Drawing.Point(12, 577);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 86);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Path";
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDistance.Location = new System.Drawing.Point(26, 26);
            this.txtDistance.Multiline = true;
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(55, 51);
            this.txtDistance.TabIndex = 19;
            this.txtDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDistance);
            this.groupBox4.Location = new System.Drawing.Point(277, 577);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(109, 86);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Distance";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.btnadd);
            this.groupBox5.Controls.Add(this.btndelete);
            this.groupBox5.Location = new System.Drawing.Point(17, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 69);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ConTrolEdge";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(119, 150);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(250, 125);
            this.groupBox8.TabIndex = 29;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "groupBox8";
            // 
            // btndetEdge
            // 
            this.btndetEdge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndetEdge.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndetEdge.ForeColor = System.Drawing.Color.Navy;
            this.btndetEdge.Location = new System.Drawing.Point(127, 24);
            this.btndetEdge.Name = "btndetEdge";
            this.btndetEdge.Size = new System.Drawing.Size(103, 39);
            this.btndetEdge.TabIndex = 15;
            this.btndetEdge.Text = "DeleteVer";
            this.btndetEdge.UseVisualStyleBackColor = true;
            this.btndetEdge.Click += new System.EventHandler(this.btndetEdge_Click);
            // 
            // btnaddVer
            // 
            this.btnaddVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddVer.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnaddVer.ForeColor = System.Drawing.Color.Navy;
            this.btnaddVer.Location = new System.Drawing.Point(16, 24);
            this.btnaddVer.Name = "btnaddVer";
            this.btnaddVer.Size = new System.Drawing.Size(103, 39);
            this.btnaddVer.TabIndex = 14;
            this.btnaddVer.Text = "AddVer";
            this.btnaddVer.UseVisualStyleBackColor = true;
            this.btnaddVer.Click += new System.EventHandler(this.btnaddVer_Click);
            // 
            // txtdis
            // 
            this.txtdis.Location = new System.Drawing.Point(74, 109);
            this.txtdis.Name = "txtdis";
            this.txtdis.Size = new System.Drawing.Size(45, 27);
            this.txtdis.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Dist";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtdis);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.cbstart);
            this.groupBox6.Controls.Add(this.cbend);
            this.groupBox6.Location = new System.Drawing.Point(17, 152);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(185, 157);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Input Edge";
            // 
            // cbVer
            // 
            this.cbVer.FormattingEnabled = true;
            this.cbVer.Location = new System.Drawing.Point(69, 26);
            this.cbVer.Name = "cbVer";
            this.cbVer.Size = new System.Drawing.Size(104, 28);
            this.cbVer.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ver";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnsave);
            this.groupBox7.Controls.Add(this.btnopen);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.btnsearch);
            this.groupBox7.Location = new System.Drawing.Point(525, 68);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(559, 69);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Menu";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDisVer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbToVer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbVer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(208, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 157);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Vertices";
            // 
            // txtDisVer
            // 
            this.txtDisVer.Location = new System.Drawing.Point(95, 109);
            this.txtDisVer.Name = "txtDisVer";
            this.txtDisVer.Size = new System.Drawing.Size(45, 27);
            this.txtDisVer.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(15, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 30);
            this.label6.TabIndex = 31;
            this.label6.Text = "Dist";
            // 
            // cbToVer
            // 
            this.cbToVer.FormattingEnabled = true;
            this.cbToVer.Location = new System.Drawing.Point(69, 68);
            this.cbToVer.Name = "cbToVer";
            this.cbToVer.Size = new System.Drawing.Size(104, 28);
            this.cbToVer.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 30);
            this.label3.TabIndex = 31;
            this.label3.Text = "To";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnaddVer);
            this.groupBox9.Controls.Add(this.btndetEdge);
            this.groupBox9.Location = new System.Drawing.Point(277, 68);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(242, 69);
            this.groupBox9.TabIndex = 29;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "ControlVer";
            // 
            // lvMatix
            // 
            this.lvMatix.HideSelection = false;
            this.lvMatix.Location = new System.Drawing.Point(53, 20);
            this.lvMatix.Name = "lvMatix";
            this.lvMatix.Size = new System.Drawing.Size(267, 230);
            this.lvMatix.TabIndex = 30;
            this.lvMatix.UseCompatibleStateImageBehavior = false;
            this.lvMatix.View = System.Windows.Forms.View.Details;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lvMatix);
            this.groupBox10.Location = new System.Drawing.Point(17, 315);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(369, 256);
            this.groupBox10.TabIndex = 31;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Matrixvalue";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsave.ForeColor = System.Drawing.Color.Navy;
            this.btnsave.Location = new System.Drawing.Point(333, 27);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 36);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 685);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbexit);
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbexit;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.ComboBox cbstart;
        private System.Windows.Forms.ComboBox cbend;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtdis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndetEdge;
        private System.Windows.Forms.Button btnaddVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbToVer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListView lvMatix;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnsave;
    }
}