namespace Model;

public class CompanyContact : Contact
{
public CompanyContact()
    : this("DefCompany",string.Empty,string.Empty)
{

}

public CompanyContact(
    string name,
    string ogrn,
    string telefonNumber) : base(telefonNumber)
    
{
    this.Name = name;
    this.OGRN = ogrn;
}

public string Fax {get; set;}
public string Name {get; set;}
public string OGRN {get; set;}

public int ManagerId {get; set;}

public override string NickName
{
    get
    {
        return $"[{this.Name}, {this.OGRN}]";
    }
}

    public override string ToString()
    {
        string output = string.Empty;

        output += $"Id: {this.Id}\n";
        output += $"Name: {this.Name}\n";
        output += $"OGRN: {this.OGRN}\n";
        output += base.ToString();
        output += $"Fax: {this.Fax}\n";

        return output;   
    }      

}