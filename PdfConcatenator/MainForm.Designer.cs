namespace PdfConcatenator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label3 = new System.Windows.Forms.Label();
            this.saveOutputFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.selectOutputButton = new System.Windows.Forms.Button();
            this.saveOutputTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.upDownItemPos = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openPdfFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownItemPos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "© O.Lopatnov";
            // 
            // saveOutputFileDialog
            // 
            this.saveOutputFileDialog.Filter = "PDF Files|*.pdf";
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(338, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 381);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.AllowDrop = true;
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(0, 0);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(338, 381);
            this.listBoxFiles.TabIndex = 2;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            this.listBoxFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxFiles_DragDrop);
            this.listBoxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxFiles_DragEnter);
            // 
            // selectOutputButton
            // 
            this.selectOutputButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectOutputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectOutputButton.Location = new System.Drawing.Point(4, 3);
            this.selectOutputButton.Name = "selectOutputButton";
            this.selectOutputButton.Size = new System.Drawing.Size(105, 22);
            this.selectOutputButton.TabIndex = 6;
            this.selectOutputButton.Text = "Select";
            this.selectOutputButton.UseVisualStyleBackColor = true;
            this.selectOutputButton.Click += new System.EventHandler(this.selectOutputButton_Click);
            // 
            // saveOutputTextBox
            // 
            this.saveOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveOutputTextBox.Location = new System.Drawing.Point(4, 4);
            this.saveOutputTextBox.Name = "saveOutputTextBox";
            this.saveOutputTextBox.Size = new System.Drawing.Size(294, 20);
            this.saveOutputTextBox.TabIndex = 4;
            this.saveOutputTextBox.Text = "output.pdf";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(715, 418);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 13;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.saveOutputTextBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(8, 29);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4);
            this.panel5.Size = new System.Drawing.Size(302, 29);
            this.panel5.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(341, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 381);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(431, 66);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.selectOutputButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(310, 29);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this.panel4.Size = new System.Drawing.Size(113, 29);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output file";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.listBoxFiles);
            this.panel1.Location = new System.Drawing.Point(18, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 381);
            this.panel1.TabIndex = 12;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(200, 418);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // upDownItemPos
            // 
            this.upDownItemPos.Location = new System.Drawing.Point(18, 420);
            this.upDownItemPos.Name = "upDownItemPos";
            this.upDownItemPos.Size = new System.Drawing.Size(120, 20);
            this.upDownItemPos.TabIndex = 10;
            this.upDownItemPos.ValueChanged += new System.EventHandler(this.upDownItemPos_ValueChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(281, 418);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "File List";
            // 
            // openPdfFileDialog
            // 
            this.openPdfFileDialog.Filter = "PDF Files|*.pdf";
            this.openPdfFileDialog.Multiselect = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.upDownItemPos);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PDF Concatenator";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upDownItemPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveOutputFileDialog;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button selectOutputButton;
        private System.Windows.Forms.TextBox saveOutputTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.NumericUpDown upDownItemPos;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openPdfFileDialog;
    }
}

