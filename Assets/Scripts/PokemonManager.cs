using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonManager : MonoBehaviour
{
    [Header("Sasha")]
    [SerializeField]
    GameObject _sashaPokemon1;
    [SerializeField]
    GameObject _sashaPokemon2;

    [Header("Ondine")]
    [SerializeField]
    GameObject _ondinePokemon1;
    [SerializeField]
    GameObject _ondinePokemon2;

    [Header("Pokemons")]
    [SerializeField]
    ScriptableObject _salameche;
    [SerializeField]
    ScriptableObject _carapuce;
    [SerializeField]
    ScriptableObject _bulbizarre;

    public void GetActivePokemons(List<int> sashaPokemons, List<int> ondinePokemons)
    {
        //switch (sashaPokemons[0])
        //{
        //    case 0: _sashaPokemon1.GetComponent<Image>().sprite = _salameche.
        //}
    }
}