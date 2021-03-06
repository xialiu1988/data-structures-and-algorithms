using System;
using Xunit;
using StacksAndQueues.Classes;

namespace stackandqueueTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushOneNodetoStack()
        {
            Stack stack = new Stack();
            stack.Push(4);

            Assert.Equal(4, stack.Top.Value);
        }


        [Fact]
        public void CanPushNodetoStack()
        {
            Stack stack = new Stack();
            stack.Push(4);
            stack.Push(44);
            Assert.Equal(44, stack.Top.Value);
        }



        [Fact]
        public void CanPushnullNodetoStack()
        {
            Node node = new Node(34);
            Stack stack = new Stack(node);
            stack.Push(13);

            Assert.Equal(13, stack.Top.Value);
        }

        [Fact]
        public void CanPopNodefromStack()
        {
            Stack stack = new Stack();
            stack.Push(4);
            stack.Push(44);
            Assert.True(stack.Top.Value == 44);
            stack.Pop();
            Assert.True(stack.Top.Value == 4);

        }



        [Fact]
        public void PopNodefromStack()
        {
            Stack stack = new Stack();
            stack.Push(44);
            Assert.True(stack.Top.Value == 44);
            stack.Pop();
            Assert.True(stack.Top == null);

        }




        [Fact]
        public void CanPopNodefromtheStack()
        {
            Node node = new Node(34);
            Stack stack = new Stack(node);
            stack.Push(13);
            Assert.True(stack.Top.Value == 13);
            stack.Pop();
            Assert.True(stack.Top.Value == 34);

        }
        [Fact]
        public void CanGetPeek()
        {
            Node node = new Node(34);
            Stack stack = new Stack(node);
            stack.Push(13);
            Assert.True(stack.Peek().Value==13);

        }
        [Fact]
        public void CanGetPeekFromStack()
        {
            Node node = new Node(34);
            Stack stack = new Stack(node);
            Assert.True(stack.Peek().Value == 34);

        }
        [Fact]
        public void CanGetPeekFromemptystack()
        {

            Stack stack = new Stack();

            Assert.True(stack.Peek() == null);

        }

        [Fact]
        public void CanEnqueueNodeToQueue()
        {
            Node node = new Node(34);
            Queue queue = new Queue(node);

           queue.Enqueue(13);
            Assert.True(queue.Rear.Value == 13);

        }

        [Fact]
        public void CanEnqueueNode()
        {
            Node node = new Node(34);
            Queue queue = new Queue(node);

            queue.Enqueue(13);
            queue.Enqueue(56);
            Assert.True(queue.Rear.Value == 56);

        }

        [Fact]
        public void CanEnqueue()
        {
            Node node = new Node(34);
            Queue queue = new Queue(node);

            queue.Enqueue(13);
            queue.Enqueue(56);
            queue.Enqueue(0);
            Assert.True(queue.Rear.Value == 0);

        }
        [Fact]
        public void CanDequeue()
        {
            Node node = new Node(34);
            Queue queue = new Queue(node);

            queue.Enqueue(13);
            queue.Enqueue(56);
            queue.Enqueue(0);
            queue.Dequeue();
            Assert.True(queue.Front.Value == 13);

        }

        [Fact]
        public void CanDequeueNode()
        {
            Node node = new Node(34);
            Queue queue = new Queue(node);

            queue.Enqueue(13);
            queue.Enqueue(56);
            queue.Enqueue(0);
            queue.Dequeue();
            queue.Dequeue();
            Assert.True(queue.Front.Value == 56);

        }

        [Fact]
        public void CanDequeueNodefromQueue()
        {
            Node node = new Node(34);
            Queue queue = new Queue(node);

         
            queue.Dequeue();

            Assert.True(queue.Front == null);

        }

        [Fact]
        public void CanGetPeekFromQueue()
        {
            Node node = new Node(34);
            Queue queue = new Queue(node);

            Assert.True(queue.Peek().Value==34);

        }
        [Fact]
        public void CangetpeekfromQueue()
        {
            Node node = new Node(34);
            Queue queue = new Queue(node);
            queue.Dequeue();
            Assert.True(queue.Peek()== null);

        }


        [Fact]
        public void CangetpeekAfterEnqueueandDequeue()
        {
            Node node = new Node(34);
            Queue queue = new Queue(node);
            queue.Enqueue(13);
            queue.Enqueue(56);
            queue.Enqueue(0);
            queue.Dequeue();
            Assert.True(queue.Peek().Value == 13);

        }
    }
}
