using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo12.Repository;
using ReflectionIT.Mvc.Paging;

namespace ProjectDemo12.Controllers
{
    public class MetaDataController : Controller
    {
        MetaDataRepository metaDataRepository = new MetaDataRepository();

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
                    dynamic querySearch = metaDataRepository.findMetadatas(txtSearch);

                    if (querySearch != null)
                    {
                        ViewBag.SearchValue = txtSearch;
                        return View(await PagingList.CreateAsync(querySearch, 10, page));
                    }
                    else
                    {
                        ViewBag.Empty("Not Found.");
                        return View();
                    }
                }

                dynamic query = metaDataRepository.GetMetadatas;
                return View(await PagingList.CreateAsync(query, 10, page));
            }
        }
    }
}