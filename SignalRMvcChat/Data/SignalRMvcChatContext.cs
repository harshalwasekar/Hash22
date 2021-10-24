using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SignalRMvcChat.Data
{
    public class SignalRMvcChatContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SignalRMvcChatContext() : base("name=SignalRMvcChatContext")
        {
        }

        public System.Data.Entity.DbSet<SignalRMvcChat.tbl_Users> tbl_Users { get; set; }
    }
}
