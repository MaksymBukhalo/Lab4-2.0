namespace Lab4
{
	partial class NewCarForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.brandTextBox = new System.Windows.Forms.TextBox();
			this.modelTextBox = new System.Windows.Forms.TextBox();
			this.addCarBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.productionYearNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productionYearNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(16, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Фірма-виробник";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(83, 80);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Модель";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(15, 121);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Рік виробництва";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(73, 164);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ціна(грн)";
			// 
			// brandTextBox
			// 
			this.brandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.brandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.brandTextBox.Location = new System.Drawing.Point(161, 31);
			this.brandTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.brandTextBox.Name = "brandTextBox";
			this.brandTextBox.Size = new System.Drawing.Size(321, 24);
			this.brandTextBox.TabIndex = 4;
			this.brandTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.brandTextBox_Validating);
			// 
			// modelTextBox
			// 
			this.modelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.modelTextBox.Location = new System.Drawing.Point(161, 76);
			this.modelTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.modelTextBox.Name = "modelTextBox";
			this.modelTextBox.Size = new System.Drawing.Size(321, 24);
			this.modelTextBox.TabIndex = 5;
			this.modelTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.modelTextBox_Validating);
			// 
			// addCarBtn
			// 
			this.addCarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addCarBtn.BackColor = System.Drawing.Color.YellowGreen;
			this.addCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addCarBtn.ForeColor = System.Drawing.Color.White;
			this.addCarBtn.Location = new System.Drawing.Point(161, 217);
			this.addCarBtn.Margin = new System.Windows.Forms.Padding(4);
			this.addCarBtn.Name = "addCarBtn";
			this.addCarBtn.Size = new System.Drawing.Size(143, 37);
			this.addCarBtn.TabIndex = 8;
			this.addCarBtn.Text = "Додати";
			this.addCarBtn.UseVisualStyleBackColor = false;
			this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.BackColor = System.Drawing.Color.Brown;
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cancelBtn.ForeColor = System.Drawing.Color.White;
			this.cancelBtn.Location = new System.Drawing.Point(339, 217);
			this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(145, 37);
			this.cancelBtn.TabIndex = 9;
			this.cancelBtn.Text = "Скасувати";
			this.cancelBtn.UseVisualStyleBackColor = false;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// priceNumericUpDown
			// 
			this.priceNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.priceNumericUpDown.Location = new System.Drawing.Point(161, 161);
			this.priceNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
			this.priceNumericUpDown.Maximum = new decimal(new int[] {
			50000000,
			0,
			0,
			0});
			this.priceNumericUpDown.Name = "priceNumericUpDown";
			this.priceNumericUpDown.Size = new System.Drawing.Size(323, 24);
			this.priceNumericUpDown.TabIndex = 7;
			// 
			// productionYearNumericUpDown
			// 
			this.productionYearNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.productionYearNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.productionYearNumericUpDown.Location = new System.Drawing.Point(161, 118);
			this.productionYearNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
			this.productionYearNumericUpDown.Maximum = new decimal(new int[] {
			2020,
			0,
			0,
			0});
			this.productionYearNumericUpDown.Minimum = new decimal(new int[] {
			1960,
			0,
			0,
			0});
			this.productionYearNumericUpDown.Name = "productionYearNumericUpDown";
			this.productionYearNumericUpDown.Size = new System.Drawing.Size(323, 24);
			this.productionYearNumericUpDown.TabIndex = 6;
			this.productionYearNumericUpDown.Value = new decimal(new int[] {
			1960,
			0,
			0,
			0});
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// NewCarForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(513, 282);
			this.Controls.Add(this.productionYearNumericUpDown);
			this.Controls.Add(this.priceNumericUpDown);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.addCarBtn);
			this.Controls.Add(this.modelTextBox);
			this.Controls.Add(this.brandTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(486, 319);
			this.Name = "NewCarForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Car";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewCarForm_FormClosing);
			this.Load += new System.EventHandler(this.NewCarForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productionYearNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox brandTextBox;
		private System.Windows.Forms.TextBox modelTextBox;
		private System.Windows.Forms.Button addCarBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.NumericUpDown priceNumericUpDown;
		private System.Windows.Forms.NumericUpDown productionYearNumericUpDown;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}