using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SnowboardCommunityProject.Data;
using SnowboardCommunityProject.Models;


namespace SnowboardCommunityProject.Controllers
{
    public class MainController : Controller
    {
         // pull in db
        private readonly ApplicationDbContext _context; 

        public MainController(ApplicationDbContext context)
        {
            _context = context;
        }

          // view all Post
        public IActionResult ViewAllPosts()
        {
            return View(_context);
        } 

         // view post details 
        public IActionResult PostDetails (int postID)
        {
            ForumPost matchingPost = _context.ForumPosts.FirstOrDefault(post => post.id == postID);

            if(matchingPost != null)
            {
                return View(matchingPost);
            }
                else
                {
                    return Content("No matching post Found!");
                }
        }



        [HttpPost]
        public IActionResult AddForumPost(ForumPost newPost)
        {
            if(ModelState.IsValid)
            {
                _context.ForumPosts.Add(newPost);
                _context.SaveChanges();

                return Content("New Post Added");
            }
                else
                {
                    return Content("Error");
                }
        }

         // Update post
        [HttpPost]        
        public IActionResult EditPost(ForumPost updatePost)
        {
            // get book 
            ForumPost mathingPost = _context.ForumPosts.FirstOrDefault(p => p.id == updatePost.id);

            // if book found, update values 
            if(mathingPost != null)
            {
                 if(ModelState.IsValid)
                {
                    mathingPost.PostCategory = updatePost.PostCategory;
                    mathingPost.Post = updatePost.Post;

                    _context.SaveChanges();

                    return Content ("Post Updated");
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

        // delete Post
        public IActionResult DeletePost(int postID)
        {
            ForumPost matchingPost = _context.ForumPosts.FirstOrDefault(post => post.id == postID);

            if(matchingPost != null)
            {
                _context.Remove(matchingPost);
                _context.SaveChanges();

                return Content("Post Deleted");
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

            if(matchingPost != null)
            {
                return View(matchingPost);
            }
                else
                {
                    return Content("Matching Post Not Found!");
                }

        }


    }

}

