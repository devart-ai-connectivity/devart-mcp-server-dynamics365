// --------------------------------------------------------------------------
// <copyright file="OdbcDynamics365Tools.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using ModelContextProtocol.Server;
using Devart.AI.McpServer.Odbc.Dynamics365.Tools;

namespace Devart.AI.McpServer.Odbc.Dynamics365
{
  internal static class OdbcDynamics365Tools
  {
    public static List<McpServerTool> CreateTools(McpConfiguration configuration)
      => OdbcTools.CreateBuilder(configuration)
        .Add(new OdbcDynamics365PrimaryKeysTool(configuration))
        .Add(new OdbcDynamics365ForeignKeysTool(configuration))
        .Build();
  }
}
