using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlaygrouundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore = 0;
    public TMP_Text textScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = playerScore.ToString(); 
    }
}
