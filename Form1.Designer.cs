namespace Approcimate_Pi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.CalculateBut = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.CloseBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter # of terms:";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(298, 55);
            this.userInput.Multiline = true;
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(280, 47);
            this.userInput.TabIndex = 1;
            // 
            // CalculateBut
            // 
            this.CalculateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CalculateBut.Location = new System.Drawing.Point(70, 127);
            this.CalculateBut.Name = "CalculateBut";
            this.CalculateBut.Size = new System.Drawing.Size(215, 114);
            this.CalculateBut.TabIndex = 0;
            this.CalculateBut.Text = "Calculate";
            this.CalculateBut.UseVisualStyleBackColor = true;
            this.CalculateBut.Click += new System.EventHandler(this.CalculateBut_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(45, 281);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(24, 33);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = " ";
            // 
            // CloseBut
            // 
            this.CloseBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBut.Location = new System.Drawing.Point(309, 127);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(223, 114);
            this.CloseBut.TabIndex = 3;
            this.CloseBut.Text = "Exit";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.CalculateBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBut;
            this.ClientSize = new System.Drawing.Size(616, 457);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.CalculateBut);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button CalculateBut;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button CloseBut;
    }
}

