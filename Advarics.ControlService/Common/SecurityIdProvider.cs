using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Advarics.ControlService.Common
{
    public class SecurityIdProvider
    {
        static public Guid GetIDToken()
        {
            return Guid.Parse("5B23D2DD-2869-4CA3-8B12-14E24EE60A55");
        }
    }
}