using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Comment
{
    public class CreateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage ="Title must be five characters")]
        [MaxLength(280, ErrorMessage ="Title cannot be over 280 characters")]
        public string? Title { get; set; }
        [Required]
        [MinLength(5, ErrorMessage ="Content must be five characters")]
        [MaxLength(280, ErrorMessage ="Content cannot be over 280 characters")]
        public string? Content { get; set; }
    }
}