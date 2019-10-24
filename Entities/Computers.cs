//Придумать базовый класс и три класса, расширяющих его.
//Сделать поля, методы.


//Базовый класс "Computers"
//Поля:
//	1. Кол-во CPU
//	2. Количество памяти
//	3. Расширяемость
//Методы:
//	1. Включить
//	2. Перезагрузить
//	3. Выключить
//	4. Подать питание
//	5. Обесточить
//	6. Нажать кнопку питания


//Классы наследники:
//	1. Notebooks
//        Поля:
//			1. Время работы батареи
//        Методы:
//			1. Отрыть крышку
//			2. Закрыть крышку
//	2. PersonalComputers
//        Поля:
//			1. Форм фактор

//        Методы:
//	3. Servers
//        Поля:
//			1. Размер(U)

//        Методы:
//			1. Подключиться к консоли

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class Computers
    {
        protected string type;
        protected ushort cpuNumber;
        protected uint memoryUmount;
        protected bool extensibility;
        protected bool isOSOn;
        protected bool isPowerOn;

        public string Type { get { return type; } set { type = value; } }
        public ushort CPUNumber { get { return cpuNumber; } set { cpuNumber = value; } }
        public uint MemoryUmount { get { return memoryUmount; } set { memoryUmount = value; } }
        public bool Extensibility { get { return extensibility; } set { extensibility = value; } }
        public bool IsOSOn { get { return isOSOn; } set { isOSOn = value; } }
        public bool IsPowerOn { get { return isPowerOn; } set { isPowerOn = value; } }
    }
}