﻿using System;
namespace Lab2
{
    class FileSnapshot
    {
        public DateTime LastModified { get; set; }

        public static implicit operator FileSnapshot(DateTime v)
        {
            throw new NotImplementedException();
        }
    }
}