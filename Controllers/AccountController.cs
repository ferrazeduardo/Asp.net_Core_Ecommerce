﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signManager)
        {
            _userManager = userManager;
            _signInManager = signManager;
        }

        //implementar login, registro e logout
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel()
            {
                ReturnUrl = returnUrl
            });
        }
        /*receber os dados da pagina login*/
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
                return View(loginVM);

            var user = await _userManager.FindByNameAsync(loginVM.UserName);

            if(user !=null )
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                if(result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginVM.ReturnUrl))//se returnUrl for null ele vai pra pagina inicial
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    return Redirect(loginVM.ReturnUrl);//se não ele volta pra pagina de login
                }
            }

            ModelState.AddModelError("", "Usuário/Senha inválidos ou não localizados!!");
            return View(loginVM);
        }

        /*metodo register get*/
        public IActionResult Register()
        {
            return View();
        }

        /*metodo register post*/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginViewModel registerVM){

            if(ModelState.IsValid){
                var user = new IdentityUser(){UserName = registerVM.UserName};

                var result =    await _userManager.CreateAsync(user, registerVM.Password);

                if(result.Succeeded){
                    return RedirectToAction("Index","Home");
                }
            }

            return View(registerVM);
        }  

        /*Metodo Logout*/
        [HttpPost]
        public async Task<IActionResult> Logout(){

            await _signInManager.SignOutAsync();
            
            return RedirectToAction("Index","Home");
        }      
    }
}