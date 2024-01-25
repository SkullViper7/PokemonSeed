using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] PokemonManager _pokemonManager;
    [SerializeField] PokemonHealthManager _pokemonHealthManager;

    public void Charge()
    {
        int _sashaActivePokemonIndex = _pokemonManager.GetCurrentActivePokemonIndex(_pokemonManager._isSashaPokemonActive);
        int _ondineActivePokemonIndex = _pokemonManager.GetCurrentActivePokemonIndex(_pokemonManager._isOndinePokemonActive);

        if (_sashaActivePokemonIndex == 1)
        {
            // Sasha's active Pokemon is Salameche
            if (_ondineActivePokemonIndex == 1)
            {
                // Ondine's active Pokemon is Salameche
                _pokemonHealthManager.RemoveHealth(false, true, 12);
            }
            else if (_ondineActivePokemonIndex == 2)
            {
                // Ondine's active Pokemon is Bulbizarre
                _pokemonHealthManager.RemoveHealth(false, true, 8);
            }
            else if (_ondineActivePokemonIndex == 3)
            {
                // Ondine's active Pokemon is Carapuce
                _pokemonHealthManager.RemoveHealth(false, true, 10);
            }
        }
        // Similar logic for other cases based on Sasha's active Pokemon
    }

    public void SpecialAttack()
    {
        int sashaActivePokemonIndex = _pokemonManager.GetCurrentActivePokemonIndex(_pokemonManager._isSashaPokemonActive);
        int ondineActivePokemonIndex = _pokemonManager.GetCurrentActivePokemonIndex(_pokemonManager._isOndinePokemonActive);

        if (sashaActivePokemonIndex == 1)
        {
            // Sasha's active Pokemon is Salameche
            if (ondineActivePokemonIndex == 1)
            {
                // Ondine's active Pokemon is Salameche
                _pokemonHealthManager.RemoveHealth(false, true, 30);
            }
            else if (ondineActivePokemonIndex == 2)
            {
                // Ondine's active Pokemon is Bulbizarre
                _pokemonHealthManager.RemoveHealth(false, true, 120);
            }
            else if (ondineActivePokemonIndex == 3)
            {
                // Ondine's active Pokemon is Carapuce
                _pokemonHealthManager.RemoveHealth(false, true, 30);
            }
        }
        else if (sashaActivePokemonIndex == 2)
        {
            // Sasha's active Pokemon is Bulbizarre
            // Bulbizarre will gain 30 health points
            _pokemonHealthManager.AddHealth(true, true, 30);
        }
        else if (sashaActivePokemonIndex == 3)
        {
            // Sasha's active Pokemon is Carapuce
            if (ondineActivePokemonIndex == 1)
            {
                // Ondine's active Pokemon is Salameche
                _pokemonHealthManager.RemoveHealth(false, true, 90);
            }
            else if (ondineActivePokemonIndex == 2)
            {
                // Ondine's active Pokemon is Bulbizarre
                _pokemonHealthManager.RemoveHealth(false, true, 45);
            }
            else if (ondineActivePokemonIndex == 3)
            {
                // Ondine's active Pokemon is Carapuce
                _pokemonHealthManager.RemoveHealth(false, true, 22);
            }
        }
        // Similar logic for other cases based on Sasha's active Pokemon
    }
}
