using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace InityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof(NavMeshAgent))]
    [RequireComponent(typeof(ThirdPersonCharacter))]
    public class AlCharacterControl : MonoBehaviour
    {
        public NavMeshAgent agent { get; private set; }
        public ThirdPersonCharacter character { get; private set; }
        public Transform target;

        // Use this for initialization
        void Start()
        {
            agent = GetComponentInChildren<NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();

            agent.updateRotation = false;
            agent.updatePosition = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (target != null)
            {
                agent.SetDestination(target.position);
                character.Move(agent.desiredVelocity, false, false);
            }
            else
            {
                character.Move(Vector3.zero, false, false);
            }
        }

        public void SetTarget(Transform target)
        {
            this.target = target;
        }
    }
}
