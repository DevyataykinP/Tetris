using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skillbox
{
    class worker
    {
        public string Position;
        public uint Salary;
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public string Print()
        {
            return $"Должность: {Position} Зарплата: {Salary} Имя: {FirstName} Фамилия:{LastName} Дата рождения: {DateOfBirth.ToShortDateString()}";
        }

    }
}
