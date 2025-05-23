﻿using System;

namespace QuestPDF.Drawing.Exceptions
{
    public sealed class InitializationException : Exception
    {
        internal InitializationException(string message) : base(message)
        {
            
        }
        
        internal InitializationException(string message, Exception inner) : base(message, inner)
        {
            
        }
    }
}