using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Users", menuName = "AddressSolution/Users", order = 0)]
public class UserAsset : ScriptableObject
{
    // Start is called before the first frame update

    [SerializeField] public List<string> userNames;
    [SerializeField] public List<string> userPwds;

    // public int id;
}
