namespace SmollBrein
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
            this.SelectButton = new System.Windows.Forms.Button();
            this.SelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.Chartreuse;
            this.SelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.Location = new System.Drawing.Point(633, 224);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(168, 63);
            this.SelectButton.TabIndex = 100;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // SelectionGroupBox
            // 
            this.SelectionGroupBox.ForeColor = System.Drawing.Color.Chartreuse;
            this.SelectionGroupBox.Location = new System.Drawing.Point(622, 10);
            this.SelectionGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SelectionGroupBox.Size = new System.Drawing.Size(189, 288);
            this.SelectionGroupBox.TabIndex = 0;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Selection";
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.ResultButton);
            this.ResultGroupBox.ForeColor = System.Drawing.Color.Chartreuse;
            this.ResultGroupBox.Location = new System.Drawing.Point(824, 10);
            this.ResultGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ResultGroupBox.Size = new System.Drawing.Size(189, 288);
            this.ResultGroupBox.TabIndex = 101;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Result";
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.Color.Black;
            this.ResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResultButton.Font = new System.Drawing.Font("Arial", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultButton.Location = new System.Drawing.Point(11, 17);
            this.ResultButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(168, 182);
            this.ResultButton.TabIndex = 102;
            this.ResultButton.UseVisualStyleBackColor = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Chartreuse;
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(835, 224);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(168, 63);
            this.StartButton.TabIndex = 102;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1023, 575);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SelectionGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResultGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.GroupBox SelectionGroupBox;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Button StartButton;
    }
}

