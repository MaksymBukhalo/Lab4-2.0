using Lab4.Classes;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab4
{
    public partial class NewCarForm : Form
    {
        private Car car;
        private bool isValidate;
        public NewCarForm(Car car)
        {
            InitializeComponent();
            this.car = car;
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.FormClosing -= NewCarForm_FormClosing;
                isValidate = true;
                car.ProdCompany = brandTextBox.Text;
                car.Model = modelTextBox.Text;
                car.Price = (int)priceNumericUpDown.Value;
                car.ProdYear = (int)productionYearNumericUpDown.Value;
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
            this.FormClosing -= NewCarForm_FormClosing;
        }

        private void NewCarForm_Load(object sender, EventArgs e)
        {
            if (car.ProdCompany != null && car.Model != null)
            {
                addCarBtn.Text = "Змінити";
                brandTextBox.Text = car.ProdCompany;
                modelTextBox.Text = car.Model;
                priceNumericUpDown.Value = car.Price;
                productionYearNumericUpDown.Value = car.ProdYear;
            }
        }

        private void NewCarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsEmpty() && IsSomthingChanged())
            {
                if (MessageBox.Show("Зберігати зміни?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    addCarBtn_Click(sender, e);
                    e.Cancel = !isValidate;
                }
            }
        }

        private void brandTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidate(sender as TextBox, e, @"^[\p{L} \.\-]+$",
                "Поле може містити літери, крапку, пробіл або тире.");
        }

        private void modelTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidate(sender as TextBox, e, @"^[\p{L}\d \.\-]+$",
                "Поле може містити літери, цифри, крапку, пробіл або тире.");
        }

        private void TextBoxValidate(TextBox textBox, CancelEventArgs e, string pattern, string text)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "Поле не може бути порожнім.");
                return;
            }
            if (!Regex.IsMatch(textBox.Text, pattern))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, text);
            }
            else
            {
                errorProvider.SetError(textBox, null);
            }
        }

        private bool IsEmpty()
        {
            return string.IsNullOrEmpty(brandTextBox.Text) && string.IsNullOrEmpty(modelTextBox.Text) &&
                priceNumericUpDown.Value == 0 && productionYearNumericUpDown.Value == productionYearNumericUpDown.Minimum;
        }

        private bool IsSomthingChanged()
        {
            return brandTextBox.Text != car.ProdCompany || modelTextBox.Text != car.Model ||
                productionYearNumericUpDown.Value != car.ProdYear || priceNumericUpDown.Value != car.Price;
        }
    }
}
