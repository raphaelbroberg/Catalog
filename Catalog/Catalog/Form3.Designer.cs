
namespace Catalog
{
    partial class del
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Delete data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDel
            // 
            this.txtDel.Location = new System.Drawing.Point(386, 161);
            this.txtDel.Name = "txtDel";
            this.txtDel.Size = new System.Drawing.Size(183, 22);
            this.txtDel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDel);
            this.Controls.Add(this.label2);
            this.Name = "del";
            this.Text = "del";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDel;
        private System.Windows.Forms.Label label2;
    }
}