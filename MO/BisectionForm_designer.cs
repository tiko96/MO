namespace MethodsOfOpt
{
    partial class BisectionForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.leftTextBox = new System.Windows.Forms.TextBox();
            this.rightTextBox = new System.Windows.Forms.TextBox();
            this.tolerTextBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.functionResultTextBox = new System.Windows.Forms.TextBox();
            this.toler2TextBox = new System.Windows.Forms.TextBox();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.maxIterTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.elapsedTimeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // functionTextBox
            // 
            this.functionTextBox.Location = new System.Drawing.Point(93, 12);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(262, 20);
            this.functionTextBox.TabIndex = 0;
            // 
            // leftTextBox
            // 
            this.leftTextBox.Location = new System.Drawing.Point(93, 55);
            this.leftTextBox.Name = "leftTextBox";
            this.leftTextBox.Size = new System.Drawing.Size(262, 20);
            this.leftTextBox.TabIndex = 1;
            this.leftTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.leftTextBox_KeyPress);
            // 
            // rightTextBox
            // 
            this.rightTextBox.Location = new System.Drawing.Point(93, 98);
            this.rightTextBox.Name = "rightTextBox";
            this.rightTextBox.Size = new System.Drawing.Size(262, 20);
            this.rightTextBox.TabIndex = 2;
            this.rightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rightTextBox_KeyPress);
            // 
            // tolerTextBox
            // 
            this.tolerTextBox.Location = new System.Drawing.Point(93, 140);
            this.tolerTextBox.Name = "tolerTextBox";
            this.tolerTextBox.Size = new System.Drawing.Size(262, 20);
            this.tolerTextBox.TabIndex = 3;
            this.tolerTextBox.Text = "1e-28";
            this.tolerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tolerTextBox_KeyPress);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(108, 239);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(172, 23);
            this.runButton.TabIndex = 6;
            this.runButton.Text = "Count";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(93, 332);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(262, 20);
            this.resultTextBox.TabIndex = 6;
            // 
            // functionResultTextBox
            // 
            this.functionResultTextBox.Location = new System.Drawing.Point(93, 370);
            this.functionResultTextBox.Name = "functionResultTextBox";
            this.functionResultTextBox.ReadOnly = true;
            this.functionResultTextBox.Size = new System.Drawing.Size(262, 20);
            this.functionResultTextBox.TabIndex = 7;
            // 
            // toler2TextBox
            // 
            this.toler2TextBox.Location = new System.Drawing.Point(93, 408);
            this.toler2TextBox.Name = "toler2TextBox";
            this.toler2TextBox.ReadOnly = true;
            this.toler2TextBox.Size = new System.Drawing.Size(262, 20);
            this.toler2TextBox.TabIndex = 8;
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Location = new System.Drawing.Point(93, 445);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.ReadOnly = true;
            this.iterationsTextBox.Size = new System.Drawing.Size(262, 20);
            this.iterationsTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Function";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Right";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tolerance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Results:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "X :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Y :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Abs(b-a)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Iterations";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 268);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(344, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Max iterations";
            // 
            // maxIterTextBox
            // 
            this.maxIterTextBox.Location = new System.Drawing.Point(93, 177);
            this.maxIterTextBox.Name = "maxIterTextBox";
            this.maxIterTextBox.Size = new System.Drawing.Size(262, 20);
            this.maxIterTextBox.TabIndex = 4;
            this.maxIterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxTolTextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Time limit (ms)";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(93, 213);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(262, 20);
            this.timeTextBox.TabIndex = 5;
            this.timeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 480);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Elapsed time";
            // 
            // elapsedTimeTextBox
            // 
            this.elapsedTimeTextBox.Location = new System.Drawing.Point(93, 480);
            this.elapsedTimeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.elapsedTimeTextBox.Name = "elapsedTimeTextBox";
            this.elapsedTimeTextBox.ReadOnly = true;
            this.elapsedTimeTextBox.Size = new System.Drawing.Size(262, 20);
            this.elapsedTimeTextBox.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(65, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 550);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.elapsedTimeTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maxIterTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iterationsTextBox);
            this.Controls.Add(this.toler2TextBox);
            this.Controls.Add(this.functionResultTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.tolerTextBox);
            this.Controls.Add(this.rightTextBox);
            this.Controls.Add(this.leftTextBox);
            this.Controls.Add(this.functionTextBox);
            this.Name = "Form1";
            this.Text = "Bisection Method";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox functionTextBox;
        private System.Windows.Forms.TextBox leftTextBox;
        private System.Windows.Forms.TextBox rightTextBox;
        private System.Windows.Forms.TextBox tolerTextBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox functionResultTextBox;
        private System.Windows.Forms.TextBox toler2TextBox;
        private System.Windows.Forms.TextBox iterationsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxIterTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox elapsedTimeTextBox;
        private System.Windows.Forms.Label label13;
    }
}

