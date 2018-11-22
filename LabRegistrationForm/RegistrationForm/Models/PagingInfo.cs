using System;

namespace RegistrationForm.Models
{
    public class PagingInfo
    {
        public int PageNumber { get; set; } 

        public int PageSize { get; set; } 

        public int TotalItems { get; set; } 

        public int TotalPages  
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / PageSize); }
        }
    }
}