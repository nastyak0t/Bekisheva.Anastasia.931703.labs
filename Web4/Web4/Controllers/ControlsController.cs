﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class ControlsController : Controller
    {
        static Controls controls = new Controls();

        [HttpGet]
        public IActionResult TextBox()
        {
            ViewBag.TextBox = controls.TextBox;
            return View();
        }

        [HttpPost]
        public IActionResult Save_TextBox(string TextBox)
        {
            controls.TextBox = TextBox;
            ViewBag.TextBox = controls.TextBox;
            return View("TextBox");
        }

        [HttpGet]
        public IActionResult TextArea()
        {
            ViewBag.TextArea = controls.TextArea;
            return View();
        }

        [HttpPost]
        public IActionResult Save_TextArea(string TextArea)
        {
            controls.TextArea = TextArea;
            ViewBag.TextArea = controls.TextArea;
            return View("TextArea");
        }

        [HttpGet]
        public IActionResult CheckBox()
        {
            ViewBag.CheckBox = controls.CheckBox;
            return View();
        }

        [HttpPost]
        public IActionResult Save_CheckBox(bool CheckBox)
        {
            controls.CheckBox = CheckBox;
            ViewBag.CheckBox = controls.CheckBox;
            return View("CheckBox");
        }

        [HttpGet]
        public IActionResult Radio()
        {
            ViewBag.Radio = controls.Radio;
            return View();
        }

        [HttpPost]
        public IActionResult Save_Radio(string Radio)
        {
            controls.Radio = Radio;
            ViewBag.Radio = controls.Radio;
            return View("Radio");
        }

        [HttpGet]
        public IActionResult DropDownList()
        {
            ViewBag.DropDownList = controls.DropDownList;
            return View();
        }

        [HttpPost]
        public IActionResult Save_DropDownList(string DropDownList)
        {
            controls.DropDownList = DropDownList;
            ViewBag.DropDownList = controls.DropDownList;
            return View("DropDownList");
        }

        [HttpGet]
        public IActionResult ListBox()
        {
            ViewBag.ListBox = controls.ListBox;
            return View();
        }

        [HttpPost]
        public IActionResult Save_ListBox(string ListBox)
        {
            controls.ListBox = ListBox;
            ViewBag.ListBox = controls.ListBox;
            return View("ListBox");
        }

    }
}