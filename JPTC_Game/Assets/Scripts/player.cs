using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Start life:" + life);
        life_text.text = life.ToString();
    }
    public float velocity = 1.0f;
    public float velocity_R_L = 2.0f;
    public FixedJoystick joystick;
    private int life = 100;
    public TextMeshProUGUI  life_text;

    // Update is called once per frame
    void Update()
    {
        // velocity * Time.deltaTime *
        transform.position += new Vector3( velocity * Time.deltaTime , 0, - (joystick.Direction.x * velocity_R_L * Time.deltaTime));
        
    }
    public void updateLife(int points){
        life += points;
        print("Current life:" + life);
        life_text.text = life.ToString(); 
        isAlive();
    }
    private void isAlive(){
        if(life <= 0){
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
}
