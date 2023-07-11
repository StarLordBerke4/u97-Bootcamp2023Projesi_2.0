using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public void PlayBtn ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    string moreGamesUrl = "https://github.com/StarLordBerke4/u97-Bootcamp2023Projesi_2.0";
    string feedback = "mailto:info@oyunveuygulamaakademisi.com";
    string youtubeUrl = "https://www.youtube.com/@oyunveuygulamaakademisi2756";

    public void MoreButton ()
    {
        Application.OpenURL (moreGamesUrl);
    }

    public void FeedBack ()
    {
        Application.OpenURL(feedback);
    }

    public void YoutubeButton ()
    {
        Application.OpenURL(youtubeUrl);
    }
}
