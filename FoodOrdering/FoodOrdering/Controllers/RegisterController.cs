﻿using FoodOrdering.Interfaces;
using FoodOrdering.Models;
using FoodOrdering.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrdering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        FoodProjectContext db;
        IJWTMangerRepository iJWTMangerRepository;
        public RegisterController(FoodProjectContext _db, IJWTMangerRepository _iJWTMangerRepository)
        {
            db = _db;
            iJWTMangerRepository = _iJWTMangerRepository;
        }
        [HttpGet]
        public IEnumerable<RegisterTbl> GetLogins()
        {
            return db.RegisterTbls;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            var token = iJWTMangerRepository.Authenicate(loginViewModel, false);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            LoginViewModel login = new LoginViewModel();
            login.UserName = registerViewModel.UserName;
            login.Password = registerViewModel.Password;
            login.PhoneNo = registerViewModel.PhoneNo;
            login.Email = registerViewModel.Email;
            login.Address = registerViewModel.Address;
            var token = iJWTMangerRepository.Authenicate(login, true);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}

