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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SelectButton = new System.Windows.Forms.Button();
            this.SelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.InnerW = new System.Windows.Forms.GroupBox();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.Chartreuse;
            this.SelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.Location = new System.Drawing.Point(1325, 292);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(224, 78);
            this.SelectButton.TabIndex = 100;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // SelectionGroupBox
            // 
            this.SelectionGroupBox.ForeColor = System.Drawing.Color.Chartreuse;
            this.SelectionGroupBox.Location = new System.Drawing.Point(1309, 28);
            this.SelectionGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectionGroupBox.Size = new System.Drawing.Size(252, 354);
            this.SelectionGroupBox.TabIndex = 0;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Selection";
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.ResultButton);
            this.ResultGroupBox.ForeColor = System.Drawing.Color.Chartreuse;
            this.ResultGroupBox.Location = new System.Drawing.Point(1309, 415);
            this.ResultGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultGroupBox.Size = new System.Drawing.Size(252, 354);
            this.ResultGroupBox.TabIndex = 101;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Result";
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.Color.Black;
            this.ResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResultButton.Font = new System.Drawing.Font("Arial", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultButton.Location = new System.Drawing.Point(15, 21);
            this.ResultButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(224, 224);
            this.ResultButton.TabIndex = 102;
            this.ResultButton.UseVisualStyleBackColor = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Chartreuse;
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(1324, 679);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(224, 78);
            this.StartButton.TabIndex = 102;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // InnerW
            // 
            this.InnerW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InnerW.BackgroundImage")));
            this.InnerW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InnerW.ForeColor = System.Drawing.Color.Chartreuse;
            this.InnerW.Location = new System.Drawing.Point(61, 46);
            this.InnerW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InnerW.Name = "InnerW";
            this.InnerW.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InnerW.Size = new System.Drawing.Size(1004, 793);
            this.InnerW.TabIndex = 103;
            this.InnerW.TabStop = false;
            this.InnerW.Text = "Inner working";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1603, 942);
            this.Controls.Add(this.InnerW);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SelectionGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        public System.Windows.Forms.GroupBox InnerW;
    }
}

