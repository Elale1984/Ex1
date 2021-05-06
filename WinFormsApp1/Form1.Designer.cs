
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_New = new System.Windows.Forms.CheckBox();
            this.tb_FN = new System.Windows.Forms.TextBox();
            this.tb_LN = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lb_Mess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(282, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lets Talk C#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(166, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(166, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // cb_New
            // 
            this.cb_New.AutoSize = true;
            this.cb_New.Location = new System.Drawing.Point(343, 234);
            this.cb_New.Name = "cb_New";
            this.cb_New.Size = new System.Drawing.Size(123, 29);
            this.cb_New.TabIndex = 3;
            this.cb_New.Text = "New To C#";
            this.cb_New.UseVisualStyleBackColor = true;
            // 
            // tb_FN
            // 
            this.tb_FN.Location = new System.Drawing.Point(316, 135);
            this.tb_FN.Name = "tb_FN";
            this.tb_FN.Size = new System.Drawing.Size(150, 31);
            this.tb_FN.TabIndex = 4;
            // 
            // tb_LN
            // 
            this.tb_LN.Location = new System.Drawing.Point(316, 183);
            this.tb_LN.Name = "tb_LN";
            this.tb_LN.Size = new System.Drawing.Size(150, 31);
            this.tb_LN.TabIndex = 5;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(354, 284);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(112, 34);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lb_Mess
            // 
            this.lb_Mess.AutoSize = true;
            this.lb_Mess.Location = new System.Drawing.Point(193, 348);
            this.lb_Mess.Name = "lb_Mess";
            this.lb_Mess.Size = new System.Drawing.Size(0, 25);
            this.lb_Mess.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 408);
            this.Controls.Add(this.lb_Mess);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_LN);
            this.Controls.Add(this.tb_FN);
            this.Controls.Add(this.cb_New);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_New;
        private System.Windows.Forms.TextBox tb_FN;
        private System.Windows.Forms.TextBox tb_LN;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lb_Mess;
    }
}

