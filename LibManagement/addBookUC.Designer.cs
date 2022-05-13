
namespace LibManagement
{
    partial class addBookUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbt_bookTitle = new System.Windows.Forms.TextBox();
            this.tbt_bookAuthor = new System.Windows.Forms.TextBox();
            this.tbt_bookDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbt_publishedYear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbt_bookTitle
            // 
            this.tbt_bookTitle.Location = new System.Drawing.Point(206, 32);
            this.tbt_bookTitle.Name = "tbt_bookTitle";
            this.tbt_bookTitle.Size = new System.Drawing.Size(396, 20);
            this.tbt_bookTitle.TabIndex = 0;
            // 
            // tbt_bookAuthor
            // 
            this.tbt_bookAuthor.Location = new System.Drawing.Point(206, 98);
            this.tbt_bookAuthor.Name = "tbt_bookAuthor";
            this.tbt_bookAuthor.Size = new System.Drawing.Size(396, 20);
            this.tbt_bookAuthor.TabIndex = 1;
            // 
            // tbt_bookDetails
            // 
            this.tbt_bookDetails.Location = new System.Drawing.Point(206, 168);
            this.tbt_bookDetails.Multiline = true;
            this.tbt_bookDetails.Name = "tbt_bookDetails";
            this.tbt_bookDetails.Size = new System.Drawing.Size(396, 64);
            this.tbt_bookDetails.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Book Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Published Year";
            // 
            // tbt_publishedYear
            // 
            this.tbt_publishedYear.Location = new System.Drawing.Point(206, 264);
            this.tbt_publishedYear.Name = "tbt_publishedYear";
            this.tbt_publishedYear.Size = new System.Drawing.Size(103, 20);
            this.tbt_publishedYear.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancecl";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addBookUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbt_publishedYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbt_bookDetails);
            this.Controls.Add(this.tbt_bookAuthor);
            this.Controls.Add(this.tbt_bookTitle);
            this.Name = "addBookUC";
            this.Size = new System.Drawing.Size(641, 525);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbt_bookTitle;
        private System.Windows.Forms.TextBox tbt_bookAuthor;
        private System.Windows.Forms.TextBox tbt_bookDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbt_publishedYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
