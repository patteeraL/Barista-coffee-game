using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private void Start() {
        DeliveryManager.Instance.OnRecipeSuccess += DeliveryManager_OnRecipeSuccess;
        DeliveryManager.Instance.OnRecipeFailed += DeliveryManager_OnRecipeFailed;
    }

    private void DeliveryManager_OnRecipeFailed(object sender, System.EventArgs e){
        //Playsound
    }

    private void DeliveryManager_OnRecipeSuccess(object sender, System.EventArgs e){
        throw new System.NotImplementedException();
    }

    private void Playsound(AudioClip audioClip, Vector3 position, float volume = 1f){
        AudioSource.PlayClipAtPoint(audioClip, position, volume);
    }
}
