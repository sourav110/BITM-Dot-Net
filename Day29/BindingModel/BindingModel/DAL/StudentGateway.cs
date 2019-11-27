using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace BindingModel.DAL
{
    public class StudentGateway
    {
        public string connString = WebConfigurationManager.ConnectionStrings["STDB"].ConnectionString;

    }
}