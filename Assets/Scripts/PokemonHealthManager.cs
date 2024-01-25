using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PokemonHealthManager : MonoBehaviour
{
    [Header("Sasha")]
    [SerializeField] int _sashaActivePokemonMaxHealth = 100;
    [SerializeField] int _sashaReservePokemonMaxHealth = 100;

    [Header("Ondine")]
    [SerializeField] int _ondineActivePokemonMaxHealth = 100;
    [SerializeField] int _ondineReservePokemonMaxHealth = 100;

    [Header("Health Text")]
    [SerializeField] TMP_Text _sashaActivePokemonHealthText;
    [SerializeField] TMP_Text _sashaReservePokemonHealthText;
    [SerializeField] TMP_Text _ondineActivePokemonHealthText;
    [SerializeField] TMP_Text _ondineReservePokemonHealthText;

    int _sashaActivePokemonCurrentHealth;
    int _sashaReservePokemonCurrentHealth;
    int _ondineActivePokemonCurrentHealth;
    int _ondineReservePokemonCurrentHealth;

    private void Start()
    {
        InitializeHealth();
        UpdateHealthText();
    }

    void InitializeHealth()
    {
        _sashaActivePokemonCurrentHealth = _sashaActivePokemonMaxHealth;
        _sashaReservePokemonCurrentHealth = _sashaReservePokemonMaxHealth;
        _ondineActivePokemonCurrentHealth = _ondineActivePokemonMaxHealth;
        _ondineReservePokemonCurrentHealth = _ondineReservePokemonMaxHealth;
    }

    void UpdateHealthText()
    {
        _sashaActivePokemonHealthText.text = $"{_sashaActivePokemonCurrentHealth}/{_sashaActivePokemonMaxHealth}";
        _sashaReservePokemonHealthText.text = $"{_sashaReservePokemonCurrentHealth}/{_sashaReservePokemonMaxHealth}";
        _ondineActivePokemonHealthText.text = $"{_ondineActivePokemonCurrentHealth}/{_ondineActivePokemonMaxHealth}";
        _ondineReservePokemonHealthText.text = $"{_ondineReservePokemonCurrentHealth}/{_ondineReservePokemonMaxHealth}";
    }

    public void AddHealth(bool isSasha, bool isActivePokemon, int amount)
    {
        if (isSasha)
        {
            if (isActivePokemon)
            {
                _sashaActivePokemonCurrentHealth = Mathf.Clamp(_sashaActivePokemonCurrentHealth + amount, 0, _sashaActivePokemonMaxHealth);
            }
            else
            {
                _sashaReservePokemonCurrentHealth = Mathf.Clamp(_sashaReservePokemonCurrentHealth + amount, 0, _sashaReservePokemonMaxHealth);
            }
        }
        else
        {
            if (isActivePokemon)
            {
                _ondineActivePokemonCurrentHealth = Mathf.Clamp(_ondineActivePokemonCurrentHealth + amount, 0, _ondineActivePokemonMaxHealth);
            }
            else
            {
                _ondineReservePokemonCurrentHealth = Mathf.Clamp(_ondineReservePokemonCurrentHealth + amount, 0, _ondineReservePokemonMaxHealth);
            }
        }

        UpdateHealthText();
    }

    public void RemoveHealth(bool isSasha, bool isActivePokemon, int amount)
    {
        if (isSasha)
        {
            if (isActivePokemon)
            {
                _sashaActivePokemonCurrentHealth = Mathf.Clamp(_sashaActivePokemonCurrentHealth - amount, 0, _sashaActivePokemonMaxHealth);
            }
            else
            {
                _sashaReservePokemonCurrentHealth = Mathf.Clamp(_sashaReservePokemonCurrentHealth - amount, 0, _sashaReservePokemonMaxHealth);
            }
        }
        else
        {
            if (isActivePokemon)
            {
                _ondineActivePokemonCurrentHealth = Mathf.Clamp(_ondineActivePokemonCurrentHealth - amount, 0, _ondineActivePokemonMaxHealth);
            }
            else
            {
                _ondineReservePokemonCurrentHealth = Mathf.Clamp(_ondineReservePokemonCurrentHealth - amount, 0, _ondineReservePokemonMaxHealth);
            }
        }

        UpdateHealthText();
    }
}