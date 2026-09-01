using System;
using System.Collections.Generic;
using System.Text;

namespace Jarvis.Tools
{
    public interface ITool
    {
        ToolDefinition Definition { get; }
        string Execute(string parameters);

    }
}
