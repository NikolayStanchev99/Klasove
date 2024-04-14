using System;

public class Class1
{
	public Class1()
	{
		 
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    
    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    
    public void ChangeName(string newName)
    {
        Name = newName;
    }

   
    public void ChangeAge(int newAge)
    {
        Age = newAge;
    }

   
    public void ChangeGender(string newGender)
    {
        Gender = newGender;
    }

    
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
    }
}
}
