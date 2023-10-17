<<<<<<< Updated upstream
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            thisAnimation.Play();
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;

    public Rigidbody _rb;
    public float velocity;

    public Text ScoreText;
    int Score;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            _rb.velocity = Vector2.up * velocity;
        }

        if (transform.position.y <= -10)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Score++;
            ScoreText.text = "SCORE : " + Score;
        }
    }
}
>>>>>>> Stashed changes
