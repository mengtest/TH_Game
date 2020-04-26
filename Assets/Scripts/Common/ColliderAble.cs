using System;
using UnityEngine;

namespace Common
{
    /// <summary>
    /// 
    /// </summary>
    public class ColliderAble : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            Debug.Log(1);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            // other.otherCollider.gameObjec
            Debug.Log(2);
        }

        private void OnCollisionExit(Collision other)
        {
            Debug.Log(3);
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            Debug.Log(4);
        }

        private void OnCollisionStay(Collision other)
        {
            Debug.Log(5);
        }

        private void OnCollisionStay2D(Collision2D other)
        {
            Debug.Log(6);
        }
    }
}