using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Country", menuName = "Country/Other")]
public class CountryScript : ScriptableObject
{
    public Sprite CountryLook;
    public string CountryOwner;
    public int TroopCount;
    public string CountryName;
    public double CountryX;
    public double CountryY;
    public string LandAdjacentCountries;
    public string SeaAdjacentCountries;
    public string CountryResources;

}