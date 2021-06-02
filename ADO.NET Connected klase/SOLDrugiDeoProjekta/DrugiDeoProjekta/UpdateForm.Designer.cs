
namespace DrugiDeoProjekta
{
    partial class UpdateForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtZemlja = new System.Windows.Forms.TextBox();
            this.lblZemlja = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.lblGrad = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtKlijentID = new System.Windows.Forms.TextBox();
            this.lblKlijentID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(259, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 50);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(79, 255);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 50);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtZemlja
            // 
            this.txtZemlja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZemlja.Location = new System.Drawing.Point(150, 199);
            this.txtZemlja.MaxLength = 15;
            this.txtZemlja.Name = "txtZemlja";
            this.txtZemlja.Size = new System.Drawing.Size(153, 24);
            this.txtZemlja.TabIndex = 17;
            // 
            // lblZemlja
            // 
            this.lblZemlja.AutoSize = true;
            this.lblZemlja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZemlja.Location = new System.Drawing.Point(81, 202);
            this.lblZemlja.Name = "lblZemlja";
            this.lblZemlja.Size = new System.Drawing.Size(56, 18);
            this.lblZemlja.TabIndex = 16;
            this.lblZemlja.Text = "Zemlja:";
            // 
            // txtGrad
            // 
            this.txtGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrad.Location = new System.Drawing.Point(150, 147);
            this.txtGrad.MaxLength = 15;
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(153, 24);
            this.txtGrad.TabIndex = 15;
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrad.Location = new System.Drawing.Point(81, 150);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(45, 18);
            this.lblGrad.TabIndex = 14;
            this.lblGrad.Text = "Grad:";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontakt.Location = new System.Drawing.Point(150, 100);
            this.txtKontakt.MaxLength = 30;
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(153, 24);
            this.txtKontakt.TabIndex = 13;
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontakt.Location = new System.Drawing.Point(81, 103);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(63, 18);
            this.lblKontakt.TabIndex = 12;
            this.lblKontakt.Text = "Kontakt:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(150, 57);
            this.txtNaziv.MaxLength = 40;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(153, 24);
            this.txtNaziv.TabIndex = 11;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(81, 60);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(49, 18);
            this.lblNaziv.TabIndex = 10;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtKlijentID
            // 
            this.txtKlijentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKlijentID.Location = new System.Drawing.Point(79, 12);
            this.txtKlijentID.MaxLength = 40;
            this.txtKlijentID.Name = "txtKlijentID";
            this.txtKlijentID.Size = new System.Drawing.Size(47, 24);
            this.txtKlijentID.TabIndex = 21;
            // 
            // lblKlijentID
            // 
            this.lblKlijentID.AutoSize = true;
            this.lblKlijentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlijentID.Location = new System.Drawing.Point(11, 15);
            this.lblKlijentID.Name = "lblKlijentID";
            this.lblKlijentID.Size = new System.Drawing.Size(65, 18);
            this.lblKlijentID.TabIndex = 20;
            this.lblKlijentID.Text = "KlijentID:";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 317);
            this.Controls.Add(this.txtKlijentID);
            this.Controls.Add(this.lblKlijentID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtZemlja);
            this.Controls.Add(this.lblZemlja);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.lblKontakt);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtZemlja;
        private System.Windows.Forms.Label lblZemlja;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtKlijentID;
        private System.Windows.Forms.Label lblKlijentID;
    }
}