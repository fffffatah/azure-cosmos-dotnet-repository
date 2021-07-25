﻿// Copyright (c) IEvangelist. All rights reserved.
// Licensed under the MIT License.

using System;
using Microsoft.Azure.CosmosRepository;
using Newtonsoft.Json;

namespace WebTier.Models
{
    public class Language : Item
    {
        public string Name { get; set; }

        public string[] Aliases { get; set; }

        public string Description { get; set; }

        public ProgrammingStyle PrimaryStyle { get; set; }

        public DateTime InitialReleaseDate { get; set; }
    }
}