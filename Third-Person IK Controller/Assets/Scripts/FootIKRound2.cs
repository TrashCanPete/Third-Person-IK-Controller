using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootIKRound2 : MonoBehaviour
{
    Animator anim;

    public LayerMask layerMask;

    [Range (0,1)]
    public float DistanceToGround;

    private void Start()
    {
        anim = GetComponent<Animator>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            anim.SetBool("Run", !anim.GetBool("Run"));
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (anim)
        {
            anim.SetIKPositionWeight(AvatarIKGoal.LeftFoot, anim.GetFloat("IKLeftFootWeight"));
            anim.SetIKRotationWeight(AvatarIKGoal.LeftFoot, anim.GetFloat("IKLeftFootWeight"));
            anim.SetIKPositionWeight(AvatarIKGoal.RightFoot, anim.GetFloat("IKRightFootWeight"));
            anim.SetIKRotationWeight(AvatarIKGoal.RightFoot, anim.GetFloat("IKRightFootWeight"));

            //Left Foot
            RaycastHit hit;
            Ray ray = new Ray(anim.GetIKPosition(AvatarIKGoal.LeftFoot) + Vector3.up, Vector3.down);
            if (Physics.Raycast(ray, out hit, DistanceToGround +1f, layerMask))
            {
                if (hit.transform.tag == "Walkable")
                {
                    Vector3 footPosition = hit.point;
                    footPosition.y += DistanceToGround;
                    anim.SetIKPosition(AvatarIKGoal.LeftFoot, footPosition);
                    Vector3 forward = Vector3.ProjectOnPlane(transform.forward, hit.normal);
                    anim.SetIKRotation(AvatarIKGoal.LeftFoot, Quaternion.LookRotation(forward, hit.normal));

                }
            }

            //Right Foot
             
            ray = new Ray(anim.GetIKPosition(AvatarIKGoal.RightFoot) + Vector3.up, Vector3.down);
            if (Physics.Raycast(ray, out hit, DistanceToGround + 1f, layerMask))
            {
                if (hit.transform.tag == "Walkable")
                {
                    Vector3 footPosition = hit.point;
                    footPosition.y += DistanceToGround;
                    anim.SetIKPosition(AvatarIKGoal.RightFoot, footPosition);
                    Vector3 forward = Vector3.ProjectOnPlane(transform.forward, hit.normal);
                    anim.SetIKRotation(AvatarIKGoal.RightFoot, Quaternion.LookRotation(forward, hit.normal));
                }
            }
        }
    }
}
