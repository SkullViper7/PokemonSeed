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

    bool[] _sashaHasPokemon = new bool[3];
    bool[] _ondineHasPokemon = new bool[3];

    public bool[] _isSashaPokemonActive = new bool[3];
    public bool[] _isOndinePokemonActive = new bool[3];

    public void GetSelectedPokemons(List<int> _sashaPokemons, List<int> _ondinePokemons)
    {
        SetActivePokemon(_sashaPokemons[0], _ondinePokemons[0]);
        SetPokemon(_sashaActivePokemon, _sashaPokemons[0], _sashaHasPokemon);
        SetPokemon(_sashaReservePokemon, _sashaPokemons[1], _sashaHasPokemon);
        SetPokemon(_ondineActivePokemon, _ondinePokemons[0], _ondineHasPokemon);
        SetPokemon(_ondineReservePokemon, _ondinePokemons[1], _ondineHasPokemon);
    }

    void SetPokemon(GameObject _pokemonGameObject, int _pokemonIndex, bool[] _hasPokemonArray)
    {
        if (_pokemonIndex >= 1 && _pokemonIndex <= _hasPokemonArray.Length)
        {
            int index = _pokemonIndex - 1;

            switch (_pokemonIndex)
            {
                case 1:
                    _pokemonGameObject.GetComponent<Image>().sprite = _salameche;
                    _hasPokemonArray[index] = true;
                    break;
                case 2:
                    _pokemonGameObject.GetComponent<Image>().sprite = _bulbizarre;
                    _hasPokemonArray[index] = true;
                    break;
                case 3:
                    _pokemonGameObject.GetComponent<Image>().sprite = _carapuce;
                    _hasPokemonArray[index] = true;
                    break;
            }
        }
    }

    public void SetActivePokemon(int _sashaActivePokemon, int _ondineActivePokemon)
    {
        SetActivePokemonHelper(_sashaHasPokemon, _isSashaPokemonActive, _sashaActivePokemon);
        SetActivePokemonHelper(_ondineHasPokemon, _isOndinePokemonActive, _ondineActivePokemon);

        SetAttackName(_sashaActivePokemon);
    }

    void SetActivePokemonHelper(bool[] _hasPokemon, bool[] _isActivePokemon, int _activePokemonIndex)
    {
        if (_activePokemonIndex >= 1 && _activePokemonIndex <= _hasPokemon.Length)
        {
            int index = _activePokemonIndex - 1;
            if (_hasPokemon[index])
            {
                _isActivePokemon[index] = true;
            }
        }
    }

    void SetAttackName(int activePokemonIndex)
    {
        string attackName = "Attaque Spé";

        if (activePokemonIndex >= 1 && activePokemonIndex <= _isSashaPokemonActive.Length)
        {
            int index = activePokemonIndex - 1;

            if (_isSashaPokemonActive[index])
            {
                switch (activePokemonIndex)
                {
                    case 1:
                        attackName = "Flammèche";
                        break;
                    case 2:
                        attackName = "Soin";
                        break;
                    case 3:
                        attackName = "Pistolet à O";
                        break;
                }
            }
        }

        _attackName.text = attackName;
    }

    public void SetSashaActivePokemon(int newActivePokemonIndex)
    {
        int currentActiveIndex = GetCurrentActivePokemonIndex(_isSashaPokemonActive);

        // Swap the sprites and active states
        SwapPokemonSprites(_sashaActivePokemon, _sashaReservePokemon, currentActiveIndex, newActivePokemonIndex);
        SwapPokemonActiveStates(_isSashaPokemonActive, currentActiveIndex, newActivePokemonIndex);

        // Update attack name based on the new active Pokémon
        SetAttackName(newActivePokemonIndex);
    }

    public int GetCurrentActivePokemonIndex(bool[] isActiveArray)
    {
        for (int i = 0; i < isActiveArray.Length; i++)
        {
            if (isActiveArray[i])
            {
                return i + 1; // Return 1-based index
            }
        }

        return -1; // No active Pokémon found
    }

    void SwapPokemonSprites(GameObject pokemon1, GameObject pokemon2, int index1, int index2)
    {
        Image image1 = pokemon1.GetComponentInChildren<Image>();
        Image image2 = pokemon2.GetComponentInChildren<Image>();

        if (image1 != null && image2 != null)
        {
            Sprite sprite1 = GetPokemonSprite(index1);
            Sprite sprite2 = GetPokemonSprite(index2);

            image1.sprite = sprite2;
            image2.sprite = sprite1;
        }
    }

    void SwapPokemonActiveStates(bool[] isActiveArray, int index1, int index2)
    {
        if (index1 >= 1 && index1 <= isActiveArray.Length && index2 >= 1 && index2 <= isActiveArray.Length)
        {
            isActiveArray[index1 - 1] = false;
            isActiveArray[index2 - 1] = true;
        }
    }

    Sprite GetPokemonSprite(int pokemonIndex)
    {
        switch (pokemonIndex)
        {
            case 1:
                return _salameche;
            case 2:
                return _bulbizarre;
            case 3:
                return _carapuce;
            default:
                return null;
        }
    }
}