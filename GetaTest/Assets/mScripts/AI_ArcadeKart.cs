using UnityEngine;
using KartGame.KartSystems;

namespace KartGame.AI
{
    public class AI_ArcadeKart : ArcadeKart
    {
        public enum Difficulty
        {
            Low,
            Medium,
            Hard
        }

        [SerializeField] Difficulty difficulty = Difficulty.Low;

        protected override void Awake()
        {
            base.Awake();
            InitializeKart(difficulty);
        }

        /// <summary>
        /// Initialize AI Kart Difficulty
        /// </summary>
        /// <param name="_difficulty">Type of difficulty</param>
        void InitializeKart(Difficulty _difficulty)
        {
            switch (_difficulty)
            {
                case Difficulty.Low:
                    baseStats = AIStats.Instance.lowLevel; 
                    break;
                case Difficulty.Medium:
                    baseStats = AIStats.Instance.mediumLevel;
                    break;
                case Difficulty.Hard:
                    baseStats = AIStats.Instance.hardLevel;
                    break;
                default:
                    break;
            }
        }

    }
}
