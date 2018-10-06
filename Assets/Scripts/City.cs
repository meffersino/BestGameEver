using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour {
    public int Cash { get; set; }
    public int Day { get; set; }
    public int PopulationCurrent { get; set; }
    public int PopulationCeiling { get; set; }
    public int JobsCurrent { get; set; }
    public int JobsCeiling { get; set; }

    public int[] buildingCounts = new int[4];
    private UIController uiController;




    // Use this for initialization
    void Start () {
        uiController = GetComponent<UIController>();
        Cash = 100;
        JobsCeiling = 10;
	}
	public void EndTurn()
    {
        Day++;
        CalculateCash();
        CalculatePopulation();
        CalculateJobs();
        Debug.Log("Day Ended");
        uiController.UpdateCityData();
        uiController.UpdateDayCount();
        Debug.LogFormat("Jobs: {0}/{1}, Cash: {2}, pop: {3}/{4}",
            JobsCurrent, JobsCeiling, Cash, PopulationCurrent, PopulationCeiling);
    }

    void CalculateJobs()
    {
        JobsCeiling = (buildingCounts[3] * 10) +( buildingCounts[2] * 4);
        JobsCurrent = Mathf.Min((int)PopulationCurrent, JobsCeiling);
    }

    void CalculateCash()
    {
        Cash += JobsCurrent * 3;
    }

    public void DepositCash(int cash)
    {
        Cash += cash;
    }

    void CalculatePopulation()
    {
        PopulationCeiling = buildingCounts[1] * 4;
        PopulationCurrent = Mathf.Min((int)buildingCounts[2] * 10, PopulationCeiling);
     }
	
}
