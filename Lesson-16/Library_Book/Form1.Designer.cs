namespace Library_Book
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
            this.cmb_FilterGenre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Genre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Book = new System.Windows.Forms.ListBox();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.txb_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_FilterGenre
            // 
            this.cmb_FilterGenre.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_FilterGenre.FormattingEnabled = true;
            this.cmb_FilterGenre.Location = new System.Drawing.Point(101, 258);
            this.cmb_FilterGenre.Name = "cmb_FilterGenre";
            this.cmb_FilterGenre.Size = new System.Drawing.Size(184, 31);
            this.cmb_FilterGenre.TabIndex = 23;
            this.cmb_FilterGenre.SelectedIndexChanged += new System.EventHandler(this.cmb_FilterGenre_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(97, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Filter by genre";
            // 
            // cmb_Genre
            // 
            this.cmb_Genre.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Genre.FormattingEnabled = true;
            this.cmb_Genre.Location = new System.Drawing.Point(660, 56);
            this.cmb_Genre.Name = "cmb_Genre";
            this.cmb_Genre.Size = new System.Drawing.Size(184, 31);
            this.cmb_Genre.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(656, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Genre";
            // 
            // lb_Book
            // 
            this.lb_Book.FormattingEnabled = true;
            this.lb_Book.Location = new System.Drawing.Point(101, 295);
            this.lb_Book.Name = "lb_Book";
            this.lb_Book.Size = new System.Drawing.Size(619, 277);
            this.lb_Book.TabIndex = 21;
            // 
            // btn_addBook
            // 
            this.btn_addBook.BackColor = System.Drawing.Color.Gold;
            this.btn_addBook.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addBook.Location = new System.Drawing.Point(101, 133);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(619, 44);
            this.btn_addBook.TabIndex = 20;
            this.btn_addBook.Text = "Add Book";
            this.btn_addBook.UseVisualStyleBackColor = false;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // txb_price
            // 
            this.txb_price.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_price.Location = new System.Drawing.Point(442, 55);
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(183, 32);
            this.txb_price.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(438, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Price";
            // 
            // txb_number
            // 
            this.txb_number.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_number.Location = new System.Drawing.Point(221, 55);
            this.txb_number.Name = "txb_number";
            this.txb_number.Size = new System.Drawing.Size(183, 32);
            this.txb_number.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(217, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "ISBN number";
            // 
            // txb_name
            // 
            this.txb_name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_name.Location = new System.Drawing.Point(6, 55);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(183, 32);
            this.txb_name.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Book name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 535);
            this.Controls.Add(this.cmb_FilterGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Genre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_Book);
            this.Controls.Add(this.btn_addBook);
            this.Controls.Add(this.txb_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_FilterGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Genre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_Book;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.TextBox txb_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label1;
    }
}

