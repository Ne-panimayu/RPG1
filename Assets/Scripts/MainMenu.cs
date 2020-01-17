using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject canvasMain;

    [SerializeField]
    GameObject canvasLevel;

    public int level;

    public void SelectLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void Selectlevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void SelectLevel3()
    {
        SceneManager.LoadScene(3);
    }


    public void LevelSelection()
    {

        canvasMain.SetActive(false);
        canvasLevel.SetActive(true);

    }

    public void Back()
    {

        canvasMain.SetActive(true);
        canvasLevel.SetActive(false);

    }

    public void QuitGame()
    {
        Application.Quit();
    }




}