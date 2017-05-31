using System;
using SQLite.Net.Attributes;

namespace SamplePCL
{
    public class SqliteItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
