
using System;
namespace AccSyscOhoda.Entities

{
    public interface IEntity<V>
    {
       V Id {get; set;}
    }
}