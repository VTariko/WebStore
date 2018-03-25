using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    /// <summary>
    /// Класс сотрудника
    /// </summary>
    public class EmployeeView
    {
        /// <summary>
        /// Id сотрудника
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        public string SurName { get; set; }

        /// <summary>
        /// Отчество сотрудника
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Возраст сотрудника
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Зарплата
        /// </summary>
        public int Salary { get; set; }
    }
}
