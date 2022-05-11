using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace loginRegistration.Models
{
    public class OurDbContest : DbContext
    {
        public DbSet<UserAccount> userAccounts { get; set; }
    }
}