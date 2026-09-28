using HtthLesson07.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HtthLesson07.Controllers
{
    public class HtthMemberController : Controller
    {
        public static List<HtthMember> htthMembers = new List<HtthMember>();
        // GET: HtthMemberController
        public ActionResult HtthIndex()
        {
            return View(htthMembers);
        }

        // GET: HtthMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HtthMemberController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult HtthCreate()
        {
            return View();
        }

        // POST: HtthMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HtthCreate(HtthMember htthMember)
        {
            try
            {
             
                if (!ModelState.IsValid)
                {
                    return View(htthMember);
                }

                
                htthMembers.Add(htthMember);

               
                return RedirectToAction("HtthIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: HtthMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HtthMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HtthMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HtthMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
