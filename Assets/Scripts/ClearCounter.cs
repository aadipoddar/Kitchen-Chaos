using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] public KitchenObjectSO kitchenObjectSO;
    [SerializeField] public Transform counterTopPoint;

    public void Interact()
    {
        Debug.Log("Interact");
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        kitchenObjectTransform.localPosition = Vector3.zero;

        Debug.Log(kitchenObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }
}
