using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Article
    {
        public Article CreateArticleMaster(Article _objCreate)
        {
            try
            {
                if (_objCreate != null)
                {
                    //Check Duplicate 

                    using (LocalEntity _context = new LocalEntity())
                    {
                        var Art = _context.tblArticles.OrderByDescending(x => x.ArtId).FirstOrDefault();
                        int intMaxId = 1;
                        if (Art != null)
                        { intMaxId = Art.ArtId + 1; }
                       // string strArtCode = "Art00" + intMaxId;

                        _context.tblArticles.Add(new tblArticle
                        {
                            ArtId = intMaxId,
                            Desc = _objCreate.Desc,
                            ArtNo = _objCreate.ArtNo,
                            Rate = _objCreate.Rate,
                            Unit = _objCreate.Unit,
                            WorkOrderDesc = _objCreate.WorkOrderDesc,
                            IsActive = _objCreate.IsActive,
                            CreatedBy = "System",
                            CreatedOn = DateTime.Now
                        });
                        if (_context.SaveChanges() == 1)
                        {
                            _objCreate.Code = Models.MessageCode.Success;
                            _objCreate.MessageText = _objCreate.ArtNo + " has been created successfully.";
                        }
                        else
                        {
                            _objCreate.Code = Models.MessageCode.Error;
                            _objCreate.MessageText = "Not Created. Pleases contact administor !!";
                        }
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _objCreate;
        }
        public Article UpdateArticleMaster(Article _objUpdate)
        {
            try
            {
                if (_objUpdate != null & _objUpdate.ArtId > 0)
                {
                    using (LocalEntity _context = new LocalEntity())
                    {
                        var obj = _context.tblArticles.Find(_objUpdate.ArtId);
                        if (obj != null)
                        {
                            if (!string.IsNullOrWhiteSpace(_objUpdate.ArtNo) && _objUpdate.ArtNo != obj.ArtNo)
                                obj.ArtNo = _objUpdate.ArtNo;

                            if (!string.IsNullOrWhiteSpace(_objUpdate.Desc) && _objUpdate.Desc != obj.Desc)
                                obj.Desc = _objUpdate.Desc;

                            if (!string.IsNullOrWhiteSpace(_objUpdate.WorkOrderDesc) && _objUpdate.WorkOrderDesc != obj.WorkOrderDesc)
                                obj.WorkOrderDesc = _objUpdate.WorkOrderDesc;

                            if (!string.IsNullOrWhiteSpace(_objUpdate.Unit) && _objUpdate.Unit != obj.Unit)
                                obj.Unit = _objUpdate.Unit;

                            // if (_objUpdate.Rate > 0 && _objUpdate.Email != obj.Email)
                            obj.Rate = _objUpdate.Rate;

                            if (!string.IsNullOrWhiteSpace(_objUpdate.ArtNo) && _objUpdate.ArtNo != obj.ArtNo)
                                obj.ArtNo = _objUpdate.ArtNo;


                            obj.IsActive = _objUpdate.IsActive;



                            if (_context.SaveChanges() == 1)
                            {
                                _objUpdate.Code = Models.MessageCode.Success;
                                _objUpdate.MessageText = _objUpdate.ArtNo + " has been updated successfully.";
                            }
                            else
                            {
                                _objUpdate.Code = Models.MessageCode.Error;
                                _objUpdate.MessageText = "Not Updated. Pleases contact administor !!";
                            }
                            return _objUpdate;
                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            return _objUpdate;
        }
        public List<ArticleRS> GetArticle(ArticleRQ _objSearch)
        {

            List<ArticleRS> _lstArtMaster = new List<ArticleRS>();
            try
            {
                using (LocalEntity _context = new LocalEntity())
                {
                    var search = _context.tblArticles.AsQueryable();
                    if (!string.IsNullOrWhiteSpace(_objSearch.Desc))
                    {
                        search = (from x in search
                                  where x.Desc.Contains(_objSearch.Desc)
                                  select x);
                    }
                    if (!string.IsNullOrWhiteSpace(_objSearch.ArtNo))
                    {
                        search = (from x in search
                                  where x.ArtNo == _objSearch.ArtNo
                                  select x);
                    }
                    _lstArtMaster = (from s in search
                                     select new ArticleRS()
                                     {
                                         ArtId = s.ArtId,
                                         ArtNo = s.ArtNo,
                                         Desc = s.Desc

                                     }).OrderBy(x => x.Desc).ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
            return _lstArtMaster;
        }
        public Article GetArticleByID(ArticleRQ _objSearch)
        {

            Article _ArticleMaster = new Article();
            try
            {
                using (LocalEntity _context = new LocalEntity())
                {
                    var search = from x in _context.tblArticles select x;

                    if (_objSearch.ArtId > 0)
                    {
                        search = from x in search where x.ArtId == _objSearch.ArtId select x;
                    }
                    if (!string.IsNullOrWhiteSpace(_objSearch.ArtNo))
                    {
                        search = from x in search where x.ArtNo == _objSearch.ArtNo select x;
                    }

                    _ArticleMaster = (from s in search
                                      select new Article()
                                      {
                                          ArtId = s.ArtId,
                                          Desc = s.Desc,
                                          ArtNo = s.ArtNo,
                                          Rate = s.Rate,
                                          Unit = s.Unit,
                                          WorkOrderDesc = s.WorkOrderDesc,
                                          IsActive = s.IsActive
                                      }).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return _ArticleMaster;
        }
        public List<ArticleWithDescRS> GetArticleForInvoice(ArticleRQ _objSearch)
        {
            List<ArticleWithDescRS> _lstArtMaster = new List<ArticleWithDescRS>();
            try
            {
                using (LocalEntity _context = new LocalEntity())
                {
                    _lstArtMaster = (from a in _context.tblArticles
                                     select new ArticleWithDescRS()
                                     {
                                         ArtId = a.ArtId,
                                         ArtNo = a.ArtNo,
                                         ArtNoWithDesc = a.Desc
                                     }
                                    ).ToList();

                    return _lstArtMaster;
                }
            }
            catch (Exception) { }
            return _lstArtMaster;
        }
    }
}
