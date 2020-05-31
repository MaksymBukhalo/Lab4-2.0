using Lab4.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab4
{
    public partial class NewRentForm : Form
    {
        private Rent rent;
        private List<Vehicle> existRentedVehicles;
        private bool isValidate;
        private int selectedVehicleIndex;

        public NewRentForm(Rent rent)
        {
            InitializeComponent();
            this.rent = rent;
        }

        private void rentFirmNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (IsEmpty())
            {
                e.Cancel = true;
                errorProvider.SetError(rentFirmNameTextBox, $"Поле не може бути порожнім.");
                return;
            }
            if (!Regex.IsMatch(rentFirmNameTextBox.Text, @"^[\p{L} \.\'\-]+$"))
            {
                e.Cancel = true;
                errorProvider.SetError(rentFirmNameTextBox, "Поле повинно містити літери, апостроф, крапку, пробіл або дефіс.");
            }
            else
            {
                errorProvider.SetError(rentFirmNameTextBox, null);
            }
            
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            if (rent.RentFirmName != null)
            {
                addRentBtn.Text = "Змінити";
                rentFirmNameTextBox.Text = rent.RentFirmName;
                rent.RentedVehicles.ForEach(vehicle => vehiclesListBox.Items.Add(vehicle));
                existRentedVehicles = this.rent.RentedVehicles.Select(vehicle =>
                    vehicle.Clone() as Vehicle
                ).ToList();
            }
        }

        private void NewOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsEmpty() && IsSomthingChanged())
            {
                if (MessageBox.Show("Зберігати зміни?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    addRentBtn_Click(sender, e);
                    e.Cancel = !isValidate;
                }
                else
                {
                    rent.RentedVehicles = existRentedVehicles;
                }
            }
        }

        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            NewVehicleForm newVehicleForm = new NewVehicleForm(vehicle);
            if (newVehicleForm.ShowDialog() == DialogResult.OK)
            {
                rent.AddVehicle(vehicle);
                vehiclesListBox.Items.Add(vehicle);
            }            
        }

        private bool IsSelectedOneVehicle()
        {
            selectedVehicleIndex = vehiclesListBox.SelectedIndex;
            if (selectedVehicleIndex < 0 || selectedVehicleIndex >= rent.RentedVehicles.Count)
            {
                MessageBox.Show("Виберіть рівно один транспортний засіб", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void editVehicleBtn_Click(object sender, EventArgs e)
        {
            if (!IsSelectedOneVehicle()) return;
            NewVehicleForm newVehicleForm = new NewVehicleForm(rent.RentedVehicles[vehiclesListBox.SelectedIndex]);
            if (newVehicleForm.ShowDialog() == DialogResult.OK)
            {
                vehiclesListBox.Items[selectedVehicleIndex] = rent.RentedVehicles[selectedVehicleIndex];
            }
        }

        private bool IsEmpty()
        {
            return string.IsNullOrEmpty(rentFirmNameTextBox.Text);
        }

        private bool IsSomthingChanged()
        {
            return rentFirmNameTextBox.Text != rent.RentFirmName || IsVehiclesChanged();   
        }
        private bool IsVehiclesChanged ()
        {
            if (rent.RentedVehicles.Count != existRentedVehicles.Count)
                return true;

            for (int i = 0; i < existRentedVehicles.Count; i++)
            {
                if (!rent.RentedVehicles[i].Equals(existRentedVehicles[i]))
                {
                    return true;
                }    
            }
            return false;
        }

        private void addRentBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.FormClosing -= NewOrderForm_FormClosing;
                isValidate = true;
                rent.RentFirmName = rentFirmNameTextBox.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                isValidate = false;
                MessageBox.Show("Не вірно введені дані!!!", "Invalidate data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            rent.RentedVehicles = existRentedVehicles;
            this.FormClosing -= NewOrderForm_FormClosing;
        }

        private void vehiclesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editVehicleBtn.Enabled = true;
            deleteVehicleBtn.Enabled = true;
        }

        private void deleteVehicleBtn_Click(object sender, EventArgs e)
        {
            if (!IsSelectedOneVehicle()) return;
            if (MessageBox.Show($"Ви дійсно хочете видалити вибраний транспортний засіб?", "Delete vehicle",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string carNumber = rent.RentedVehicles[selectedVehicleIndex].CarNumber;
                rent.RentedVehicles.RemoveAt(selectedVehicleIndex);
                vehiclesListBox.Items.RemoveAt(selectedVehicleIndex);
                MessageBox.Show("Транспортний засіб з номером " + 
                    carNumber + " було видалено!!!");
                if (vehiclesListBox.Items.Count == 0)
                {
                    editVehicleBtn.Enabled = false;
                    deleteVehicleBtn.Enabled = false;
                }
            }
            else
            {
                return;
            }
        }
    }
}
