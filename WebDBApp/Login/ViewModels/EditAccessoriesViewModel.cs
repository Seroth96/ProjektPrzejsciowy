﻿using WebDBApp.Service_References.Annotation;
using WebDBApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDBApp.Database;
using WebDBApp.Interfaces;
using NLog;

namespace WebDBApp.ViewModels
{
    public class EditAccessoriesViewModel 
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        //private readonly IUnitOfWork _unitOfWork;
        
        public IEnumerable<Accessory> Accessories { get; set; }
        public List<SelectListItem> choices { get; set; }

        [Required]
        public int ID { get; set; }
        [Required]
        public int SelectedAccesory { get; set; }
        [Required]
        public string NewName { get; set; }
        [Required]
        public string Description { get; set; }

        public EditAccessoriesViewModel()
        {
            choices = new List<SelectListItem>();   

        }

    }
}