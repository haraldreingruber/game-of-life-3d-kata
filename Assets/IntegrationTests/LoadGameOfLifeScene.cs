using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Zenject;

namespace Tests
{
    public class LoadGameOfLifeScene : SceneTestFixture
    {
        [UnityTest]
        public IEnumerator TestGameOfLifeScene()
        {
            yield return LoadScene("GameOfLife");

            // Wait a few seconds to ensure the scene starts correctly
            yield return new WaitForSeconds(2.0f);
        }
    }
}
