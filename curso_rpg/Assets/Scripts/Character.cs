using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Weapon
{
    public string name; //las variables no pueden tomar valores por defecto
    public int damage;

    public Weapon(string name, int damage) //y todas las variables en una estructura tienen que tener valor, obligado
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.Log($"Arma: {this.name} - daño: {this.damage}");
    }


}



public class Character
{
    public string name;
    public int exp = 0;

    public Character() //constructor por defecto ahora se llamará al llamar al constructor por defecto que el nombre por defecto es Antonio Banderas
    {
        name = "Antonio Banderas";
    }

    public Character(string name)
    {
        this.name = name; //this hace referencia a mi name, el de la clase, no al parámetro name del parentesis
    }

    public Character(string name, int exp)
    {
        this.name = name;
        this.exp = exp;
    }

    //hagamos un método

    public void PrintCharacterStats()
    {
        Debug.Log($"Héroe: {this.name} - {this.exp} exp");
    }
}