namespace ItsLeet.Tree;

public class CountCompleteTreeNodes
{
    public int CountNodes(TreeNode treeNode)
    {
        var height = FindHeight(treeNode, 0);

        if (height == 0 || height == 1)
        {
            return height;
        }

        var numberOfFullNodes = (int)(Math.Pow(2, height - 1) - 1);

        var left = 0;
        var right = numberOfFullNodes;

        while (left < right)
        {
            var index2Find = (int)Math.Ceiling((double)(left + right) / 2);
            var nodeExists = BinarySearch(index2Find, height, treeNode, numberOfFullNodes);

            if (nodeExists)
            {
                left = index2Find;
            }
            else
            {
                right = index2Find - 1;
            }
        }

        return numberOfFullNodes + left + 1;
    }

    private static bool BinarySearch(int index2Find, int height, TreeNode? treeNode, int numberOfFullNodes)
    {
        var left = 0;
        var right = numberOfFullNodes;
        var count = 1;

        while (count < height)
        {
            var mid = (int)(Math.Ceiling((double)(left + right) / 2));
            if (index2Find >= mid)
            {
                treeNode = treeNode?.right;
                left = mid;
            }
            else
            {
                treeNode = treeNode?.left;
                right = mid - 1;
            }

            count++;
        }

        return treeNode != null;
    }

    private static int FindHeight(TreeNode? treeNode, int h)
    {
        if (treeNode == null)
        {
            return h;
        }

        h++;
        return FindHeight(treeNode.left, h);
    }
}