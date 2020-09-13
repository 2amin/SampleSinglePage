using SampleSinglePage.Models.DomainModels.DTO.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleSinglePage.Models.DomainModels.POCO
{
    public class ProductCrud
    {
        #region [-ctor-]
        public ProductCrud()
        {

        }
        #endregion

        #region [- Tasks -]

        #region [- Select() -]
        public List<Models.DomainModels.DTO.EF.Product> Select()
        {
            using (var context = new Models.DomainModels.DTO.EF.OnlineStoreEntities())
            {
                try
                {
                    var q = context.Products.Include(p => p.Category).ToList();
                    return q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Insert(Category ref_category) -]
        public void Insert(DTO.EF.Product Ref_Product)
        {
            using (var context = new DTO.EF.OnlineStoreEntities())
            {
                try
                {
                    context.Products.Add(Ref_Product);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- FindId(int? id) -]
        public Product FindCategory(int? id)
        {
            using (var context = new DTO.EF.OnlineStoreEntities())
            {
                try
                {
                    var q = context.Products.Find(id);
                    return q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Update(Product Ref_Product) -]
        public void Update(Product Ref_Product)
        {
            using (var context = new OnlineStoreEntities())
            {
                try
                {
                    context.Entry(Ref_Product).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Delete(int id) -]
        public void Delete(int id)
        {
            using (var context = new DTO.EF.OnlineStoreEntities())
            {
                try
                {
                    var q = context.Products.Find(id);
                    context.Products.Remove(q);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Findcategories()-]
        public List<Category> Findcategories()
        {
            using (var context = new DTO.EF.OnlineStoreEntities())
            {
                try
                {
                    return context.Categories.ToList();

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }

        } 
        #endregion

        #endregion
    }

}