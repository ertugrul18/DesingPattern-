﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPAttern
{
    public interface IChatMediator
    {


        void AddUser(IUser user);
        void SendMessage(string message,IUser user);
    }
}
