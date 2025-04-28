using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Sale item)
        {
            try
            {
                return _dal.Sale.Create(BO.Tools.convertToDoSale(item));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Delete(int id)
        {
            _dal.Sale.Delete(id);
        }

        public BO.Sale Read(int id)
        {
            return BO.Tools.convertToBoSale(_dal.Sale.Read(id));
        }

        public List<BO.Sale> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            if (filter == null)
            {
                return _dal.Sale.ReadAll().Select(s => BO.Tools.convertToBoSale(s)).ToList();
            }
            return _dal.Sale.ReadAll(sale => filter(BO.Tools.convertToBoSale(sale)))
            .Select(s => BO.Tools.convertToBoSale(s)).ToList();

        }

        public void Update(BO.Sale item)
        {
            DO.Sale s = BO.Tools.convertToDoSale(item);
            _dal.Sale.Update(s);
        }
    }
}
