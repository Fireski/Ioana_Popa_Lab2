﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ioana_Popa_lab2.Data;
using Microsoft.Extensions.Options;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizeFolder("/Books");
});
options.Conventions.AllowAnonymousToPage("/Books/Index");
options.Conventions.AllowAnonymousToPage("/Books/Details");
});
builder.Services.AddDbContext<Ioana_Popa_lab2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Ioana_Popa_lab2Context") ?? throw new InvalidOperationException("Connection string 'Ioana_Popa_lab2Context' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
