using SampleSinglePage.Models.DomainModels.DTO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleSinglePage.Models.ViewModels
{
    public class ProductViewModel
    {
        #region [-Ctor-]
        public ProductViewModel()
        {
            Ref_ProductCrud = new DomainModels.POCO.ProductCrud();
            Ref_Product = new DomainModels.DTO.EF.Product();
        }
        #endregion
        #region [-Props-]
        #region [-Props For Class-]
        public Models.DomainModels.POCO.ProductCrud Ref_ProductCrud { get; set; }
        public Models.DomainModels.DTO.EF.Product Ref_Product { get; set; }
        #endregion

        #region [-Props For Model-]
        public int Id { get; set; }
        public string Title { get; set; }

        public int Categoryref { get; set; }
        public DomainModels.DTO.EF.Category Ref_Category { get; set; }

        #endregion
        #endregion
        #region [-Tasks-]

        #region [-SelectProducts()-]
        public List<ProductViewModel> SelectProducts()
        {
            var q= Ref_ProductCrud.Select();
            ViewModels.ProductViewModel Ref_ProductViewModels = new ProductViewModel();
            var productViewModelList = q.Select(p => new ProductViewModel()
            {
                Id = p.Id,
                Categoryref = p.CategoryRef.Value,
                Ref_Category = p.Category,
                Title = p.Title,
           
            }).ToList();
            return productViewModelList;
        }
        #endregion

        #region [-InsertProduct(ProductViewModel Ref_ProductViewModel)-]
        public void InsertProduct(ProductViewModel Ref_ProductViewModel)
        {
            Ref_Product.Title = Ref_ProductViewModel.Title;
            Ref_Product.CategoryRef = Ref_ProductViewModel.Categoryref;
            Ref_ProductCrud.Insert(Ref_Product);
        }
        #endregion

        #region [-update(ProductViewModel Ref_ProductViewModel)-]
        public void update(ProductViewModel Ref_ProductViewModel)
        {
            Ref_Product.Id = Ref_ProductViewModel.Id;
            Ref_Product.Title = Ref_ProductViewModel.Title;
            Ref_ProductCrud.Update(Ref_Product);
        }
        #endregion

        #region [-Delete(ProductViewModel Ref_ProductViewModel)-]
        public void Delete(ProductViewModel Ref_ProductViewModel)
        {
            Ref_ProductCrud.Delete(Ref_ProductViewModel.Id);
        }
        #endregion

        #region [-SelectCategoris()-]
        public List<Category> SelectCategoris()
        {
            return Ref_ProductCrud.Findcategories();
        }
        #endregion 
        #endregion

    }

   
}