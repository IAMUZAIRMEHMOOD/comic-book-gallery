using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail  ()
        { 

              var comicBook = new ComicBook();

                comicBook.SeriesTitle = "The Amazing Spider-Man";
                comicBook.IssueNumber = 700;
                comicBook.DescriptionHtml = "<p>Final issue! Witness the final hour of Doctor Octupus' life and his one, last m great act of revenge! Even if Spider-Man survues...<strog> will Peter Parker?</strong></p>";
                comicBook.Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott",Role="Scripts"},
                    new Artist() { Name = "Humberto Ramos",Role="Pencils"},
                    new Artist() { Name = "Edgar",Role="Colors"},
                    new Artist() { Name = "Chris Eliopoulos",Role="Letters"},
                    new Artist() { Name = "Victor Olazaba",Role="Inks"},

                };

            
            
            return View(comicBook);
        }
    }
} 