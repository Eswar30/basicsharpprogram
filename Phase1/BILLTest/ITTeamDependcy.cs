using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class ITTeamDependcy
    {
        public static object GetInstance(string type)
        {
            switch (type)
            {
                case "IITTeam":
                    {
                        return new ITTeam();
                    }
            }
            return null;
        }
    }
}
