using System;
using System.Collections.Generic;

using UnityEngine;

public class PlateKitchenObject : KitchenObject
{
    public event EventHandler<OnTngredientAddedEventArgs> OnTngredientAdded;
    public class OnTngredientAddedEventArgs : EventArgs
    {
        public KitchenObjectSO kitchenObjectSO;
    }

    [SerializeField] private List<KitchenObjectSO> validKitchenObjectSOList;

    private List<KitchenObjectSO> kitchenObjectSOList;

    private void Awake()
    {
        kitchenObjectSOList = new List<KitchenObjectSO>();
    }

    public bool TryAddIngredient(KitchenObjectSO kitchenObjectSO)
    {
        if (!validKitchenObjectSOList.Contains(kitchenObjectSO))
        {
            return false;
        }

        if (kitchenObjectSOList.Contains(kitchenObjectSO))
        {
            return false;
        }
        else
        {
            kitchenObjectSOList.Add(kitchenObjectSO);

            OnTngredientAdded?.Invoke(this, new OnTngredientAddedEventArgs { kitchenObjectSO = kitchenObjectSO });
            return true;
        }
    }
}
