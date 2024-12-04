using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<MicroserviceWithAspire_ProductWebAPI>("product-webapi");
builder.AddProject<MyMicroserviceWithAspire_CategoryWebAPI>("category-webapi");
builder.AddProject<MyMicroserviceWithAspire_GatewayWebAPI>("gateway-webapi");

builder.Build().Run();
