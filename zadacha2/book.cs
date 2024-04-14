using System;

public class Class1
{
	public Class1()
	{
		 
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    
    public void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}");
    }
}
}
