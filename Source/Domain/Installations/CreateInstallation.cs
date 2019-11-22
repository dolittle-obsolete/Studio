/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Concepts.Installations;
using Dolittle.Commands;

namespace Domain.Installations
{
    public class CreateInstallation : ICommand
    {
        public SiteName SiteName { get; set; }
        public InstallationName Name { get; set; }
    }
}