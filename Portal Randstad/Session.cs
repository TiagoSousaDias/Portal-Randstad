using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_Randstad
{
    public static class Session
    {
        private static Boolean loggedIN;

        static Session()
        {
            loggedIN = false;
        }

        public static Boolean IsLogged
        {
            get
            {
                return (loggedIN);
            }
            set
            {
                loggedIN = value;
            }
        }

    }
}
