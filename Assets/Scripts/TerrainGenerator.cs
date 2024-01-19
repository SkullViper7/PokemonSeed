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

    List<int> sashaPokemons = new List<int> { 1, 2, 3 };
    List<int> ondinePokemons = new List<int> { 1, 2, 3 };

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
        sashaPokemons.RemoveAt(Random.Range(0, sashaPokemons.Count));

        Random.InitState(_ondineSeed);
        ondinePokemons.RemoveAt(Random.Range(0, ondinePokemons.Count));

        Debug.Log(sashaPokemons[0]);
        Debug.Log(sashaPokemons[1]);
        Debug.Log(ondinePokemons[0]);
        Debug.Log(ondinePokemons[1]);

        _pokemonManager.GetActivePokemons(sashaPokemons, ondinePokemons);

        _terrainPage.SetActive(false);
        _battlePage.SetActive(true);
    }
}