namespace ICS_4U0_Lesson_1_2
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
            this.components = new System.ComponentModel.Container();
            this.txtFractionNum1 = new System.Windows.Forms.TextBox();
            this.txtFractionDenom1 = new System.Windows.Forms.TextBox();
            this.txtFractionNum2 = new System.Windows.Forms.TextBox();
            this.txtFractionDenom2 = new System.Windows.Forms.TextBox();
            this.CBOperator = new System.Windows.Forms.ComboBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFractionNum3 = new System.Windows.Forms.TextBox();
            this.txtFractionDenom3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ttFractionNum1 = new System.Windows.Forms.ToolTip(this.components);
            this.ttFractionDenom1 = new System.Windows.Forms.ToolTip(this.components);
            this.ttFractionNum2 = new System.Windows.Forms.ToolTip(this.components);
            this.ttFractionDenom2 = new System.Windows.Forms.ToolTip(this.components);
            this.ttOperator = new System.Windows.Forms.ToolTip(this.components);
            this.ttEqual = new System.Windows.Forms.ToolTip(this.components);
            this.lblFraction1 = new System.Windows.Forms.Label();
            this.lblFraction2 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFractionNum1
            // 
            this.txtFractionNum1.Location = new System.Drawing.Point(39, 49);
            this.txtFractionNum1.Name = "txtFractionNum1";
            this.txtFractionNum1.Size = new System.Drawing.Size(56, 20);
            this.txtFractionNum1.TabIndex = 0;
            this.ttFractionNum1.SetToolTip(this.txtFractionNum1, "Enter a numerator.");
            // 
            // txtFractionDenom1
            // 
            this.txtFractionDenom1.Location = new System.Drawing.Point(39, 87);
            this.txtFractionDenom1.Name = "txtFractionDenom1";
            this.txtFractionDenom1.Size = new System.Drawing.Size(56, 20);
            this.txtFractionDenom1.TabIndex = 1;
            this.ttFractionDenom1.SetToolTip(this.txtFractionDenom1, "Enter a denominator.");
            // 
            // txtFractionNum2
            // 
            this.txtFractionNum2.Location = new System.Drawing.Point(214, 49);
            this.txtFractionNum2.Name = "txtFractionNum2";
            this.txtFractionNum2.Size = new System.Drawing.Size(56, 20);
            this.txtFractionNum2.TabIndex = 3;
            this.ttFractionNum2.SetToolTip(this.txtFractionNum2, "Enter a numerator.");
            // 
            // txtFractionDenom2
            // 
            this.txtFractionDenom2.Location = new System.Drawing.Point(214, 87);
            this.txtFractionDenom2.Name = "txtFractionDenom2";
            this.txtFractionDenom2.Size = new System.Drawing.Size(56, 20);
            this.txtFractionDenom2.TabIndex = 4;
            this.ttFractionDenom2.SetToolTip(this.txtFractionDenom2, "Enter a denominator.");
            // 
            // CBOperator
            // 
            this.CBOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOperator.FormattingEnabled = true;
            this.CBOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.CBOperator.Location = new System.Drawing.Point(127, 63);
            this.CBOperator.Name = "CBOperator";
            this.CBOperator.Size = new System.Drawing.Size(56, 21);
            this.CBOperator.TabIndex = 2;
            this.ttOperator.SetToolTip(this.CBOperator, "Select an operator.");
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(304, 55);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(53, 41);
            this.btnEqual.TabIndex = 5;
            this.btnEqual.Text = "=";
            this.ttEqual.SetToolTip(this.btnEqual, "Click to determine the answer.");
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Clear";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // txtFractionNum3
            // 
            this.txtFractionNum3.Location = new System.Drawing.Point(388, 48);
            this.txtFractionNum3.Name = "txtFractionNum3";
            this.txtFractionNum3.Size = new System.Drawing.Size(56, 20);
            this.txtFractionNum3.TabIndex = 6;
            // 
            // txtFractionDenom3
            // 
            this.txtFractionDenom3.Location = new System.Drawing.Point(388, 87);
            this.txtFractionDenom3.Name = "txtFractionDenom3";
            this.txtFractionDenom3.Size = new System.Drawing.Size(56, 20);
            this.txtFractionDenom3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "------------------------";
            // 
            // ttFractionNum1
            // 
            this.ttFractionNum1.IsBalloon = true;
            // 
            // ttFractionDenom1
            // 
            this.ttFractionDenom1.IsBalloon = true;
            // 
            // ttFractionNum2
            // 
            this.ttFractionNum2.IsBalloon = true;
            // 
            // ttFractionDenom2
            // 
            this.ttFractionDenom2.IsBalloon = true;
            // 
            // ttOperator
            // 
            this.ttOperator.IsBalloon = true;
            // 
            // ttEqual
            // 
            this.ttEqual.IsBalloon = true;
            // 
            // lblFraction1
            // 
            this.lblFraction1.AutoSize = true;
            this.lblFraction1.Location = new System.Drawing.Point(40, 123);
            this.lblFraction1.Name = "lblFraction1";
            this.lblFraction1.Size = new System.Drawing.Size(54, 13);
            this.lblFraction1.TabIndex = 16;
            this.lblFraction1.Text = "Fraction 1";
            // 
            // lblFraction2
            // 
            this.lblFraction2.AutoSize = true;
            this.lblFraction2.Location = new System.Drawing.Point(215, 123);
            this.lblFraction2.Name = "lblFraction2";
            this.lblFraction2.Size = new System.Drawing.Size(54, 13);
            this.lblFraction2.TabIndex = 17;
            this.lblFraction2.Text = "Fraction 2";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(394, 123);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(42, 13);
            this.lblAnswer.TabIndex = 18;
            this.lblAnswer.Text = "Answer";
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.ForeColor = System.Drawing.Color.Red;
            this.lblNotification.Location = new System.Drawing.Point(40, 147);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(0, 13);
            this.lblNotification.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 178);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblFraction2);
            this.Controls.Add(this.lblFraction1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFractionDenom3);
            this.Controls.Add(this.txtFractionNum3);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.CBOperator);
            this.Controls.Add(this.txtFractionDenom2);
            this.Controls.Add(this.txtFractionNum2);
            this.Controls.Add(this.txtFractionDenom1);
            this.Controls.Add(this.txtFractionNum1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fraction Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFractionNum1;
        private System.Windows.Forms.TextBox txtFractionDenom1;
        private System.Windows.Forms.TextBox txtFractionNum2;
        private System.Windows.Forms.TextBox txtFractionDenom2;
        private System.Windows.Forms.ComboBox CBOperator;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.ToolTip ttFractionNum1;
        private System.Windows.Forms.ToolTip ttFractionDenom1;
        private System.Windows.Forms.ToolTip ttFractionNum2;
        private System.Windows.Forms.ToolTip ttFractionDenom2;
        private System.Windows.Forms.ToolTip ttOperator;
        private System.Windows.Forms.ToolTip ttEqual;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFractionNum3;
        private System.Windows.Forms.TextBox txtFractionDenom3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label lblFraction1;
        private System.Windows.Forms.Label lblFraction2;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblNotification;
    }
}

