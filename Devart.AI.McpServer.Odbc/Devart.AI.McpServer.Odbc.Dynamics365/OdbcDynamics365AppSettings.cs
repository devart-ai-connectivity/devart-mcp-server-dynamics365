// --------------------------------------------------------------------------
// <copyright file="OdbcDynamics365AppSettings.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

namespace Devart.AI.McpServer.Odbc.Dynamics365
{
  internal sealed class OdbcDynamics365AppSettings : McpAppSettings
  {
    public override string ServerName => $"Devart {Properties.ProductInfo.ProductFullName}";

    public override string SourceName => "Dynamics 365";

    public override bool OnPremise => false;
  }
}
