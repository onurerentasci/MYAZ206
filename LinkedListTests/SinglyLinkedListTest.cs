using DataStructures.LinkedList.SinglyLinkedList;
using Xunit;

namespace LinkedListTests
{
    public class SinglyLinkedListTest
    {
        private SinglyLinkedList<int> _list;
        public SinglyLinkedListTest()
        {
            // 8 -> 6
            _list = new SinglyLinkedList<int>(new int[] {6, 8});
        }

        [Fact]
        public void Count_Test()
        {
            //act
            int count = _list.Count;

            //assert
            Assert.Equal(2, count);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(1)]
        [InlineData(9)]


        public void AddFirst_Test(int value)
        {
            //act
            _list.AddFirst(value);

            //assert
            Assert.Equal(value, _list.Head.Value);
            Assert.Collection(_list,
                item => Assert.Equal(item, value),
                item => Assert.Equal(item, _list.Head.Next.Value),
                item => Assert.Equal(item, _list.Head.Next.Next.Value));
        }

        [Fact]
        public void GetEnumerator_Test()
        {
            //Assert
            Assert.Collection(_list,
                item => Assert.Equal(item, 8),
                item => Assert.Equal(item, 6)
                );
        }
    }
}