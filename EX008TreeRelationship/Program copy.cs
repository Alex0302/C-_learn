
public class Node
{
    public Node Child (get; set;);

}

public class People
{
    public int Id;

    public int[] ParentId {get; set;}
    public String FirstName {get; set;}
    public String LastName {get; set;}
    public String MiddleName {get; set;}
    public DateOnly BirthDay {get; set;}
    public DateOnly? DeathDay {get; set;}

    public bool Sex;

}

public class Research
{
    public int GetNodeId (int id, int type)
    {

    }

    public int[] GetAllNodeId (int type)
    {
        
    }
}


