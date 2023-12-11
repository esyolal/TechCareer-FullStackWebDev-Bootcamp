using System.ComponentModel.DataAnnotations;
namespace BootcampEf.Data{
    public class Ogrenci{
        //id => primary key
        
        [Key]
        public int OgrenciId{get;set;}
        public string OgrenciAd { get; set; }
        public int MyProperty { get; set; }
    }
}