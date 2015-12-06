using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domainModels
{
    public class AccountExternal
    {
        //NOTE c#6 featueres property intialisation
        public DateTimeOffset whenCreated { get; } = DateTimeOffset.UtcNow;
    }
}
