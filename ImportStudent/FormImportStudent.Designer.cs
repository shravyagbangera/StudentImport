using System;

namespace ImportStudent
{
    partial class FormImportStudent
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
            this.DG1 = new System.Windows.Forms.DataGridView();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).BeginInit();
            this.SuspendLayout();
            // 
            // DG1
            // 
            this.DG1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG1.Location = new System.Drawing.Point(-4, 103);
            this.DG1.Margin = new System.Windows.Forms.Padding(4);
            this.DG1.Name = "DG1";
            this.DG1.RowHeadersWidth = 62;
            this.DG1.RowTemplate.Height = 28;
            this.DG1.Size = new System.Drawing.Size(1727, 429);
            this.DG1.TabIndex = 0;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Green;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(470, 555);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(168, 45);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.BackColor = System.Drawing.Color.RosyBrown;
            this.button_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Load.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Load.Location = new System.Drawing.Point(274, 30);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(175, 53);
            this.button_Load.TabIndex = 3;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = false;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(519, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(843, 44);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.Text_Select);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(863, 555);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(149, 45);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "CLOSE";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // FormImportStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1724, 612);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.DG1);
            this.Name = "FormImportStudent";
            this.Text = "LIST";
            this.Load += new System.EventHandler(this.FormImportStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        







        #endregion

        private System.Windows.Forms.DataGridView DG1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Close;
    }
}

