# Lab4
Тип «Категорія» - відповідає перерахуванню enum «CarCategory», з полями:
	Легковий сімейний – Family
	Спортивний – Sport
	Кабріолет – Cabriolet
  Джип –Jeep
  Тип «Автомобіль» - відповідає класу «Car», використовується при створенні нового автомобіля, має закриті поля та публічні властивості,
  реалізує інтерфейси IXmlSerializable, ICloneable, IEquatable<Car>. Використовується як поле у класі «Vehicle».
  
Поля та властивості:
  Фірма-виробник – поле (private, string): prodCompany, властивості (public, string): ProdCompany;
	Модель автомобіля – поле (private, string): model, властивості (public, string): Model;
	Рік виробництва – поле (private, int): prodYear, властивості (public, int): ProdYear;
  Вартість – (private, int): price, властивості (private, int): Price.
	В формі «NewCarForm» клас має таке відношення з контролами:
	Властивість ProdCompany (фірма-виробник) класу (plain old object) відповідає textbox-y «brandTextBox»;
	Властивість Model (модель автомобіля) класу (plain old object) відповідає textbox-y «modelTextBox»;
	Властивість ProdYear (рік виробництва) класу (plain old object) відповідає NumericUpDown-y «productionYearNumericUpDown»;
	Властивість Price (вартість) класу (plain old object) відповідає NumericUpDown-y «priceNumericUpDown»;
Тип «Транспортний засіб» - відповідає класу «Vehicle», використовується при створенні нового транспортного засобу, має закриті поля та 
публічні властивості, реалізує інтерфейси IXmlSerializable, ICloneable, IEquatable<Vehicle>.
Поля та властивості:
	Категорія – поле (private, CarCategory): carCategory, властивості (public, CarCategory): CarCategory; 
	Автомобіль – поле (private, Car): car, властивості (public, Car): Car, зберігає  в собі фірму-виробник, модель, вартість та рік 
  виробництва автомобіля.
	Дата початку прокату – поле (private, DateTime): rentStartDate, властивості (public, DateTime): RentStartDate;
	Вартість прокату – поле (private, int): rentPrice, властивості (public, int): RentPrice;
	Тривалість прокату – поле (private, int): duration, властивості (public, int): Duration;
	Номер автомобіля –  поле (private, string): carNumber, властивості (public, string): CarNumber;
В формі «NewVehicleForm» клас має таке відношення з контролами:
	Властивість CarCategory (категорія) класу (plain old object) відповідає ComboBox-y «carCategoryComboBox»;
	Властивість Car (автомобіль) класу (plain old object) відповідає TextBox-y «carInfoTextBox»;
	Властивість RentStartDate (дата початку прокату) класу (plain old object) відповідає DateTimePicker-y «dateTimePicker1»;
	Властивість RentPrice (вартість прокату) класу (plain old object) відповідає NumericUpDown-y «rentPriceNumericUpDown»;
	Властивість Duration (тривалість прокату) класу (plain old object) відповідає NumericUpDown-y «durationRentNumericUpDown»;
	Властивість CarNumber (номер автомобіля) класу (plain old object) відповідає TextBox-y «carNumberTextBox»;
Тип «Прокат» - відповідає класу «Rent», має закриті поля та публічні властивості, реалізує інтерфейси IXmlSerializable.
Поля та властивості:
	Приватне поле «rentFirmName» типу «string» (зберігає в собі назву фірми з прокату транспортних засобів), публічні властивості цього 
  поля «RentFirmName»;
	Приватне поле «rentedVehicles» яке є списком (List<Vehicle>) який зберігає тип «Vehicle», публічні властивості «RentedVehicles», 
  реалізовано метод «AddVehicle()» для додавання одного транспортного засобу типу «Vehicle» до списку.
В формі «NewRentForm» клас має таке відношення з контролами:
	Властивість «RentFirmName» (назва фірми з прокату ТЗ) класу (plain old object) відповідає TextBox-y «rentFirmNameTextBox»;
	Список оформлених замовлень (орендованих ТЗ) відповідає ListBox-y «vehiclesListBox» і лише виводить інформацію про ТЗ який створюється за допомогою форми «NewVehicleForm»

Серіалізаця та десеріалізація зроблені з власним реалізуванням інтерфейсу IXmlSerializable.
Для класу «Car» серіалізаці/десеріалцізація відбувається для таких закритих полів:
	private string prodCompany, model;
	private int price, prodYear;

Для класу «Vehicle» серіалізаці/десеріалцізація відбувається для таких закритих полів:
	private CarCategory carCategory;
	private Car car;
	private DateTime rentStartDate;
	private int rentPrice, duration;
	private string carNumber;

Для класу «Rent» серіалізаці/десеріалцізація відбувається для таких закритих полів:
	private string rentFirmName;
	private List<Vehicle> rentedVehicles;


  Файл NewRentForm.cs, клас NewRentForm, метод rentFirmNameTextBox_Validating: валідація на правильність введення назви фірми з прокату
  ТЗ,дозволяє літери, пробіли, апостроф, крапку та дефіс(мінуса).
  Файл NewVehicleForm.cs, клас NewVehicleForm, метод carCategoryComboBox_Validating: перевіряє чи вибрано елемент в comboBox.
На мій погляд така перевірка є доцільнішою ніж викликати самому в коді метод для перевірки, а так він буде автоматично викликатися,
коли фокус покидає comboBox.
  Файл NewVehicleForm.cs, клас NewVehicleForm, метод carNumberTextBox_Validating: в умові не було уточнено який саме номер повинен бути, 
тому було вибрано варіант українських номерів автомобілів, тоді даний метод перевіряє правильність введення номеру, а саме спочатку 
повинно бути 2 великі латинські літери, потім 4 цифри (0-9), і знову дві великі латинські літери.
  Файл NewVehicleForm.cs, клас NewVehicleForm, метод carInfoTextBox_Validating: перевіряє чи TextBox  «carInfoTextBox» не порожній, 
оскільки ми не можемо змінювати інформацію і додавати «напряму» її до textbox-y, вирішено зробити саме так, це зроблено за допомогою 
властивості текстбокса «ReadOnly» яка встановлена в положення «true», a в сам текстбокс виводиться інформація про створений автомобіль.
  Файл NewCarForm.cs, клас NewCarForm, метод TextBoxValidate, метод викликається в головних методах валідації для фірми-виробника 
(brandTextBox) та моделі (modelTextBox) автомобіля: 
	для фірми-виробника brandTextBox_Validating;
	для моделі modelTextBox_Validating;
Валідація полягає в правильному введення фірми-виробника та моделі автомобіля. Для фірми дозволяє літери, пробіл, крапку і дефіс.
Для моделі все те що і для фірми але додаються ще цифри.

