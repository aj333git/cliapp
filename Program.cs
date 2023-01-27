using System;
using Spectre.Console;

namespace cliapptable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("D is system programming and Garbage Collected language !");
            //Create table object
            var table = new Table();
           // table.Centered();
            //table.Collapse();
//table.Border(TableBorder.HeavyHead);
//Fluent Interface design pattern with method chaining
table.Centered().Collapse().Border(TableBorder.HeavyHead);


// Add  columns

table.AddColumn("[magenta3]C[/]");
table.AddColumn(new TableColumn("[red3_1]C++[/]").Centered());

// Add  rows

table.AddRow("[green]Java[/]", "[lightcyan1]D language[/]");
table.AddRow( new Panel("[deeppink2]C#[/]"));




// Render the table to the console
AnsiConsole.Write(table);
        }
    }
}
