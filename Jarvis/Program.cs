using Jarvis.Agent;
using Jarvis.Tools.FileTools;

var folderTool = new CreateFolderTool();
var fileTool = new CreateFileTool();

var registry = new ToolRegistry();

registry.Register(folderTool);
registry.Register(fileTool);

var tools = registry.GetTools();

foreach (var tool in tools)
{
    Console.WriteLine(tool.Definition.Name);
}
var selectedTool = registry.GetTool("CreateFolder");
if (selectedTool != null)
{
    var result = selectedTool.Execute("teste3");
    Console.WriteLine(result);
}
else Console.WriteLine("Tool not found");