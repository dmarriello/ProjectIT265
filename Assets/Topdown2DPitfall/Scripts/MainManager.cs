using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class MainManager : MonoBehaviour
    {
        public static MainManager Instance;
        public int waterCount;
    public string TimeOnTitle="";
    public string TimeInRoom1="";
    public string TimeInRoom2="";
    public float yVal = 0;
    public bool paused = false;
    private float holdtime=0;
        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            if(paused)
            {
                holdtime = Time.timeScale;
                Time.timeScale = 0f;
            }
            else
            {
                if(holdtime!=0f)
                {
                    Time.timeScale = holdtime;
                }
                
            }
        }
    }
}

