using System;
using System.Reflection;

namespace Reflection_dll
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly myAssembly = Assembly.LoadFile(@"C:\Users\Sanket V\source\repos\DLL_File\DLL_File\bin\Debug\netcoreapp3.1\DLL_File.dll");

            Type myType = myAssembly.GetType("DLL_File.Class1");

            object objInstance = Activator.CreateInstance(myType);

            Type objectTypes = objInstance.GetType();
            Console.WriteLine("Reading metadata of an assembly via Reflection");
            Console.WriteLine("************************");
            foreach (MemberInfo objMemberInfo in objectTypes.GetMembers())
            {
                Console.WriteLine(objMemberInfo.Name);
            }
            Console.WriteLine("************************");
            Console.WriteLine("Invoking particular method via Reflection");
            objectTypes.InvokeMember("PrintClassName", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.Instance, null, objInstance, null);

            Console.WriteLine("************************");
            Console.WriteLine("Invoking particular method with inputs using Reflection");
            double answer = (double)objectTypes.InvokeMember("Sum", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.Instance, null, objInstance, new object[] { 20, 10 });

            Console.WriteLine(answer);

            //Setting value to a property
            PropertyInfo numberPropertyInfo = objectTypes.GetProperty("SetNum1");
            numberPropertyInfo.SetValue(objInstance, 10, null);

            //Getting value of a property
            //PropertyInfo numberPropertyInfo = objectTypes.GetProperty("SetNum1");
            //int value = (int)numberPropertyInfo.GetValue(objInstance, null);
        }
    }
}
