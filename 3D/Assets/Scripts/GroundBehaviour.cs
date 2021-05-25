using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;

public class GroundBehaviour : MonoBehaviour
{

    public List<GroundType> groundType = new List<GroundType>();
    public FirstPersonController fPC;
    public string currentGround;

    // Start is called before the first frame update
    void Start()
    {
        setGroundType(groundType[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "sand") setGroundType(groundType[0]);
        else if (hit.transform.tag == "wood") setGroundType(groundType[1]);
        else if (hit.transform.tag == "rock") setGroundType(groundType[2]);
    }

    public void setGroundType(GroundType ground)
    {
        fPC.m_FootstepSounds = ground.footStepSounds;
        fPC.m_WalkSpeed = ground.walkSpeed;
        fPC.m_RunSpeed = ground.runSpeed;
        currentGround = ground.name;
    }
}

[System.Serializable]
public class GroundType
{
    public string name;
    public AudioClip[] footStepSounds;
    public float walkSpeed = 5;
    public float runSpeed = 10;
}
