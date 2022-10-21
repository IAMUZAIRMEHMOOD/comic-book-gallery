using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using ComicBookGallery.Models;
namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
       
            private static ComicBook[] _comicBooks = new ComicBook[]
                {
                    new ComicBook()
                    {
                        SeriesTitle = "The Amazing Spider-Man",
                        IssueNumber = 700,
                        DescriptionHtml = "<p>Final issue! Witness the final hour of Doctor Octupus' life and his one, last m great act of revenge! Even if Spider-Man survues...<strog> will Peter Parker?</strong></p>",
                        Artists = new Artist[]
                        {

                            new Artist() { Name = "Dan Slott",Role="Scripts"},
                            new Artist() { Name = "Humberto Ramos",Role="Pencils"},
                            new Artist() { Name = "Victor Olazaba",Role="Inks"},
                            new Artist() { Name = "Edgar Delgado",Role="Colors"},
                            new Artist() { Name = "Chris Eliopoulos",Role="Letters"},
                        }
                     },
                    new ComicBook()
                    {
                        SeriesTitle = "The Amazing Spider-Man",
                        IssueNumber = 657,
                        DescriptionHtml = "<p>Spider-Man issue! Witness the final hour of Doctor Octupus' life and his one, last m great act of revenge! Even if Spider-Man survues...<strog> will Peter Parker?</strong></p>",
                        Artists = new Artist[]
                        {

                            new Artist() { Name = "Dan Slott",Role="Scripts"},
                            new Artist() { Name = "Humberto Ramos",Role="Pencils"},
                            new Artist() { Name = "Victor Olazaba",Role="Inks"},
                            new Artist() { Name = "Edgar Delgado",Role="Colors"},
                            new Artist() { Name = "Chris Eliopoulos",Role="Letters"}


                        },
                        Favorite = false,
                     },
                    new ComicBook()
                    {
                        SeriesTitle = "Bone",
                        IssueNumber = 50,
                        DescriptionHtml = "<p><strong>The Dunegon</strong> Witness the final hour of Doctor Octupus' life and his one, last m great act of revenge! Even if Spider-Man survues...<strog> will Peter Parker?</strong></p>",
                        Artists = new Artist[]
                        {

                            new Artist() { Name = "Jeff Smith",Role="Scripts"},
                            new Artist() { Name = "Jeff Smith",Role="Pencils"},
                            new Artist() { Name = "Jeff Smith",Role="Inks"},
                            new Artist() { Name = "Jeff Smith",Role="Letters"}


                        },
                        Favorite = false,
    },
                };
                    public ComicBook GetComicBook(int id)
                                    {
                        ComicBook comicBookToReturn = null;
                        foreach (var comicBook in _comicBooks)
                        {
                            if (comicBook.Id == id)
                            {
                                comicBookToReturn = comicBook;
                                break;
                            }

                        }
                        return comicBookToReturn;
                                    }
        

        //var comicBook = new ComicBook();
        //    { 
        //    comicBook.SeriesTitle = "The Amazing Spider-Man";
        //    comicBook.IssueNumber = 700;
        //    comicBook.DescriptionHtml = "<p>Final issue! Witness the final hour of Doctor Octupus' life and his one, last m great act of revenge! Even if Spider-Man survues...<strog> will Peter Parker?</strong></p>";
        //    comicBook.Artists = new Artist[]
        //    {
        //            new Artist() { Name = "Dan Slott",Role="Scripts"},
        //            new Artist() { Name = "Humberto Ramos",Role="Pencils"},
        //            new Artist() { Name = "Edgar",Role="Colors"},
        //            new Artist() { Name = "Chris Eliopoulos",Role="Letters"},
        //            new Artist() { Name = "Victor Olazaba",Role="Inks"},

        //    };
            }
        }
    