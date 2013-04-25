﻿using System;
using System.Collections.Generic;
using WitchOS.Core;

namespace WitchOS.Applications
{
    public abstract class Application
    {
        public int APPID;
        public string call;
        public string usage;
        public abstract void Run(string[] args);
        public void CallHelp()
        {
            HAL.drvman.screenbuffer.Push();
            Console.Clear();
            this.Help();
            Console.Clear();
            HAL.drvman.screenbuffer.Pop();
        }
        public virtual void Help()
        {
            Out.printf("No help available.");
        }
    }
}