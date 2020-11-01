using System;
using System.Collections.Generic;
using System.Text;

namespace FengCode.Asp.Logger
{
    internal class NoopDisposable : IDisposable
    {
        public void Dispose()
        {
        }
    }
}
