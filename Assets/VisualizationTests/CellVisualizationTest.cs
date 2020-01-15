using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

namespace Tests
{
    public class CellVisualizationTest
    {
/*
        [UnityTest]
        public IEnumerator CellShouldRender()
        {
            // See https://docs.unity3d.com/ScriptReference/Assertions.Assert.html

            Time.timeScale = 0;

            // make sure it is injected
            Assert.IsNotNull(go);

            // The referenced GameObject should be always (in every frame) be active
            Assert.IsTrue(go.activeInHierarchy);

            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
        */

        [PrebuildSetup(typeof(TestsWithPrebuildStep))]
        [UnityTest]
        public IEnumerator MonoBehaviourTest_Works()
        {
            yield return new MonoBehaviourTest<MyMonoBehaviourTest>();
        }

        public class MyMonoBehaviourTest : MonoBehaviour, IMonoBehaviourTest, IPrebuildSetup
        {
            public GameObject go;
            private int frameCount;
            public bool IsTestFinished
            {
                get { return frameCount > 10; }
            }

            void Update()
            {
                // make sure it is injected
                Assert.IsNotNull(go);

                // The referenced GameObject should be always (in every frame) be active
                Assert.IsTrue(go.activeInHierarchy);
                frameCount++;
            }

            public void Setup() {
                go = new GameObject();
            }
        }
    }

}
