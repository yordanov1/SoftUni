namespace Trees_DFS_BFS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tree<T>
    {
        private readonly List<Tree<T>> children;

        public T Key { get; set; }
        public Tree<T> Parent { get; set; }


        public Tree(T key, params Tree<T>[] children )
        {
            this.Key = key;
            this.children = new List<Tree<T>>();

            foreach (var child in children)
            {
                this.AddChild(child);
                child.AddParent(this);
            }
        }

        public IReadOnlyCollection<Tree<T>> Children
            => this.children.AsReadOnly();

        public void AddParent(Tree<T> parent)
        {
            this.Parent = parent;
        }

        public void AddChild(Tree<T> child)
        {
            this.children.Add(child);
        }


        //(2) Tree as String ----------------------------------------------------------------->
        public string GetAsString(int identation = 0)
        {
            var result = new string(' ', identation) + this.Key + "\r\n";

            foreach (var child in this.Children)
            {
                result += child.GetAsString(identation + 2);
            }

            return result;
        }



        //( )Return Tree as List ------------------------------------------------------------->
        public List<int> GetTreeAsList()
        {
            List<int> result = new List<int>();
            
            result.Add(Convert.ToInt32(this.Key));
           
            this.FillTreeAsList(result, this);

            return result;
        }

        public void FillTreeAsList(List<int> result, Tree<T> node)
        {            
            foreach (var child in node.Children)
            {
                result.Add(Convert.ToInt32(child.Key));
                this.FillTreeAsList(result, child);
            }            
        }



        //(3) Leafs Nodes -------------------------------------------------------------------->
        public List<T> GetLeafKeys()
        {
            var leafNodes = this.GetLeafNodes();

            return leafNodes.Select(x => x.Key).ToList();
        }

        public List<Tree<T>> GetLeafNodes()
        {
            List<Tree<T>> leafNodes = new List<Tree<T>>();

            Queue<Tree<T>> queueNodes = new Queue<Tree<T>>();

            queueNodes.Enqueue(this);


            while (queueNodes.Count > 0)
            {                
                var node = queueNodes.Dequeue();

                if (node.Children.Count == 0)
                {
                    leafNodes.Add(node);
                }

                foreach (var child in node.Children)
                {
                    queueNodes.Enqueue(child);
                }
            }

            return leafNodes;
        }



        //(4) Middle nodes ------------------------------------------------------------------->
        public List<T> GetMiddleKeys()
        {
            List<T> result = new List<T>();

            this.InsertMidKeys(result, this);

            List<int> newList = new List<int>();

            result.Sort();

            return result;
        }

        public void InsertMidKeys(List<T> result, Tree<T> node)
        {
            foreach (var child in node.Children)
            {
                if (child.Parent != null && child.Children.Count != 0)
                {
                    result.Add(child.Key);
                }

                this.InsertMidKeys(result, child);
            }
        }



        //(5) Deepest Node ------------------------------------------------------------------->
        public Tree<T> GetDeepestLeftomostNode()
        {
            var deepestNode = this;

            var allLeafs = this.GetLeafNodes();

            int counterBiggest = 0;

            foreach (var leaf in allLeafs)
            {
                int counter = 0;

                var node = leaf;

                while (node.Parent != null)
                {                   
                    counter++;

                    node = node.Parent;

                }

                if (counterBiggest < counter)
                {
                    counterBiggest = counter;

                    deepestNode = leaf;
                }

                counter = 0;
            }

            return deepestNode;
        }



        //(6) Longest Path ------------------------------------------------------------------->
        public List<T> GetLongestPath()
        {
            var longestPath = new List<T>();

            var currentPath = new List<T>();
            currentPath.Add(this.Key);

            int counter = 1;

            this.FindLongestPath(this,currentPath ,longestPath, ref counter);

            return longestPath;
        }

        public void FindLongestPath(Tree<T> current, List<T> currentPath, List<T> longestPath, ref int counter)
        {
            foreach (var child in current.Children)
            {
                currentPath.Add(child.Key);
                counter++;
                this.FindLongestPath(child,currentPath ,longestPath, ref counter);
            }

            if (longestPath.Count < counter)
            {
                for (int i = 0; i < currentPath.Count; i++)
                {
                    if (i > longestPath.Count - 1)
                    {
                        longestPath.Add(currentPath[i]);
                    }

                    longestPath[i] = (currentPath[i]);
                }                                
            }

            counter--;
            currentPath.RemoveAt(currentPath.Count - 1);
        }




        //(7)(1) All Paths With a Given Sum(from leafs to root) ------------------------------>
        public List<List<T>> PathsWithGivenSum(int sum)
        {
            var leafNodes = this.GetLeafNodes();

            var result = new List<List<T>>();

            foreach (var leaf in leafNodes)
            {
                var node = leaf;
                int currentSum = 0;
                List<T> currentPathValues = new List<T>();

                while (node != null)
                {
                    currentSum += Convert.ToInt32(node.Key);
                    currentPathValues.Add(node.Key);
                    node = node.Parent;
                }

                if (currentSum == sum)
                {
                    currentPathValues.Reverse();
                    result.Add(currentPathValues);
                }
            }

            return result;
        }




        //(7)(2) All Paths With a Given Sum(from root to leafs) ----------------------------->
        public List<List<T>> PathsWithGivenSum2(int sum)
        {
            var result = new List<List<T>>();

            var currentPath = new List<T>();
            currentPath.Add(this.Key);

            int currentSum = Convert.ToInt32(this.Key);

            this.GetPathsWithSumDfs(this, result, currentPath, ref currentSum, sum);

            return result;
        }

        public void GetPathsWithSumDfs(
            Tree<T> current, 
            List<List<T>> wantedPaths, 
            List<T> currentPath, 
            ref int currentSum, 
            int wantedSum)
        {
            foreach (var child in current.Children)
            {
                currentPath.Add(child.Key);
                currentSum += Convert.ToInt32(child.Key);
                this.GetPathsWithSumDfs(child, wantedPaths, currentPath, ref currentSum, wantedSum);
            }

            if (currentSum == wantedSum)
            {
                wantedPaths.Add(new List<T>(currentPath));
            }

            currentSum -= Convert.ToInt32(current.Key);
            currentPath.RemoveAt(currentPath.Count - 1);
        }




        //(8) All Subtrees With a Given Sum ------------------------------------------------->
        public List<Tree<T>> SubTreesWithGivenSum(int sum)
        {
            var roots = new List<Tree<T>>();

            SubTreeSumDFS(this, sum, roots);

            return roots;
        }

        public int SubTreeSumDFS(Tree<T> node, int targetSum, List<Tree<T>> roots)
        {
            var currentSum = Convert.ToInt32(node.Key);

            foreach (var child in node.Children)
            {
                currentSum += SubTreeSumDFS(child, targetSum, roots);
            }

            if (currentSum == targetSum)
            {
                roots.Add(node);
            }

            return currentSum;
        }
       
    }
}
