namespace DemoExercises;

internal class Person
{
    public int id;
    private string name;
    public bool isNewPerson = true;
    public string Name
    {
        get { return name;  }
        set
        {
            if (isNewPerson)
            {
                name = value;
            }
        }
    }

    public string lastname;
    public int age;

    public Person(int id, string name, string lastname, int age )
    {
        this.id = id;
        this.name = name;
        this.lastname = lastname;
        this.age = age;
    }



}

