namespace part_3b___basic_input
{
    partial class frmlife
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
            this.txtboxheight = new System.Windows.Forms.TextBox();
            this.txtboxname = new System.Windows.Forms.TextBox();
            this.txtboxage = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.lblheight = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxheight
            // 
            this.txtboxheight.Location = new System.Drawing.Point(12, 12);
            this.txtboxheight.Name = "txtboxheight";
            this.txtboxheight.Size = new System.Drawing.Size(100, 20);
            this.txtboxheight.TabIndex = 0;
            this.txtboxheight.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtboxname
            // 
            this.txtboxname.Location = new System.Drawing.Point(12, 38);
            this.txtboxname.Name = "txtboxname";
            this.txtboxname.Size = new System.Drawing.Size(100, 20);
            this.txtboxname.TabIndex = 1;
            // 
            // txtboxage
            // 
            this.txtboxage.Location = new System.Drawing.Point(12, 64);
            this.txtboxage.Name = "txtboxage";
            this.txtboxage.Size = new System.Drawing.Size(100, 20);
            this.txtboxage.TabIndex = 2;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(118, 67);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(113, 13);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "Please enter your age.";
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Location = new System.Drawing.Point(118, 15);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(169, 13);
            this.lblheight.TabIndex = 4;
            this.lblheight.Text = "Please enter your height in metres.";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(118, 41);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(140, 13);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Please enter your first name.";
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(118, 96);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(50, 13);
            this.lblmessage.TabIndex = 6;
            this.lblmessage.Text = "Message";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(12, 91);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.Text = "Submit!";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmlife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 123);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblheight);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.txtboxage);
            this.Controls.Add(this.txtboxname);
            this.Controls.Add(this.txtboxheight);
            this.Name = "frmlife";
            this.Text = "Average Life Expectancy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxheight;
        private System.Windows.Forms.TextBox txtboxname;
        private System.Windows.Forms.TextBox txtboxage;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btnsubmit;
    }
}

