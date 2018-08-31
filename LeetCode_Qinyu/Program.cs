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
        LeetCode_Qinyu.SelfDividingNumbers.SelfDividingNumbers_728 selfDividingNumbers = new LeetCode_Qinyu.SelfDividingNumbers.SelfDividingNumbers_728();
        selfDividingNumbers.Test();




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

