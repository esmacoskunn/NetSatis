using FluentValidation;
using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tools
{
    public static class ValidatorTool
    {
        public static bool Validate(IValidator validator, IEntity entity)
        {
            return Equals(validator, entity);
        }


    }
}
