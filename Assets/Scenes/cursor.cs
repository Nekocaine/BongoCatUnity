using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cursor : MonoBehaviour {

    public Animator animator;
    public BoxCollider2D collider2D;
    public score score;
    public Spawnner spawnner;

    // Use this for initialization
    void Start () {
        Cursor.visible = false;
        collider2D.enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
        transform.position = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(0)){
            collider2D.enabled = true;
            animator.SetBool("hasClicked", true);
            if (spawnner.hasLost)
            {
                Application.Quit();
            }
        }
        else{
            collider2D.enabled = false;
            animator.SetBool("hasClicked", false);
        }
        
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "drum")
        {
            Destroy(collision.gameObject);
            spawnner.drumDetroyed();
            score.addScore(2);
        }
        else
        {
            score.addScore(-1);
        }
    }

}