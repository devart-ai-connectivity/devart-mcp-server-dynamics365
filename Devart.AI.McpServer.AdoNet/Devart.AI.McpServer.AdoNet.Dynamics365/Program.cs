// --------------------------------------------------------------------------
// <copyright file="Program.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

using System.Threading.Tasks;
using Devart.AI.McpServer.AdoNet.Dynamics365.CommandLine;

namespace Devart.AI.McpServer.AdoNet.Dynamics365
{
  internal class Program
  {
    public static Task<int> Main(string[] args) => AdoNetLauncher.Create(new AdoNetDynamics365RunCommand()).RunAsync(args);
  }
}
