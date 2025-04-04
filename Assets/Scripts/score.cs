using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Transform player;
    public TMPro.TMP_Text scoreText;

    public float Num = 15.7f;
       void Update()
    {
       scoreText.text  = player.position.z.ToString("0");
        
    }
}
