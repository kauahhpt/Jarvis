using System;
using System.Collections.Generic;
using System.Text;

namespace Jarvis.Tools.FileTools
{
    public class CreateFileTool : ITool
    {
        public ToolDefinition Definition { get; } =
            new ToolDefinition
            {
                Name = "CreateFile",
                Description = "Cria um novo arquivo no caminho especificado.",
                Parameters = "path — caminho do arquivo que será criado."
            };
        public string Execute(string parameters)
        {
            if (File.Exists(parameters))
            {
                return "O arquivo já existe.";
            }

            File.Create(parameters).Dispose();

            return $"Arquivo criado: {parameters}";
        }
    }
}
