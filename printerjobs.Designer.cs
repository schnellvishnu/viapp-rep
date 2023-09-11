namespace responsive_app
{
    partial class printerjobs
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
            this.Print = new System.Windows.Forms.TableLayoutPanel();
            this.txtpo = new System.Windows.Forms.TextBox();
            this.txtgtin = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtlot = new System.Windows.Forms.TextBox();
            this.txtexp = new System.Windows.Forms.TextBox();
            this.hrfkey = new System.Windows.Forms.TextBox();
            this.productionorder = new System.Windows.Forms.Label();
            this.serialnumber = new System.Windows.Forms.Label();
            this.gtin = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.lot = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hrf = new System.Windows.Forms.Label();
            this.slnolist = new System.Windows.Forms.ListBox();
            this.hrfvalue = new System.Windows.Forms.TextBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.txtresponseprinter = new System.Windows.Forms.TextBox();
            this.Print.SuspendLayout();
            this.SuspendLayout();
            // 
            // Print
            // 
            this.Print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Print.ColumnCount = 3;
            this.Print.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Print.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Print.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.Print.Controls.Add(this.txtpo, 1, 0);
            this.Print.Controls.Add(this.txtgtin, 1, 2);
            this.Print.Controls.Add(this.txttype, 1, 3);
            this.Print.Controls.Add(this.txtlot, 1, 4);
            this.Print.Controls.Add(this.txtexp, 1, 5);
            this.Print.Controls.Add(this.hrfkey, 1, 6);
            this.Print.Controls.Add(this.productionorder, 0, 0);
            this.Print.Controls.Add(this.serialnumber, 0, 1);
            this.Print.Controls.Add(this.gtin, 0, 2);
            this.Print.Controls.Add(this.type, 0, 3);
            this.Print.Controls.Add(this.lot, 0, 4);
            this.Print.Controls.Add(this.label6, 0, 5);
            this.Print.Controls.Add(this.hrf, 0, 6);
            this.Print.Controls.Add(this.slnolist, 1, 1);
            this.Print.Controls.Add(this.hrfvalue, 2, 6);
            this.Print.Controls.Add(this.btnprint, 1, 7);
            this.Print.Controls.Add(this.txtresponseprinter, 2, 7);
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(53, 12);
            this.Print.Name = "Print";
            this.Print.RowCount = 8;
            this.Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.42384F));
            this.Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.57616F));
            this.Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.Print.Size = new System.Drawing.Size(932, 518);
            this.Print.TabIndex = 0;
            // 
            // txtpo
            // 
            this.txtpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpo.Location = new System.Drawing.Point(381, 14);
            this.txtpo.Name = "txtpo";
            this.txtpo.Size = new System.Drawing.Size(261, 26);
            this.txtpo.TabIndex = 0;
            this.txtpo.TextChanged += new System.EventHandler(this.txtpo_TextChanged);
            // 
            // txtgtin
            // 
            this.txtgtin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgtin.Location = new System.Drawing.Point(380, 164);
            this.txtgtin.Name = "txtgtin";
            this.txtgtin.Size = new System.Drawing.Size(263, 26);
            this.txtgtin.TabIndex = 2;
            // 
            // txttype
            // 
            this.txttype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttype.Location = new System.Drawing.Point(380, 217);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(263, 26);
            this.txttype.TabIndex = 3;
            // 
            // txtlot
            // 
            this.txtlot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtlot.Location = new System.Drawing.Point(379, 274);
            this.txtlot.Name = "txtlot";
            this.txtlot.Size = new System.Drawing.Size(265, 26);
            this.txtlot.TabIndex = 4;
            // 
            // txtexp
            // 
            this.txtexp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtexp.Location = new System.Drawing.Point(377, 336);
            this.txtexp.Name = "txtexp";
            this.txtexp.Size = new System.Drawing.Size(268, 26);
            this.txtexp.TabIndex = 5;
            // 
            // hrfkey
            // 
            this.hrfkey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hrfkey.Location = new System.Drawing.Point(377, 399);
            this.hrfkey.Name = "hrfkey";
            this.hrfkey.Size = new System.Drawing.Size(269, 26);
            this.hrfkey.TabIndex = 6;
            // 
            // productionorder
            // 
            this.productionorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productionorder.AutoSize = true;
            this.productionorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionorder.Location = new System.Drawing.Point(79, 17);
            this.productionorder.Name = "productionorder";
            this.productionorder.Size = new System.Drawing.Size(182, 20);
            this.productionorder.TabIndex = 7;
            this.productionorder.Text = "Productionorder Number";
            // 
            // serialnumber
            // 
            this.serialnumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serialnumber.AutoSize = true;
            this.serialnumber.Location = new System.Drawing.Point(115, 93);
            this.serialnumber.Name = "serialnumber";
            this.serialnumber.Size = new System.Drawing.Size(111, 20);
            this.serialnumber.TabIndex = 8;
            this.serialnumber.Text = "Serialnumbers";
            // 
            // gtin
            // 
            this.gtin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gtin.AutoSize = true;
            this.gtin.Location = new System.Drawing.Point(151, 167);
            this.gtin.Name = "gtin";
            this.gtin.Size = new System.Drawing.Size(39, 20);
            this.gtin.TabIndex = 9;
            this.gtin.Text = "Gtin";
            // 
            // type
            // 
            this.type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(120, 220);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 20);
            this.type.TabIndex = 10;
            this.type.Text = "Printing Type";
            // 
            // lot
            // 
            this.lot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lot.AutoSize = true;
            this.lot.Location = new System.Drawing.Point(124, 277);
            this.lot.Name = "lot";
            this.lot.Size = new System.Drawing.Size(92, 20);
            this.lot.TabIndex = 11;
            this.lot.Text = "Lot Number";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Expiry Date";
            // 
            // hrf
            // 
            this.hrf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hrf.AutoSize = true;
            this.hrf.Location = new System.Drawing.Point(155, 402);
            this.hrf.Name = "hrf";
            this.hrf.Size = new System.Drawing.Size(31, 20);
            this.hrf.TabIndex = 13;
            this.hrf.Text = "Hrf";
            // 
            // slnolist
            // 
            this.slnolist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slnolist.FormattingEnabled = true;
            this.slnolist.ItemHeight = 20;
            this.slnolist.Location = new System.Drawing.Point(380, 61);
            this.slnolist.Name = "slnolist";
            this.slnolist.Size = new System.Drawing.Size(262, 84);
            this.slnolist.TabIndex = 14;
            // 
            // hrfvalue
            // 
            this.hrfvalue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hrfvalue.Location = new System.Drawing.Point(704, 399);
            this.hrfvalue.Name = "hrfvalue";
            this.hrfvalue.Size = new System.Drawing.Size(205, 26);
            this.hrfvalue.TabIndex = 15;
            // 
            // btnprint
            // 
            this.btnprint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(429, 452);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(165, 57);
            this.btnprint.TabIndex = 16;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // txtresponseprinter
            // 
            this.txtresponseprinter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtresponseprinter.Location = new System.Drawing.Point(708, 467);
            this.txtresponseprinter.Name = "txtresponseprinter";
            this.txtresponseprinter.Size = new System.Drawing.Size(198, 26);
            this.txtresponseprinter.TabIndex = 17;
            // 
            // printerjobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::responsive_app.Properties.Resources._240_F;
            this.ClientSize = new System.Drawing.Size(997, 565);
            this.Controls.Add(this.Print);
            this.Name = "printerjobs";
            this.Text = "printerjobs";
            this.Load += new System.EventHandler(this.printerjobs_Load);
            this.Print.ResumeLayout(false);
            this.Print.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Print;
        private System.Windows.Forms.TextBox txtpo;
        private System.Windows.Forms.TextBox txtgtin;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtlot;
        private System.Windows.Forms.TextBox txtexp;
        private System.Windows.Forms.TextBox hrfkey;
        private System.Windows.Forms.Label productionorder;
        private System.Windows.Forms.Label serialnumber;
        private System.Windows.Forms.Label gtin;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label lot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hrf;
        private System.Windows.Forms.ListBox slnolist;
        private System.Windows.Forms.TextBox hrfvalue;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.TextBox txtresponseprinter;
    }
}