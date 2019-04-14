using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PartyMaster
    {
        public PartyMaster CreatepartyMaster(PartyMaster _objCreate)
        {
            try
            {
                if (_objCreate != null)
                {
                    //Check Duplicate 

                    using (LocalEntity _context = new LocalEntity())
                    {
                        var party = _context.tblPartyMasters.OrderByDescending(x => x.PartyId).FirstOrDefault();
                        int intMaxId = 1;
                        if (party != null)
                        { intMaxId = party.PartyId + 1; }
                        string strPartyCode = "Party00" + intMaxId;

                        _context.tblPartyMasters.Add(new tblPartyMaster
                        {
                            PartyId = intMaxId,
                            PartyCode = strPartyCode,
                            ContactPerson = _objCreate.ContactPerson,
                            Address = _objCreate.Address,
                            Phone = _objCreate.Phone,
                            Mobile = _objCreate.Mobile,
                            Fax = _objCreate.Fax,
                            Email = _objCreate.Email,
                            Pager = _objCreate.Pager,
                            PartyName = _objCreate.PartyName,
                            IsActive = _objCreate.IsActive,
                            CreatedBy = "System",
                            CreatedOn = DateTime.Now
                        });
                        if (_context.SaveChanges() == 1)
                        {
                            _objCreate.Code = Models.MessageCode.Success;
                            _objCreate.MessageText = _objCreate.PartyName + " has been created successfully.";
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
        public PartyMaster UpdatePartyMaster(PartyMaster _objUpdate)
        {
            try
            {
                if (_objUpdate != null & _objUpdate.PartyId > 0)
                {
                    using (LocalEntity _context = new LocalEntity())
                    {
                        var obj = _context.tblPartyMasters.Find(_objUpdate.PartyId);
                        if (obj != null)
                        {
                            if (!string.IsNullOrWhiteSpace(_objUpdate.PartyName) && _objUpdate.PartyName != obj.PartyName)
                                obj.PartyName = _objUpdate.PartyName;

                            if (!string.IsNullOrWhiteSpace(_objUpdate.Address) && _objUpdate.Address != obj.Address)
                                obj.Address = _objUpdate.Address;

                            if (!string.IsNullOrWhiteSpace(_objUpdate.ContactPerson) && _objUpdate.ContactPerson != obj.ContactPerson)
                                obj.ContactPerson = _objUpdate.ContactPerson;

                            if (!string.IsNullOrWhiteSpace(_objUpdate.Email) && _objUpdate.Email != obj.Email)
                                obj.Email = _objUpdate.Email;

                            if (!string.IsNullOrWhiteSpace(_objUpdate.Fax) && _objUpdate.Fax != obj.Fax)
                                obj.Fax = _objUpdate.Fax;

                            if (!string.IsNullOrWhiteSpace(_objUpdate.Mobile) && _objUpdate.Mobile != obj.Mobile)
                                obj.Mobile = _objUpdate.Mobile;

                            if (!string.IsNullOrWhiteSpace(_objUpdate.Pager) && _objUpdate.Pager != obj.Pager)
                                obj.Pager = _objUpdate.Pager;

                            if (!string.IsNullOrWhiteSpace(_objUpdate.Phone) && _objUpdate.Phone != obj.Phone)
                                obj.Phone = _objUpdate.Phone;

                            obj.IsActive = _objUpdate.IsActive;



                            if (_context.SaveChanges() == 1)
                            {
                                _objUpdate.Code = Models.MessageCode.Success;
                                _objUpdate.MessageText = _objUpdate.PartyName + " has been updated successfully.";
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
        public List<PartyMasterRS> GetPartyMaster(PartyMasterRQ _objSearch)
        {

            List<PartyMasterRS> _lstPartyMaster = new List<PartyMasterRS>();
            try
            {
                using (LocalEntity _context = new LocalEntity())
                {
                    var search = _context.tblPartyMasters.AsQueryable();
                    if (!string.IsNullOrWhiteSpace(_objSearch.PartyName))
                    {
                        search = (from x in search
                                  where x.PartyName.Contains(_objSearch.PartyName)
                                  select x);
                    }
                    if (!string.IsNullOrWhiteSpace(_objSearch.PartyCode))
                    {
                        search = (from x in search
                                  where x.PartyCode == _objSearch.PartyCode
                                  select x);
                    }
                    _lstPartyMaster = (from s in search
                                       select new PartyMasterRS()
                                       {
                                           PartyCode = s.PartyCode,
                                           PartyName = s.PartyName,
                                           PartyId = s.PartyId

                                       }).OrderBy(x => x.PartyName).ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
            return _lstPartyMaster;
        }
        public PartyMaster GetPartyMasterByID(PartyMasterRQ _objSearch)
        {

            PartyMaster _PartyMaster = new PartyMaster();
            try
            {
                using (LocalEntity _context = new LocalEntity())
                {

                    var search = from s in _context.tblPartyMasters select s;

                    if(_objSearch.PartyId > 0)
                    {
                        search = from s in search where s.PartyId == _objSearch.PartyId select s;
                    }
                    if (!string.IsNullOrWhiteSpace(_objSearch.PartyCode))
                    {
                        search = from s in search where s.PartyCode == _objSearch.PartyCode select s;

                    }

                    _PartyMaster = (from s in search
                                    select new PartyMaster()
                                    {
                                        PartyCode = s.PartyCode,
                                        PartyName = s.PartyName,
                                        PartyId = s.PartyId,
                                        Address = s.Address,
                                        ContactPerson = s.ContactPerson,
                                        Email = s.Email,
                                        Fax = s.Fax,
                                        IsActive = s.IsActive,
                                        Mobile = s.Mobile,
                                        Pager = s.Pager,
                                        Phone = s.Phone
                                    }).FirstOrDefault();

                }
            }
            catch (Exception)
            {

                throw;
            }
            return _PartyMaster;
        }
    }
}
