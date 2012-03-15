﻿using Gimela.Toolkit.CommandLines.Foundation;

namespace Gimela.Toolkit.CommandLines.Join
{
  class Program
  {
    static void Main(string[] args)
    {
      using (CommandLine command = new JoinCommandLine(args))
      {
        CommandLineBootstrap.Start(command);
      }
    }
  }
}
