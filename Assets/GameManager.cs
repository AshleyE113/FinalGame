using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject PSpawnPoint;
    [SerializeField] GameObject PlayerChar;
    [SerializeField] Canvas customCanvas;
    //[SerializeField] Button button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToSpawnPoint()
    {
        PlayerChar.transform.position = PSpawnPoint.transform.position + new Vector3(0, 1, 0);
        customCanvas.enabled = false;
    }
}
