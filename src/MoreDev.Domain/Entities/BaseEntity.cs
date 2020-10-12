﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MoreDev.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
