using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            employeeManager.Update();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(employeeManager);
        }
    }
    interface IPersonManager
    {
        // Unimplemented operation
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // Müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // Personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
