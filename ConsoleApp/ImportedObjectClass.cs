namespace ConsoleApp { 
 public class ImportedObject : ImportedObjectBaseClass
{
    public new string Name
    {
        get;
        set;
    }
    public string Schema;

    public string ParentName;
    public string ParentType
    {
        get; set;
    }

    public string DataType { get; set; }
    public string IsNullable { get; set; }

    public double NumberOfChildren;

    public ImportedObject(string name, string schema, string parentName, string parentType, string dataType, string isNullable, double numberOfChildren)
    {
        Name = name;
        Schema = schema;
        ParentName = parentName;
        ParentType = parentType;
        DataType = dataType;
        IsNullable = isNullable;
        NumberOfChildren = numberOfChildren;
    }
    public ImportedObject()
    {
        Name = "name";
        Schema = "schema";
        ParentName = "parentName";
        ParentType = "parentType";
        DataType = "dataType";
        IsNullable = "isNullable";
        NumberOfChildren = 0.00000000001;
    }
}

public class ImportedObjectBaseClass
{

    public string Name { get; set; }
    public string Type { get; set; }
}
}