﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System.Runtime.Serialization;

namespace Squidex.Domain.Apps.Entities.Backup.State
{
    public class RestoreState2
    {
        [DataMember]
        public RestoreJob Job { get; set; }
    }
}
