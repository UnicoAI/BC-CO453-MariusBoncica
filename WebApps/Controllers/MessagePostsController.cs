﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApps.Data;
using WebApps.Models;
//<author>Marius Boncica
//</author>
//<summary>
//version 1.0
//</summary>
namespace WebApps.Controllers
{
    public class MessagePostsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MessagePostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MessagePosts
        public async Task<IActionResult> Index(String userName)
        {
            var posts = from p in _context.Messages select p;
            if (!String.IsNullOrEmpty(userName))
            {
                posts = posts.Where(u => u.Username == userName);

            }

            return View(await posts.ToListAsync());
        }

        // GET: MessagePosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Messages == null)
            {
                return NotFound();
            }

            var messagePost = await _context.Messages
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (messagePost == null)
            {
                return NotFound();
            }

            return View(messagePost);
        }

        // GET: MessagePosts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MessagePosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostID,Username,Messages,Timestamp,Likes")] MessagePost messagePost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(messagePost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(messagePost);
        }

        // GET: MessagePosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Messages == null)
            {
                return NotFound();
            }

            var messagePost = await _context.Messages.FindAsync(id);
            if (messagePost == null)
            {
                return NotFound();
            }
            return View(messagePost);
        }

        // POST: MessagePosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostID,Username,Messages,Timestamp,Likes")] MessagePost messagePost)
        {
            if (id != messagePost.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(messagePost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MessagePostExists(messagePost.PostId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(messagePost);
        }
        public ActionResult Like(int id)
        {
            var messagepost = _context.Photos.Find(id);
            if (messagepost == null)
            {
                return NotFound();
            }
            messagepost.Like();
            try
            {
                _context.Update(messagepost);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessagePostExists(messagepost.PostId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction("Details", new { id = id });
        }
        public ActionResult Unlike(int id)
        {
            var messagepost = _context.Photos.Find(id);
            if (messagepost == null)
            {
                return NotFound();
            }
            messagepost.Unlike();
            try
            {
                _context.Update(messagepost);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessagePostExists(messagepost.PostId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction("Details", new { id = id });
        }

        // GET: MessagePosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Messages == null)
            {
                return NotFound();
            }

            var messagePost = await _context.Messages
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (messagePost == null)
            {
                return NotFound();
            }

            return View(messagePost);
        }

        // POST: MessagePosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Messages == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Messages'  is null.");
            }
            var messagePost = await _context.Messages.FindAsync(id);
            if (messagePost != null)
            {
                _context.Messages.Remove(messagePost);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MessagePostExists(int id)
        {
          return _context.Messages.Any(e => e.PostId == id);
        }
    }
}
