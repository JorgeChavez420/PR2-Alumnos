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
        Console.WriteLine("--En el grado de: " + segundoSem.semestre + "--");

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

        Semestres cuartoSem = new Semestres("Cuarto semestre");
            Console.WriteLine("--En el grado de: " + cuartoSem.semestre + "--");

            Grupos grupo11 = new Grupos("Grupo 1");
        Console.WriteLine("---Los alumnos del " + grupo11.grupo + " son: ");
          
            Alumnos alumno21 = new Alumnos("Raul Ramses", "Gomez Mendoza", "con matricula", 4141);
            Alumnos alumno22 = new Alumnos("Ain Albert", "Catala Robles", "con matricula", 4142);
            Alumnos alumno23 = new Alumnos("Victoria Vane", "Mendez Torres", "con matricula", 4143);
            Alumnos alumno24 = new Alumnos("Rich Jake", "Roig Watson", "con matricula", 4144);
            Alumnos alumno25 = new Alumnos("Marcos Angel", "Chavira Chavez", "con matricula", 4145);

            Console.WriteLine("1. " + alumno21.NombreCompleto);
            Console.WriteLine("2. " + alumno22.NombreCompleto);
            Console.WriteLine("3. " + alumno23.NombreCompleto);
            Console.WriteLine("4. " + alumno24.NombreCompleto);
            Console.WriteLine("5. " + alumno25.NombreCompleto);

            Semestres sextoSem = new Semestres("Sexto semestre");
            Console.WriteLine("--En el grado de: " + sextoSem.semestre + "--");

            Grupos grupo12 = new Grupos("Grupo 1");
        Console.WriteLine("---Los alumnos del " + grupo12.grupo + " son: ");

            Alumnos alumno26 = new Alumnos("Jaime Alan", "Ruiz Mendoza", "con matricula", 6141);
            Alumnos alumno27 = new Alumnos("Aaron Alejandro", "Sabino Robles", "con matricula", 6142);
            Alumnos alumno28 = new Alumnos("Ana Vanessa", "Mendez Torres", "con matricula", 6143);
            Alumnos alumno29 = new Alumnos("Jhon Peter", "Jackson Watson", "con matricula", 6144);
            Alumnos alumno30 = new Alumnos("Luis Angel", "Torres Chavez", "con matricula", 6145);

            Console.WriteLine("1. " + alumno26.NombreCompleto);
            Console.WriteLine("2. " + alumno27.NombreCompleto);
            Console.WriteLine("3. " + alumno28.NombreCompleto);
            Console.WriteLine("4. " + alumno29.NombreCompleto);
            Console.WriteLine("5. " + alumno30.NombreCompleto);

            Semestres octavoSem = new Semestres("Octavo semestre");
            Console.WriteLine("--En el grado de: " + octavoSem.semestre + "--");

            Grupos grupo13 = new Grupos("Grupo 1");
            Console.WriteLine("---Los alumnos del " + grupo13.grupo + " son: ");

            Alumnos alumno31 = new Alumnos("Jhonny Roberto", "Coronado Martinez", "con matricula", 8141);
            Alumnos alumno32 = new Alumnos("Javier Angel", "Palacios Robles", "con matricula", 8142);
            Alumnos alumno33 = new Alumnos("Ana Victoria", "Mendez Torres", "con matricula", 8143);
            Alumnos alumno34 = new Alumnos("Walter Jhon", "White Watson", "con matricula", 8144);
            Alumnos alumno35 = new Alumnos("Dean Jake", "Domino Jersey", "con matricula", 8145);

            Console.WriteLine("1. " + alumno31.NombreCompleto);
            Console.WriteLine("2. " + alumno32.NombreCompleto);
            Console.WriteLine("3. " + alumno33.NombreCompleto);
            Console.WriteLine("4. " + alumno34.NombreCompleto);
            Console.WriteLine("5. " + alumno35.NombreCompleto);
            
            Console.WriteLine("------");

        Carreras ingEnMultimedia = new Carreras("Ingenieria en Multimedia");
            Console.WriteLine("-La segunda carrera es: " + ingEnMultimedia.carrera);

            Semestres segundoSem1 = new Semestres("Segundo semestre");
        Console.WriteLine("--En el grado de: " + segundoSem1.semestre + "--");

        Grupos grupo3 = new Grupos("Grupo 1");
            Console.WriteLine("---Los alumnos del " + grupo3.grupo + " son: ");
        Grupos grupo4 = new Grupos("Grupo 2");

            Alumnos alumno11 = new Alumnos("Lidia Sara", "Perera Gomez", "con matricula", 2241);
            Alumnos alumno12 = new Alumnos("Maria Anahi", "Rojas Perez ", "con matricula", 2242);
            Alumnos alumno13 = new Alumnos("Lizbeth Vanessa", "Mendoza Torres", "con matricula", 2243);
            Alumnos alumno14 = new Alumnos("Pavel Irving", "Ruiz Guevara", "con matricula", 2244);
            Alumnos alumno15 = new Alumnos("Lizeth Irlanda", "Ontillon Chavez", "con matricula", 2245);

            Console.WriteLine("1. " + alumno11.NombreCompleto);
            Console.WriteLine("2. " + alumno12.NombreCompleto);
            Console.WriteLine("3. " + alumno13.NombreCompleto);
            Console.WriteLine("4. " + alumno14.NombreCompleto);
            Console.WriteLine("5. " + alumno15.NombreCompleto);

            List<Grupos> grupos1 = new List<Grupos>();
            grupos1.Add(grupo4);
            Console.WriteLine("---Los alumnos del " + grupo4.grupo + " son: ");

            Alumnos alumno16 = new Alumnos("Bonifacio Raul", "Perera Merchan", "con matricula", 2246);
            Alumnos alumno17 = new Alumnos("Mariam Andres", "Rojas Ali ", "con matricula", 2247);
            Alumnos alumno18 = new Alumnos("Lizbeth Rufina", "De la rosa Torres", "con matricula", 2248);
            Alumnos alumno19 = new Alumnos("Tomas Angel", "Mercedes Guevara", "con matricula", 2249);
            Alumnos alumno20 = new Alumnos("Luis Alejandro", "Bencomo Ruiz", "con matricula", 2250);

            Console.WriteLine("6. " + alumno16.NombreCompleto);
            Console.WriteLine("7. " + alumno17.NombreCompleto);
            Console.WriteLine("8. " + alumno18.NombreCompleto);
            Console.WriteLine("9. " + alumno19.NombreCompleto);
            Console.WriteLine("10. " + alumno20.NombreCompleto);

            Semestres cuartoSem1 = new Semestres("Cuarto semestre");
            Console.WriteLine("--En el grado de: " + cuartoSem1.semestre + "--");

            Grupos grupo14 = new Grupos("Grupo 1");
            Console.WriteLine("---Los alumnos del " + grupo14.grupo + " son: ");

            Alumnos alumno36 = new Alumnos("Victor Rogelio", "Paredes Gomez", "con matricula", 4241);
            Alumnos alumno37 = new Alumnos("Maria Ayleen", "Jimenez Perez ", "con matricula", 4242);
            Alumnos alumno38 = new Alumnos("Luisa Fernanda", "Ronquillo Torres", "con matricula", 4243);
            Alumnos alumno39 = new Alumnos("Pavel Aaron", "Juarez Guevara", "con matricula", 4244);
            Alumnos alumno40 = new Alumnos("Lizeth Joana", "Ontillon Jimenez", "con matricula", 4245);

            Console.WriteLine("1. " + alumno36.NombreCompleto);
            Console.WriteLine("2. " + alumno37.NombreCompleto);
            Console.WriteLine("3. " + alumno38.NombreCompleto);
            Console.WriteLine("4. " + alumno39.NombreCompleto);
            Console.WriteLine("5. " + alumno40.NombreCompleto);

            Semestres sextoSem1 = new Semestres("Sexto semestre");
            Console.WriteLine("--En el grado de: " + sextoSem1.semestre + "--");

            Grupos grupo15 = new Grupos("Grupo 1");
            Console.WriteLine("---Los alumnos del " + grupo15.grupo + " son: ");

            Alumnos alumno41 = new Alumnos("Pablo Yahir", "Frias Jimenez", "con matricula", 6241);
            Alumnos alumno42 = new Alumnos("Marcela Ayleen", "Zapata Perez ", "con matricula", 6242);
            Alumnos alumno43 = new Alumnos("Luisa Maria", "Ronquillo Valles", "con matricula", 6243);
            Alumnos alumno44 = new Alumnos("Pavel Oziel", "Juarez Mendez", "con matricula", 6244);
            Alumnos alumno45 = new Alumnos("Martha Joana", "Loera Jimenez", "con matricula", 6245);

            Console.WriteLine("1. " + alumno41.NombreCompleto);
            Console.WriteLine("2. " + alumno42.NombreCompleto);
            Console.WriteLine("3. " + alumno43.NombreCompleto);
            Console.WriteLine("4. " + alumno44.NombreCompleto);
            Console.WriteLine("5. " + alumno45.NombreCompleto);

            Semestres octavoSem1 = new Semestres("Octavo semestre");
            Console.WriteLine("--En el grado de: " + octavoSem1.semestre + "--");

            Grupos grupo16 = new Grupos("Grupo 1");
            Console.WriteLine("---Los alumnos del " + grupo16.grupo + " son: ");

            Alumnos alumno46 = new Alumnos("Yara Gizel", "Loera Jimenez", "con matricula", 8241);
            Alumnos alumno47 = new Alumnos("Martha Ayleen", "Zapata Robles ", "con matricula", 8242);
            Alumnos alumno48 = new Alumnos("Gabriela Maria", "Almeda Valles", "con matricula", 8243);
            Alumnos alumno49 = new Alumnos("Gilberto Oziel", "Carrillo Mendez", "con matricula", 8244);
            Alumnos alumno50 = new Alumnos("Patricia Evelyn", "Casillas Juarez", "con matricula", 8245);

            Console.WriteLine("1. " + alumno46.NombreCompleto);
            Console.WriteLine("2. " + alumno47.NombreCompleto);
            Console.WriteLine("3. " + alumno48.NombreCompleto);
            Console.WriteLine("4. " + alumno49.NombreCompleto);
            Console.WriteLine("5. " + alumno50.NombreCompleto);



        }
    }
}
