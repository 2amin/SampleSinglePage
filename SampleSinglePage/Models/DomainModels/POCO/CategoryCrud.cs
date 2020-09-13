using SampleSinglePage.Models.DomainModels.DTO.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleSinglePage.Models.DomainModels.POCO
{
    public class CategoryCrud
    {
        #region [- ctor -]
        public CategoryCrud()
        {

        }
      
        #endregion

        #region [- Tasks -]

        #region [- Select() -]
        public List<Models.DomainModels.DTO.EF.Category> Select()
        {
            using (var context = new Models.DomainModels.DTO.EF.OnlineStoreEntities())
            {
                try
                {
                    var q = context.Categories.ToList();
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
        public void Insert(DTO.EF.Category ref_category)
        {
            using (var context = new DTO.EF.OnlineStoreEntities())
            {
                try
                {
                    context.Categories.Add(ref_category);
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
        public Category FindCategory(int? id)
        {
            using (var context = new DTO.EF.OnlineStoreEntities())
            {
                try
                {
                    var q = context.Categories.Find(id);
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

        #region [- Update() -]
        public void Update(Category ref_category)
        {
            using (var context = new OnlineStoreEntities())
            {
                try
                {
                    context.Entry(ref_category).State = EntityState.Modified;
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
                    var q = context.Categories.Find(id);
                    context.Categories.Remove(q);
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

        #endregion
    }
}