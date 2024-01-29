// MainProject.cs
class Program
{
    static void Main()
    {
        // Попытка создать экземпляр класса InternalClass (неудачная из-за модификатора internal)
        // InternalClass internalInstance = new InternalClass(); // Эта строка вызовет ошибку компиляции

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
