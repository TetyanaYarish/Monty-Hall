﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    public interface IPlayerAnswer
    {
        string AnswerChooseNumberOfDoor();
        string AnswerStayOrSwitchTheDoor();
    }
}