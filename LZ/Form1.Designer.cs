namespace LZ
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
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
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox = new System.Windows.Forms.TextBox();
			this.result = new System.Windows.Forms.TextBox();
			this.button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(76, 43);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(410, 83);
			this.textBox.TabIndex = 0;
			// 
			// result
			// 
			this.result.Enabled = false;
			this.result.Location = new System.Drawing.Point(76, 200);
			this.result.Multiline = true;
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(410, 83);
			this.result.TabIndex = 1;
			// 
			// button
			// 
			this.button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.button.Location = new System.Drawing.Point(173, 155);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(200, 22);
			this.button.TabIndex = 2;
			this.button.Text = "Сжать";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(148, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(250, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Введите текст для сжатия";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 362);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button);
			this.Controls.Add(this.result);
			this.Controls.Add(this.textBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.TextBox result;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Label label1;
	}
}

