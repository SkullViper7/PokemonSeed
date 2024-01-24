using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerrainGenerator : MonoBehaviour
{
    [SerializeField]
    Dropdown _terrain;

    [SerializeField]
    PokemonManager _pokemonManager;

    int _sashaSeed;
    int _ondineSeed;

    List<int> _sashaPokemons = new List<int> { 1, 2, 3 };
    List<int> _ondinePokemons = new List<int> { 1, 2, 3 };

    [SerializeField]
    GameObject _terrainPage;
    [SerializeField]
    GameObject _battlePage;

    public void RandomTerrain()
    {
        switch (_terrain.value)
        {
            case 0:
                {
                    _sashaSeed = 0;
                    _ondineSeed = 150;
                }
                break;
            case 1:
                {
                    _sashaSeed = 10;
                    _ondineSeed = 694;
                }
                break;
            case 2:
                {
                    _sashaSeed = 20;
                    _ondineSeed = 7954;
                }
                break;
        }

        Random.InitState(_sashaSeed);
        _sashaPokemons.RemoveAt(Random.Range(0, _sashaPokemons.Count));

        Random.InitState(_ondineSeed);
        _ondinePokemons.RemoveAt(Random.Range(0, _ondinePokemons.Count));

        Debug.Log(_sashaPokemons[0]);
        Debug.Log(_sashaPokemons[1]);
        Debug.Log(_ondinePokemons[0]);
        Debug.Log(_ondinePokemons[1]);

        _pokemonManager.GetSelectedPokemons(_sashaPokemons, _ondinePokemons);

        _terrainPage.SetActive(false);
        _battlePage.SetActive(true);
    }
}