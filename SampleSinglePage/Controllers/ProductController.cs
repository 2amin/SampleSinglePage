using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleSinglePage.Controllers
{
   
    public class ProductController : Controller
    {
        #region [-ctor-]
        public ProductController()
        {
            Ref_ProductViewModels = new Models.ViewModels.ProductViewModel();
        }
        #endregion

        #region [-Props-]
        public Models.ViewModels.ProductViewModel Ref_ProductViewModels { get; set; }
        #endregion

        #region [-Actions-]
        #region [-Index()-]
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
      

            return View(Ref_ProductViewModels);
        }

        #endregion

        #region [-Create(Models.ViewModels.ProductViewModel Ref_ProductViewModel)-]
        [HttpPost]
        [AllowAnonymous]
        [Route("Create")]
        public ActionResult Create(Models.ViewModels.ProductViewModel Ref_ProductViewModel)
        {
            if (ModelState.IsValid)
            {
                                                                        
                
                Ref_ProductViewModels.InsertProduct(Ref_ProductViewModel);
                return Json(new { Message = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { ModelState_IsValid = "False", JsonRequestBehavior.AllowGet });
            }

        }
        #endregion 


        #endregion
    }
}