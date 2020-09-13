using SampleSinglePage.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleSinglePage.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        #region [- ctor -]
        public CategoryController()
        {
            Ref_CategoryViewModel = new Models.ViewModels.CategoryViewModel();
        }
        #endregion

        #region [- Props -]

        public Models.ViewModels.CategoryViewModel Ref_CategoryViewModel { get; private set; }

        #endregion

        #region [- Actions -]

        #region [- Category() -]
        public ActionResult Category()
        {
            return View(Ref_CategoryViewModel);
        }
        #endregion

        #region [- Create() -]
        [HttpPost]
        // [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Create(CategoryViewModel ref_CategoryViewModel)
        {

            if (ModelState.IsValid)
            {
                Ref_CategoryViewModel.PostCategory(ref_CategoryViewModel);
                return Json(new { Message = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    ModelState_IsValid = "False",
                    JsonRequestBehavior.AllowGet
                });
            }
        }
        #endregion

        #endregion
    }
}