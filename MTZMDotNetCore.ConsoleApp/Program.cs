﻿// See https://aka.ms/new-console-template for more information
using MTZMDotNetCore.ConsoleApp.DapperExamples;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello World");

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();

//adoDotNetExample.Read();
//adoDotNetExample.Create("Author","Title", "Content");
//adoDotNetExample.Update(1, "Author", "Title", "Content");
//adoDotNetExample.Delete(11);
//adoDotNetExample.Edit(1);
//adoDotNetExample.Edit(3);
//Console.ReadKey();

DapperExample dapperExample = new DapperExample();
dapperExample.Run();

