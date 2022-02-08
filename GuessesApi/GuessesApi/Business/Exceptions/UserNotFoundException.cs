﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessesApi.Business.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base("User not Found!")
        {

        }
    }
}
