using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using BuyFood_Template.Models;
using BuyFood_Template.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuyFood_Template.Controllers
{
    public class MemberController : Controller
    {
        public void test()
        {
            MailMessage MyMail = new MailMessage();
            MyMail.From = new MailAddress("always0537@gmail.com");
            MyMail.To.Add("always0537@gmail.com"); //設定收件者Email
            //MyMail.Bcc.Add("密件副本的收件者Mail"); //加入密件副本的Mail          
            MyMail.Subject = "Email Test";
            MyMail.Body = "<h1>HIHI</h1>"; //設定信件內容
            MyMail.IsBodyHtml = true; //是否使用html格式
            SmtpClient MySMTP = new SmtpClient("smtp.gmail.com",587);
            MySMTP.Credentials = new NetworkCredential("account", "password");
            MySMTP.EnableSsl = true;
            MySMTP.UseDefaultCredentials = true;
            try
            {
                MySMTP.Send(MyMail);
                MySMTP = null;
                MyMail.Dispose(); //釋放資源
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public string checkLogin()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString(CDictionary.CURRENT_LOGINED_USERNAME)))
                return "1";
            return "0";
        }
        public IActionResult MemberCenter()
        {

            if (!string.IsNullOrEmpty(HttpContext.Session.GetString(CDictionary.CURRENT_LOGINED_USERNAME)))
            {
                ViewBag.userName = HttpContext.Session.GetString(CDictionary.CURRENT_LOGINED_USERNAME);
                ViewBag.userPhoto = HttpContext.Session.GetString(CDictionary.CURRENT_LOGINED_USERPHOTO);
                ViewBag.memberID = HttpContext.Session.GetString(CDictionary.CURRENT_LOGINED_USERID);
                擺腹BuyFoodContext dbcontext = new 擺腹BuyFoodContext();
                TMember data = dbcontext.TMembers.FirstOrDefault(n => n.CMemberId == int.Parse(HttpContext.Session.GetString(CDictionary.CURRENT_LOGINED_USERID)));

                return View(new MemberCenterViewModel(data));
            }
            ViewBag.memberID = 2;

            擺腹BuyFoodContext ccc = new 擺腹BuyFoodContext();
            TMember ddd = ccc.TMembers.FirstOrDefault(n => n.CMemberId ==2);
            return View(new MemberCenterViewModel(ddd));

            //else {
            //    HttpContext.Session.SetString(CDictionary.REDIRECT_FROM_MEMBERCENTER, "1");
            //    return RedirectToAction("登入", "HomePage");
            //}
        }

        public JsonResult updateMemberCenter(string id)
        {
            擺腹BuyFoodContext dbcontext = new 擺腹BuyFoodContext();
            var issueCombo = dbcontext.TComboDetails
                    .Where(n => n.CCombo.CMemberId == int.Parse(id))
                    .Select(n => new {
                        comboID = n.CComboId,
                        productID = n.CProduct.CProductId,
                        productOn = n.CProduct.CIsOnSaleId
                    })
                    .GroupBy(n => n.comboID)
                    .Select(n => new
                    {
                        comboID = n.Key,
                        issueItem = n.Count(p => p.productOn == 3)
                    });

            return Json(issueCombo);
        }

        [HttpPost]
        public JsonResult saveProfile([FromBody] TMember member)
        {
            擺腹BuyFoodContext dbcontext = new 擺腹BuyFoodContext();
            TMember data = dbcontext.TMembers.FirstOrDefault(n => n.CMemberId == member.CMemberId);
            data.CName = member.CName;
            dbcontext.SaveChanges();
            return Json(data);
        }

        public void logout()
        {
            HttpContext.Session.Remove(CDictionary.CURRENT_LOGINED_USERID);
            HttpContext.Session.Remove(CDictionary.CURRENT_LOGINED_USERNAME);
            HttpContext.Session.Remove(CDictionary.CURRENT_LOGINED_USERPHOTO);
        }

        public JsonResult QRcode(string id)
        {
            擺腹BuyFoodContext dbcontext = new 擺腹BuyFoodContext();
            TMember targetMember = dbcontext.TMembers.FirstOrDefault(n => n.CMemberId == int.Parse(id));
            string head = $"<h1>推薦碼 : {targetMember.CReferrerCode}</h1>";
            string contenxt = $"/Customer/Create?id={targetMember.CReferrerCode}";
            List<string> data = new List<string>();
            data.Add(head);
            data.Add(contenxt);
            return Json(data);
        }

    }

}
