Relationship
    Parent
    Child

Person
    int Id
    string Name
    int Age

Person - Relationship - Person  

IRelationshipStorage
    ICustomList<Person> Find(string name);

Relationships : IRelationshipStorage
    List<(Person, Relationship, Person)> relation;
    //Find