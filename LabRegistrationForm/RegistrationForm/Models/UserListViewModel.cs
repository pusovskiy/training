using System.Collections.Generic;

namespace RegistrationForm.Models
{
    public class UserListViewModel
    {

        public IEnumerable<User> Users { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public string NameUser { get; set; }
    }
}