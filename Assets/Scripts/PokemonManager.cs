using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PokemonManager : MonoBehaviour
{
    [Header("Sasha")]
    [SerializeField] GameObject _sashaActivePokemon;
    [SerializeField] GameObject _sashaReservePokemon;

    [Header("Ondine")]
    [SerializeField] GameObject _ondineActivePokemon;
    [SerializeField] GameObject _ondineReservePokemon;

    [Header("Pokemons")]
    [SerializeField] Sprite _salameche;
    [SerializeField] Sprite _bulbizarre;
    [SerializeField] Sprite _carapuce;

    [Header("Attack")]
    [SerializeField]
    TMP_Text _attackName;

    public void GetSelectedPokemons(List<int> _sashaPokemons, List<int> _ondinePokemons)
    {
        SetPokemon(_sashaActivePokemon, _sashaPokemons[0]);
        SetPokemon(_sashaReservePokemon, _sashaPokemons[1]);
        SetPokemon(_ondineActivePokemon, _ondinePokemons[0]);
        SetPokemon(_ondineReservePokemon, _ondinePokemons[1]);
    }

    private void SetPokemon(GameObject _pokemonGameObject, int _pokemonIndex)
    {
        Image _pokemonImage = _pokemonGameObject.GetComponent<Image>();

        switch (_pokemonIndex)
        {
            case 1:
                _pokemonImage.sprite = _salameche;
                _attackName.text = "Flammèche";
                break;
            case 2:
                _pokemonImage.sprite = _bulbizarre;
                _attackName.text = "Soin";
                break;
            case 3:
                _pokemonImage.sprite = _carapuce;
                _attackName.text = "Pistolet à O";
                break;
        }
    }
}