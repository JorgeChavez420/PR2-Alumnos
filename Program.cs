using System;
using System.Collections.Generic;

namespace PR2_Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
        Carreras licEnArtesVisuales = new Carreras("Licenciatura en artes visuales");
        Console.WriteLine("-La primera carrera es: " + licEnArtesVisuales.carrera);

        Semestres segundoSem = new Semestres("Segundo semestre");
        Console.WriteLine("--En el grado de: " + segundoSem.semestre);

        Grupos grupo1 = new Grupos("Grupo 1");
        Console.WriteLine("---Los alumnos del " + grupo1.grupo + " son: ");
        Grupos grupo2 = new Grupos("Grupo 2");
        
            Alumnos alumno1 = new Alumnos("Noah Raul", "Pelaez Gomez", "con matricula", 2141);
            Alumnos alumno2 = new Alumnos("Ainhoa Alberto", "Catala Robles", "con matricula", 2142);
            Alumnos alumno3 = new Alumnos("Gloria Vanessa", "Becerra Torres", "con matricula", 2143);
            Alumnos alumno4 = new Alumnos("Richard Alejandro", "Roig Guevara", "con matricula", 2144);
            Alumnos alumno5 = new Alumnos("Anabel Maria", "Bueno Chavez", "con matricula", 2145);

            Console.WriteLine("1. " + alumno1.NombreCompleto);
            Console.WriteLine("2. " + alumno2.NombreCompleto);
            Console.WriteLine("3. " + alumno3.NombreCompleto);
            Console.WriteLine("4. " + alumno4.NombreCompleto);
            Console.WriteLine("5. " + alumno5.NombreCompleto);


        List<Grupos> grupos = new List<Grupos>();
            grupos.Add(grupo2);
            Console.WriteLine("---Los alumnos del " + grupo2.grupo + " son: ");

            Alumnos alumno6 = new Alumnos("Vicente Abraham", "Godoy Guzman", "con matricula", 2146);
            Alumnos alumno7 = new Alumnos("Ibrahim Luis", "Valencia Martinez", "con matricula", 2147);
            Alumnos alumno8 = new Alumnos("Paulo Sebastian", "Prado Dominguez", "con matricula", 2148);
            Alumnos alumno9 = new Alumnos("Anibal Roberto", "Izquierdo Prado", "con matricula", 2149);
            Alumnos alumno10 = new Alumnos("Ian Fernando", "Exposito Lechuga", "con matricula", 2150);

            Console.WriteLine("6. " + alumno6.NombreCompleto);
            Console.WriteLine("7. " + alumno7.NombreCompleto);
            Console.WriteLine("8. " + alumno8.NombreCompleto);
            Console.WriteLine("9. " + alumno9.NombreCompleto);
            Console.WriteLine("10. " + alumno10.NombreCompleto);

            Console.WriteLine("------");

        Carreras ingEnMultimedia = new Carreras("Ingenieria en Multimedia");
            Console.WriteLine("-La segunda carrera es: " + ingEnMultimedia.carrera);

            Semestres tercerSem1 = new Semestres("Tercer semestre");
        Console.WriteLine("--En el grado de: " + tercerSem1.semestre);

        Grupos grupo3 = new Grupos("Grupo 1");
            Console.WriteLine("---Los alumnos del " + grupo3.grupo + " son: ");
        Grupos grupo4 = new Grupos("Grupo 2");

            Alumnos alumno11 = new Alumnos("Lidia Sara", "Perera Gomez", "con matricula", 3141);
            Alumnos alumno12 = new Alumnos("Maria Anahi", "Rojas Perez ", "con matricula", 3142);
            Alumnos alumno13 = new Alumnos("Lizbeth Vanessa", "Mendoza Torres", "con matricula", 3143);
            Alumnos alumno14 = new Alumnos("Pavel Irving", "Ruiz Guevara", "con matricula", 3144);
            Alumnos alumno15 = new Alumnos("Lizeth Irlanda", "Ontillon Chavez", "con matricula", 3145);

            Console.WriteLine("1. " + alumno11.NombreCompleto);
            Console.WriteLine("2. " + alumno12.NombreCompleto);
            Console.WriteLine("3. " + alumno13.NombreCompleto);
            Console.WriteLine("4. " + alumno14.NombreCompleto);
            Console.WriteLine("5. " + alumno15.NombreCompleto);

            List<Grupos> grupos1 = new List<Grupos>();
            grupos1.Add(grupo4);
            Console.WriteLine("---Los alumnos del " + grupo4.grupo + " son: ");

            Alumnos alumno16 = new Alumnos("Bonifacio Raul", "Perera Merchan", "con matricula", 3146);
            Alumnos alumno17 = new Alumnos("Mariam Andres", "Rojas Ali ", "con matricula", 3147);
            Alumnos alumno18 = new Alumnos("Lizbeth Rufina", "De la rosa Torres", "con matricula", 3148);
            Alumnos alumno19 = new Alumnos("Tomas Angel", "Mercedes Guevara", "con matricula", 3149);
            Alumnos alumno20 = new Alumnos("Luis Alejandro", "Bencomo Ruiz", "con matricula", 3150);

            Console.WriteLine("6. " + alumno16.NombreCompleto);
            Console.WriteLine("7. " + alumno17.NombreCompleto);
            Console.WriteLine("8. " + alumno18.NombreCompleto);
            Console.WriteLine("9. " + alumno19.NombreCompleto);
            Console.WriteLine("10. " + alumno20.NombreCompleto);

        }
    }
}
