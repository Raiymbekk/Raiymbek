// MainProject.cs
class Programmain
{
    static void Main()
    {


        // Создание объекта другого класса и вызов метода PrintMessage()
        ExternalClass externalInstance = new ExternalClass();
        externalInstance.CallInternalMethod();
    }
}

public class ExternalClass
{
    public void CallInternalMethod()
    {
        InternalClass internalInstance = new InternalClass();
        internalInstance.PrintMessage();
    }
}