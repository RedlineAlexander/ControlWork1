using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
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
    enum Railway
    {
        ElectricityTrain,
        Locomotives,
        PassengerTrain,
        StoreTrain
    };
  public abstract  class RailTransport : Transport
    {
        public void LINQLogicPlanePassengerFly()
        {
            // Specify the data source.
            int[] scoresPassengers = new int[] { 97, 92, 81, 60,35,65,22 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scoresPassengers
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }
    }
}
