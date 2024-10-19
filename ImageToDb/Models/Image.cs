using System.ComponentModel.DataAnnotations;

namespace ImageToDb.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        [DataType(DataType.Upload)]
        public byte[] Img { get; set; }

    }
}
