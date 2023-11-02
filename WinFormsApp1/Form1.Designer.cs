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
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            btnGeneruj = new Button();
            bubble = new Button();
            selection = new Button();
            insert = new Button();
            merge = new Button();
            quick = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(193, 16);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 0;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(214, 12);
            numericUpDown1.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // btnGeneruj
            // 
            btnGeneruj.Location = new Point(232, 41);
            btnGeneruj.Name = "btnGeneruj";
            btnGeneruj.Size = new Size(75, 23);
            btnGeneruj.TabIndex = 3;
            btnGeneruj.Text = "Generuj";
            btnGeneruj.UseVisualStyleBackColor = true;
            btnGeneruj.Click += btnGeneruj_Click;
            // 
            // bubble
            // 
            bubble.Location = new Point(48, 146);
            bubble.Name = "bubble";
            bubble.Size = new Size(40, 23);
            bubble.TabIndex = 4;
            bubble.Text = "sb";
            bubble.UseVisualStyleBackColor = true;
            bubble.Click += sb_Click;
            // 
            // selection
            // 
            selection.Location = new Point(94, 146);
            selection.Name = "selection";
            selection.Size = new Size(40, 23);
            selection.TabIndex = 5;
            selection.Text = "ss";
            selection.UseVisualStyleBackColor = true;
            selection.Click += selection_Click;
            // 
            // insert
            // 
            insert.Location = new Point(140, 146);
            insert.Name = "insert";
            insert.Size = new Size(40, 23);
            insert.TabIndex = 6;
            insert.Text = "si";
            insert.UseVisualStyleBackColor = true;
            insert.Click += button4_Click;
            // 
            // merge
            // 
            merge.Location = new Point(186, 146);
            merge.Name = "merge";
            merge.Size = new Size(40, 23);
            merge.TabIndex = 7;
            merge.Text = "sm";
            merge.UseVisualStyleBackColor = true;
            merge.Click += merge_Click;
            // 
            // quick
            // 
            quick.Location = new Point(232, 146);
            quick.Name = "quick";
            quick.Size = new Size(40, 23);
            quick.TabIndex = 8;
            quick.Text = "sq";
            quick.UseVisualStyleBackColor = true;
            quick.Click += quick_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 116);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 9;
            label1.Text = "Czas: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 116);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 10;
            label2.Text = "*czas w sekundach*";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(48, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(340, 181);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(quick);
            Controls.Add(merge);
            Controls.Add(insert);
            Controls.Add(selection);
            Controls.Add(bubble);
            Controls.Add(btnGeneruj);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Button btnGeneruj;
        private Button bubble;
        private Button selection;
        private Button insert;
        private Button merge;
        private Button quick;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
    }
}