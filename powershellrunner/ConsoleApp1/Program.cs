// See https://aka.ms/new-console-template for more information


using System.Management.Automation;


using (PowerShell ps = PowerShell.Create())
{
    ps.AddScript("pwd");
    var pipelineObjects = await ps.InvokeAsync().ConfigureAwait(false);
    foreach (var item in pipelineObjects)
    {
        Console.WriteLine(item.BaseObject.ToString());
    }
}

