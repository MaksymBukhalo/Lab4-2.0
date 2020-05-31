namespace Lab4
{
	partial class NewVehicleForm
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.carCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.rentPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.durationRentNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.addCarBtn = new System.Windows.Forms.Button();
			this.carInfoTextBox = new System.Windows.Forms.TextBox();
			this.editCarBtn = new System.Windows.Forms.Button();
			this.addVehicleBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.carNumberTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.rentPriceNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.durationRentNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(125, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Категорія";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(39, 160);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Дата початку прокату";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(35, 208);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(158, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Вартість прокату(грн)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(16, 255);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(181, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Тривалість прокату(год.)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(60, 298);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(140, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "Номер автомобіля";
			// 
			// carCategoryComboBox
			// 
			this.carCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.carCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.carCategoryComboBox.FormattingEnabled = true;
			this.carCategoryComboBox.Location = new System.Drawing.Point(216, 26);
			this.carCategoryComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.carCategoryComboBox.Name = "carCategoryComboBox";
			this.carCategoryComboBox.Size = new System.Drawing.Size(324, 26);
			this.carCategoryComboBox.TabIndex = 6;
			this.carCategoryComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.carCategoryComboBox_Validating);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker1.Location = new System.Drawing.Point(217, 160);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(323, 24);
			this.dateTimePicker1.TabIndex = 10;
			// 
			// rentPriceNumericUpDown
			// 
			this.rentPriceNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.rentPriceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rentPriceNumericUpDown.Location = new System.Drawing.Point(217, 206);
			this.rentPriceNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rentPriceNumericUpDown.Maximum = new decimal(new int[] {
			1000000,
			0,
			0,
			0});
			this.rentPriceNumericUpDown.Name = "rentPriceNumericUpDown";
			this.rentPriceNumericUpDown.Size = new System.Drawing.Size(324, 24);
			this.rentPriceNumericUpDown.TabIndex = 11;
			// 
			// durationRentNumericUpDown
			// 
			this.durationRentNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.durationRentNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.durationRentNumericUpDown.Location = new System.Drawing.Point(217, 252);
			this.durationRentNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.durationRentNumericUpDown.Maximum = new decimal(new int[] {
			100000,
			0,
			0,
			0});
			this.durationRentNumericUpDown.Name = "durationRentNumericUpDown";
			this.durationRentNumericUpDown.Size = new System.Drawing.Size(324, 24);
			this.durationRentNumericUpDown.TabIndex = 12;
			// 
			// addCarBtn
			// 
			this.addCarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addCarBtn.BackColor = System.Drawing.Color.YellowGreen;
			this.addCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addCarBtn.ForeColor = System.Drawing.Color.White;
			this.addCarBtn.Location = new System.Drawing.Point(216, 103);
			this.addCarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addCarBtn.Name = "addCarBtn";
			this.addCarBtn.Size = new System.Drawing.Size(143, 38);
			this.addCarBtn.TabIndex = 8;
			this.addCarBtn.Text = "Додати";
			this.addCarBtn.UseVisualStyleBackColor = false;
			this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
			// 
			// carInfoTextBox
			// 
			this.carInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.carInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.carInfoTextBox.Location = new System.Drawing.Point(217, 69);
			this.carInfoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.carInfoTextBox.Name = "carInfoTextBox";
			this.carInfoTextBox.ReadOnly = true;
			this.carInfoTextBox.Size = new System.Drawing.Size(323, 24);
			this.carInfoTextBox.TabIndex = 7;
			this.carInfoTextBox.TextChanged += new System.EventHandler(this.carInfoTextBox_TextChanged);
			this.carInfoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.carInfoTextBox_Validating);
			// 
			// editCarBtn
			// 
			this.editCarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.editCarBtn.BackColor = System.Drawing.Color.Orange;
			this.editCarBtn.Enabled = false;
			this.editCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editCarBtn.ForeColor = System.Drawing.Color.White;
			this.editCarBtn.Location = new System.Drawing.Point(399, 105);
			this.editCarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.editCarBtn.Name = "editCarBtn";
			this.editCarBtn.Size = new System.Drawing.Size(143, 38);
			this.editCarBtn.TabIndex = 9;
			this.editCarBtn.Text = "Редагувати";
			this.editCarBtn.UseVisualStyleBackColor = false;
			this.editCarBtn.Click += new System.EventHandler(this.editCarBtn_Click);
			// 
			// addVehicleBtn
			// 
			this.addVehicleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addVehicleBtn.BackColor = System.Drawing.Color.YellowGreen;
			this.addVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addVehicleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addVehicleBtn.ForeColor = System.Drawing.Color.White;
			this.addVehicleBtn.Location = new System.Drawing.Point(216, 350);
			this.addVehicleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addVehicleBtn.Name = "addVehicleBtn";
			this.addVehicleBtn.Size = new System.Drawing.Size(163, 43);
			this.addVehicleBtn.TabIndex = 14;
			this.addVehicleBtn.Text = "Додати";
			this.addVehicleBtn.UseVisualStyleBackColor = false;
			this.addVehicleBtn.Click += new System.EventHandler(this.addVehicleBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.BackColor = System.Drawing.Color.Brown;
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cancelBtn.ForeColor = System.Drawing.Color.White;
			this.cancelBtn.Location = new System.Drawing.Point(387, 350);
			this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(155, 43);
			this.cancelBtn.TabIndex = 15;
			this.cancelBtn.Text = "Скасувати";
			this.cancelBtn.UseVisualStyleBackColor = false;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(109, 70);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Автомобіль";
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// carNumberTextBox
			// 
			this.carNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.carNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.carNumberTextBox.Location = new System.Drawing.Point(217, 297);
			this.carNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.carNumberTextBox.Name = "carNumberTextBox";
			this.carNumberTextBox.Size = new System.Drawing.Size(323, 24);
			this.carNumberTextBox.TabIndex = 13;
			this.carNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.carNumberTextBox_Validating);
			// 
			// NewVehicleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(569, 412);
			this.Controls.Add(this.carNumberTextBox);
			this.Controls.Add(this.carInfoTextBox);
			this.Controls.Add(this.addCarBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.editCarBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.addVehicleBtn);
			this.Controls.Add(this.durationRentNumericUpDown);
			this.Controls.Add(this.rentPriceNumericUpDown);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.carCategoryComboBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "NewVehicleForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Vehicle ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewVehicleForm_FormClosing);
			this.Load += new System.EventHandler(this.NewVehicleForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.rentPriceNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.durationRentNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox carCategoryComboBox;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.NumericUpDown rentPriceNumericUpDown;
		private System.Windows.Forms.NumericUpDown durationRentNumericUpDown;
		private System.Windows.Forms.Button addCarBtn;
		private System.Windows.Forms.TextBox carInfoTextBox;
		private System.Windows.Forms.Button editCarBtn;
		private System.Windows.Forms.Button addVehicleBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.TextBox carNumberTextBox;
	}
}