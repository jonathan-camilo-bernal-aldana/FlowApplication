﻿using Domain.Field;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Configuration.Field.Input
{
    public class TypeFieldInputCreate
    {
        public string TypeName { get; set; }

        public TypeFieldEnum Type { get; set; }

        public List<string> ValidationsId { get; set; }

        public string Description { get; set; }
    }
}
