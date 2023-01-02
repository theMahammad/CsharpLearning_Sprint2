using System.Reflection;
string path = @"C:\Users\acer\source\repos\CSharpLearning_Sprint2\ReflectionLibrary\bin\Debug\net6.0\ReflectionLibrary.dll";
Assembly assembly = Assembly.LoadFile(path);
List<Type> types = assembly.GetExportedTypes().ToList();
foreach(Type type in types)
{
    Console.WriteLine($"Class name : {type.Name}");
    #region Constructors
    Console.WriteLine("Its Constructors:");
    ConstructorInfo[] ctors = type.GetConstructors();
    foreach (var ctor in ctors)
    {
        Console.WriteLine(" " + ctor);
    }
    #endregion
    #region Methods
    Console.WriteLine("Its methods : ");
    MethodInfo[] methods = type.GetMethods();
    foreach (var method in methods)
    {
        Console.WriteLine(" " + method);
    }
    #endregion
    #region Properties
    #endregion


    Console.WriteLine("Its properties : ");
        PropertyInfo[] properties = type.GetProperties();
    foreach(var property in properties)
    {
        Console.WriteLine(" "+ property);
    }
    Console.WriteLine("*************************");
}
