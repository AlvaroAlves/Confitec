using System;

namespace Api.Domain.Interfaces
{
    public interface IDtoBase
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}