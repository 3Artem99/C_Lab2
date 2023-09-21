//Задание№1
//Создайте класс, представляющий учебный класс ClassRoom.
//Создайте класс ученик - Pupil. 
//В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика
//(реализация может быть произвольной, например простой вывод на консоль разных строк).
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать. 

//Примечание: при реализации возможности создания экземпляра класса ClassRoom с произвольным количеством учеников воспользуйтесь ключевым словом params.

//=====================================================================================================================================================================================================================================================================================

//Задание№2
//Создайте класс Vehicle.
//В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
//Создайте 3 производных класса Plane, Саг и Ship.
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки.
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

//Примечание: избегайте дублирования кода, используйте ключевое слово base после объявления конструкторов в классах наследниках для вызова и передачи параметров в конструктор базового класса.

//=====================================================================================================================================================================================================================================================================================

//Задание №3
//Создайте класс DocumentWorker.
//В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
//В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт", "Редактирование документа доступно в версии Pro", "Сохранение документа доступно в версии Pro".
//Создайте производный класс ProDocumentWorker.
//Переопределите соответствующие методы, при переопределении методов выводите следующие строки: "Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert".
//Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
//Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате".
//В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
//Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.



using System;

namespace Lab2
{
    //Задание №1
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Ученик учится");
        }

        public virtual void Read()
        {
            Console.WriteLine("Ученик читает:");
        }

        public virtual void Write()
        {
            Console.WriteLine("Ученик пишет:");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Ученик отдыхает:");
        }
    }

    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Отлично.");
        }

        public override void Read()
        {
            Console.WriteLine("Отлично.");
        }

        public override void Write()
        {
            Console.WriteLine("Отлично.");
        }

        public override void Relax()
        {
            Console.WriteLine("Мало.");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Хорошо.");
        }

        public override void Read()
        {
            Console.WriteLine("Хорошо.");
        }

        public override void Write()
        {
            Console.WriteLine("Хорошо.");
        }

        public override void Relax()
        {
            Console.WriteLine("Достаточно.");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Плохо.");
        }

        public override void Read()
        {
            Console.WriteLine("Плохо.");
        }

        public override void Write()
        {
            Console.WriteLine("Плохо.");
        }

        public override void Relax()
        {
            Console.WriteLine("Круто.");
        }
    }
    class OutPupil : Pupil
    {
        void Out()
        {
            Console.WriteLine("Отсутствует.");
        }
    }

    class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length < 2 || pupils.Length > 4)
            {
                throw new ArgumentException("В классе должно быть от 2 до 4 учеников.");
            }

            this.pupils = new Pupil[4];

            for (int i = 0; i < pupils.Length; i++)
            {
                this.pupils[i] = pupils[i];
            }

            for (int i = pupils.Length; i < 4; i++)
            {
                this.pupils[i] = new OutPupil();
            }
        }

        public void ShowClassInfo()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine("Ученик " + (i + 1) + ":");
                Console.WriteLine("Учится: ");
                pupils[i].Study();
                Console.WriteLine("Читает: ");
                pupils[i].Read();
                Console.WriteLine("Пишет: ");
                pupils[i].Write();
                Console.WriteLine("Отдыхает: ");
                pupils[i].Relax();
                Console.WriteLine();
            }
        }

        //=====================================================================================================================================================================================================================================================================================
        //Задание 2
        class Vehicle
        {
            private double price;
            private double speed;
            private int year;
            private string name;

            public Vehicle(double price, double speed, int year, string name)
            {
                this.price = price;
                this.speed = speed;
                this.year = year;
                this.name = name;
            }

            public void ShowInfo()
            {
                Console.WriteLine("Информация о {0}", name);
                Console.WriteLine("Цена: ${0}", price);
                Console.WriteLine("Скорость: {0} км/ч", speed);
                Console.WriteLine("Год выпуска: {0}", year);

            }
        }

        class Plane : Vehicle
        {
            private double altitude;
            private int passengerCapacity;

            public Plane(double price, double speed, int year, string name, double altitude, int passengerCapacity)
                : base(price, speed, year, name)
            {
                this.altitude = altitude;
                this.passengerCapacity = passengerCapacity;
            }

            public new void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine();
                Console.WriteLine("Дополнительно:");
                Console.WriteLine("Высота: {0} feet", altitude);
                Console.WriteLine("Пассажировмещаемость: {0}", passengerCapacity);
            }
        }

        class Car : Vehicle
        {
            public Car(double price, double speed, int year, string name)
                : base(price, speed, year, name)
            {
                Console.WriteLine();
            }
        }

        class Ship : Vehicle
        {
            private int passengerCapacity;
            private string portOfRegistry;

            public Ship(double price, double speed, int year, string name, int passengerCapacity, string portOfRegistry)
                : base(price, speed, year, name)
            {
                this.passengerCapacity = passengerCapacity;
                this.portOfRegistry = portOfRegistry;
            }

            public new void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine();
                Console.WriteLine("Дополнительно:");
                Console.WriteLine("Пассажировмещаемость: {0}", passengerCapacity);
                Console.WriteLine("Порт приписки: {0}", portOfRegistry);
            }
        }
        //=====================================================================================================================================================================================================================================================================================
        //Задание №3
        class DocumentWorker
        {
            public virtual void OpenDocument()
            {
                Console.WriteLine("Документ открыт");
            }

            public virtual void EditDocument()
            {
                Console.WriteLine("Редактирование документа доступно в версии Pro");
            }

            public virtual void SaveDocument()
            {
                Console.WriteLine("Сохранение документа доступно в версии Pro");
            }
        }

        class ProDocumentWorker : DocumentWorker
        {
            public override void EditDocument()
            {
                Console.WriteLine("Документ отредактирован");
            }

            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
            }
        }

        class ExpertDocumentWorker : ProDocumentWorker
        {
            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в новом формате");
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                //Задание 1
                Console.WriteLine("Задание №1");
                Console.WriteLine();
                Pupil pupil1 = new ExcellentPupil();
                Pupil pupil2 = new GoodPupil();
                Pupil pupil3 = new BadPupil();
                Pupil pupil4 = new ExcellentPupil();

                ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);

                classRoom.ShowClassInfo();


                //Задание 2
                Console.WriteLine("Задание №2");
                Plane plane = new Plane(10000000, 600, 2022, "Самолёт", 35000, 250);
                Car car = new Car(30000, 120, 2021, "Машина");
                Ship ship = new Ship(8000000, 40, 2020, "Корабль", 1500, "Севастополь");

                plane.ShowInfo();
                Console.WriteLine();
                car.ShowInfo();
                Console.WriteLine();
                ship.ShowInfo();

                //Задание 3
                Console.WriteLine();
                Console.WriteLine("Задание №3");
                Console.WriteLine();
                Console.WriteLine("Введите ключ доступа (pro/exp): ");
                string key = Console.ReadLine();

                DocumentWorker worker;

                if (key == "pro")
                {
                    worker = new ProDocumentWorker();
                }
                else if (key == "exp")
                {
                    worker = new ExpertDocumentWorker();
                }
                else
                {
                    worker = new DocumentWorker();
                }

                // Пример использования методов
                worker.OpenDocument();
                worker.EditDocument();
                worker.SaveDocument();
                Console.ReadLine();
            }
        }
    }
}
