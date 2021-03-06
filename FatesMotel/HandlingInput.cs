﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatesMotel
{
    class HandlingInput
    {
        private Parser parser = new Parser();

        public void play()
        {
            Boolean finished = false;
            while (!finished)
            {
                Console.Write("Command: ");
                Command command = parser.getCommand();
                finished = processCommand(command);
            }
        }

        private Boolean processCommand(Command c)
        {
            if (c.IsUnknown)
                return true;
            return false;
        }
    }
}