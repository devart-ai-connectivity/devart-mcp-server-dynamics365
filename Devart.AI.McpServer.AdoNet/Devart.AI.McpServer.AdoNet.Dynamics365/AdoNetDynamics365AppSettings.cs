// --------------------------------------------------------------------------
// <copyright file="AdoNetDynamics365AppSettings.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

namespace Devart.AI.McpServer.AdoNet.Dynamics365
{
  internal sealed class AdoNetDynamics365AppSettings : McpAppSettings
  {
    public override string ServerName => $"Devart {Properties.ProductInfo.ProductFullName}";

    public override string SourceName => "Dynamics 365";

    public override bool OnPremise => true;
  }
}
