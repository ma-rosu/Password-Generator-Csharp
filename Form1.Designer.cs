namespace PasswordMaker
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.checkSpecial = new System.Windows.Forms.CheckBox();
            this.checkLet = new System.Windows.Forms.CheckBox();
            this.checkNum = new System.Windows.Forms.CheckBox();
            this.lenPassSet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lenPassSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(129, 232);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(339, 32);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(129, 194);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(339, 32);
            this.btnGen.TabIndex = 7;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.BtnGen_Click);
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(129, 48);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(339, 22);
            this.inputPassword.TabIndex = 1;
            // 
            // checkSpecial
            // 
            this.checkSpecial.AutoSize = true;
            this.checkSpecial.Location = new System.Drawing.Point(236, 110);
            this.checkSpecial.Name = "checkSpecial";
            this.checkSpecial.Size = new System.Drawing.Size(143, 20);
            this.checkSpecial.TabIndex = 4;
            this.checkSpecial.Text = "Special Characters";
            this.checkSpecial.UseVisualStyleBackColor = true;
            // 
            // checkLet
            // 
            this.checkLet.AutoSize = true;
            this.checkLet.Location = new System.Drawing.Point(236, 136);
            this.checkLet.Name = "checkLet";
            this.checkLet.Size = new System.Drawing.Size(69, 20);
            this.checkLet.TabIndex = 5;
            this.checkLet.Text = "Letters";
            this.checkLet.UseVisualStyleBackColor = true;
            // 
            // checkNum
            // 
            this.checkNum.AutoSize = true;
            this.checkNum.Location = new System.Drawing.Point(236, 162);
            this.checkNum.Name = "checkNum";
            this.checkNum.Size = new System.Drawing.Size(84, 20);
            this.checkNum.TabIndex = 6;
            this.checkNum.Text = "Numbers";
            this.checkNum.UseVisualStyleBackColor = true;
            // 
            // lenPassSet
            // 
            this.lenPassSet.Location = new System.Drawing.Point(236, 82);
            this.lenPassSet.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.lenPassSet.Name = "lenPassSet";
            this.lenPassSet.Size = new System.Drawing.Size(45, 22);
            this.lenPassSet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Length";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(129, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(339, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Generated Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 363);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lenPassSet);
            this.Controls.Add(this.checkNum);
            this.Controls.Add(this.checkLet);
            this.Controls.Add(this.checkSpecial);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.lenPassSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.CheckBox checkSpecial;
        private System.Windows.Forms.CheckBox checkLet;
        private System.Windows.Forms.CheckBox checkNum;
        private System.Windows.Forms.NumericUpDown lenPassSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
    }
}

