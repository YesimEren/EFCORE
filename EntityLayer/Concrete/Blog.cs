using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; } //bloğun küçük resmi.
        public string BlogImage { get; set; } //resimler sunucuda çok yer kaplayack o yüzden dosyayolu olarak tutacağız.
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; } // ilişkiden alınacak tablo türünde olmalı

        public List<Comment> Comments { get; set; } // Bir bloğa birden fazla yorum yapılabilir.

    }
}
