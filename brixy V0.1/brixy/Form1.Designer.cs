namespace brixy
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
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSkipUp = new System.Windows.Forms.Button();
            this.buttonSkipRight = new System.Windows.Forms.Button();
            this.buttonSkipDown = new System.Windows.Forms.Button();
            this.buttonSkipLeft = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUp.Location = new System.Drawing.Point(444, 101);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(60, 60);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "^";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMovement_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLeft.Location = new System.Drawing.Point(378, 167);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(60, 60);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMovement_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDown.Location = new System.Drawing.Point(444, 233);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(60, 60);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.Text = "v";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMovement_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRight.Location = new System.Drawing.Point(510, 167);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(60, 60);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMovement_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(444, 167);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(60, 60);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonMovement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Turn: Player 1";
            // 
            // buttonSkipUp
            // 
            this.buttonSkipUp.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSkipUp.Location = new System.Drawing.Point(454, 55);
            this.buttonSkipUp.Name = "buttonSkipUp";
            this.buttonSkipUp.Size = new System.Drawing.Size(40, 40);
            this.buttonSkipUp.TabIndex = 6;
            this.buttonSkipUp.Text = "^";
            this.buttonSkipUp.UseVisualStyleBackColor = true;
            this.buttonSkipUp.Visible = false;
            this.buttonSkipUp.Click += new System.EventHandler(this.buttonMovement_Click);
            // 
            // buttonSkipRight
            // 
            this.buttonSkipRight.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSkipRight.Location = new System.Drawing.Point(576, 177);
            this.buttonSkipRight.Name = "buttonSkipRight";
            this.buttonSkipRight.Size = new System.Drawing.Size(40, 40);
            this.buttonSkipRight.TabIndex = 7;
            this.buttonSkipRight.Text = ">";
            this.buttonSkipRight.UseVisualStyleBackColor = true;
            this.buttonSkipRight.Visible = false;
            this.buttonSkipRight.Click += new System.EventHandler(this.buttonMovement_Click);
            // 
            // buttonSkipDown
            // 
            this.buttonSkipDown.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSkipDown.Location = new System.Drawing.Point(454, 299);
            this.buttonSkipDown.Name = "buttonSkipDown";
            this.buttonSkipDown.Size = new System.Drawing.Size(40, 40);
            this.buttonSkipDown.TabIndex = 8;
            this.buttonSkipDown.Text = "v";
            this.buttonSkipDown.UseVisualStyleBackColor = true;
            this.buttonSkipDown.Visible = false;
            this.buttonSkipDown.Click += new System.EventHandler(this.buttonMovement_Click);
            // 
            // buttonSkipLeft
            // 
            this.buttonSkipLeft.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSkipLeft.Location = new System.Drawing.Point(332, 177);
            this.buttonSkipLeft.Name = "buttonSkipLeft";
            this.buttonSkipLeft.Size = new System.Drawing.Size(40, 40);
            this.buttonSkipLeft.TabIndex = 9;
            this.buttonSkipLeft.Text = "<";
            this.buttonSkipLeft.UseVisualStyleBackColor = true;
            this.buttonSkipLeft.Visible = false;
            this.buttonSkipLeft.Click += new System.EventHandler(this.buttonMovement_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 23);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 355);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSkipLeft);
            this.Controls.Add(this.buttonSkipDown);
            this.Controls.Add(this.buttonSkipRight);
            this.Controls.Add(this.buttonSkipUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += Form1_KeyPress;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonUp;
        private Button buttonLeft;
        private Button buttonDown;
        private Button buttonRight;
        private Button buttonAdd;
        private Label label1;
        private Button buttonSkipUp;
        private Button buttonSkipRight;
        private Button buttonSkipDown;
        private Button buttonSkipLeft;
        private TextBox textBox1;
    }
}