using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Используя шаблон «Цепочка обязанностей», реализовать следующую задачу: сотрудник компании желает получить одобрение на получение некоторой суммы денег.
/// Для получения одобрения сотрудник обращается к непосредственному руководителю.
/// Руководитель не имеет полномочий одобрить выделение такой суммы денег (может одобрить меньшую сумму) и обращается к своему руководителю (директору компании).
/// Директор компании может одобрить или отклонить запрос и отправить ответ сотруднику.
/// </summary>
namespace Lesson_6_1
{
    class Program
    {
        private static Worker GetChainWorkers()
        {
            var employee = new Employee(100);
            var lowManager = new LowManager(1000);
            var topManager = new TopManager(10000);
            employee.SetNextWorker(lowManager);
            lowManager.SetNextWorker(topManager);

            return employee;
        }
        static void Main(string[] args)
        {
            Worker worker = GetChainWorkers();

            worker.Approve(100);
            worker.Approve(999);
            worker.Approve(5000);

            Console.ReadKey();
        }
    }
}
