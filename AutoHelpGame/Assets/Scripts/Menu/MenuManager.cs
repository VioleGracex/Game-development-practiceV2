using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame() 
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadUpgradeScene() 
    {
        SceneManager.LoadScene("UpgradeMenu");
    }
    public void LoadCarWashScene()
    {
        SceneManager.LoadScene("CarWashMenu");
    }
    public void LoadSalesScene()
    {
        SceneManager.LoadScene("SalesMenu");
    }
    public void LoadRepairScene()
    {
        SceneManager.LoadScene("RepairMenu");
    }
	public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadStockMenu()
    {
        SceneManager.LoadScene("StockScene");
    }
}
