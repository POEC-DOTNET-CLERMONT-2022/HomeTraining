// See https://aka.ms/new-console-template for more information
using NBomber.Contracts;
using NBomber.CSharp;

Console.WriteLine("Hello, World!");
var step = Step.Create("step", async context =>
{
    // you can define and execute any logic here,
    // for example: send http request, SQL query etc
    // NBomber will measure how much time it takes to execute your logic

    await Task.Delay(TimeSpan.FromSeconds(1));
    return Response.Ok();
});

// second, we add our step to the scenario
var scenario = ScenarioBuilder.CreateScenario("hello_world", step);

NBomberRunner
    .RegisterScenarios(scenario)
    .Run();
      