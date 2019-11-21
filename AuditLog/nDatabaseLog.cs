using System;
using System.ComponentModel.DataAnnotations;

namespace AccSyscOhoda.Entities
{
    public class nDatabaseLog : IEntity<Guid>
    {
        [Key]
        public Guid  Id {get; set;}
        public string Event {get; set;}
        public string Object {get; set;}
        public DateTime PostTime {get; set;}
        public string Schema {get; set;}
        public string TSQL {get; set;}
        public string XmlEvent {get; set;}

    }
}