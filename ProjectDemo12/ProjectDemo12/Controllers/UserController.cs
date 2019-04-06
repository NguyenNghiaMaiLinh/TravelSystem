using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo12.Models;
using ProjectDemo12.Repository;
using ReflectionIT.Mvc.Paging;

namespace ProjectDemo12.Controllers
{
    public class UserController : Controller
    {
        UserRepository userRepository = new UserRepository();

        public async Task<IActionResult> Index(string txtSearch, int page = 1)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSearch))
                {
                    dynamic querySearch = userRepository.findUsers(txtSearch);
                    if (querySearch != null)
                    {
                        ViewBag.SearchValue = txtSearch;
                        ViewBag.CountUser = userRepository.getCountUsers();
                        return View(await PagingList.CreateAsync(querySearch, 10, page));
                    }
                    else
                    {
                        ViewBag.Empty("Not Found.");
                        return View();
                    }
                }
                ViewBag.CountUser = userRepository.getCountUsers();
                dynamic query = userRepository.GetAllUsers;
                return View(await PagingList.CreateAsync(query, 10, page));
            }
        }


        [HttpGet]
        public IActionResult Delete(string Id)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (Id == null)
                {
                    //Error
                    return NotFound();
                }
                else
                {
                    User model = userRepository.GetUser(Id);
                    return View(model);
                }
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(string Username)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                userRepository.Remove(Username);
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Details(string Id)
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                return View(userRepository.GetUser(Id));
            }
        }

    }
}
