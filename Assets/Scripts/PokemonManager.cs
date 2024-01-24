using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonManager : MonoBehaviour
{
    [Header("Sasha")]
    [SerializeField] GameObject _sashaPokemon1;
    [SerializeField] GameObject _sashaPokemon2;

    [Header("Ondine")]
    [SerializeField] GameObject _ondinePokemon1;
    [SerializeField] GameObject _ondinePokemon2;

    [Header("Pokemons")]
    [SerializeField] Sprite _salameche;
    [SerializeField] Sprite _bulbizarre;
    [SerializeField] Sprite _carapuce;

    public void GetActivePokemons(List<int> sashaPokemons, List<int> ondinePokemons)
    {
        SetPokemon(_sashaPokemon1, sashaPokemons[0]);
        SetPokemon(_sashaPokemon2, sashaPokemons[1]);
        SetPokemon(_ondinePokemon1, ondinePokemons[0]);
        SetPokemon(_ondinePokemon2, ondinePokemons[1]);
    }

    private void SetPokemon(GameObject pokemonGameObject, int pokemonIndex)
    {
        Image pokemonImage = pokemonGameObject.GetComponent<Image>();

        switch (pokemonIndex)
        {
            case 1:
                pokemonImage.sprite = _salameche;
                break;
            case 2:
                pokemonImage.sprite = _bulbizarre;
                break;
            case 3:
                pokemonImage.sprite = _carapuce;
                break;
        }
    }
}