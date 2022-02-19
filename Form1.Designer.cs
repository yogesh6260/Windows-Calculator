namespace Calculator
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
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.txtbox_Result = new System.Windows.Forms.TextBox();
            this.lblCurrent_Operation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(91, 99);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 45);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button_click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(142, 99);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 45);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button_click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(195, 99);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(45, 45);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.operator_click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(40, 99);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 45);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button_click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(246, 99);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(56, 45);
            this.btnCE.TabIndex = 5;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(246, 150);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(56, 45);
            this.btnC.TabIndex = 10;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(40, 150);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 45);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button_click);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(195, 150);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(45, 45);
            this.btnMul.TabIndex = 8;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.operator_click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(142, 150);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 45);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button_click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(91, 150);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 45);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button_click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(40, 201);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 45);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(195, 201);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(45, 45);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.operator_click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(142, 201);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 45);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(91, 201);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 45);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(246, 201);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(56, 96);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(40, 252);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(96, 45);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button_click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(195, 252);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(45, 45);
            this.btnPlus.TabIndex = 18;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(142, 252);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(45, 45);
            this.btnDot.TabIndex = 17;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.button_click);
            // 
            // txtbox_Result
            // 
            this.txtbox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Result.Location = new System.Drawing.Point(40, 64);
            this.txtbox_Result.Name = "txtbox_Result";
            this.txtbox_Result.ReadOnly = true;
            this.txtbox_Result.Size = new System.Drawing.Size(262, 29);
            this.txtbox_Result.TabIndex = 21;
            this.txtbox_Result.Text = "0";
            this.txtbox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCurrent_Operation
            // 
            this.lblCurrent_Operation.AutoSize = true;
            this.lblCurrent_Operation.BackColor = System.Drawing.Color.White;
            this.lblCurrent_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent_Operation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCurrent_Operation.Location = new System.Drawing.Point(36, 34);
            this.lblCurrent_Operation.Name = "lblCurrent_Operation";
            this.lblCurrent_Operation.Size = new System.Drawing.Size(0, 24);
            this.lblCurrent_Operation.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 337);
            this.Controls.Add(this.lblCurrent_Operation);
            this.Controls.Add(this.txtbox_Result);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.TextBox txtbox_Result;
        private System.Windows.Forms.Label lblCurrent_Operation;
    }
}

