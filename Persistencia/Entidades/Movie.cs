using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Entidades
{
        public class Movie
        {
            public int MovieId { get; set; }
            public string Title { get; set; }
            public string Director { get; set; }

            [DataType(DataType.Date)]
            public DateTime ReleaseDate { get; set; }
            public decimal Gross { get; set; }
            public double Rating { get; set; }

            public int GenreID { get; set; }
            public virtual Genre Genre { get; set; }

            public virtual ICollection<ActorMovie> Characters { get; set; }
        }

    
}
