namespace WindowsFormsAppUI
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
            this.components = new System.ComponentModel.Container();
            this.labelBook = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelIsbn = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelBorrower = new System.Windows.Forms.Label();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.booksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet3 = new WindowsFormsAppUI.LibraryDBDataSet3();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxIsbn = new System.Windows.Forms.ComboBox();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.comboBoxBorrower = new System.Windows.Forms.ComboBox();
            this.libraryDBDataSet1 = new WindowsFormsAppUI.LibraryDBDataSet1();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new WindowsFormsAppUI.LibraryDBDataSet1TableAdapters.BooksTableAdapter();
            this.libraryDBDataSet2 = new WindowsFormsAppUI.LibraryDBDataSet2();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter1 = new WindowsFormsAppUI.LibraryDBDataSet2TableAdapters.BooksTableAdapter();
            this.booksTableAdapter2 = new WindowsFormsAppUI.LibraryDBDataSet3TableAdapters.BooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBook.Location = new System.Drawing.Point(12, 78);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(146, 25);
            this.labelBook.TabIndex = 0;
            this.labelBook.Text = "Select a Book";
            this.labelBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(249, 78);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(173, 25);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Select an Author";
            this.labelAuthor.Click += new System.EventHandler(this.labelAuthor_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(504, 78);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(241, 25);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Select a Copyright Year";
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsbn.Location = new System.Drawing.Point(12, 232);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(129, 25);
            this.labelIsbn.TabIndex = 3;
            this.labelIsbn.Text = "Select ISBN";
            this.labelIsbn.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(249, 232);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(161, 25);
            this.labelLocation.TabIndex = 4;
            this.labelLocation.Text = "Select Location";
            // 
            // labelBorrower
            // 
            this.labelBorrower.AutoSize = true;
            this.labelBorrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrower.Location = new System.Drawing.Point(504, 232);
            this.labelBorrower.Name = "labelBorrower";
            this.labelBorrower.Size = new System.Drawing.Size(183, 25);
            this.labelBorrower.TabIndex = 5;
            this.labelBorrower.Text = "Select a Borrower";
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.DataSource = this.booksBindingSource2;
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(17, 106);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(153, 21);
            this.comboBoxBook.TabIndex = 6;
            this.comboBoxBook.SelectedIndexChanged += new System.EventHandler(this.comboBoxBook_SelectedIndexChanged);
            // 
            // booksBindingSource2
            // 
            this.booksBindingSource2.DataMember = "Books";
            this.booksBindingSource2.DataSource = this.libraryDBDataSet3;
            // 
            // libraryDBDataSet3
            // 
            this.libraryDBDataSet3.DataSetName = "LibraryDBDataSet3";
            this.libraryDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(254, 106);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(182, 21);
            this.comboBoxAuthor.TabIndex = 7;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(582, 106);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYear.TabIndex = 8;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // comboBoxIsbn
            // 
            this.comboBoxIsbn.FormattingEnabled = true;
            this.comboBoxIsbn.Location = new System.Drawing.Point(17, 260);
            this.comboBoxIsbn.Name = "comboBoxIsbn";
            this.comboBoxIsbn.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIsbn.TabIndex = 9;
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(254, 260);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocation.TabIndex = 10;
            // 
            // comboBoxBorrower
            // 
            this.comboBoxBorrower.FormattingEnabled = true;
            this.comboBoxBorrower.Location = new System.Drawing.Point(509, 260);
            this.comboBoxBorrower.Name = "comboBoxBorrower";
            this.comboBoxBorrower.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBorrower.TabIndex = 11;
            // 
            // libraryDBDataSet1
            // 
            this.libraryDBDataSet1.DataSetName = "LibraryDBDataSet1";
            this.libraryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDBDataSet1;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // libraryDBDataSet2
            // 
            this.libraryDBDataSet2.DataSetName = "LibraryDBDataSet2";
            this.libraryDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.libraryDBDataSet2;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // booksTableAdapter2
            // 
            this.booksTableAdapter2.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxBorrower);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.comboBoxIsbn);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.labelBorrower);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelIsbn);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelBook);
            this.Name = "Form1";
            this.Text = "Library Drop Down UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelBorrower;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxIsbn;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.ComboBox comboBoxBorrower;
        private LibraryDBDataSet1 libraryDBDataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDBDataSet1TableAdapters.BooksTableAdapter booksTableAdapter;
        private LibraryDBDataSet2 libraryDBDataSet2;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private LibraryDBDataSet2TableAdapters.BooksTableAdapter booksTableAdapter1;
        private LibraryDBDataSet3 libraryDBDataSet3;
        private System.Windows.Forms.BindingSource booksBindingSource2;
        private LibraryDBDataSet3TableAdapters.BooksTableAdapter booksTableAdapter2;
    }
}

