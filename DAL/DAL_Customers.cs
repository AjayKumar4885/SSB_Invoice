using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Customers
    {

        public Customers GetCustomersById(RQ_Customer _objcust)
        {
            if (_objcust.CustId != null)
            {
                using (LocalEntity _context = new LocalEntity())
                {
                    //var search = _context.tblCustomers.();
                    var search = (from x in _context.tblCustomers
                                  where x.Id == _objcust.CustId
                                  select x).AsQueryable();
                    var result = (from s in search
                                  select new Customers
                                  {
                                      Id = s.Id,
                                      Address = s.Address,
                                      ContactPerson = s.ContactPerson,
                                      Country = s.Country,
                                      CustomerCode = s.CustomerCode,
                                      CustomerName = s.CustomerName,
                                      IsActive = s.IsActive ?? true,
                                      MobileNo = s.MobileNo
                                  }).FirstOrDefault();
                    return result;
                }

            }
            return new Customers() { };
        }
        public List<RS_Customers> GetCustomers(RQ_Customer _objcust)
        {
            List<RS_Customers> _lstCust = new List<RS_Customers>();
            try
            {
                using (LocalEntity _context = new LocalEntity())
                {
                    var search = _context.tblCustomers.AsQueryable();
                    if (!string.IsNullOrWhiteSpace(_objcust.CustomerName))
                    {
                        search = (from x in search
                                  where x.CustomerName == _objcust.CustomerName
                                  select x).AsQueryable();
                    }
                    if (_objcust.CustId != null)
                    {
                        search = (from x in search
                                  where x.Id == _objcust.CustId
                                  select x).AsQueryable();
                    }
                    int total = search.Count();
                    int skip = (_objcust.PageNo * (_objcust.PageSize ?? 5) ?? 0);
                    _lstCust = (from s in search
                                select new RS_Customers()
                                {
                                    Id = s.Id,
                                    Address = s.Address,
                                    ContactPerson = s.ContactPerson,
                                    Country = s.Country,
                                    CustomerCode = s.CustomerCode,
                                    CustomerName = s.CustomerName,
                                    IsActive = s.IsActive ?? true,
                                    MobileNo = s.MobileNo

                                }).OrderBy(x => x.CustomerName).Skip(skip).ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
            return _lstCust;
        }
        public Customers CreateCust(Customers _objcust)
        {
            try
            {
                if (_objcust != null)
                {
                    //Check Duplicate 

                    using (LocalEntity _context = new LocalEntity())
                    {
                        var cust = _context.tblCustomers.OrderByDescending(x => x.Id).FirstOrDefault();
                        int intMaxId = 1;
                        if (cust != null)
                        { intMaxId = cust.Id + 1; }
                        string strCustCode = "Cust00" + intMaxId;

                        _context.tblCustomers.Add(new tblCustomer()
                        {
                            Id = intMaxId,
                            Address = _objcust.Address,
                            ContactPerson = _objcust.ContactPerson,
                            Country = _objcust.Country,
                            CreatedBy = _objcust.CreatedBy,
                            CreatedOn = _objcust.CreatedOn,
                            CustomerCode = strCustCode,
                            CustomerName = _objcust.CustomerName,
                            IsActive = true,
                            MobileNo = _objcust.MobileNo
                        });
                        if (_context.SaveChanges() == 1)
                        {
                            _objcust.Code = Models.MessageCode.Success;
                            _objcust.MessageText = _objcust.CustomerName + " has been created successfully.";
                        }
                        else
                        {
                            _objcust.Code = Models.MessageCode.Error;
                            _objcust.MessageText = "Not Created. Pleases contact administor !!";
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
            return _objcust;
        }
        public Customers UpdateCustomer(Customers _objcust)
        {
            try
            {
                if (_objcust != null & _objcust.Id > 0)
                {
                    using (LocalEntity _context = new LocalEntity())
                    {
                        var obj = _context.tblCustomers.Find(_objcust.Id);
                        if (obj != null)
                        {
                            if (!string.IsNullOrWhiteSpace(_objcust.CustomerName) && _objcust.CustomerName != obj.CustomerName)
                                obj.CustomerName = _objcust.CustomerName;

                            if (!string.IsNullOrWhiteSpace(_objcust.Address) && _objcust.Address != obj.Address)
                                obj.Address = _objcust.Address;

                            if (!string.IsNullOrWhiteSpace(_objcust.ContactPerson) && _objcust.ContactPerson != obj.ContactPerson)
                                obj.ContactPerson = _objcust.ContactPerson;

                            if (!string.IsNullOrWhiteSpace(_objcust.Country) && _objcust.Country != obj.Country)
                                obj.Country = _objcust.Country;

                            if (!string.IsNullOrWhiteSpace(_objcust.MobileNo) && _objcust.MobileNo != obj.MobileNo)
                                obj.MobileNo = _objcust.MobileNo;

                            //if (!string.IsNullOrWhiteSpace(_objcust.) && _objcust.CustomerName != obj.CustomerName)
                            //    obj.CustomerName = _objcust.CustomerName;

                            //if (!string.IsNullOrWhiteSpace(_objcust.CustomerName) && _objcust.CustomerName != obj.CustomerName)
                            //    obj.CustomerName = _objcust.CustomerName;

                            //if (!string.IsNullOrWhiteSpace(_objcust.CustomerName) && _objcust.CustomerName != obj.CustomerName)
                            //    obj.CustomerName = _objcust.CustomerName;

                            if (_context.SaveChanges() == 1)
                            {
                                _objcust.Code = Models.MessageCode.Success;
                                _objcust.MessageText = _objcust.CustomerName + " has been updated successfully.";
                            }
                            else
                            {
                                _objcust.Code = Models.MessageCode.Error;
                                _objcust.MessageText = "Not Updated. Pleases contact administor !!";
                            }
                            return _objcust;
                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            return _objcust;
        }



    }
}
