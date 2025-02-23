using OnlineEdu.DTO.DTOs.BlogCategoryDtos;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTO.DTOs.CourseDtos
{
    public class CreateCourseDto
    {
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CourseCategoryId { get; set; }
        // Kurslar bir kategoriye ait olacak o yüzden burada Category sınıfına erişebilmek için tanımlıyoruz
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
    }
}
