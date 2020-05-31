namespace Lab4
{
	partial class NewRentForm
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
			this.rentFirmNameTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.addVehicleBtn = new System.Windows.Forms.Button();
			this.deleteVehicleBtn = new System.Windows.Forms.Button();
			this.editVehicleBtn = new System.Windows.Forms.Button();
			this.vehiclesListBox = new System.Windows.Forms.ListBox();
			this.addRentBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(16, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Назва фірми прокату";
			// 
			// rentFirmNameTextBox
			// 
			this.rentFirmNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.rentFirmNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rentFirmNameTextBox.Location = new System.Drawing.Point(223, 41);
			this.rentFirmNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rentFirmNameTextBox.Name = "rentFirmNameTextBox";
			this.rentFirmNameTextBox.Size = new System.Drawing.Size(393, 24);
			this.rentFirmNameTextBox.TabIndex = 1;
			this.rentFirmNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.rentFirmNameTextBox_Validating);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.addVehicleBtn);
			this.groupBox1.Controls.Add(this.deleteVehicleBtn);
			this.groupBox1.Controls.Add(this.editVehicleBtn);
			this.groupBox1.Controls.Add(this.vehiclesListBox);
			this.groupBox1.Location = new System.Drawing.Point(16, 112);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(613, 313);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Vehicles";
			// 
			// addVehicleBtn
			// 
			this.addVehicleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addVehicleBtn.BackColor = System.Drawing.Color.YellowGreen;
			this.addVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addVehicleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addVehicleBtn.ForeColor = System.Drawing.Color.White;
			this.addVehicleBtn.Location = new System.Drawing.Point(8, 247);
			this.addVehicleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addVehicleBtn.Name = "addVehicleBtn";
			this.addVehicleBtn.Size = new System.Drawing.Size(183, 47);
			this.addVehicleBtn.TabIndex = 1;
			this.addVehicleBtn.Text = "Додати";
			this.addVehicleBtn.UseVisualStyleBackColor = false;
			this.addVehicleBtn.Click += new System.EventHandler(this.addVehicleBtn_Click);
			// 
			// deleteVehicleBtn
			// 
			this.deleteVehicleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteVehicleBtn.BackColor = System.Drawing.Color.Brown;
			this.deleteVehicleBtn.Enabled = false;
			this.deleteVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteVehicleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deleteVehicleBtn.ForeColor = System.Drawing.Color.White;
			this.deleteVehicleBtn.Location = new System.Drawing.Point(423, 247);
			this.deleteVehicleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.deleteVehicleBtn.Name = "deleteVehicleBtn";
			this.deleteVehicleBtn.Size = new System.Drawing.Size(183, 47);
			this.deleteVehicleBtn.TabIndex = 2;
			this.deleteVehicleBtn.Text = "Видалити";
			this.deleteVehicleBtn.UseVisualStyleBackColor = false;
			this.deleteVehicleBtn.Click += new System.EventHandler(this.deleteVehicleBtn_Click);
			// 
			// editVehicleBtn
			// 
			this.editVehicleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.editVehicleBtn.BackColor = System.Drawing.Color.Orange;
			this.editVehicleBtn.Enabled = false;
			this.editVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editVehicleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.editVehicleBtn.ForeColor = System.Drawing.Color.White;
			this.editVehicleBtn.Location = new System.Drawing.Point(219, 247);
			this.editVehicleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.editVehicleBtn.Name = "editVehicleBtn";
			this.editVehicleBtn.Size = new System.Drawing.Size(183, 47);
			this.editVehicleBtn.TabIndex = 2;
			this.editVehicleBtn.Text = "Редагувати";
			this.editVehicleBtn.UseVisualStyleBackColor = false;
			this.editVehicleBtn.Click += new System.EventHandler(this.editVehicleBtn_Click);
			// 
			// vehiclesListBox
			// 
			this.vehiclesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.vehiclesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.vehiclesListBox.FormattingEnabled = true;
			this.vehiclesListBox.HorizontalScrollbar = true;
			this.vehiclesListBox.ItemHeight = 18;
			this.vehiclesListBox.Location = new System.Drawing.Point(8, 23);
			this.vehiclesListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.vehiclesListBox.Name = "vehiclesListBox";
			this.vehiclesListBox.Size = new System.Drawing.Size(596, 184);
			this.vehiclesListBox.TabIndex = 0;
			this.vehiclesListBox.SelectedIndexChanged += new System.EventHandler(this.vehiclesListBox_SelectedIndexChanged);
			// 
			// addRentBtn
			// 
			this.addRentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addRentBtn.BackColor = System.Drawing.Color.YellowGreen;
			this.addRentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addRentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addRentBtn.ForeColor = System.Drawing.Color.White;
			this.addRentBtn.Location = new System.Drawing.Point(24, 462);
			this.addRentBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addRentBtn.Name = "addRentBtn";
			this.addRentBtn.Size = new System.Drawing.Size(183, 47);
			this.addRentBtn.TabIndex = 3;
			this.addRentBtn.Text = "Додати";
			this.addRentBtn.UseVisualStyleBackColor = false;
			this.addRentBtn.Click += new System.EventHandler(this.addRentBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.BackColor = System.Drawing.Color.Brown;
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cancelBtn.ForeColor = System.Drawing.Color.White;
			this.cancelBtn.Location = new System.Drawing.Point(439, 462);
			this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(183, 47);
			this.cancelBtn.TabIndex = 4;
			this.cancelBtn.Text = "Скасувати";
			this.cancelBtn.UseVisualStyleBackColor = false;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// NewRentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(645, 543);
			this.Controls.Add(this.addRentBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.rentFirmNameTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MinimumSize = new System.Drawing.Size(661, 579);
			this.Name = "NewRentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Order";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewOrderForm_FormClosing);
			this.Load += new System.EventHandler(this.NewOrderForm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox rentFirmNameTextBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox vehiclesListBox;
		private System.Windows.Forms.Button editVehicleBtn;
		private System.Windows.Forms.Button addVehicleBtn;
		private System.Windows.Forms.Button addRentBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.Button deleteVehicleBtn;
	}
}