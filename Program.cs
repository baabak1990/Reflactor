using System.Reflection;
// See https://aka.ms/new-console-template for more information

//Late binding Training
// Execute The assemblly you want First
Assembly GetassymblyType=Assembly.GetExecutingAssembly();
//Secondly get type of that object and try name it after class or other object you want
 Type GetTestReflactorType=GetassymblyType.GetType("Reflactor.TestReflactor");
//After we got our type it is time to create an instance of it
//Just takecare about relations and namings
object GetInstanceOfTestClass=Activator.CreateInstance(GetTestReflactorType);
