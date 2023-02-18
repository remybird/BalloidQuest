using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
// [RequireComponent(typeof(AudioSource))]
public class PlayerMovement : MonoBehaviour {
  private Rigidbody2D rb2d;
  // private AudioSource audioSrc;

  public Animator animator;

  [SerializeField]
  private float speedMultiplier;

  void Awake () {
    rb2d = GetComponent<Rigidbody2D>();
    // audioSrc = GetComponent<AudioSource>();
  }

  void FixedUpdate () {
    var horiz = Input.GetAxis("Horizontal");
    var vert = Input.GetAxis("Vertical");
    rb2d.velocity = new Vector2(horiz * speedMultiplier * 0.8f,
                                vert * speedMultiplier * 0.8f);
  }

  void Update () {
    animator.SetFloat("VX", Input.GetAxis("Horizontal"));
    animator.SetFloat("VY", Input.GetAxis("Vertical"));
    // if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
    //   if (!audioSrc.isPlaying) {
    //     audioSrc.Play();
    //   }
    // }
  }
}
