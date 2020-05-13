﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web2.Models;

namespace Web2.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManualParsingInSingleAction()
        {
            return View();
        }

        public IActionResult ManualParsingInSeparateActions()
        {
            return View();
        }

        public IActionResult ModelBindingParametrs()
        {
            return View();
        }

        public IActionResult ModelBindingSeparateModel()
        {
            return View();
        }

        private double Calc(double value1, double value2, string operation)
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = value1 + value2;
                    break;

                case "-":
                    result = value1 - value2;
                    break;

                case "*":
                    result = value1 * value2;
                    break;

                case "/":
                    result = value1 / value2;
                    break;

                default:
                    result = 0;
                    break;
            }

            return result;
        }

        public IActionResult Count1()
        {
            if (Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase))
            {
                int value1 = Convert.ToInt32(this.Request.Form["input1"]);
                int value2 = Convert.ToInt32(this.Request.Form["input2"]);
                string operation = this.Request.Form["operation"];

                ViewBag.input1 = value1;
                ViewBag.input2 = value2;
                ViewBag.operation = operation;
                ViewBag.result = Calc(value1, value2, operation);

            }

            return View("Result");
        }

        [HttpPost, ActionName("Count2")]
        public IActionResult Count2Post()
        {
            int value1 = Convert.ToInt32(this.Request.Form["input1"]);
            int value2 = Convert.ToInt32(this.Request.Form["input2"]);
            string operation = this.Request.Form["operation"];

            ViewBag.input1 = value1;
            ViewBag.input2 = value2;
            ViewBag.operation = operation;
            ViewBag.result = Calc(value1, value2, operation);

            return View("Result");
        }

        [HttpPost]
        public IActionResult Count3(int input1, int input2, string operation)
        {
            ViewBag.input1 = input1;
            ViewBag.input2 = input2;
            ViewBag.operation = operation;
            ViewBag.result = Calc(input1, input2, operation);

            return View("Result");
        }


        [HttpPost]
        public IActionResult Count4(CalcModel calc)
        {

            ViewBag.input1 = calc.value1;
            ViewBag.input2 = calc.value2;
            ViewBag.operation = calc.operation;
            ViewBag.result = calc.Calc();

            return View("Result");
        }
    }
}