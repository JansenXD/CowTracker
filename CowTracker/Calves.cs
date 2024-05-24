using System.ComponentModel.DataAnnotations;
namespace CowTracker
{
        public class Calf
        {
            public int Id { get; set; }
            public int TagNum { get; set; }

            [Required]
            public string TagColor { get; set; }

            [Required]
            public string Breed { get; set; }

            [Required]
            public string Gender { get; set; }

            [Required]
            public float Cost { get; set; }
            
            public int Pen { get; set; }
            //add buy date later
            // maybe Nickname
            public DateTime ImplantDate { get; set; }
            public DateTime NextImplantDate { get; set;}
            public int Implant_length { get; set; }
        }
    public class PenDB
    {
        public int ID { get; set; }
        public string Name { get; set; }
       

    }
    public class Pen 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        ICollection<Calf> Calves { get; set; }

    }

}
