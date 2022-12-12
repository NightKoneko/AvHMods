using System;

[assembly: MelonInfo(typeof(MainMod), "NoFisheye", "1.0.0", "NightKoneko")]
[assembly: MelonGame("Sayan", "Apes vs Helium")]
[assembly: MelonPriority(-1000)]
[assembly: MelonColor(ConsoleColor.DarkCyan)]
[assembly: MelonAuthorColor(ConsoleColor.DarkMagenta)]


namespace NoFisheye;

using System.Linq;
using System.Reflection;
using UnityEngine.Rendering;
using UnityStandardAssets.Characters.FirstPerson;

internal class MainMod : MelonMod
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