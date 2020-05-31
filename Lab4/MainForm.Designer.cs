namespace Lab4
{
	partial class MainForm
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
			this.rentsListBox = new System.Windows.Forms.ListBox();
			this.shortInfoListBox = new System.Windows.Forms.ListBox();
			this.addRentBtn = new System.Windows.Forms.Button();
			this.editRentBtn = new System.Windows.Forms.Button();
			this.addVehicleBtn = new System.Windows.Forms.Button();
			this.deleteRentBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rentsListBox
			// 
			this.rentsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.rentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rentsListBox.FormattingEnabled = true;
			this.rentsListBox.HorizontalScrollbar = true;
			this.rentsListBox.ItemHeight = 18;
			this.rentsListBox.Location = new System.Drawing.Point(331, 1);
			this.rentsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rentsListBox.Name = "rentsListBox";
			this.rentsListBox.Size = new System.Drawing.Size(1063, 418);
			this.rentsListBox.TabIndex = 1;
			this.rentsListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
			// 
			// shortInfoListBox
			// 
			this.shortInfoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)));
			this.shortInfoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.shortInfoListBox.FormattingEnabled = true;
			this.shortInfoListBox.HorizontalScrollbar = true;
			this.shortInfoListBox.ItemHeight = 18;
			this.shortInfoListBox.Location = new System.Drawing.Point(1, 1);
			this.shortInfoListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.shortInfoListBox.Name = "shortInfoListBox";
			this.shortInfoListBox.Size = new System.Drawing.Size(320, 418);
			this.shortInfoListBox.TabIndex = 0;
			this.shortInfoListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
			// 
			// addRentBtn
			// 
			this.addRentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.addRentBtn.BackColor = System.Drawing.Color.YellowGreen;
			this.addRentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addRentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addRentBtn.ForeColor = System.Drawing.Color.White;
			this.addRentBtn.Location = new System.Drawing.Point(1197, 519);
			this.addRentBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addRentBtn.Name = "addRentBtn";
			this.addRentBtn.Size = new System.Drawing.Size(183, 43);
			this.addRentBtn.TabIndex = 3;
			this.addRentBtn.Text = "Додати";
			this.addRentBtn.UseVisualStyleBackColor = false;
			this.addRentBtn.Click += new System.EventHandler(this.addRentBtn_Click);
			// 
			// editRentBtn
			// 
			this.editRentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.editRentBtn.BackColor = System.Drawing.Color.Orange;
			this.editRentBtn.Enabled = false;
			this.editRentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editRentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.editRentBtn.ForeColor = System.Drawing.Color.White;
			this.editRentBtn.Location = new System.Drawing.Point(988, 438);
			this.editRentBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.editRentBtn.Name = "editRentBtn";
			this.editRentBtn.Size = new System.Drawing.Size(183, 43);
			this.editRentBtn.TabIndex = 2;
			this.editRentBtn.Text = "Редагувати";
			this.editRentBtn.UseVisualStyleBackColor = false;
			this.editRentBtn.Click += new System.EventHandler(this.editRentBtn_Click);
			// 
			// addVehicleBtn
			// 
			this.addVehicleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addVehicleBtn.BackColor = System.Drawing.Color.YellowGreen;
			this.addVehicleBtn.Enabled = false;
			this.addVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addVehicleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addVehicleBtn.ForeColor = System.Drawing.Color.White;
			this.addVehicleBtn.Location = new System.Drawing.Point(16, 519);
			this.addVehicleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addVehicleBtn.Name = "addVehicleBtn";
			this.addVehicleBtn.Size = new System.Drawing.Size(183, 43);
			this.addVehicleBtn.TabIndex = 4;
			this.addVehicleBtn.Text = "Додати ТЗ";
			this.addVehicleBtn.UseVisualStyleBackColor = false;
			this.addVehicleBtn.Click += new System.EventHandler(this.addVehicleBtn_Click);
			// 
			// deleteRentBtn
			// 
			this.deleteRentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteRentBtn.BackColor = System.Drawing.Color.Brown;
			this.deleteRentBtn.Enabled = false;
			this.deleteRentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteRentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deleteRentBtn.ForeColor = System.Drawing.Color.White;
			this.deleteRentBtn.Location = new System.Drawing.Point(1197, 438);
			this.deleteRentBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.deleteRentBtn.Name = "deleteRentBtn";
			this.deleteRentBtn.Size = new System.Drawing.Size(183, 43);
			this.deleteRentBtn.TabIndex = 2;
			this.deleteRentBtn.Text = "Видалити";
			this.deleteRentBtn.UseVisualStyleBackColor = false;
			this.deleteRentBtn.Click += new System.EventHandler(this.deleteRentBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1396, 577);
			this.Controls.Add(this.addVehicleBtn);
			this.Controls.Add(this.shortInfoListBox);
			this.Controls.Add(this.deleteRentBtn);
			this.Controls.Add(this.editRentBtn);
			this.Controls.Add(this.addRentBtn);
			this.Controls.Add(this.rentsListBox);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rent";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox rentsListBox;
		private System.Windows.Forms.ListBox shortInfoListBox;
		private System.Windows.Forms.Button addRentBtn;
		private System.Windows.Forms.Button editRentBtn;
		private System.Windows.Forms.Button addVehicleBtn;
		private System.Windows.Forms.Button deleteRentBtn;
	}
}

