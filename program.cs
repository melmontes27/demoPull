using System;
//Class persona
public class Persona 
{
    public string Nombre{get; set;}
    public int Edad {get; set;}
    //metodo saludar
    public void Saludar ()
    {
        Console.WriteLine($"Hola {Nombre} como estas, tengo {Edad}");
    }
    
}
//Class alumno hereda persona
public class Alumno : Persona
{
    public string Matricula {get; set;}
    //metodo
    public void Estudiar ()
    {
        Console.WriteLine();
    }
}
//Class profesor hereda persona
public class Profesor : Persona
{
    public string Especialidad {get; set;}
    //metodo
    public void Ensenar ()
    {
        Console.WriteLine();
    }
}

class Program 
{
