﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FansPen.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace FansPen.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime RegistrationDate { get; set; }
        public string AboutMe { get; set; }
        public string Interests { get; set; }
        public string Lang { get; set; }
        public string Style { get; set; }
        public string AvatarUrl { get; set; }
        public string ProviderKey { get; set; }
        public ICollection<Fanfic> Fanfics { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<ApplicationUserTopic> RatedTopics { get; set; }
        public ApplicationUser()
        {
            Fanfics = new List<Fanfic>();
            Likes = new List<Like>();
            Comments = new List<Comment>();
            RatedTopics = new List<ApplicationUserTopic>();
        }
        internal object FindById(object p)
        {
            throw new NotImplementedException();
        }
    }
}