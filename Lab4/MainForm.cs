using Lab4.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab4
{
    public partial class MainForm : Form
    {
        private List<Rent> rents;
        private int currentListBoxItemIndex;
        private ListBox currentListBox;
        public MainForm()
        {  
            InitializeComponent();
            rents = new List<Rent>();          
        }

        private bool IsSelectedOneRent()
        {
            currentListBoxItemIndex = currentListBox.SelectedIndex;
            if (currentListBoxItemIndex < 0 || currentListBoxItemIndex >= rents.Count)
            {
                MessageBox.Show("Виберіть рівно один елемент списку", "",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer deSerializer = new XmlSerializer(typeof(List<Rent>));
                using (TextReader reader = new StreamReader("rented_cars.xml"))
                {
                    rents = (List<Rent>)deSerializer.Deserialize(reader);
                }
                rents.ForEach(rent =>
                {
                    shortInfoListBox.Items.Add(rent.ToShortString());
                    rentsListBox.Items.Add(rent);
                });                

            }
            catch (IOException ex)
            {
                MessageBox.Show("Не вдалося знайти файл із раніше збереженими даними,\n" +
                    "починаємо З ЧИСТОГО ЛИСТА.\nДеталі помилки: " + ex.Message, "File not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rentsListBox.Items.Count > 0)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Rent>));
                using (TextWriter writer = new StreamWriter("rented_cars.xml"))
                {
                    serializer.Serialize(writer, rents);
                    MessageBox.Show("Файл збережено!!!\n" + Path.GetFullPath("rented_cars.xml"), "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }   
        }

        private void addRentBtn_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            NewRentForm newOrderForm = new NewRentForm(rent);
            if (newOrderForm.ShowDialog() == DialogResult.OK)
            {
                rents.Add(rent);
                rentsListBox.Items.Add(rent);
                shortInfoListBox.Items.Add(rent.ToShortString());
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editRentBtn.Enabled = true;
            addVehicleBtn.Enabled = true;
            deleteRentBtn.Enabled = true;
            currentListBox = sender as ListBox;
            if (currentListBox.Name == "rentsListBox" && currentListBox.SelectedIndex > -1)
                shortInfoListBox.SelectedIndex = currentListBox.SelectedIndex;
            else
                rentsListBox.SelectedIndex = currentListBox.SelectedIndex;
        }

        private void editRentBtn_Click(object sender, EventArgs e)
        {
            if (!IsSelectedOneRent()) return;
            NewRentForm newOrderForm = new NewRentForm(rents[currentListBoxItemIndex]);
            if (newOrderForm.ShowDialog() == DialogResult.OK)
            {
                rentsListBox.Items[currentListBoxItemIndex] = rents[currentListBoxItemIndex];
                shortInfoListBox.Items[currentListBoxItemIndex] = rents[currentListBoxItemIndex].ToShortString();
            }
        }

        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            if (!IsSelectedOneRent()) return;
            Vehicle vehicle = new Vehicle();
            NewVehicleForm newVehicleForm = new NewVehicleForm(vehicle);
            if (newVehicleForm.ShowDialog() == DialogResult.OK)
            {
                rents[currentListBoxItemIndex].AddVehicle(vehicle);
                rentsListBox.Items[currentListBoxItemIndex] = rents[currentListBoxItemIndex];
                shortInfoListBox.Items[currentListBoxItemIndex] = rents[currentListBoxItemIndex].ToShortString();
            }
        }

        private void deleteRentBtn_Click(object sender, EventArgs e)
        {
            if (!IsSelectedOneRent()) return;
            if (MessageBox.Show($"Ви дійсно хочете видалити фірму \"" + rents[currentListBoxItemIndex].RentFirmName + "\"\n з прокату транспортних засобів?", "Delete rent firm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string firmName = rents[currentListBoxItemIndex].RentFirmName;
                rents.RemoveAt(currentListBoxItemIndex);
                rentsListBox.Items.RemoveAt(currentListBoxItemIndex);
                shortInfoListBox.Items.RemoveAt(currentListBoxItemIndex);
                MessageBox.Show("Фірма \"" +
                    firmName + "\" з прокату транспортних засобів була видалена!!!");
                if (rentsListBox.Items.Count == 0)
                {
                    editRentBtn.Enabled = false;
                    deleteRentBtn.Enabled = false;
                }
            }
            else
            {
                return;
            }
        }
    }
}
