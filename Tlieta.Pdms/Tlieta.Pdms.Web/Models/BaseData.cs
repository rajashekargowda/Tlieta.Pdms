using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tlieta.Pdms.DB;

namespace Tlieta.Pdms.Web.Models
{
    public class BaseData
    {
        public PDMSDatabaseEntities entities = new PDMSDatabaseEntities();
    }
}