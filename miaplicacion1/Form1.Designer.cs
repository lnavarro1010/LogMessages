namespace miaplicacion1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxToConsole = new System.Windows.Forms.CheckBox();
            this.checkBoxToFile = new System.Windows.Forms.CheckBox();
            this.checkBoxToDatabase = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxWarning = new System.Windows.Forms.CheckBox();
            this.checkBoxError = new System.Windows.Forms.CheckBox();
            this.checkBoxMessage = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "probar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 26);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxToDatabase);
            this.groupBox1.Controls.Add(this.checkBoxToFile);
            this.groupBox1.Controls.Add(this.checkBoxToConsole);
            this.groupBox1.Location = new System.Drawing.Point(290, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "to";
            // 
            // checkBoxToConsole
            // 
            this.checkBoxToConsole.AutoSize = true;
            this.checkBoxToConsole.Location = new System.Drawing.Point(49, 37);
            this.checkBoxToConsole.Name = "checkBoxToConsole";
            this.checkBoxToConsole.Size = new System.Drawing.Size(90, 24);
            this.checkBoxToConsole.TabIndex = 0;
            this.checkBoxToConsole.Text = "console";
            this.checkBoxToConsole.UseVisualStyleBackColor = true;
            // 
            // checkBoxToFile
            // 
            this.checkBoxToFile.AutoSize = true;
            this.checkBoxToFile.Location = new System.Drawing.Point(49, 67);
            this.checkBoxToFile.Name = "checkBoxToFile";
            this.checkBoxToFile.Size = new System.Drawing.Size(55, 24);
            this.checkBoxToFile.TabIndex = 1;
            this.checkBoxToFile.Text = "file";
            this.checkBoxToFile.UseVisualStyleBackColor = true;
            
            // 
            // checkBoxToDatabase
            // 
            this.checkBoxToDatabase.AutoSize = true;
            this.checkBoxToDatabase.Location = new System.Drawing.Point(49, 97);
            this.checkBoxToDatabase.Name = "checkBoxToDatabase";
            this.checkBoxToDatabase.Size = new System.Drawing.Size(102, 24);
            this.checkBoxToDatabase.TabIndex = 2;
            this.checkBoxToDatabase.Text = "database";
            this.checkBoxToDatabase.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxWarning);
            this.groupBox2.Controls.Add(this.checkBoxError);
            this.groupBox2.Controls.Add(this.checkBoxMessage);
            this.groupBox2.Location = new System.Drawing.Point(32, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 174);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "type";
            // 
            // checkBoxWarning
            // 
            this.checkBoxWarning.AutoSize = true;
            this.checkBoxWarning.Location = new System.Drawing.Point(49, 97);
            this.checkBoxWarning.Name = "checkBoxWarning";
            this.checkBoxWarning.Size = new System.Drawing.Size(90, 24);
            this.checkBoxWarning.TabIndex = 2;
            this.checkBoxWarning.Text = "warning";
            this.checkBoxWarning.UseVisualStyleBackColor = true;
            // 
            // checkBoxError
            // 
            this.checkBoxError.AutoSize = true;
            this.checkBoxError.Location = new System.Drawing.Point(49, 67);
            this.checkBoxError.Name = "checkBoxError";
            this.checkBoxError.Size = new System.Drawing.Size(68, 24);
            this.checkBoxError.TabIndex = 1;
            this.checkBoxError.Text = "error";
            this.checkBoxError.UseVisualStyleBackColor = true;
            // 
            // checkBoxMessage
            // 
            this.checkBoxMessage.AutoSize = true;
            this.checkBoxMessage.Location = new System.Drawing.Point(49, 37);
            this.checkBoxMessage.Name = "checkBoxMessage";
            this.checkBoxMessage.Size = new System.Drawing.Size(100, 24);
            this.checkBoxMessage.TabIndex = 0;
            this.checkBoxMessage.Text = "message";
            this.checkBoxMessage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Logs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxToDatabase;
        private System.Windows.Forms.CheckBox checkBoxToFile;
        private System.Windows.Forms.CheckBox checkBoxToConsole;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxWarning;
        private System.Windows.Forms.CheckBox checkBoxError;
        private System.Windows.Forms.CheckBox checkBoxMessage;
    }
}

