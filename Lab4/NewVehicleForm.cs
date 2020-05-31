using Lab4.Classes;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab4
{
    public partial class NewVehicleForm : Form
    {
        private Vehicle vehicle;
        private Car existCar;
        private bool isValidate;
        public NewVehicleForm(Vehicle vehicle)
        {
            InitializeComponent();
            this.vehicle = vehicle;            
        }

        private void NewVehicleForm_Load(object sender, EventArgs e)
        {
            carCategoryComboBox.Items.AddRange(new object[]
            {
                CarCategory.Cabriolet,
                CarCategory.Family,
                CarCategory.Jeep,
                CarCategory.Sport
            });

            if (vehicle.Car != null)
            {
                addVehicleBtn.Text = "Змінити";
                carCategoryComboBox.SelectedItem = vehicle.CarCategory;
                carInfoTextBox.Text = vehicle.Car.ToString();
                dateTimePicker1.Value = vehicle.RentStartDate;
                rentPriceNumericUpDown.Value = vehicle.RentPrice;
                durationRentNumericUpDown.Value = vehicle.Duration;
                carNumberTextBox.Text = vehicle.CarNumber;
                existCar = vehicle.Car;
                addCarBtn.Enabled = false;
            }
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            NewCarForm newCarForm = new NewCarForm(car);
            if (newCarForm.ShowDialog() == DialogResult.OK)
            {
                vehicle.Car = car;
                carInfoTextBox.Text = car.ToString();
            }
        }

        private void editCarBtn_Click(object sender, EventArgs e)
        {
            NewCarForm newCarForm = new NewCarForm(vehicle.Car);
            if (newCarForm.ShowDialog() == DialogResult.OK)
            {
                carInfoTextBox.Text = vehicle.Car.ToString();
            }
        }

        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.FormClosing -= NewVehicleForm_FormClosing;
                isValidate = true;
                vehicle.CarCategory = (CarCategory)Enum.Parse(typeof(CarCategory), carCategoryComboBox.Text.ToString());
                vehicle.RentStartDate = dateTimePicker1.Value;
                vehicle.RentPrice = (int)rentPriceNumericUpDown.Value;
                vehicle.Duration = (int)durationRentNumericUpDown.Value;
                vehicle.CarNumber = carNumberTextBox.Text;
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
            vehicle.Car = existCar;
            this.FormClosing -= NewVehicleForm_FormClosing;
        }

        private void NewVehicleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsEmpty() && IsSomthingChanged())
            {
                if (MessageBox.Show("Зберігати зміни?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    addVehicleBtn_Click(sender, e);
                    e.Cancel = !isValidate;
                }
                else
                {
                    vehicle.Car = existCar;
                }
            }
        }

        private bool IsEmpty()
        {
            return carCategoryComboBox.SelectedIndex == -1 && dateTimePicker1.Value.Date == DateTime.Today.Date &&
                rentPriceNumericUpDown.Value == 0 && durationRentNumericUpDown.Value == 0 &&
                carNumberTextBox.Text == "" && carInfoTextBox.Text == "";
        }

        private bool IsSomthingChanged()
        {
            return carCategoryComboBox.Text != vehicle.CarCategory.ToString() || dateTimePicker1.Value.Date != vehicle.RentStartDate ||
                rentPriceNumericUpDown.Value != vehicle.RentPrice || durationRentNumericUpDown.Value != vehicle.Duration ||
                carNumberTextBox.Text != vehicle.CarNumber || carInfoTextBox.Text != vehicle.Car.ToString();
        }

        private void carNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(carNumberTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(carNumberTextBox, "Поле не може бути порожнім.");
                return;
            }
            if (!Regex.IsMatch(carNumberTextBox.Text, @"[A-Z]{2}[0-9]{4}[A-Z]{2}"))
            {
                e.Cancel = true;
                errorProvider.SetError(carNumberTextBox, "Формат номеру: [A-Z]{2}[0-9]{4}[A-Z]{2}\n" +
                    "(дві великі ЛАТИНСЬКІ літери, 4 цифри (0-9), дві великі ЛАТИНСЬКІ літери)");
            }
            else
            {
                errorProvider.SetError(carNumberTextBox, null);
            }
        }

        private void carCategoryComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (carCategoryComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(carCategoryComboBox, "Виберіть тип транспортного засобу.");
            }
            else
            {
                errorProvider.SetError(carCategoryComboBox, null);
            }
        }

        private void carInfoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(carInfoTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(carInfoTextBox, "Поле не може бути порожнім.");                
                return;
            }     
        }

        private void carInfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(carInfoTextBox.Text))
            {
                addCarBtn.Enabled = false;
                editCarBtn.Enabled = true;
                errorProvider.SetError(carInfoTextBox, null);            
            }
        }
    }
}
