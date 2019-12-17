﻿using System.Threading.Tasks;
using Ecommerce.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;//serve para autenticação

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signManager)
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("UserName","Password","ReturnUrl")]LoginViewModel loginVM)
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
        public async Task<IActionResult> Register(RegisterViewModel registerVM){

            if(ModelState.IsValid){

                var user = new ApplicationUser(){
                    UserName = registerVM.UserName
                };

                // var user = new IdentityUser(){UserName = registerVM.UserName};

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