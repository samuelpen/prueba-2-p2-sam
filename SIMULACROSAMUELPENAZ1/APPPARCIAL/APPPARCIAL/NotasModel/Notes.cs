using SQLite;
using System;

namespace APPPARCIAL.NotasModel
{
    public class Notes
    {
        [PrimaryKey, AutoIncrement]     
        public int NotesId { get; set; }
        public string Contents { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Notes()
        {
            this.CreatedDate = DateTime.Now;
            this.ModifiedDate = DateTime.Now;
        }


    }
}
