using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] public KitchenObjectSO kitchenObjectSO;
    [SerializeField] public Transform counterTopPoint;
    [SerializeField] public ClearCounter secondClearCounter;
    [SerializeField] public bool testing;

    private KitchenObject kitchenObject;

    private void Update()
    {
        if (testing && Input.GetKeyDown(KeyCode.T))
            if (kitchenObject != null)
                kitchenObject.SetClearCounter(secondClearCounter);
    }

    public void Interact()
    {
        if (kitchenObject == null)
        {
            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
            kitchenObjectTransform.GetComponent<KitchenObject>().SetClearCounter(this);
            kitchenObjectTransform.localPosition = Vector3.zero;

            kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();
            kitchenObject.SetClearCounter(this);
        }
        else
        {
            Debug.Log(kitchenObject.GetClearCounter());
        }
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }
}
