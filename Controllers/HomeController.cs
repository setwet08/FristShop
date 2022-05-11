using Newtonsoft.Json;
using sampleEco.DAL;
using sampleEco.Models;
using sampleEco.Models.Home;
using sampleEco.Repository;
using sampleEco.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace sampleEco.Controllers
{
    public class HomeController : Controller
    {
        dbFirstSpEntities ctx = new dbFirstSpEntities();
        public ActionResult Index(string search, int? page)
        {
            HomeIndexViewModel model = new HomeIndexViewModel();

            return View(model.CreateModel(search, 4, page));
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult CheckoutDetails()
        {
            return View();
        }
        public ActionResult Paymentsucess()
        {
            return View();
        }

        public ActionResult AddToCart(int productId)
        {
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                var product = ctx.tbl_product.Find(productId);
                cart.Add(new Item()
                {
                    product = product,
                    Quantity = 1
                });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                var product = ctx.tbl_product.Find(productId);
                foreach (var item in cart)
                {
                    if (item.product.productId == productId)
                    {
                        int prevQty = item.Quantity;
                        cart.Remove(item);
                        cart.Add(new Item()
                        {
                            product = product,
                            Quantity = prevQty + 1
                        });
                        break;
                    }
                    else
                    {
                        cart.Add(new Item()
                        {
                            product = product,
                            Quantity = 1
                        }) ;
                    }
                }
                Session["cart"] = cart;
            }
            return Redirect("Index");
        }
            public ActionResult RemoveFromCart(int productId)
            {
                List<Item> cart = (List<Item>)Session["cart"];
                foreach (var item in cart)
                {
                    if (item.product.productId == productId)
                    {
                        cart.Remove(item);
                        break;
                    }
                }
                Session["cart"] = cart;
                return Redirect("Index");
            }
       
    }
    }
