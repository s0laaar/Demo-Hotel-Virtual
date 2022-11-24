using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    public PlayerAnim playerAnim;
    public FirstPersonMovement movement;
    [SerializeField] PlayerCommands playerComands;
    [SerializeField] Recoger recoger;
    [SerializeField] PuertasDetector puertasDetector;
    public bool playerActivado = true;
    float x, y;

    private void Awake()
    {
        if(playerAnim == null)
        {
            playerAnim = GetComponent<PlayerAnim>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerActivado)
        {
            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (recoger.DetecteObjetoParaRecoger())
                {
                    recoger.RecogerObjeto();
                }
            }

            playerAnim.SetAnim(x, y);

            playerComands.PlayerComandsActions();

            if (Input.GetMouseButtonDown(0))
            {
                if (puertasDetector.IsPuertaDetectada())
                {
                    StartCoroutine(puertasDetector.EntrarAHabitacionCoroutine(this));
                    return;
                }
            }
        }
    }

    private void FixedUpdate()
    {
        if(playerActivado)
        {
            movement.Move(x, y);
        }
    }
}
