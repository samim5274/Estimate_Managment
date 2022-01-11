using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuySallsProject
{
    public class Manager
    {
        public List<CatagoryInfo> GettAllCatagory()
        {
            var context = new ESTIMATEEntities();
            var q = from cat in context.CatagoryInfoes select cat;
            return q.ToList();
        }

        public List<CustomarInfo> GetCustomer()
        {
              var context = new ESTIMATEEntities();
            var q = from cus in context.CustomarInfoes
                    select cus;
            return q.ToList();
        }

        public List<SP_ItemSelection_Result> GetItem(int cateId)
        {
            var context = new ESTIMATEEntities();
            var q = context.SP_ItemSelection(cateId).ToList();
            return q.ToList();
        }

        public List<ItemInfo> GetAllItem()
        {
            var context = new ESTIMATEEntities();
            var q = from item in context.ItemInfoes
                    select item;
            return q.ToList();
        }

        public List<SP_ItemSelection_Result> GetAllItem(int catId)
        {
            var context = new ESTIMATEEntities();
            var q = context.SP_ItemSelection(catId).ToList();
            return q.ToList();
        }

        internal object GettCustomar()
        {
            var context = new ESTIMATEEntities();
            var q = from c in context.CustomarInfoes select c;
            return q.ToList();
        }

        internal object GettAllItem()
        {
            var context = new ESTIMATEEntities();
            var q = from i in context.ItemInfoes select i;
            return q.ToList();
        }

        internal object GettAllDepartment()
        {
            var context = new ESTIMATEEntities();
            var q = from d in context.EmpolyDipartments select d;
            return q.ToList();
        }

        internal object GetAllEmployName()
        {
            var context = new ESTIMATEEntities();
            var q = from EN in context.EmpolyInfoes select EN;
            return q.ToList();
        }
    }
}
