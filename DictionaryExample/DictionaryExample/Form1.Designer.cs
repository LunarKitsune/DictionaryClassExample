namespace DictionaryExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.rtbNameDisplay = new System.Windows.Forms.RichTextBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.btnDisplayNames = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Names:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(76, 10);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(76, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(76, 49);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(76, 20);
            this.txtGrade.TabIndex = 4;
            // 
            // rtbNameDisplay
            // 
            this.rtbNameDisplay.Location = new System.Drawing.Point(174, 49);
            this.rtbNameDisplay.Name = "rtbNameDisplay";
            this.rtbNameDisplay.Size = new System.Drawing.Size(139, 137);
            this.rtbNameDisplay.TabIndex = 5;
            this.rtbNameDisplay.Text = "";
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(12, 90);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(75, 23);
            this.btnAddName.TabIndex = 6;
            this.btnAddName.Text = "Add";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btn_AddName);
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.Location = new System.Drawing.Point(93, 90);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveName.TabIndex = 7;
            this.btnRemoveName.Text = "Remove";
            this.btnRemoveName.UseVisualStyleBackColor = true;
            this.btnRemoveName.Click += new System.EventHandler(this.btn_DeleteName);
            // 
            // btnDisplayNames
            // 
            this.btnDisplayNames.Location = new System.Drawing.Point(12, 119);
            this.btnDisplayNames.Name = "btnDisplayNames";
            this.btnDisplayNames.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayNames.TabIndex = 8;
            this.btnDisplayNames.Text = "Display";
            this.btnDisplayNames.UseVisualStyleBackColor = true;
            this.btnDisplayNames.Click += new System.EventHandler(this.btn_DisplayNames);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(93, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Btn_Exit);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(93, 117);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 207);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayNames);
            this.Controls.Add(this.btnRemoveName);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.rtbNameDisplay);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.RichTextBox rtbNameDisplay;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Button btnDisplayNames;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFind;
    }
}

