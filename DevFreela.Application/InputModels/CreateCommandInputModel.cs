﻿using System.Globalization;

namespace DevFreela.Application.InputModels
{
    public class CreateCommandInputModel
    {
        public string? Content { get; set; }
        public int  IdProject { get; set; }
        public int IdUser { get; set; }
    }
}