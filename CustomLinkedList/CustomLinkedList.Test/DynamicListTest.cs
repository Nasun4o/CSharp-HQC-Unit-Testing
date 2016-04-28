namespace CustomLinkedList.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DynamicListTest
    {
        private DynamicList<int> list;

        [TestInitialize]
        public void TestInitialize()
        {
            this.list = new DynamicList<int>();
        }

        [TestMethod]
        public void ElementInList_AddedElement_ShouldEqual()
        {
            this.list.Add(50);
            bool exist = this.list.Contains(50);

            Assert.IsTrue(exist);
        }

        [TestMethod]
        public void RemoveAtIndex_AtSpecificIndex_ShouldRemoveElement()
        {
            this.list.Add(34);
            this.list.Add(33);
            this.list.Add(32);
            this.list.Add(31);
            this.list.Add(30);

            int index = this.list.RemoveAt(3);

            Assert.AreEqual(31, index);
        }

        [TestMethod]
        public void RemoveElement_ExistingElement_ShouldRemove()
        {
            this.list.Add(7);
            this.list.Add(13);

            int item = this.list.Remove(13);

            Assert.AreNotEqual(13, item);
        }

        [TestMethod]
        public void SearchElementInList_AtSpecifiedIndexOfElement_ShouldReturn()
        {
            const int MaxItem = 10;

            for (int i = 0; i <= MaxItem; i++)
            {
                this.list.Add(i);
            }

            int index = this.list.IndexOf(MaxItem);

            Assert.AreEqual(10, index);
        }

        [TestMethod]
        public void ContainsElement_IfElementExists_ShouldReturn()
        {
            for (int i = 0; i < 30; i++)
            {
                this.list.Add(i);
            }

            bool isExsist = this.list.Contains(40);

            Assert.IsFalse(isExsist);
        }

        [TestMethod]
        public void Add_EmptyList_ShouldIncrementCounter()
        {
            this.list.Add(3);
            this.list.Add(1);
            this.list.Add(1);
            this.list.Add(1);

            Assert.AreEqual(4, this.list.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_NonExistentIndex_ShouldThrowException()
        {
            this.list.Add(9);
            this.list.Add(11);
            this.list.Add(13);
            this.list.RemoveAt(4);

        }
    }
}
