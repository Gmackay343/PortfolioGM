namespace MackayLab8
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.cboNames = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btn2ndCard = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpProducts = new System.Windows.Forms.GroupBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.grpLogin.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.grpCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.cboNames);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Location = new System.Drawing.Point(13, 13);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(213, 90);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // cboNames
            // 
            this.cboNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNames.FormattingEnabled = true;
            this.cboNames.Location = new System.Drawing.Point(74, 23);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(121, 21);
            this.cboNames.Sorted = true;
            this.cboNames.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(74, 56);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(61, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name:";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.lblLastName);
            this.grpCustomer.Controls.Add(this.btnCheckout);
            this.grpCustomer.Controls.Add(this.btn2ndCard);
            this.grpCustomer.Controls.Add(this.lblFirstName);
            this.grpCustomer.Controls.Add(this.lblID);
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Controls.Add(this.label2);
            this.grpCustomer.Location = new System.Drawing.Point(13, 109);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(213, 122);
            this.grpCustomer.TabIndex = 1;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // lblLastName
            // 
            this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastName.Location = new System.Drawing.Point(111, 43);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 22);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckout
            // 
            this.btnCheckout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCheckout.Location = new System.Drawing.Point(105, 86);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "&Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btn2ndCard
            // 
            this.btn2ndCard.Location = new System.Drawing.Point(13, 86);
            this.btn2ndCard.Name = "btn2ndCard";
            this.btn2ndCard.Size = new System.Drawing.Size(75, 23);
            this.btn2ndCard.TabIndex = 4;
            this.btn2ndCard.Text = "&2nd Card";
            this.btn2ndCard.UseVisualStyleBackColor = true;
            this.btn2ndCard.Click += new System.EventHandler(this.btn2ndCard_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstName.Location = new System.Drawing.Point(53, 44);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(52, 22);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblID.Location = new System.Drawing.Point(53, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 23);
            this.lblID.TabIndex = 2;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // grpProducts
            // 
            this.grpProducts.Controls.Add(this.btnCompare);
            this.grpProducts.Controls.Add(this.cboProducts);
            this.grpProducts.Controls.Add(this.btnAddToCart);
            this.grpProducts.Controls.Add(this.nudNumber);
            this.grpProducts.Location = new System.Drawing.Point(232, 13);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Size = new System.Drawing.Size(184, 218);
            this.grpProducts.TabIndex = 2;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "Products";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(49, 186);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Com&pare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // cboProducts
            // 
            this.cboProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducts.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(7, 17);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(164, 24);
            this.cboProducts.TabIndex = 2;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(78, 157);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(93, 23);
            this.btnAddToCart.TabIndex = 1;
            this.btnAddToCart.Text = "&Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(6, 157);
            this.nudNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(66, 20);
            this.nudNumber.TabIndex = 0;
            this.nudNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.label8);
            this.grpCart.Controls.Add(this.label7);
            this.grpCart.Controls.Add(this.label6);
            this.grpCart.Controls.Add(this.label5);
            this.grpCart.Controls.Add(this.label4);
            this.grpCart.Controls.Add(this.lstCart);
            this.grpCart.Location = new System.Drawing.Point(15, 237);
            this.grpCart.Name = "grpCart";
            this.grpCart.Size = new System.Drawing.Size(401, 147);
            this.grpCart.TabIndex = 9;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Cart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Code";
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 16;
            this.lstCart.Location = new System.Drawing.Point(6, 37);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(389, 84);
            this.lstCart.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCheckout;
            this.ClientSize = new System.Drawing.Size(438, 396);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.grpProducts);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping by Graeme Mackay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.grpCart.ResumeLayout(false);
            this.grpCart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpProducts;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btn2ndCard;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.ComboBox cboNames;
    }
}

