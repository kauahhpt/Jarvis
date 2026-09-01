using System;
using System.Collections.Generic;
using System.Text;
using Jarvis.Tools;

namespace Jarvis.Agent
{
    public class ToolRegistry
    {
        private readonly List<ITool> _tools = new();

        public void Register(ITool tool)
        {
            _tools.Add(tool);
        }

        public IReadOnlyList<ITool> GetTools()
        {
            return _tools;
        }

        public ITool? GetTool(string name)
        {
            return _tools.Find(tool => tool.Definition.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
