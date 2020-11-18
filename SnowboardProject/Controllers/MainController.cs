using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SnowboardProject.Data;
using SnowboardProject.Models;


namespace SnowboardProject.Controllers
{
    public class MainController : Controller
    {
        // pull in db
        private readonly ApplicationDbContext _context;

        public MainController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ----------------------------------------------------Forum Post Methods--------------------------------------------------------------------------

        // view all Post
        public IActionResult ViewAllPosts()
        {
            return View(_context);
            // return Content("Endpoint hit");
        }

        // view post details 
        public IActionResult PostDetails(int postID)
        {
            ForumPost matchingPost = _context.ForumPosts.FirstOrDefault(post => post.id == postID);

            if (matchingPost != null)
            {
                return View(matchingPost);
                // return Content("Endpoint hit");
            }
            else
            {
                return Content("No matching post Found!");
            }
        }

        [HttpPost]
        public IActionResult AddForumPost(ForumPost newPost)
        {
            if (ModelState.IsValid)
            {
                _context.ForumPosts.Add(newPost);
                _context.SaveChanges();

                return RedirectToAction("ViewAllPosts");
            }
            else
            {
                return Content("Error");
            }
        }

        public IActionResult AddForumPostForm()
        {
            return View();
        }

        // Update post
        [HttpPost]
        public IActionResult EditPost(ForumPost updatePost)
        {
            // get book 
            ForumPost mathingPost = _context.ForumPosts.FirstOrDefault(p => p.id == updatePost.id);

            // if book found, update values 
            if (mathingPost != null)
            {
                if (ModelState.IsValid)
                {
                    // mathingPost.PostCategory = updatePost.PostCategory;
                    mathingPost.Post = updatePost.Post;

                    _context.SaveChanges();

                    return View("EditForumPostForm", updatePost);
                }
                else
                {
                    return Content("Error");
                }
            }
            else
            {
                return Content("Post not found");
            }


        }

        public IActionResult EditForumPostForm(int postID)
        {
            ForumPost foundPost = _context.ForumPosts.FirstOrDefault(p => p.id == postID);
            if (foundPost != null)
            {
                return View(foundPost);
            }
            else
            {
                return Content("No Post with that ID");
            }
        }

        // delete Post
        public IActionResult DeletePost(int postID)
        {
            ForumPost matchingPost = _context.ForumPosts.FirstOrDefault(post => post.id == postID);

            if (matchingPost != null)
            {
                _context.Remove(matchingPost);
                _context.SaveChanges();

                return RedirectToAction("ViewAllPosts");
            }
            else
            {
                return Content("Matching Post Not Found!");
            }

        }

        // delete confirmation
        public IActionResult DeleteConf(int postID)
        {
            ForumPost matchingPost = _context.ForumPosts.FirstOrDefault(post => post.id == postID);

            if (matchingPost != null)
            {
                return View(matchingPost);
            }
            else
            {
                return Content("Matching Post Not Found!");
            }

        }
        // ----------------------------------------------------Resort Methods-------------------------------------------------------------------------

        // view all Resorts
        public IActionResult ViewAllResorts()
        {
            return View(_context);
            // return Content("Endpoint hit");
        }

        // view resort details 
        public IActionResult ResortDetails(int resortID)
        {
            Resort matchingResort = _context.ListOfResorts.FirstOrDefault(resort => resort.ResortId == resortID);

            if (matchingResort != null)
            {
                return View(matchingResort);
                // return Content("Endpoint hit");
            }
            else
            {
                return Content("No matching resort Found!");
            }
        }

        // add new resort
        [HttpPost]
        public IActionResult AddResort(Resort newResort)
        {
            if (ModelState.IsValid)
            {
                _context.ListOfResorts.Add(newResort);
                _context.SaveChanges();

                return Content("New Resort Added");
            }
            else
            {
                return Content("Error");
            }
        }
        public IActionResult AddResortForm()
        {
            return View();
        }

