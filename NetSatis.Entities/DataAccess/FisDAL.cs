using System;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.DataAccess
{
    public class FisDAL : EntityRepositoryBase<NetSatisContext, Fis, CariValidator>
    {

    }
}
