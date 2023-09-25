using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if(!HasKitchenObject())
        {
            // There is no kitchen object here
            if(player.HasKitchenObject())
            {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            } else
            {
                // player not carrying anything

            }
        } else
        {
            // There is a kitchen object here
            if(player.HasKitchenObject())
            {
                //Player is carrying something
            } else
            {
                // palyer is not carrying anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
