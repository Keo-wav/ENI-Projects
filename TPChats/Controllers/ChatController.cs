using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TPChats.Models;

namespace TPChats.Controllers
{
    public class ChatController : Controller
    {
        private static List<Chat> chats = Chat.GetMeuteDeChats();
        // GET: ChatController
        public ActionResult Index()
        {
            return View(chats);
        }

        // GET: ChatController/Details/5
        public ActionResult Details(int id)
        {
            // var chatDetail = chats.Find(x => x.Id == id);
            // return View(chatDetail);
            // correction from Quentin below : 
            Chat? chat = chats.FirstOrDefault(x => x.Id == id);
            if (chat == null) return NotFound();
            return View(chat);
        }

        // GET: ChatController/Create
        // POST: ChatController/Create
        // GET: ChatController/Edit/5
        // POST: ChatController/Edit/5

        // GET: ChatController/Delete/5
        public ActionResult Delete(int id)
        {
            var chatDelete = chats.Find(x => x.Id == id);
            return View(chatDelete);
        }

        // POST: ChatController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            // creation of a new list where we filtered out the id that we want to delete
            chats = chats.Where(c => c.Id != id).ToList();
            return RedirectToAction(nameof(Index));

            // other method (preferred)
            Chat? chat = chats.FirstOrDefault(x => x.Id == id);
            if (chat == null) return NotFound();
            chats.Remove(chat);

            // other method : find index and .RemoveAt(index)


            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }
    }
}
