using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "ScriptableObjects/Pokemons")]

public class PokemonSO : ScriptableObject
{
    public int pv;
    public int damage;
    public int defense;
    public int speed;
    public string type;
    public Texture2D sprite;
}