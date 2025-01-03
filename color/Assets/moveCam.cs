using Unity.VisualScripting;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player;


    // Update is called once per frame
    void Update()
    {
        if(player.position.y>= transform.position.y){
            transform.position=new Vector3(0f, player.position.y, -10f);
        }
        
    }
}
