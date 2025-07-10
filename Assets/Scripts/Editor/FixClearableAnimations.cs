#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEditor.Animations;
using Match3;

public class FixClearableAnimations : MonoBehaviour
{
    [MenuItem("Tools/Match3/Fix Clearable Animations")]
    public static void FixAll()
    {
        string animationsPath = "Assets/Animations/";
        string prefabsPath = "Assets/Prefabs/";

        string[] prefabNames = new string[]
        {
            "BubblePiecePrefab",
            "ColumnPiecePrefab",
            "RowClearPiecePrefab",
            "NormalPiecePrefab"
        };

        foreach (var prefabName in prefabNames)
        {
            string prefabFullPath = prefabsPath + prefabName + ".prefab";
            string controllerPath = animationsPath + prefabName + ".controller";
            string animClipPath = animationsPath + prefabName + "Clear.anim";

            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabFullPath);
            AnimatorController controller = AssetDatabase.LoadAssetAtPath<AnimatorController>(controllerPath);
            AnimationClip clip = AssetDatabase.LoadAssetAtPath<AnimationClip>(animClipPath);

            if (prefab == null || controller == null || clip == null)
            {
                Debug.LogWarning($"⚠️ Missing one of the required assets for {prefabName}");
                continue;
            }

            Animator animator = prefab.GetComponent<Animator>();
            if (animator == null)
            {
                animator = prefab.AddComponent<Animator>();
            }

            animator.runtimeAnimatorController = controller;

            ClearablePiece clearable = prefab.GetComponent<ClearablePiece>();
            if (clearable == null)
            {
                clearable = prefab.AddComponent<ClearablePiece>();
            }

            clearable.clearAnimation = clip;

            AnimatorState state = null;
            var layer = controller.layers[0];
            foreach (var st in layer.stateMachine.states)
            {
                if (st.state.name == clip.name)
                {
                    state = st.state;
                    break;
                }
            }

            if (state == null)
            {
                state = controller.AddMotion(clip);
                state.name = clip.name;
            }

            layer.stateMachine.defaultState = state;

            Debug.Log($"✅ Fixed: {prefabName}");
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}
#endif
