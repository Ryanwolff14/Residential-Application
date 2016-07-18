
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Residential_capstone_project
{
	public class TableDTO
    {
		public System.Int32 Id { get; set; }

        public static System.Linq.Expressions.Expression<Func< Table,  TableDTO>> SELECT =
            x => new  TableDTO
            {
                Id = x.Id,
            };

	}
}