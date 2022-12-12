using MelonLoader;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: MelonInfo(typeof(NoFisheye.Main), "NoFisheye", "1.0.0", "NightKoneko")]
[assembly: MelonGame("Sayan", "Apes vs Helium")]
namespace NoFisheye;



internal class Main : MelonMod
{
    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        base.OnSceneWasInitialized(buildIndex, sceneName);


        foreach (var component in GameObject.Find("Post-process Volume").GetComponent<Volume>().profile.components)
        {
            if (component.name != "PaniniProjection(Clone)") continue;
            component.active = false;
        }
    }
}
