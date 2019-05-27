using System;

namespace smgrushb.GeTui.Domain.Exceptions
{
    internal class TemplateTypeException : Exception
    {
        public TemplateTypeException()
        {
        }

        public TemplateTypeException(string message) : base(message)
        {
        }
    }
}