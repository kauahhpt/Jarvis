using System;
using System.Collections.Generic;
using System.Text;

namespace Jarvis.Tools.FileTools
{
    public class CreateFolderTool : ITool
    {
        public ToolDefinition Definition { get; } =
            new ToolDefinition
            {
                Name = "CreateFolder",
                Description = "Cria uma nova pasta no caminho especificado.",
                Parameters = "path — caminho da pasta que será criada."
            };
        public string Execute(string parameters)
        {
            if (Directory.Exists(parameters))
            {
                return "A pasta já existe.";
            }

            Directory.CreateDirectory(parameters);

            return $"Pasta criada: {parameters}";
        }
    }
}
