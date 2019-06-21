using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TopButtonScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
    
    }

    public void OnClick()
    {
        StartCoroutine("ChangeToStartPageScene");
    }

   public IEnumerator ChangeToStartPageScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("StartPageScene");
    }
}
