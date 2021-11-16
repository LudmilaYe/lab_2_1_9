
namespace lab_2_1_9 {
  partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.num3 = new System.Windows.Forms.NumericUpDown();
            this.clearButton = new System.Windows.Forms.Button();
            this.outLabel = new System.Windows.Forms.Label();
            this.showTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите числа:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(12, 43);
            this.num1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.num1.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(139, 39);
            this.num1.TabIndex = 1;
            this.num1.ValueChanged += new System.EventHandler(this.NumChanged);
            this.num1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumChangedByKey);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(157, 43);
            this.num2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.num2.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(139, 39);
            this.num2.TabIndex = 2;
            this.num2.ValueChanged += new System.EventHandler(this.NumChanged);
            this.num2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumChangedByKey);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.num3.Location = new System.Drawing.Point(302, 43);
            this.num3.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.num3.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(139, 39);
            this.num3.TabIndex = 3;
            this.num3.ValueChanged += new System.EventHandler(this.NumChanged);
            this.num3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumChangedByKey);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(12, 120);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(135, 34);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Очистить ввод";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.DeleteNums);
            // 
            // outLabel
            // 
            this.outLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outLabel.Location = new System.Drawing.Point(0, 82);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(449, 35);
            this.outLabel.TabIndex = 5;
            this.outLabel.Text = "Тут будет вычисленное значение";
            this.outLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outLabel.Click += new System.EventHandler(this.outLabel_Click);
            // 
            // showTask
            // 
            this.showTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showTask.Location = new System.Drawing.Point(269, 120);
            this.showTask.Name = "showTask";
            this.showTask.Size = new System.Drawing.Size(172, 34);
            this.showTask.TabIndex = 6;
            this.showTask.Text = "Показать задание";
            this.showTask.UseVisualStyleBackColor = true;
            this.showTask.Click += new System.EventHandler(this.ShowTask);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(449, 161);
            this.Controls.Add(this.showTask);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num2);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Произведение двух наименьших чисел";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown num1;
    private System.Windows.Forms.NumericUpDown num2;
    private System.Windows.Forms.NumericUpDown num3;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.Label outLabel;
    private System.Windows.Forms.Button showTask;
  }
}

