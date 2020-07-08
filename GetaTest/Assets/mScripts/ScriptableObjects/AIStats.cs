using UnityEngine;
using KartGame.KartSystems;

namespace KartGame.AI
{
    [CreateAssetMenu(menuName = "ScriptableObjects/AI/AIStats")]
    public class AIStats : ScriptableSingleton<AIStats>
    {
        public ArcadeKart.Stats lowLevel;
        public ArcadeKart.Stats mediumLevel;
        public ArcadeKart.Stats hardLevel;
    }
}
