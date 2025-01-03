using UnityEngine;
using UnityEngine.SceneManagement;
public class plaScr : MonoBehaviour
{ public float jumpForce= 10f;
    public Rigidbody2D rb;
    public string currentColor;
    public SpriteRenderer sR;
    public Color blueC;
    public Color yellowC;
    public Color redC;
    public Color purpleC;
    string prevColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
void Start(){
    setBallColor();
}
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")|| Input.GetMouseButtonDown(0)){
            rb.linearVelocity = Vector2.up * jumpForce;
        }
        
    }
    void OnTriggerEnter2D(Collider2D col){
if(col.tag=="colorC"){
    setBallColor();
    Destroy(col.gameObject);
    return;
}
if(col.tag!=currentColor){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
    }
    void setBallColor(){
        int index=Random.Range(0, 4);

switch(index){
    case 0:
        currentColor="blue";
        sR.color=blueC;
        break;
    case 1:
        currentColor="yellow";
        sR.color=yellowC;
        break;
    case 2:
        currentColor="red";
        sR.color=redC;
        break;
    case 3:
        currentColor="purple";
        sR.color=purpleC;
        break;
}
     if(prevColor==currentColor){
        setBallColor();
     }
     prevColor=currentColor;

    }
}