        // Update Resort
        [HttpPost]
        public IActionResult EditResort(Resort updateResort)
        {
            // get resort 
            Resort matchingResort = _context.ListOfResorts.FirstOrDefault(resort => resort.ResortId == updateResort.ResortId);

            // if resort found, update values 
            if (matchingResort != null)
            {
                if (ModelState.IsValid)
                {
                    // mathingPost.PostCategory = updatePost.PostCategory;
                    matchingResort.ResortId = updateResort.ResortId;
                    matchingResort.ResortName = updateResort.ResortName;
                    matchingResort.ResortLocation = updateResort.ResortLocation;
                    matchingResort.ResortElevation = updateResort.ResortElevation;


                    _context.SaveChanges();

                    return Content("Resort Updated");
                }
                else
                {
                    return Content("Error");
                }
            }
            else
            {
                return Content("Resort not found");
            }


        }

        public IActionResult EditResortForm(int resortID)
        {
            Resort foundResort = _context.ListOfResorts.FirstOrDefault(r => r.ResortId == resortID);
            if (foundResort != null)
            {
                return View(foundResort);
            }
            else
            {
                return Content("No Resort with that ID");
            }
        }


        // delete resort
        public IActionResult DeleteResort(int resortID)
        {
            Resort matchingResort = _context.ListOfResorts.FirstOrDefault(resort => resort.ResortId == resortID);

            if (matchingResort != null)
            {
                _context.Remove(matchingResort);
                _context.SaveChanges();

                return Content("Resort Deleted");
            }
            else
            {
                return Content("Matching Resort Not Found!");
            }

        }

        // delete confirmation
        public IActionResult DeleteConfResort(int resortID)
        {
            Resort matchingResort = _context.ListOfResorts.FirstOrDefault(resort => resort.ResortId == resortID);

            if (matchingResort != null)
            {
                return View(matchingResort);
            }
            else
            {
                return Content("Matching Post Not Found!");
            }

        }

        // -------------------------------------------------- User Methods --------------------------------------------------------------------

        public IActionResult ViewAllUsers()
        {
            List<User> userList = _context.ListOfUsers
                .Include(u => u.ListOfFavoriteResorts)
                .Include(u => u.ListOfFriends)
                .ToList();
            return View(_context);
        }

        public IActionResult UserDetails(int userID)
        {
            User matchingUser = _context.ListOfUsers.FirstOrDefault(user => user.id == userID);

            if (matchingUser != null)
            {
                return View(matchingUser);
                // return Content("Endpoint hit");
            }
            else
            {
                return Content("No matching resort Found!");
            }
        }

        public IActionResult AddUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                _context.ListOfUsers.Add(newUser);
                _context.SaveChanges();

                return Content("New User Added");
            }
            else
            {
                return Content("Error");
            }
        }

        public IActionResult AddUserForm()
        {
            return View();
        }

        // ------------------------------------------------- Add Friends / Save Favorite Resort Methods -------------------------------------------------

        public IActionResult AddFriend(int userID)
        {
            User matchingUser = _context.ListOfUsers.FirstOrDefault(user => user.id == userID);


            _context.ListOfUserFriends.Add(matchingUser);
            _context.SaveChanges();



            return Content("Friend Added");
        }


        public IActionResult SaveFavoriteResort(Resort FavoriteResort, int resortID)
        {
            // Resort matchingResort = _context.ListOfResorts.FirstOrDefault(resort => resort.ResortId == resortID);
            User user = _context.ListOfUsers.Include(u => u.ListOfFavoriteResorts).First(r => r.id == FavoriteResort.ResortId);
        
                if (ModelState.IsValid)
                {
                    user.ListOfFavoriteResorts.Add(FavoriteResort);
                    // _context.ListOfUserFavoriteResorts.Add(FavoriteResort);
                    _context.SaveChanges();

                    return Content("Resort Added to favorites");
                }
                    else 
                    {
                        return Content("No matching user or resort");
                    }
        }

                
                public IActionResult ViewFavoriteResorts()
                {
                    return View(_context);
                }

            }



        }

