using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public Image img;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(HideGame());
            this.gameObject.GetComponent<Collider2D>().enabled = false;
        }
            
    }
    IEnumerator HideGame()
    {
        for (int i = 0; i <= 255; i += 10)
        {
            img.GetComponent<Image>().color = new Color32(255, 255, 225, (byte)i);
            yield return new WaitForSeconds(0.04f);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
