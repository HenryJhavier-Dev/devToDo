using System;
using SQLite;

namespace ToDo.Model
{
    public class Assignment
    {
        [PrimaryKey, AutoIncrement, Column("id_task")]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public TimeSpan Duration { get; set; }
        public bool Succes { get; set; }
    }
}
