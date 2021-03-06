﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Иван" ,
                SurName = "Иванов" ,
                Patronymic = "Иванович" ,
                Age = 22,
                Salary = 50000
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Владислав" ,
                SurName = "Петров" ,
                Patronymic = "Иванович" ,
                Age = 35,
                Salary = 75000
            }
        };

        public IActionResult Index()
        {
            return View(_employees);
        }

        public IActionResult Details(int id)
        {
            EmployeeView employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);

        }
    }
}