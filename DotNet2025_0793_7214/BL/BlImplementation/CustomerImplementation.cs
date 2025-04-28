using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;

namespace BlImplementation;

internal class CustomerImplementation : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Customer item)
    {
        return _dal.Customer.Create(BO.Tools.convertToDoCustomer(item));
    }

    public void Delete(int id)
    {
        _dal.Customer.Delete(id);
    }

    public bool IsCustomerExist(int id)
    {
        try
        {
            Read(id);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public BO.Customer Read(int id)
    {
        try
        {
            return BO.Tools.convertToBoCustomer(_dal.Customer.Read(id));
        }
        catch(Exception e) 
        {
            throw new Exception(e.Message);
        }
    }

    public List<BO.Customer> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        if(filter == null)
        {
            return _dal.Customer.ReadAll().Select(c => BO.Tools.convertToBoCustomer(c)).ToList();
        }
        return _dal.Customer.ReadAll(cust => filter(BO.Tools.convertToBoCustomer(cust)))
        .Select(p => BO.Tools.convertToBoCustomer(p)).ToList();

    }

    public void Update(BO.Customer item)
    {
        DO.Customer c = BO.Tools.convertToDoCustomer(item);
        _dal.Customer.Update(c);
    }
}
