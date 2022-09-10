using Task_03_AttributePractice;

Worker worker = new("Vasily");
Manager manager = new("Vital");
Director director = new("Anton Feodosevich");

GetAccess(worker, AccesLevelType.TopLevelSecret);
GetAccess(manager, AccesLevelType.PublicTrust);
GetAccess(director, AccesLevelType.TopLevelSecret);

static void GetAccess(Employee emp, AccesLevelType accessLevel)
{
    Type typeOfEmp = emp.GetType();

    object[] attribute = typeOfEmp.GetCustomAttributes(typeof(AccessLevelAttribute), true);
    bool isAccess = false;
    foreach (AccessLevelAttribute partArr in attribute)
    {
        if ((int)partArr.type >= (int)accessLevel)
            isAccess = true;
    }
    string text = isAccess ? "Your level is approved" : "Your level is prohibit";
    Console.WriteLine(text);
}

/*
Создать перечисление AccesLevelType. Создать атрибут AccessLevelAttribute. 
Создать классы Director, Manager, Worker и создать базовый класс Employee.
Декорировать эти три класса атрибутом AccessLevelAttribute - каждому работнику 
назначить свой уровень доступа через атрибут. В классе Program создать метод GetAccess, 
который будет принимать два параметра - параметр типа Employee, параметр типа AccessLevelType. 
Внутри метода для параметра Employee через  AccessLevelAttribute узнать уровень доступа сотрудника
и сравнить с параметром AccessLevelType. Если уровень доступа сотрудника совпадает или выше с уровнем доступа, 
который был в качестве аргумента методу, то вы вести сообщение "Доступ к данным разрешен"(можно свое сообщение придумать),
в противном случае, вывести "Доступ к данным разрешен". В методе main создать сотрудников и попробовать вызвать метод GetAccess.
*/