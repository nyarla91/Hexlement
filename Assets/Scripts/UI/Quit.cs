using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void QuitGame() => StartCoroutine(QuitGameIE());

    private IEnumerator QuitGameIE()
    {
        yield return new WaitForSeconds(0.25f);
        Application.Quit();
    }
}
