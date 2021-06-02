
namespace DrugiDeoProjekta
{
    partial class Insert
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.lblGrad = new System.Windows.Forms.Label();
            this.txtZemlja = new System.Windows.Forms.TextBox();
            this.lblZemlja = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(13, 25);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(49, 18);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(82, 22);
            this.txtNaziv.MaxLength = 40;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(153, 24);
            this.txtNaziv.TabIndex = 1;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontakt.Location = new System.Drawing.Point(82, 65);
            this.txtKontakt.MaxLength = 30;
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(153, 24);
            this.txtKontakt.TabIndex = 3;
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontakt.Location = new System.Drawing.Point(13, 68);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(63, 18);
            this.lblKontakt.TabIndex = 2;
            this.lblKontakt.Text = "Kontakt:";
            // 
            // txtGrad
            // 
            this.txtGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrad.Location = new System.Drawing.Point(82, 112);
            this.txtGrad.MaxLength = 15;
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(153, 24);
            this.txtGrad.TabIndex = 5;
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrad.Location = new System.Drawing.Point(13, 115);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(45, 18);
            this.lblGrad.TabIndex = 4;
            this.lblGrad.Text = "Grad:";
            // 
            // txtZemlja
            // 
            this.txtZemlja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZemlja.Location = new System.Drawing.Point(82, 164);
            this.txtZemlja.MaxLength = 15;
            this.txtZemlja.Name = "txtZemlja";
            this.txtZemlja.Size = new System.Drawing.Size(153, 24);
            this.txtZemlja.TabIndex = 7;
            // 
            // lblZemlja
            // 
            this.lblZemlja.AutoSize = true;
            this.lblZemlja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZemlja.Location = new System.Drawing.Point(13, 167);
            this.lblZemlja.Name = "lblZemlja";
            this.lblZemlja.Size = new System.Drawing.Size(56, 18);
            this.lblZemlja.TabIndex = 6;
            this.lblZemlja.Text = "Zemlja:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(91, 256);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(153, 50);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 50);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 318);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtZemlja);
            this.Controls.Add(this.lblZemlja);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.lblKontakt);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Name = "Insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.TextBox txtZemlja;
        private System.Windows.Forms.Label lblZemlja;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
    }
}