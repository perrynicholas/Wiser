﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiser.Data;
using Wiser.Models.Author;

namespace Wiser.Models.Wisdom
{
    public class WisdomDetailItem
    {
        [UIHint("Upvoted")]
        public bool IsUpvoted { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "First Name")]

        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        [Display(Name = "User")]
        public string UserName => $"{FirstName} {LastName}";
        [Required]
        public AuthorScrollItem Author { get; set; }
        //[Required]
        //public int AuthorId { get; set; }
        //[Required]
        //[Display(Name ="Author")]
        ////Put in string for author name so I could link Author's id to  his/her name
        //public string AuthorName { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Source { get; set; }
        [Required]
        [Display(Name ="Genre")]
        public Genre WisdomGenre { get; set; }
        [Required]
        [Display(Name = "Created At")]

        public DateTime CreatedAt { get; set; }
        [Required]
        public int? Virtue { get; set; }
        public int WisdomId { get; set; }
    }
}
