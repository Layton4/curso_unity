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


    //concepto de encapsulación
    private void ResetStats() //no se podrá llamar fuera de la clase, solo en la clase. //protegemos de usarlo fuera de aquí
    {
        this.name = "Antonio Banderas";
        this.exp = 0;
    }

    //hagamos un método

    public virtual void PrintCharacterStats() //virtual es para poder hacer override en una clase dentro de la clase
    {
        Debug.Log($"Héroe: {this.name} - {this.exp} exp");
    }
}


public class Paladin : Character //todo lo que haga un character lo puede hacer un paladín, heredándo el acceder a todo
{
    public Weapon weapon;
    public Paladin() : base() //base cogerá los constructores del Character, haciendo nombre por defecto de Paladín
    {

    }

    public Paladin(string name, Weapon weapon) : base(name) //aquí podremos agregarle parámetro name para que lo use en Character
    {
        this.weapon = weapon;

    }

    public override void PrintCharacterStats()
    {
        Debug.Log($"Hola, soy el paladín {this.name} y llevo un(a) {this.weapon.name}");
    }

}
public class Archer : Character
{
    Weapon arch;
    public Archer(string name, Weapon arch) : base(name)
    {
        this.arch = arch;
    }

    public override void PrintCharacterStats()
    {
        base.PrintCharacterStats(); //hace lo que hace el padre
        Debug.Log($"Llevo un(a) {this.arch.name}"); //agrega algo al print character stats para los arqueros
    }

}
public class Magician : Character
{
    Weapon staff;
    public Magician(string name, int exp/*, Weapon staff*/) : base(name, exp)
    {
        this.staff = new Weapon("Bara de magia blanca", 20); //Por defecto los magos llevarían la bara de magia blanca, todos
    }
}

