namespace Quest06
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ФИО");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Работники");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Капитан");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Отдыхающие");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Тип пассажира", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Дата рождения");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Номер билета");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Дата отправления");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Пассажиры", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Название");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Военный");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Торговый");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Пассажирский");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Тип порта", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Страна");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Количество причалов");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Порты", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Название");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Военный");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Торговый");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Пассажирский");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Тип корабля", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Год основания");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Скорость");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Количество экипажа");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Корабли", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tree1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 656);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.splitContainer1.Panel1.Controls.Add(this.treeView2);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.tree1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 656);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView2.Location = new System.Drawing.Point(11, 471);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Node1";
            treeNode1.Text = "ФИО";
            treeNode2.Name = "Node6";
            treeNode2.Text = "Работники";
            treeNode3.Name = "Node7";
            treeNode3.Text = "Капитан";
            treeNode4.Name = "Node8";
            treeNode4.Text = "Отдыхающие";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Тип пассажира";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Дата рождения";
            treeNode7.Name = "Node5";
            treeNode7.Text = "Номер билета";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Дата отправления";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Пассажиры";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView2.Size = new System.Drawing.Size(229, 143);
            this.treeView2.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Location = new System.Drawing.Point(11, 318);
            this.treeView1.Name = "treeView1";
            treeNode10.Name = "Node1";
            treeNode10.Text = "Название";
            treeNode11.Name = "Node6";
            treeNode11.Text = "Военный";
            treeNode12.Name = "Node7";
            treeNode12.Text = "Торговый";
            treeNode13.Name = "Node8";
            treeNode13.Text = "Пассажирский";
            treeNode14.Name = "Node3";
            treeNode14.Text = "Тип порта";
            treeNode15.Name = "Node4";
            treeNode15.Text = "Страна";
            treeNode16.Name = "Node5";
            treeNode16.Text = "Количество причалов";
            treeNode17.Name = "Node0";
            treeNode17.Text = "Порты";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.treeView1.Size = new System.Drawing.Size(229, 143);
            this.treeView1.TabIndex = 2;
            // 
            // tree1
            // 
            this.tree1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tree1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree1.Location = new System.Drawing.Point(13, 169);
            this.tree1.Name = "tree1";
            treeNode18.Name = "Node1";
            treeNode18.Text = "Название";
            treeNode19.Name = "Node6";
            treeNode19.Text = "Военный";
            treeNode20.Name = "Node7";
            treeNode20.Text = "Торговый";
            treeNode21.Name = "Node8";
            treeNode21.Text = "Пассажирский";
            treeNode22.Name = "Node3";
            treeNode22.Text = "Тип корабля";
            treeNode23.Name = "Node4";
            treeNode23.Text = "Год основания";
            treeNode24.Name = "Node5";
            treeNode24.Text = "Скорость";
            treeNode25.Name = "Node9";
            treeNode25.Text = "Количество экипажа";
            treeNode26.Name = "Node0";
            treeNode26.Text = "Корабли";
            this.tree1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.tree1.Size = new System.Drawing.Size(229, 143);
            this.tree1.TabIndex = 1;
            this.tree1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree1_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Quest06.Properties.Resources.ship;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 656);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Загрузить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить XML-файл Корабли";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Показать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(823, 621);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(829, 627);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Закрыть";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "Загрузить JSON-файл Корабли";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 77);
            this.button3.TabIndex = 2;
            this.button3.Text = "Загрузить XML-файл    Порты";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(471, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 77);
            this.button4.TabIndex = 3;
            this.button4.Text = "Загрузить XML-файл Пассажиры";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(244, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 77);
            this.button5.TabIndex = 4;
            this.button5.Text = "Загрузить JSON-файл   Порты";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(471, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(204, 77);
            this.button6.TabIndex = 5;
            this.button6.Text = "Загрузить JSON-файл Пассажиры";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI Historic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(46, 114);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(689, 335);
            this.button7.TabIndex = 0;
            this.button7.Text = "закрыть приложение";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 656);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fleet";
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView tree1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
    }
}

