using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFirstScript : MonoBehaviour
{


    /// <summary>
    /// Variables
    /// 
    /// COLECCIONES
    /// arrays
    /// listas
    /// diccionarios
    /// 
    /// BUCLES!!!
    /// Bucle For y b�squedas
    /// Foreach
    /// While
    /// 
    /// PROGRAMACI�N ORIENTADA A OBJETOS
    /// 
    /// Clases vs structuras
    /// </summary>
    /// 

    //public int carDoors = 4;
    public int x = 2;
    public int y = 3;


    public int hour = 23;
    public float pi = 3.14f;
    public string game = "Objetivo cumplido";
    public bool spiderman = true;


    //Arrays: no puede crecer el n�mero de elementos que tiene, solo modificar su interior, pero no a�adir ni quitar numero de elementos.
    public int[] ranking = new int[4]; //luego introducimos los elementos, en unity, pero tiene 4 elementos el array
    public int[] ranking2 = new int[] { 1, 2, 4, 5 }; //tiene 4 elementos y es fijado los valores del array

    //Lists

    public List<string> partyMembers = new List<string>() { "Aragorn", "Gimli", "L�golas" };

    //Diccionary
    //Diccionary<KeyType, valueType> varName = new Dictionary<KeyType, valueType> {{clave1,valor1},{clave1,valor2}....}
    public Dictionary<string, int> inventory = new Dictionary<string, int>()
    {
        {"Potion", 3},
        {"Antorcha", 5},
        {"Espada", 1},
        {"Ant�doto", 2},
        {"Flecha", 29},
        {"Hacha", 1},
    };


    void Start()
    {

        /*
        //Debug.Log(3 + 5);
        //Debug.Log(carDoors - 3);
        AddTwoNumbers();

        //consultar Array
        Debug.Log(ranking[1]);

        //consultar Lista:
        Debug.Log($"nuestra comunidad tiene {partyMembers.Count} miembros");
        Debug.Log(partyMembers[0]);
        Debug.Log(partyMembers[1]);
        Debug.Log(partyMembers[2]);

        //a�adimos 1 objeto al final de partyMembers(lista)

        partyMembers.Add("Gandalf");
        partyMembers.Add("Frodo");

        //A�adimos 1 objeto en la posici�n que le indiquemos de partyMembers(lista)
        Debug.Log($"Ahora somos {partyMembers.Count} miembros");
        partyMembers.Insert(2, "Sam");
        partyMembers.Insert(3, "Pipi");
        partyMembers.Insert(4, "Merry");
        partyMembers.Add("Boromir");
        Debug.Log($"De acuerdo, somos {partyMembers.Count} miembros");
        
        //Eliminamos un objeto espec�fico que queramos de partyMembers(lista) o el que se situa en la posici�n que le digamos
        partyMembers.Remove("Boromir");
        Debug.Log($"Ha muerto uno de nosotros, ahora somos {partyMembers.Count} miembros");
        partyMembers.RemoveAt(6);

        //cuantos elementos tiene el diccionario
        Debug.Log($"Tienes {inventory.Count} elementos en el inventario");

        //cambiar datos al diccionario

        inventory["Potion"] = 10;

        //agregar datos a diccionario
        inventory.Add("Venda", 9); //modo ortodoxo
        inventory["cuchillo"] = 4; //forma r�pida

        //comprobar si contiene un elemento un diccionario
        if(inventory.ContainsKey("cuerda"))
        {
            inventory["cuerda"] -= 1; //consumimos 1 cuerda si tenemos
            if (inventory["cuerda"] == 0)
            {
                inventory.Remove("Cuerda");
            }
        }


        //Bucle For:

        /* for(inicializacion; condicion; iteracion)
         {
         }
        */

        /*
        for(int i = 0; i < partyMembers.Count; i += 1)
        {
            Debug.Log($"posici�n {i} - {partyMembers[i]}");
        }

        
        //recorrido hacia atr�s con for

        for (int i = ranking.Length - 1;  i >= 0; i--)
        {
            Debug.Log(ranking[i]);
        }

        //busqueda en una lista con un for

        bool found = false;

        for (int i= 0; i < partyMembers.Count && !found; i++)
        {
            string currentCharacter = partyMembers[i];
            if (currentCharacter == "Gollum")
            {
                Debug.Log($"Encontr� a {currentCharacter}");
                found = true;
            }
        }

        if (found)
        {
            Debug.Log("He encontrado al personaje");
        }
        else
        {
            Debug.Log("No he podido encontrar ese personaje");
        }


        //Foreach
        /*
        foreach(elementType localVar in collectionVar)
        {

        }
        pongamos un ejemplo:
        */

        /*
        foreach(string partyMember in partyMembers)
        {
            Debug.Log(partyMember); //imprimir� el nombre de cada partyMember en orden
        }

        foreach(int score in ranking)
        {
            Debug.Log(score);
        }

        //que pasa si queremos acceder a un diccionario en vez de una lista o un array? hay una modificaci�n del foreach

        foreach(KeyValuePair<string, int> kvp in inventory)
        {
            Debug.Log($"Item: {kvp.Key} - {kvp.Value}");
        }

        //busqueda en diccionarios
        foreach(string partyMember in partyMembers)
        {
            if (partyMember == "Frodo")
            {
                Debug.Log($"Encontr� a {partyMember}");
                break;
            }
        }


        //buscar el que tenga m�s en el inventario

        string item = "";
        foreach (KeyValuePair<string, int> kvp in inventory)
        {
            Debug.Log($"Item: {kvp.Key} - {kvp.Value}");
            if (!inventory.ContainsKey(item) || inventory[item] < kvp.Value) //si no est� en el inventario o que tienes m�s cantidad de elementos que el anterior mayor item
            {
                item = kvp.Key;
            }

        }

        Debug.Log($"El item con m�s existencias de tu inventario es {item} y tienes {inventory[item]} unidades");


        //While
        /* While(condicion)
         * {
         * }
         */

        /*
        int numberOfLifes = 3;

        while(numberOfLifes > 0)
        {
            Debug.Log("Aun sigo vivo!! -1 vida");
            numberOfLifes--;
        }
        Debug.Log("Personaje muerto, Game Over");


        */

        //PROGRAMACI�N ORIENTADA A OBJETOS

        Character hero = new Character();

        //Debug.Log($"Heroe: {hero.name} - {hero.exp} exp");
        hero.PrintCharacterStats();

        //PRUEBA IMPORTANTE DE QUE NO SON VALORES SINO REFERENCIAS LO QUE GUARDAMOS EN CLASES
        Character hero2 = hero;
        hero2.PrintCharacterStats(); //Antonio Banderas - 0 exp
        hero2.name = "Madonna";
        hero.PrintCharacterStats();
        hero2.PrintCharacterStats(); //al haber cambiado el nombre del personaje en hero2 la referencia cambia y por lo tanto
        //los dos characters se llamar�n madonna ahora.


        Character heroine = new Character("Lara Croft");
        //Debug.Log($"Heroe: {heroine.name} - {hero.exp} exp");
        heroine.PrintCharacterStats();

        //Character archer = new Character();


        //Structs:
        Weapon sword = new Weapon("Espada roma", 5);
        sword.PrintWeaponStats(); //Espada roma
        Weapon sword2 = sword;
        sword2.PrintWeaponStats(); //Espada roma

        sword2.name = "Excalibur";
        sword2.damage = 255;

        sword.PrintWeaponStats(); //Espada roma
        sword2.PrintWeaponStats(); //Excalibur
        //las estructuras no van como las clases, la estructura te permite hacer esto de arriba

    }
    void Update()
    {
        
    }

    void AddTwoNumbers()
    {
        Debug.Log(x + y);
    }
}
