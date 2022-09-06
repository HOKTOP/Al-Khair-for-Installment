namespace Al_Khair_for_Installment
{
    partial class addProduct
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
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceproduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeproduct = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.electric_machines = new System.Windows.Forms.RadioButton();
            this.mobile = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // nameProduct
            // 
            this.nameProduct.Cursor = System.Windows.Forms.Cursors.Cross;
            this.nameProduct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameProduct.Location = new System.Drawing.Point(33, 77);
            this.nameProduct.Multiline = true;
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(360, 46);
            this.nameProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(315, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المنتج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(312, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "سعر المنتج";
            // 
            // priceproduct
            // 
            this.priceproduct.Cursor = System.Windows.Forms.Cursors.Cross;
            this.priceproduct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceproduct.Location = new System.Drawing.Point(212, 140);
            this.priceproduct.Multiline = true;
            this.priceproduct.Name = "priceproduct";
            this.priceproduct.Size = new System.Drawing.Size(181, 45);
            this.priceproduct.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(156, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "الكمية";
            // 
            // sizeproduct
            // 
            this.sizeproduct.Cursor = System.Windows.Forms.Cursors.Cross;
            this.sizeproduct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeproduct.Location = new System.Drawing.Point(33, 140);
            this.sizeproduct.Multiline = true;
            this.sizeproduct.Name = "sizeproduct";
            this.sizeproduct.Size = new System.Drawing.Size(173, 45);
            this.sizeproduct.TabIndex = 4;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.ForestGreen;
            this.add.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add.Location = new System.Drawing.Point(212, 253);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(181, 86);
            this.add.TabIndex = 6;
            this.add.Text = "اضافة";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.Location = new System.Drawing.Point(31, 253);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(173, 86);
            this.exit.TabIndex = 7;
            this.exit.Text = "الغاء";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // electric_machines
            // 
            this.electric_machines.AutoSize = true;
            this.electric_machines.Location = new System.Drawing.Point(81, 203);
            this.electric_machines.Name = "electric_machines";
            this.electric_machines.Size = new System.Drawing.Size(92, 19);
            this.electric_machines.TabIndex = 8;
            this.electric_machines.TabStop = true;
            this.electric_machines.Text = "اجهزة كهربائية";
            this.electric_machines.UseVisualStyleBackColor = true;
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Location = new System.Drawing.Point(262, 203);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(89, 19);
            this.mobile.TabIndex = 9;
            this.mobile.TabStop = true;
            this.mobile.Text = "اجهزة محمول";
            this.mobile.UseVisualStyleBackColor = true;
            this.mobile.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(412, 367);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.electric_machines);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sizeproduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceproduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameProduct);
            this.Name = "addProduct";
            this.Text = "addProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceproduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sizeproduct;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RadioButton electric_machines;
        private System.Windows.Forms.RadioButton mobile;
    }
}