﻿using System;
using System.Collections.Generic;
using System.Text;
/*
 * Ваша задача – сделать приближенную к реальности логически выстроенную структуру любого объекта/процесса на ваше усмотрение. Особенное внимание при проверке будет обращено на логичность построения структуры.
Во время выполнения вы должны использовать все ваши знания, а именно:
1. Классы – минимум 4;
2. Интерфейсы – минимум 2;
3. Абстрактные классы (или класс);
4. Обобщенные методы;
5. Методы расширения;
6. List/Dictionary/IEnumerable;
7. Обобщения как для классов, так и для методов;
8. LINQ (желательно несколько);
9. Необязательные параметры в методах;
10. Вызовы конструктора базового класса;
11. Конструкции try/catch;
12. Перечисления (enum);
13. Делегаты + анонимные методы.
 */
namespace ControlWork1

{
    public delegate void EmptyTransportPhase();

    enum CheckForTruTransport{
        TypeOfTransport,
        NonOfTransportItsPassenger
    }
    public abstract class Transport : IMove, ITurn, IStop
    {
        public int PointA { get; set; }


        public int PointB { get; set; }
        public void AnonymousFunctionOfTransport() => Console.WriteLine("Никуда ты пустышка не поедешь ");
    }
}
