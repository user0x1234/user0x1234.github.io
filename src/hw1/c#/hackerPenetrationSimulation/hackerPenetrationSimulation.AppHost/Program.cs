var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.hackerPenetrationSimulation_ApiService>("apiservice");

builder.AddProject<Projects.hackerPenetrationSimulation_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
