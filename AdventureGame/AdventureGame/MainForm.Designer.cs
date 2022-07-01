namespace AdventureGame
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reStartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eastBtn = new System.Windows.Forms.Button();
            this.southBtn = new System.Windows.Forms.Button();
            this.westBtn = new System.Windows.Forms.Button();
            this.northBtn = new System.Windows.Forms.Button();
            this.InvBtn = new System.Windows.Forms.Button();
            this.lookBtn = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lookAtBtn = new System.Windows.Forms.Button();
            this.dropBtn = new System.Windows.Forms.Button();
            this.takeBtn = new System.Windows.Forms.Button();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem
            // 
            this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMenuItem,
            this.saveMenuItem,
            this.reStartMenuItem,
            this.toolStripMenuItem1,
            this.exitMenuItem});
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(54, 29);
            this.MenuItem.Text = "File";
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.Size = new System.Drawing.Size(169, 34);
            this.loadMenuItem.Text = "Load";
            this.loadMenuItem.Click += new System.EventHandler(this.loadMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(169, 34);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // reStartMenuItem
            // 
            this.reStartMenuItem.Name = "reStartMenuItem";
            this.reStartMenuItem.Size = new System.Drawing.Size(169, 34);
            this.reStartMenuItem.Text = "ReStart";
            this.reStartMenuItem.Click += new System.EventHandler(this.reStartMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(169, 34);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // displayTB
            // 
            this.displayTB.Location = new System.Drawing.Point(0, 36);
            this.displayTB.Multiline = true;
            this.displayTB.Name = "displayTB";
            this.displayTB.Size = new System.Drawing.Size(800, 172);
            this.displayTB.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eastBtn);
            this.panel1.Controls.Add(this.southBtn);
            this.panel1.Controls.Add(this.westBtn);
            this.panel1.Controls.Add(this.northBtn);
            this.panel1.Controls.Add(this.InvBtn);
            this.panel1.Controls.Add(this.lookBtn);
            this.panel1.Controls.Add(this.testBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 224);
            this.panel1.TabIndex = 2;
            // 
            // eastBtn
            // 
            this.eastBtn.Location = new System.Drawing.Point(676, 99);
            this.eastBtn.Name = "eastBtn";
            this.eastBtn.Size = new System.Drawing.Size(112, 34);
            this.eastBtn.TabIndex = 7;
            this.eastBtn.Text = "E";
            this.eastBtn.UseVisualStyleBackColor = true;
            this.eastBtn.Click += new System.EventHandler(this.eastBtn_Click);
            // 
            // southBtn
            // 
            this.southBtn.Location = new System.Drawing.Point(601, 143);
            this.southBtn.Name = "southBtn";
            this.southBtn.Size = new System.Drawing.Size(112, 34);
            this.southBtn.TabIndex = 6;
            this.southBtn.Text = "S";
            this.southBtn.UseVisualStyleBackColor = true;
            this.southBtn.Click += new System.EventHandler(this.southBtn_Click);
            // 
            // westBtn
            // 
            this.westBtn.Location = new System.Drawing.Point(513, 99);
            this.westBtn.Name = "westBtn";
            this.westBtn.Size = new System.Drawing.Size(112, 34);
            this.westBtn.TabIndex = 5;
            this.westBtn.Text = "W";
            this.westBtn.UseVisualStyleBackColor = true;
            this.westBtn.Click += new System.EventHandler(this.westBtn_Click);
            // 
            // northBtn
            // 
            this.northBtn.Location = new System.Drawing.Point(601, 45);
            this.northBtn.Name = "northBtn";
            this.northBtn.Size = new System.Drawing.Size(112, 34);
            this.northBtn.TabIndex = 4;
            this.northBtn.Text = "N";
            this.northBtn.UseVisualStyleBackColor = true;
            this.northBtn.Click += new System.EventHandler(this.northBtn_Click);
            // 
            // InvBtn
            // 
            this.InvBtn.Location = new System.Drawing.Point(357, 139);
            this.InvBtn.Name = "InvBtn";
            this.InvBtn.Size = new System.Drawing.Size(112, 34);
            this.InvBtn.TabIndex = 3;
            this.InvBtn.Text = "Inventory";
            this.InvBtn.UseVisualStyleBackColor = true;
            this.InvBtn.Click += new System.EventHandler(this.InvBtn_Click);
            // 
            // lookBtn
            // 
            this.lookBtn.Location = new System.Drawing.Point(357, 99);
            this.lookBtn.Name = "lookBtn";
            this.lookBtn.Size = new System.Drawing.Size(112, 34);
            this.lookBtn.TabIndex = 2;
            this.lookBtn.Text = "Look";
            this.lookBtn.UseVisualStyleBackColor = true;
            this.lookBtn.Click += new System.EventHandler(this.lookBtn_Click);
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(357, 59);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(112, 34);
            this.testBtn.TabIndex = 1;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lookAtBtn);
            this.groupBox1.Controls.Add(this.dropBtn);
            this.groupBox1.Controls.Add(this.takeBtn);
            this.groupBox1.Controls.Add(this.inputTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Do to Object...";
            // 
            // lookAtBtn
            // 
            this.lookAtBtn.Location = new System.Drawing.Point(6, 118);
            this.lookAtBtn.Name = "lookAtBtn";
            this.lookAtBtn.Size = new System.Drawing.Size(112, 34);
            this.lookAtBtn.TabIndex = 3;
            this.lookAtBtn.Text = "Look At";
            this.lookAtBtn.UseVisualStyleBackColor = true;
            this.lookAtBtn.Click += new System.EventHandler(this.lookAtBtn_Click);
            // 
            // dropBtn
            // 
            this.dropBtn.Location = new System.Drawing.Point(182, 78);
            this.dropBtn.Name = "dropBtn";
            this.dropBtn.Size = new System.Drawing.Size(112, 34);
            this.dropBtn.TabIndex = 2;
            this.dropBtn.Text = "Drop";
            this.dropBtn.UseVisualStyleBackColor = true;
            this.dropBtn.Click += new System.EventHandler(this.dropBtn_Click);
            // 
            // takeBtn
            // 
            this.takeBtn.Location = new System.Drawing.Point(6, 78);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(112, 34);
            this.takeBtn.TabIndex = 1;
            this.takeBtn.Text = "Take";
            this.takeBtn.UseVisualStyleBackColor = true;
            this.takeBtn.Click += new System.EventHandler(this.takeBtn_Click);
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(6, 41);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(288, 31);
            this.inputTB.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItem;
        private ToolStripMenuItem loadMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem reStartMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private TextBox displayTB;
        private Panel panel1;
        private Button InvBtn;
        private Button lookBtn;
        private Button testBtn;
        private GroupBox groupBox1;
        private Button lookAtBtn;
        private Button dropBtn;
        private Button takeBtn;
        private TextBox inputTB;
        private Button southBtn;
        private Button westBtn;
        private Button northBtn;
        private Button eastBtn;
        private ToolStripSeparator toolStripMenuItem1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}