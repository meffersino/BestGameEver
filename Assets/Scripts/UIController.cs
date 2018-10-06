using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    [SerializeField]
    private Text dayText;
    [SerializeField]
    private Text cityText;
    private City city;
	// Use this for initialization
	void Start () {
        city = GetComponent<City>();
	}
	public void UpdateCityData()
    {
       cityText.text = string.Format("Jobs: {0}/{1}\nCash: £{2} (+£{5})\nPopulation: {3}/{4}",
            city.JobsCurrent, city.JobsCeiling, city.Cash, city.PopulationCurrent, city.PopulationCeiling, city.JobsCurrent*3);
    }
	public void UpdateDayCount()
    {
        dayText.text = string.Format("Day {0}", city.Day);
    }
}
