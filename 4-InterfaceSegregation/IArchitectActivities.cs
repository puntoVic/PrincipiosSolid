﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal interface IArchitectActivities: ITestActivities, IDesignActivities, IDevelopActivities, IWorkTeamActivities
    {
    }
}
