using sampleEco.DAL;
using sampleEco.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace sampleEco.Models.Home
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        dbFirstSpEntities context = new dbFirstSpEntities();
        public IPagedList<tbl_product> ListOfProducts { get; set; }
        public HomeIndexViewModel CreateModel(string search, int pageSize,int? page)

        {
            SqlParameter[] pram = new SqlParameter[] {
                   new SqlParameter("@search",search??(object)DBNull.Value)
                   };
            IPagedList<tbl_product> data = context.Database.SqlQuery<tbl_product>("GetBySearch @search",pram).ToList().ToPagedList(page ?? 1, pageSize);
            return new HomeIndexViewModel
           
            {
                ListOfProducts = data
            };
        }
    }
}