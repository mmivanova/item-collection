using System;
using System.Windows.Forms;

namespace ItemCollection
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lbNames = new System.Windows.Forms.ListBox();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.lblCountNames = new System.Windows.Forms.Label();
            this.lblCountNumbers = new System.Windows.Forms.Label();
            this.tbCountNames = new System.Windows.Forms.TextBox();
            this.tbCountNumbers = new System.Windows.Forms.TextBox();
            this.lbCollection = new System.Windows.Forms.ListBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCountList = new System.Windows.Forms.Label();
            this.tbCountCollection = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.tbEnter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(26, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(320, 15);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(78, 20);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number: ";
            // 
            // lbNames
            // 
            this.lbNames.BackColor = System.Drawing.Color.SeaShell;
            this.lbNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNames.FormattingEnabled = true;
            this.lbNames.ItemHeight = 22;
            this.lbNames.Items.AddRange(new object[] {
            "Ivan",
            "Maria",
            "Aleks",
            "Ivaila",
            "Petur",
            "Kamen"});
            this.lbNames.Location = new System.Drawing.Point(29, 39);
            this.lbNames.Name = "lbNames";
            this.lbNames.Size = new System.Drawing.Size(230, 180);
            this.lbNames.TabIndex = 2;
            // 
            // lbNumbers
            // 
            this.lbNumbers.BackColor = System.Drawing.Color.SeaShell;
            this.lbNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.ItemHeight = 22;
            this.lbNumbers.Items.AddRange(new object[] {
            "1",
            "8",
            "7",
            "6",
            "5",
            "9",
            "3",
            "4",
            "2"});
            this.lbNumbers.Location = new System.Drawing.Point(323, 39);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(230, 180);
            this.lbNumbers.TabIndex = 3;
            // 
            // btnAddName
            // 
            this.btnAddName.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddName.Location = new System.Drawing.Point(57, 239);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(168, 35);
            this.btnAddName.TabIndex = 4;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = false;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNumber.Location = new System.Drawing.Point(354, 239);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(168, 35);
            this.btnAddNumber.TabIndex = 5;
            this.btnAddNumber.Text = "Add Number";
            this.btnAddNumber.UseVisualStyleBackColor = false;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // lblCountNames
            // 
            this.lblCountNames.AutoSize = true;
            this.lblCountNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblCountNames.Location = new System.Drawing.Point(26, 293);
            this.lblCountNames.Name = "lblCountNames";
            this.lblCountNames.Size = new System.Drawing.Size(166, 20);
            this.lblCountNames.TabIndex = 6;
            this.lblCountNames.Text = "Total count of names: ";
            // 
            // lblCountNumbers
            // 
            this.lblCountNumbers.AutoSize = true;
            this.lblCountNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblCountNumbers.Location = new System.Drawing.Point(320, 297);
            this.lblCountNumbers.Name = "lblCountNumbers";
            this.lblCountNumbers.Size = new System.Drawing.Size(180, 20);
            this.lblCountNumbers.TabIndex = 7;
            this.lblCountNumbers.Text = "Total count of numbers: ";
            // 
            // tbCountNames
            // 
            this.tbCountNames.BackColor = System.Drawing.Color.Azure;
            this.tbCountNames.Location = new System.Drawing.Point(208, 293);
            this.tbCountNames.Name = "tbCountNames";
            this.tbCountNames.Size = new System.Drawing.Size(51, 22);
            this.tbCountNames.TabIndex = 8;
            this.tbCountNames.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCountNumbers
            // 
            this.tbCountNumbers.BackColor = System.Drawing.Color.Azure;
            this.tbCountNumbers.Location = new System.Drawing.Point(508, 297);
            this.tbCountNumbers.Name = "tbCountNumbers";
            this.tbCountNumbers.Size = new System.Drawing.Size(45, 22);
            this.tbCountNumbers.TabIndex = 9;
            this.tbCountNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbCollection
            // 
            this.lbCollection.BackColor = System.Drawing.Color.SeaShell;
            this.lbCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCollection.FormattingEnabled = true;
            this.lbCollection.ItemHeight = 22;
            this.lbCollection.Location = new System.Drawing.Point(30, 350);
            this.lbCollection.Name = "lbCollection";
            this.lbCollection.Size = new System.Drawing.Size(230, 202);
            this.lbCollection.TabIndex = 10;
            this.lbCollection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbCollection_KeyPress);
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.LightCyan;
            this.btnCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCount.Location = new System.Drawing.Point(354, 350);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(168, 35);
            this.btnCount.TabIndex = 11;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCyan;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(354, 403);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(168, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.LightCyan;
            this.btnClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearAll.Location = new System.Drawing.Point(354, 457);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(168, 35);
            this.btnClearAll.TabIndex = 13;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.LightCyan;
            this.btnSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Location = new System.Drawing.Point(354, 511);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(168, 35);
            this.btnSort.TabIndex = 14;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(479, 631);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 35);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCountList
            // 
            this.lblCountList.AutoSize = true;
            this.lblCountList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblCountList.Location = new System.Drawing.Point(25, 570);
            this.lblCountList.Name = "lblCountList";
            this.lblCountList.Size = new System.Drawing.Size(184, 20);
            this.lblCountList.TabIndex = 16;
            this.lblCountList.Text = "Total count of collection: ";
            // 
            // tbCountCollection
            // 
            this.tbCountCollection.BackColor = System.Drawing.Color.Azure;
            this.tbCountCollection.Location = new System.Drawing.Point(221, 570);
            this.tbCountCollection.Name = "tbCountCollection";
            this.tbCountCollection.Size = new System.Drawing.Size(38, 22);
            this.tbCountCollection.TabIndex = 17;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnter.Location = new System.Drawing.Point(26, 614);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(49, 20);
            this.lblEnter.TabIndex = 18;
            this.lblEnter.Text = "Enter";
            // 
            // tbEnter
            // 
            this.tbEnter.BackColor = System.Drawing.Color.Azure;
            this.tbEnter.Location = new System.Drawing.Point(81, 613);
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.Size = new System.Drawing.Size(177, 22);
            this.tbEnter.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(593, 677);
            this.Controls.Add(this.tbEnter);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.tbCountCollection);
            this.Controls.Add(this.lblCountList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.lbCollection);
            this.Controls.Add(this.tbCountNumbers);
            this.Controls.Add(this.tbCountNames);
            this.Controls.Add(this.lblCountNumbers);
            this.Controls.Add(this.lblCountNames);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.lbNames);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Item Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Label lblCountNames;
        private System.Windows.Forms.Label lblCountNumbers;
        private System.Windows.Forms.TextBox tbCountNames;
        private System.Windows.Forms.TextBox tbCountNumbers;
        private System.Windows.Forms.ListBox lbCollection;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCountList;
        private System.Windows.Forms.TextBox tbCountCollection;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox tbEnter;
    }
}

