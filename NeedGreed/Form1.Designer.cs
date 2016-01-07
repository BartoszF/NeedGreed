namespace NGTest
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
            this.characters = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_char = new System.Windows.Forms.Button();
            this.cycle_butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.characters)).BeginInit();
            this.SuspendLayout();
            // 
            // characters
            // 
            this.characters.AllowUserToAddRows = false;
            this.characters.AllowUserToDeleteRows = false;
            this.characters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.characters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn});
            this.characters.Location = new System.Drawing.Point(13, 13);
            this.characters.Name = "characters";
            this.characters.ReadOnly = true;
            this.characters.Size = new System.Drawing.Size(653, 150);
            this.characters.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // add_char
            // 
            this.add_char.Location = new System.Drawing.Point(13, 170);
            this.add_char.Name = "add_char";
            this.add_char.Size = new System.Drawing.Size(93, 23);
            this.add_char.TabIndex = 1;
            this.add_char.Text = "Add Character";
            this.add_char.UseVisualStyleBackColor = true;
            this.add_char.Click += new System.EventHandler(this.add_char_Click);
            // 
            // cycle_butt
            // 
            this.cycle_butt.Location = new System.Drawing.Point(113, 170);
            this.cycle_butt.Name = "cycle_butt";
            this.cycle_butt.Size = new System.Drawing.Size(75, 23);
            this.cycle_butt.TabIndex = 2;
            this.cycle_butt.Text = "Cycle";
            this.cycle_butt.UseVisualStyleBackColor = true;
            this.cycle_butt.Click += new System.EventHandler(this.cycle_butt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 483);
            this.Controls.Add(this.cycle_butt);
            this.Controls.Add(this.add_char);
            this.Controls.Add(this.characters);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.characters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView characters;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.Button add_char;
        private System.Windows.Forms.Button cycle_butt;

    }
}

