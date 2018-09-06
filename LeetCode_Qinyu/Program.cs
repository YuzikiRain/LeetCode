using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //500. 键盘行
        //LeetCode_Qinyu.KeyboardRow.KeyboardRow keyboardRow = new LeetCode_Qinyu.KeyboardRow.KeyboardRow();
        //keyboardRow.Test();

        //557. 反转字符串中的单词 III
        //LeetCode_Qinyu.ReverseWords.ReverseWords_557 reverseWords_557 = new LeetCode_Qinyu.ReverseWords.ReverseWords_557();
        //reverseWords_557.Test();

        //728. 自除数
        //LeetCode_Qinyu.SelfDividingNumbers.SelfDividingNumbers_728 selfDividingNumbers = new LeetCode_Qinyu.SelfDividingNumbers.SelfDividingNumbers_728();
        //selfDividingNumbers.Test();

        //867. 转置矩阵
        //LeetCode_Qinyu.Transpose.Transpose_867 transpose_867 = new LeetCode_Qinyu.Transpose.Transpose_867();
        //transpose_867.Test();

        //171. Excel表列序号
        //LeetCode_Qinyu.TitleToNumber.TitleToNumber_171 titleToNumber_171 = new LeetCode_Qinyu.TitleToNumber.TitleToNumber_171();
        //titleToNumber_171.Test();

        //559. N叉树的最大深度
        //LeetCode_Qinyu.MaxDepthOfNAryTree.MaxDepthOfNAryTree_559 maxDepthOfNAryTree_559 = new LeetCode_Qinyu.MaxDepthOfNAryTree.MaxDepthOfNAryTree_559();
        //maxDepthOfNAryTree_559.Test();

        //821. 字符的最短距离
        //LeetCode_Qinyu.ShortestToChar.ShortestToChar_821 shortestToChar_821 = new LeetCode_Qinyu.ShortestToChar.ShortestToChar_821();
        //shortestToChar_821.Test();

        //589. N叉树的前序遍历
        //LeetCode_Qinyu.NaryTreePreoderTraversal.NaryTreePreoderTraversal_589 naryTreePreoderTraversal = new LeetCode_Qinyu.NaryTreePreoderTraversal.NaryTreePreoderTraversal_589();
        //naryTreePreoderTraversal.Test();

        //693. 交替位二进制数
        LeetCode_Qinyu.HasAlternatingBits.HasAlternatingBits_693 hasAlternatingBits = new LeetCode_Qinyu.HasAlternatingBits.HasAlternatingBits_693();
        hasAlternatingBits.Test();


        //344. 反转字符串
        //ReverseStringTest reverseStringTest = new ReverseStringTest();
        //Console.WriteLine(reverseStringTest.ReverseString("A man, a plan, a canal: Panama"));

        //104.二叉树的最大深度
        //TreeNode root_maxDepthOfBSTTest = new TreeNode(3);
        //root_maxDepthOfBSTTest.left = new TreeNode(9);
        //root_maxDepthOfBSTTest.right = new TreeNode(20);
        //root_maxDepthOfBSTTest.right.left = new TreeNode(15);
        //root_maxDepthOfBSTTest.right.right = new TreeNode(7);

        //MaxDepthOfBSTTest maxDepthOfBSTTest = new MaxDepthOfBSTTest();
        //maxDepthOfBSTTest.MaxDepth(root_maxDepthOfBSTTest);
        Console.ReadLine();
    }
}

public class ReverseStringTest
{
    public string ReverseString(string s)
    {
        StringBuilder str_new = new StringBuilder(s);

        for (int i = 0, j = s.Length - 1; i < j; i++, j--)
        {
            char temp = s[i];
            str_new[i] = s[j];
            str_new[j] = s[i];
        }
        return str_new.ToString();
    }
}



public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class MaxDepthOfBSTTest
{
    int depth_max = 0;
    public int MaxDepth(TreeNode root)
    {
        int depth = 0;
        PreorderTraverse(root, depth);
        return depth_max;
    }

    void PreorderTraverse(TreeNode node, int depth)
    {
        if(node != null)
        { depth += 1; if (depth > depth_max) depth_max = depth; }
        else { return; }

        PreorderTraverse(node.left, depth);  
        PreorderTraverse(node.right, depth);
    }
}

