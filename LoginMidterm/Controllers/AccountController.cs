using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginMidterm.Models;
using System.Data.SqlClient;
using DataLibrary;
using static DataLibrary.Logic.RegisterProcessor;

namespace LoginMidterm.Controllers
{
    public class AccountController : Controller
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        // GET: Account
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString ="data source=NEW\\SQLEXPRESS;database=usr;integrated security=SSPI;";
        }
        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText ="select id from Login where username='"+acc.Name+"' and password='"+acc.Password+"'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                int id = (int)dr["id"];
                con.Close();
                return View("Register");
            }
            else
            {
                con.Close();
                return View("Register");
            }


        }
        

        [HttpPost]
        public ActionResult Register(Registration model)
        {
            
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateRegistration(
                    model.UserId,
                    model.FirstName,
                    model.LastName,
                    model.Email,
                    model.Subject,
                    model.PhoneNum);
                return RedirectToAction("Final");
            }
            return View("Final");
        
            

        }
    }
            
        }
