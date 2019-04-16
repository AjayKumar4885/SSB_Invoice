using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_RefillInkMaster
    {
        public List<RefillInk> GetRefillInks(RefillInk_RQ refillInk_RQ)
        {
            List<RefillInk> lstrefillInks = new List<RefillInk>();
            try
            {

                using (LocalEntity localEntity = new LocalEntity())
                {
                    var search = localEntity.tblRefillInks.Select(x => x).AsQueryable();
                    if (refillInk_RQ.id != 0)
                        search = from x in search where x.id == refillInk_RQ.id select x;
                    if (!string.IsNullOrWhiteSpace(refillInk_RQ.RefillInkColor))
                        search = from x in search where x.RefillInkColor.Contains(x.RefillInkColor) select x;

                    lstrefillInks = (from x in search
                                     select new RefillInk()
                                     {
                                         id = x.id,
                                         RefillInkColor = x.RefillInkColor,
                                         CreatedBy = x.CreatedBy,
                                         CreatedOn = x.CreatedOn,
                                         IsActive = x.IsActive,
                                         ModifiedBy = x.ModifiedBy,
                                         ModifiedOn = x.ModifiedOn
                                     }).OrderBy(x=>x.RefillInkColor).ToList();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lstrefillInks;

        }

        public RefillInk AddRefillInk(RefillInk _objCreate)
        {
            RefillInk _objResult = new RefillInk();
            try
            {
                if (_objCreate != null)
                {
                    using (LocalEntity localEntity = new LocalEntity())
                    {
                        var isExist = (from x in localEntity.tblRefillInks where x.RefillInkColor.ToLower() == _objCreate.RefillInkColor.ToLower() select x);
                        if (isExist != null && isExist.Count() > 0)
                        {
                            _objResult.MessageText = "Refill Ink " + _objCreate.RefillInkColor + "is already exist !!";
                        }
                        else
                        {
                            localEntity.tblRefillInks.Add(new tblRefillInk
                            {
                                RefillInkColor = _objCreate.RefillInkColor,
                                CreatedBy = _objCreate.CreatedBy,
                                CreatedOn = _objCreate.CreatedOn,
                                IsActive = _objCreate.IsActive
                            });
                            if(localEntity.SaveChanges() == 1)
                            {
                                _objResult.Code = Models.MessageCode.Success;
                                _objResult.MessageText = "Refill Ink " + _objCreate.RefillInkColor + " has been created successfully.";
                            }
                            else
                            {
                                _objResult.Code = Models.MessageCode.Failed;
                                _objResult.MessageText = "Not Created. Please contact System Admin.";
                            }
                        }
                    }
                }
                else
                {
                    _objResult.MessageText = "Please add refillink to create !";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return _objResult;
        }

        public RefillInk UpdateRefillInk(RefillInk _objUpdate)
        {
            RefillInk _objResult = new RefillInk();
            try
            {
                if (_objUpdate != null)
                {
                    using (LocalEntity localEntity = new LocalEntity())
                    {
                        var isExist = (from x in localEntity.tblRefillInks
                                       where x.RefillInkColor.ToLower() == _objUpdate.RefillInkColor.ToLower() 
                                          && x.id != _objUpdate.id select x);
                        if (isExist != null && isExist.Count() > 0)
                        {
                            _objResult.MessageText = "Refill Ink " + _objUpdate.RefillInkColor + "is already exist !!";
                        }
                        else
                        {
                            var result = localEntity.tblRefillInks.Find(_objUpdate.id);
                            if(result != null)
                            {
                                result.RefillInkColor = result.RefillInkColor == _objUpdate.RefillInkColor ? result.RefillInkColor : _objUpdate.RefillInkColor;
                                result.IsActive = _objUpdate.IsActive;
                                result.ModifiedBy = _objUpdate.ModifiedBy;
                                result.ModifiedOn = _objUpdate.ModifiedOn; 
                                
                            }
                            if (localEntity.SaveChanges() == 1)
                            {
                                _objResult.Code = Models.MessageCode.Success;
                                _objResult.MessageText = "Refill Ink " + _objUpdate.RefillInkColor + " has been updated successfully.";
                            }
                            else
                            {
                                _objResult.Code = Models.MessageCode.Failed;
                                _objResult.MessageText = "Not Updated. Please contact System Admin.";
                            }
                        }
                    }
                }
                else
                {
                    _objResult.MessageText = "Please modified refillink to update !";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return _objResult;
        }
    }
}
