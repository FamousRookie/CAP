﻿using System;

// ReSharper disable once CheckNamespace
namespace DotNetCore.CAP
{
    public class EFOptions
    {
        public const string DefaultSchema = "cap";

        /// <summary>
        /// Gets or sets the table name prefix to use when creating database objects.
        /// </summary>
        public string TableNamePrefix { get; set; } = DefaultSchema;

        /// <summary>
        /// EF db context type.
        /// </summary>
        internal Type DbContextType { get; set; }
    }
}