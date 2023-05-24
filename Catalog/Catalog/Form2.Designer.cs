
namespace Catalog
{
    partial class save
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(355, 255);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 22);
            this.txtEmail.TabIndex = 22;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(355, 211);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(205, 22);
            this.txtNumber.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "First name";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(355, 169);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(205, 22);
            this.txtClass.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(355, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 22);
            this.txtName.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button2);
            this.Name = "save";
            this.Text = "save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button2;
    }
}