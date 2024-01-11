namespace Task_4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 7);
            label1.Name = "label1";
            label1.Size = new Size(178, 27);
            label1.TabIndex = 0;
            label1.Text = "Lista Numérica:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(201, 9);
            label2.Name = "label2";
            label2.Size = new Size(467, 27);
            label2.TabIndex = 1;
            label2.Text = " [-34, 77, -89, -25, -19, 14, -20, 46, -32, 91]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 58);
            label3.Name = "label3";
            label3.Size = new Size(191, 27);
            label3.TabIndex = 2;
            label3.Text = "Lista Convertida:";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(691, 7);
            button1.Name = "button1";
            button1.Size = new Size(192, 38);
            button1.TabIndex = 3;
            button1.Text = "Converter Lista";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(214, 58);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 27);
            lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1577, 99);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label lblResult;
    }
}
